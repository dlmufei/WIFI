using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Reflection;

namespace WIFI
{
    static class Program
    {
       ///
        /// 应用程序的主入口点。
        ///
        [STAThread]
        static void Main(string[] Args)
        {
            try
            {
                //获得当前登录的Windows用户标示
                System.Security.Principal.WindowsIdentity identity = System.Security.Principal.WindowsIdentity.GetCurrent();
               
                Application.SetCompatibleTextRenderingDefault(false);
                Process intance = RunningIntance();  //调用检查函数
                System.Security.Principal.WindowsPrincipal principal = new System.Security.Principal.WindowsPrincipal(identity);
                //判断当前登录用户是否为管理员
                if (principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator))
                {
                    //如果是管理员，则直接运行
                    Application.EnableVisualStyles();
                    if (intance == null)    //不存在相同的程序
                    {
                        Application.Run(new FormWIFI());
                    }
                    else  //存在相同的程序
                    {
                        HandleRunningInstance(intance);
                    }
                   
                }
                else
                {
                    //创建启动对象
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    //设置运行文件
                    startInfo.FileName = System.Windows.Forms.Application.ExecutablePath;
                    //设置启动参数
                    startInfo.Arguments = String.Join(" ", Args);
                    //设置启动动作,确保以管理员身份运行
                    startInfo.Verb = "runas";
                    //如果不是管理员，则启动UAC
                    System.Diagnostics.Process.Start(startInfo);
                    //退出
                    System.Windows.Forms.Application.Exit();
                }

               
               
            }
            catch
            { }
        }
        ///
        /// 监测系统中是否有相同的运行实例
        ///
        /// 运行实例
        private static Process RunningIntance()
        {
            Process currentProcess = Process.GetCurrentProcess();
            Process[] processCollection = Process.GetProcessesByName(currentProcess.ProcessName);
            foreach (Process p in processCollection)
            {
                if (p.Id != currentProcess.Id)  //检查ID是否相同
                {
                    //检查运行文件路径是否相同
                    if (Assembly.GetExecutingAssembly().Location.Replace("/",@"\") == currentProcess.MainModule.FileName)
                        return currentProcess;
                }
            }
            return null;
        }
        ///
        /// 发现相同的运行实例（正常显示窗口，并将该应用窗口前置）
        ///
        /// 运行实例
        private static void HandleRunningInstance(Process instance)
        {
            MessageBox.Show("系统已经在运行！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowWindowAsync(instance.MainWindowHandle, 1); //调用api函数，正常显示窗口
            SetForegroundWindow(instance.MainWindowHandle); //将窗口放置最前端。
        }
        [DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(System.IntPtr hWnd, int cmdShow);
        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(System.IntPtr hWnd);
    }
}
