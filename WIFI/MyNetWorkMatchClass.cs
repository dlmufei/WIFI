using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace WIFI
{
    /// <summary>
    /// 一个安装在计算机上的网络适配器，该类可用于获取网络中的流量
    /// </summary>
    class MyNetWorkMatchClass
    {
        public override string ToString()
        {
            return m_strMatchName;
        }
        public string strMatchName
        {
            get
            {
                return m_strMatchName;
            }
        }
        public long DownloadSpeed
        {
            get
            {
                return m_lDownLoadSpeed;
            }
        }
        public long UploadSpeed
        {
            get
            {
                return m_lUpLoadSpeed;
            }
        }
        public double DownloadSpeedKbps
        {
            get
            {
                return this.m_lUpLoadSpeed / 1024.0;
            }
        }
        public double UploadSpeedKbps
        {
            get
            {
                return this.m_lUpLoadSpeed / 1024.0;
            }
        }
        private long m_lDownLoadNetValues1;           //当前的下载速度,字节计算
        private long m_lUploadNetValues1;             //当前的上传速度
        private long m_lDownLoadNetValues2;           //一秒前的下载速度,字节计算
        private long m_lUploadNetValues2;             //一秒前的上传速度
        private string m_strMatchName;     //此适配器的名字
        internal PerformanceCounter m_Performance_Down;    //控制下载速度的流量计算中心
        internal PerformanceCounter m_Performance_Up;     // //控制上传速度的流量计算中心
        private long m_lDownLoadSpeed;      //每秒钟下载速度
        private long m_lUpLoadSpeed;          //每秒钟上传速度
        public MyNetWorkMatchClass(string strComputerNetName)
        {
            m_lDownLoadNetValues1 = 0;
            m_strMatchName = strComputerNetName;
            m_lUploadNetValues1 = 0;
            m_lDownLoadNetValues2 = 0;
            m_lUploadNetValues2 = 0;
        }
        //该适配器准备控制的方法函数
        public void Start()
        {
            m_lUploadNetValues1 = m_Performance_Up.NextSample().RawValue;
            m_lDownLoadNetValues1 = m_Performance_Down.NextSample().RawValue;
        }
        public void CaculateAndRefresh()                //计算速度
        {
            m_lDownLoadNetValues2 = m_Performance_Down.NextSample().RawValue;
            m_lUploadNetValues2 = m_Performance_Up.NextSample().RawValue;
            m_lDownLoadSpeed = m_lDownLoadNetValues2 - m_lDownLoadNetValues1;
            m_lUpLoadSpeed = m_lUploadNetValues2 - m_lUploadNetValues1;
            m_lDownLoadNetValues1 = m_lDownLoadNetValues2;
            m_lUploadNetValues1 = m_lUploadNetValues2;
        }
    }
}
