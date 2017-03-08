using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Launcher
{
    class NetworkInterface
    {
        private const double timerUpdate = 1000;
        private System.Net.NetworkInformation.NetworkInterface[] nicArr;
        private Timer timer;
        main MainForm;
        double lblBytesReceived = 0;

        public NetworkInterface(main MainView)
        {
            MainForm = MainView;
            InitializeNetworkInterface();
            InitializeTimer();
        }
        public void StopNetworkInterface()
        {
            timer.Stop();
        }
        private void InitializeNetworkInterface()
        {
            nicArr = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces();
        }
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = (int)timerUpdate;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        private void UpdateNetworkInterface()
        {
            System.Net.NetworkInformation.NetworkInterface nic = nicArr[0];
            IPv4InterfaceStatistics interfaceStats = nic.GetIPv4Statistics();
            int bytesReceivedSpeed = (int)(interfaceStats.BytesReceived - lblBytesReceived);
            lblBytesReceived = interfaceStats.BytesReceived;
            MainForm.updateDownloadSpeed(bytesReceivedSpeed);
            MainForm.updateEstimatedTime();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            UpdateNetworkInterface();
        }

    }
}
