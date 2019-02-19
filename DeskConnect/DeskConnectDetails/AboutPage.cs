using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;

namespace DeskConnectDetails
{
    public partial class AboutPage : UserControl
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void AboutPage_Load(object sender, EventArgs e)
        {
            LoadVersionInfo();
        }
        private void LoadVersionInfo()
        {
            string LibraryVersion = RetrieveValue("DLLVersion");
            string DeskConnectVer =  RetrieveValue("Version");
            string DeskConnectActiveListenerVer = RetrieveValue("ListenerVersion");
            string MessageNotifierVer = RetrieveValue("MessageNotifierVersion");

            label1.Text = label1.Text + DeskConnectVer;
            label5.Text = label5.Text + DeskConnectActiveListenerVer;
            label6.Text = label6.Text + MessageNotifierVer;
            label8.Text = label8.Text + ", Version : " + LibraryVersion;
            label9.Text = label9.Text + ", Version : " + LibraryVersion;
            label10.Text = label10.Text + ", Version : " + LibraryVersion;
            label11.Text = label11.Text + ", Version : " + LibraryVersion;
            label12.Text = label12.Text + ", Version : " + LibraryVersion;
            label13.Text = label13.Text + ", Version : " + LibraryVersion;
            label14.Text = label14.Text + ", Version : " + LibraryVersion;
            label15.Text = label15.Text + ", Version : " + LibraryVersion;
            label16.Text = label16.Text + ", Version : " + LibraryVersion;
            label17.Text = label17.Text + ", Version : " + LibraryVersion;
            


        }

        private string RetrieveValue(string Key)
        {
            return ConfigurationSettings.AppSettings[Key];
        }

        private void StartMailClient(string Command)
        {
            try
            {
                Process MailClient = new Process();
                MailClient.StartInfo.FileName = Command;
                MailClient.StartInfo.UseShellExecute = true;
                MailClient.Start();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Failed to start mail client due to the following reason: "+Ex.Message, "Desk Connect - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmailLabel_Click(object sender, EventArgs e)
        {
            string Command = "mailto:aronsajan@hotmail.com";
            StartMailClient(Command);
        }
    }
}
