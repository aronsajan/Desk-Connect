using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using InterProcessCommunicator.ProcessCommunicator.Receiver;
using System.Configuration;
using DeskConnectEngine.CoreSystem.InstantMessenger;
using DeskConnectEngine.CoreSystem.CommandExecutor.RemoteExecutor;
using InstantMessage.MessageSender;
using DeskConnectEngine.CoreSystem;
using DeskConnectEngine.CoreSystem.DeskConnectSubsystem.SystemListDataRepository;
using System.Media;
using System.Diagnostics;

namespace InstantMessage
{
    public partial class MessageUserControl : UserControl
    {
        public delegate void UIAssist(string dataCone);
        public MessageUserControl()
        {
            InitializeComponent();
        }
        private Thread ListenerThread;
        UIAssist AppendList;
        private void MessageUserControl_Load(object sender, EventArgs e)
        {
            InitControls();
            AppendList = new UIAssist(WriteToListBox);
            InitActivities();
            this.Disposed += new EventHandler(MessageUserControl_Disposed);

        }

        private void InitControls()
        {
            ConfigurationManager MachineRepository = new ConfigurationManager();
            SystemRepositoryRoot Repository = MachineRepository.ReadRepository();
            foreach (SystemAttributes Machine in Repository.SystemRepository)
            {
                MachineDropDown.Items.Add(Machine.SystemName);
            }
        }

        void MessageUserControl_Disposed(object sender, EventArgs e)
        {
            if (ListenerThread != null)
            {
                if (ListenerThread.IsAlive)
                {
                    ListenerThread.Abort();
                    ReceiveMessage.Listner.Stop();
                }
            }
        }
        private void InitActivities()
        {
            ListenerThread = new Thread(ReadIncomingMessage);
            ListenerThread.Priority = ThreadPriority.Normal;
            ListenerThread.Name = "MessageThread";
            ListenerThread.Start();
        }

        public void WriteToListBox(string Message)
        {
            string UIFormat = Message;
            ListViewItem MessageItem = new ListViewItem(UIFormat);
            PlayMessageSound();
            ChatBoxList.Items.Add(MessageItem);


        }

        private void PlayMessageSound()
        {
            string MediaDir = Environment.CurrentDirectory + ConfigurationSettings.AppSettings["MediaSource"];
            string MediaFilePath = MediaDir + ConfigurationSettings.AppSettings["MessageTone"];
            SoundPlayer AudioPlayer = new SoundPlayer(MediaFilePath);
            AudioPlayer.Play();

        }


        public string TargetMachine
        {
            get
            {
                return MachineDropDown.SelectedItem.ToString();
            }
        }




        ExecuteReceiver ReceiveMessage;

        private void ReadIncomingMessage()
        {
            while (true)
            {
                ReceivingParams Param = new ReceivingParams();
                Param.Channel = int.Parse(ConfigurationSettings.AppSettings["MessageChannel"]);
                ReceiveMessage = new ExecuteReceiver();
                GC.Collect();
                ReceiveMessage.Parameters = Param;
                ReceiveMessage.ReceiveData();
                if (ReceiveMessage.Parameters.DataReceived)
                {
                    this.Invoke(AppendList, ReceiveMessage.ReceivedMessage);
                }
            }

        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (MachineDropDown.SelectedIndex >= 0)
            {
                try
                {
                    IResult Result = Send();
                    if (Result.Result == ExecutionResultType.Passed)
                    {
                        ListViewItem SendItem = new ListViewItem("Me : " + MessageText.Text);
                        ChatBoxList.Items.Add(SendItem);
                        MessageText.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Sending failed due to the following reason : " + Result.FailureException.Message, "Message Sending Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Sending failed due to the following reason : " + Ex.Message, "Message Sending Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a machine and then continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private IResult Send()
        {
            MessageSenderExecutor SendAction = new MessageSenderExecutor();
            MessageExecutor MessageEntity = SendAction.PrepareMessage(MessageText.Text);
            IResult ExecResult = SendAction.SendMessage(MessageEntity, TargetMachine);
            return ExecResult;

        }

    }
}
