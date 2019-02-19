using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DeskConnectEngine.CoreSystem.ServiceSubsystem;
using DeskConnectEngine.CoreSystem;
using DeskConnectEngine.CoreSystem.CommandTransReceiver.CommandPacket;
using DeskConnectEngine.CoreSystem.CommandTransReceiver.Transmitter;
using DeskConnectEngine.CoreSystem.CommandTransReceiver.Receiver;
using DeskConnectEngine.CoreSystem.CommandExecutor;
using DeskConnectEngine.CoreSystem.CommandExecutor.RemoteExecutor;
using DeskConnectEngine.CoreSystem.NetworkSubsystem;
using DeskConnectEngine.CoreSystem.ProcessSubsystem;
using DeskConnectEngine.CoreSystem.BatchSubsystem;
using DeskConnectEngine.CoreSystem.DeskConnectSubsystem.SystemListDataRepository;

namespace HomeControl
{
    public partial class HomeUserControl : UserControl
    {
        public HomeUserControl()
        {
            InitializeComponent();
        }



        private void HomeUserControl_Load(object sender, EventArgs e)
        {
            InitHome();
        }

        private void AddToListButton_Click(object sender, EventArgs e)
        {
            if (SystemNameText.Text.Length > 0)
            {
                ConfigurationManager SaveToConnectionList = new ConfigurationManager();
                SaveToConnectionList.AddToRepository(SystemNameText.Text);
                RefreshView();
            }
            else
            {
                MessageBox.Show("Please enter a system name and then continue","Desk Connect - Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void InitHome()
        {
            MachineListView.LargeImageList = imageList1;
            RefreshView();
        }

        private void RefreshView()
        {
            MachineListView.Items.Clear();
            ConfigurationManager MachineRepository = new ConfigurationManager();
            SystemRepositoryRoot SystemListRoot = MachineRepository.ReadRepository();
            foreach (SystemAttributes Machine in SystemListRoot.SystemRepository)
            {
                ListViewItem MachineItem = new ListViewItem(Machine.SystemName);
                MachineItem.ImageIndex = 0;
                MachineListView.Items.Add(MachineItem);
            }
            GC.Collect();
        }

        private void RemoveFromListButton_Click(object sender, EventArgs e)
        {

            try
            {


                ConfigurationManager ConfigManager = new ConfigurationManager();
                ConfigManager.RemoveFromRepository(SelectedMachine);
                RemoveFromListButton.Enabled = false;
                RefreshView();
            }
            catch (Exception DeletionException)
            {
                MessageBox.Show("Operation failed due the following reason : " + DeletionException.Message, "Deletion operation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MachineListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MachineListView.SelectedItems.Count == 1)
            {
                SelectedMachine = MachineListView.SelectedItems[0].Text;
                RemoveFromListButton.Enabled = true;
            }
            else
            {
                SelectedMachine = "";
                RemoveFromListButton.Enabled = false;
            }
        }

        private string SelectedMachine
        {
            get;
            set;
        }




    }
}
