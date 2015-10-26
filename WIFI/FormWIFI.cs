using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WIFI
{
    public partial class FormWIFI : Form
    {

        private MyNetWorkMatchClass[] m_MNWMadapters;
        private MyNetWorkMonitor monitor;

        Process MyProcess = new Process();
        string WIFIName = null;
        string WIFIPwd = null;

        private FormDock formDock;

        public FormWIFI()
        {
            InitializeComponent();
            formDock = new FormDock();
            formDock.Show();
        }

        private void FormWIFI_Load(object sender, EventArgs e)
        {            
            //设定程序名
            MyProcess.StartInfo.FileName = "cmd.exe";
            //关闭Shell的使用
            MyProcess.StartInfo.UseShellExecute = false;
            //重定向标准输入
            MyProcess.StartInfo.RedirectStandardInput = true;
            //重定向标准输出
            MyProcess.StartInfo.RedirectStandardOutput = true;
            //重定向错误输出
            MyProcess.StartInfo.RedirectStandardError = true;
            //设置不显示窗口
            MyProcess.StartInfo.CreateNoWindow = true;

            monitor = new MyNetWorkMonitor();
            m_MNWMadapters = monitor.Adapters;   //获得控制器MyNetWorkMonitor上所有计算机的适配器列表

            if (m_MNWMadapters.Length == 0)
            {
                cboxAdapters.Enabled = false;
                MessageBox.Show("在计算机上没有找到网络适配器");
                return;
            }
            cboxAdapters.Items.AddRange(m_MNWMadapters); 
            
        }

        private void cboxAdapters_SelectedIndexChanged(object sender, EventArgs e)      //选中其中一个适配器
        {
            monitor.StopMonitoring();
            monitor.StartMonitoring(m_MNWMadapters[cboxAdapters.SelectedIndex]);     //控制该适配器开始工作
            this.timer1.Start();                                      //计时开始
        }
        private void timer1_Tick(object sender, EventArgs e)    //计时开始,用于每秒钟改变显示速度
        {

            MyNetWorkMatchClass adapter = m_MNWMadapters[cboxAdapters.SelectedIndex];    //该适配器
            lb_Down.Text = String.Format("{0:n} kbps", adapter.DownloadSpeedKbps);   //得到该适配器的下载速度
            lb_Up.Text = String.Format("{0:n} kbps", adapter.UploadSpeedKbps);     //得到该适配器的上传速度
            formDock.ShowInfo(String.Format("{0:n} kbps", adapter.UploadSpeedKbps),
                String.Format("{0:n} kbps", adapter.DownloadSpeedKbps));
        }
   

        //netsh wlan set hostednetwork mode=allow  ssid=WF key=87654321
        private void bt_Creat_Click(object sender, EventArgs e)
        {
            WIFIName = tb_Name.Text;
            WIFIPwd = tb_Pwd.Text;
            if (string.IsNullOrEmpty(WIFIName) || string.IsNullOrEmpty(WIFIPwd))
            {
                MessageBox.Show("请输入完整的热点名称和密码！");
                return;
            }
            try
            {
                MyProcess.Start();
                MyProcess.StandardInput.WriteLine("netsh wlan set hostednetwork mode=allow  ssid="+WIFIName+" key="+WIFIPwd);
                MyProcess.StandardInput.WriteLine("Exit");
                MessageBox.Show("创建成功！");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            
            MyProcess.Start();
            MyProcess.StandardInput.WriteLine("netsh wlan start hostednetwork");
            MyProcess.StandardInput.WriteLine("Exit");
            MessageBox.Show("启动成功！");
        }

        private void bt_Stop_Click(object sender, EventArgs e)
        {
            MyProcess.Start();
            MyProcess.StandardInput.WriteLine("netsh wlan stop hostednetwork");
            MyProcess.StandardInput.WriteLine("Exit");
            MessageBox.Show("停止成功！");
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
    }
}
