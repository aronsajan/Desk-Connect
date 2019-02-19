using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;

namespace DeskConnect
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void LoadVersion()
        {
            VersionLabel.Text = ConfigurationSettings.AppSettings["Version"];
        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            LoadVersion();
            Delay_StartApp(5);
        }

        private void Delay_StartApp(int Seconds)
        {
            DelayTimer.Interval = Seconds * 1000;
            DelayTimer.Start();
        }

        private void DelayTimer_Tick(object sender, EventArgs e)
        {
            DelayTimer.Stop();
            LoadApplication();
        }

        private void LoadApplication()
        {
            ConditionalListenerLoad();
            Home DeskConnectApp = new Home();
            DeskConnectApp.Show();

            this.Visible = false;
            

        }

        private void ConditionalListenerLoad()
        {
            string ActiveListenerApp = ConfigurationSettings.AppSettings["ActiveListener"];
            if (Process.GetProcessesByName(ActiveListenerApp).Length == 0)
            {
                if (MessageBox.Show("Desk Connect Active Listener is not running. Do you want to turn it on?", "Desk Connect Active Listener", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        Process ActiveListener = new Process();
                        ActiveListener.StartInfo.FileName = Environment.CurrentDirectory + "\\" + ActiveListenerApp + ".exe";
                        ActiveListener.Start();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exception encountered while starting Desk Connect Active Listener", "Exception Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
