using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DeskConnectActiveListener.UI;
using System.Threading;
using System.IO;
using System.Configuration;

namespace DeskConnectActiveListener
{
    public partial class ActivePage : Form
    {
        private NotifyIcon Notifier;
        const int NotifierTimeOut = 7000;

        ActiveListener ExecutionListener;

        public ActivePage()
        {
            InitializeComponent();

            Notifier = new NotifyIcon();

        }



        private void ActivePage_Load(object sender, EventArgs e)
        {

            InitFormUI();
            InitErrorLog();
            ShowStartupNotification();
            StartListener();
        }


        private void InitErrorLog()
        {
            string CurrentDir = Environment.CurrentDirectory;
            string LogDir = CurrentDir + "\\Logs";
            string LogFile = LogDir + "\\" + ConfigurationSettings.AppSettings["ErrorLog"];

            if (Directory.Exists(LogDir))
            {

                if (!File.Exists(LogFile))
                {
                    File.Create(LogFile);
                }
            }
            else
            {
                Directory.CreateDirectory(LogDir);
                File.Create(LogFile);
            }
        }
        protected CreateParams CreateParams
        {
            get
            {
                var CreateParamData = base.CreateParams;
                CreateParamData.ExStyle |= 0x80;
                return CreateParamData;
            }
        }

        private void InitFormUI()
        {
            this.Location = new Point(-2000, 2000);
            this.Size = new Size(0, 0);
            this.ShowInTaskbar = false;
        }

        private void ShowStartupNotification()
        {
            Notifier.Visible = true;
            Notifier.Click += new EventHandler(Notifier_Click);

            Notifier.Icon = new Icon(Environment.CurrentDirectory + "\\DeskConnectIcon.ico");
            Notifier.ShowBalloonTip(NotifierTimeOut, "Desk Connect Active Listener", "Desk Connect Active Listener has started on your machine " + Environment.MachineName, ToolTipIcon.Info);



        }

        ActiveListenerPref ListenerPreference;
        void Notifier_Click(object sender, EventArgs e)
        {
            if (ListenerPreference == null)
            {
                ListenerPreference = new ActiveListenerPref();
                ListenerPreference.ListenerThread = ExecutionListener.ExecutionThread;
                ListenerPreference.PulseThread = ListenerThread;
                ListenerPreference.ShowDialog();
                ListenerPreference = null;
            }


        }
        Thread ListenerThread;
        private void StartListener()
        {
            ExecutionListener = new ActiveListener();
            ListenerThread = new Thread(ExecutionListener.Start);
            ListenerThread.Start();

        }
    }
}
