using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Timers;
using System.Diagnostics;

namespace WIFI
{
    class MyNetWorkMonitor
    {
        private System.Timers.Timer Monitor_Timer;              // 计时器事件执行每秒钟刷新值在适配器。
        private ArrayList m_AdaptersList;        //该计算机的适配器列表。
        private ArrayList m_MonitoredAdapters;      //目前控制的适配器列表
        public MyNetWorkMonitor()
        {
            m_AdaptersList = new ArrayList();          //用来保存获取到的计算机的适配器列表
            m_MonitoredAdapters = new ArrayList();         //运行的有效的适配器列表

            ShowNetAdapter();                                //列举出安装在该计算机上面的适配器
            Monitor_Timer = new System.Timers.Timer(1000);
            Monitor_Timer.Elapsed += new ElapsedEventHandler(timer_ElapsedClick);
        }
        private void timer_ElapsedClick(object sender, ElapsedEventArgs e)     //用于每秒钟刷新速度      
        {
            foreach (MyNetWorkMatchClass adapter in m_MonitoredAdapters)       //每秒钟遍历有效的网络适配器
            {
                adapter.CaculateAndRefresh();                                           //刷新上传下载速度                        
            }

        }

        private void ShowNetAdapter()    //列举出安装在该计算机上面的适配器方法
        {
            PerformanceCounterCategory PCCCategory = new PerformanceCounterCategory("Network Interface");
            foreach (string InstanceName in PCCCategory.GetInstanceNames())
            {
                if (InstanceName == "MS TCP Loopback interface")
                    continue;
                //  创建一个实例Net workAdapter类别，并创建性能计数器它。
                MyNetWorkMatchClass myMNWMadapter = new MyNetWorkMatchClass(InstanceName);
                myMNWMadapter.m_Performance_Down = new PerformanceCounter("Network Interface", "Bytes Received/sec", InstanceName);
                myMNWMadapter.m_Performance_Up = new PerformanceCounter("Network Interface", "Bytes Sent/sec", InstanceName);
                m_AdaptersList.Add(myMNWMadapter);
            }
        }

        public void StartMonitoring()
        {
            if (m_AdaptersList.Count > 0)
            {
                foreach (MyNetWorkMatchClass myMNWMadapter in m_AdaptersList)
                    if (!m_MonitoredAdapters.Contains(myMNWMadapter))
                    {
                        m_MonitoredAdapters.Add(myMNWMadapter);
                        myMNWMadapter.Start();
                    }
                Monitor_Timer.Enabled = true;
            }
        }
        public void StartMonitoring(MyNetWorkMatchClass myMNWMadapter)     //控制该适配器开始工作
        {
            if (!m_MonitoredAdapters.Contains(myMNWMadapter))
            {
                m_MonitoredAdapters.Add(myMNWMadapter);
                myMNWMadapter.Start();                           //该适配器调用自己函数开始工作      
            }
            Monitor_Timer.Enabled = true;
        }
        public void StopMonitoring()
        {
            m_MonitoredAdapters.Clear();
            Monitor_Timer.Enabled = false;
        }
        public void StopMonitoring(MyNetWorkMatchClass adapter)
        {
            if (m_MonitoredAdapters.Contains(adapter))
                m_MonitoredAdapters.Remove(adapter);
            if (m_MonitoredAdapters.Count == 0)
                Monitor_Timer.Enabled = false;
        }
        public MyNetWorkMatchClass[] Adapters                //该控制类所控制的找出所有适配器的适配器列表
        {
            get
            {
                return (MyNetWorkMatchClass[])m_AdaptersList.ToArray(typeof(MyNetWorkMatchClass));
            }
        }
    }
}
