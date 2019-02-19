using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DeskConnectEngine.CoreSystem.ServiceSubsystem;
using System.ServiceProcess;
using DeskConnectEngine.CoreSystem.NetworkSubsystem;
using DeskConnectEngine.CoreSystem.CommandExecutor.RemoteExecutor;
using DeskConnectEngine.CoreSystem;
using DeskConnectEngine.CoreSystem.DeskConnectSubsystem.SystemListDataRepository;

namespace SystemServiceHandler
{
    public partial class ServiceHandlerUI : UserControl
    {
        public ServiceHandlerUI()
        {
            InitializeComponent();
        }



        private void ServiceHandlerUI_Load(object sender, EventArgs e)
        {
            InitControls();
        }

        private void InitControls()
        {
            ConfigurationManager MachineRepository = new ConfigurationManager();
            SystemRepositoryRoot Repository = MachineRepository.ReadRepository();
            ServiceContextActionButton.Enabled = false;
            foreach (SystemAttributes Machine in Repository.SystemRepository)
            {
                MachineListDropdown.Items.Add(Machine.SystemName);
            }
        }

        private void GoLabel_Click(object sender, EventArgs e)
        {
            if (MachineListDropdown.SelectedIndex >= 0)
            {
                try
                {
                    RefreshServiceList();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Communication with the remote system failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a machine and then continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshServiceList()
        {
            if (MachineName.Length > 0)
            {
                RetrieveServiceList Retrieve = new RetrieveServiceList();
                PopulateServiceList(Retrieve.RetrieveServices(MachineName));
            }
            else
            {
                throw new ApplicationException("Remote system name required");
            }
        }

        private string MachineName
        {
            get
            {
                return MachineListDropdown.SelectedItem.ToString();
            }
        }
        private void PopulateServiceList(List<ServiceListResult> ResultList)
        {
            ServicelistView.Items.Clear();

            foreach (ServiceListResult ServiceData in ResultList)
            {
                ListViewItem ServiceItem = new ListViewItem(ServiceData.ServiceName);
                string Status = ServiceData.ServiceStatus.ToString();
                ServiceItem.SubItems.Add(Status);
                LinkLabel ActionLabel = new LinkLabel();
                ActionLabel.Name = ServiceData.ServiceName;

                ServicelistView.Items.Add(ServiceItem);

            }
        }

        private void ServicelistView_MouseClick(object sender, MouseEventArgs e)
        {


        }

        private string SelectedService
        {
            get;
            set;
        }

        public ServiceActionType ServiceAction
        {
            get;
            set;
        }

        private void ServiceContextActionButton_Click(object sender, EventArgs e)
        {
            ServiceParameters ServiceParams = new ServiceParameters();
            ServiceParams.ServiceName = SelectedService;
            NetworkParameters NetParams = new NetworkParameters();
            NetParams.RemoteSystemName = MachineName;
            RemoteExecutionManager RemoteExec = new RemoteExecutionManager();
            if (ServiceAction == ServiceActionType.StartService)
            {
                StartService Start = new StartService();
                Start.ServiceParameters = ServiceParams;

                RemoteExec.Command = Start;
                RemoteExec.NetParams = NetParams;
                IResult StartResult = RemoteExec.Execute();
                if (StartResult.Result == ExecutionResultType.Passed)
                {
                    MessageBox.Show(SelectedService + " has been successfully started on the remote machine " + MachineName, "Start Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshServiceList();
                }
                else
                {
                    MessageBox.Show("Failed to start the service " + SelectedService + " on the remote machine " + MachineName + " due to the following reason : " + StartResult.FailureException.Message, "Start Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
                if (ServiceAction == ServiceActionType.StopService)
                {
                    StopService Stop = new StopService();
                    Stop.ServiceParameters = ServiceParams;
                    RemoteExec.Command = Stop;
                    RemoteExec.NetParams = NetParams;
                    IResult StopResult = RemoteExec.Execute();
                    if (StopResult.Result == ExecutionResultType.Passed)
                    {
                        MessageBox.Show(SelectedService + " has been successfully stopped on the remote machine " + MachineName, "Stop Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshServiceList();
                    }
                    else
                    {
                        MessageBox.Show("Failed to stop the service " + SelectedService + " on the remote machine " + MachineName + " due to the following reason : " + StopResult.FailureException.Message, "Stop Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
        }


        private void ServicelistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ServicelistView.SelectedIndices.Count == 1)
            {
                ServiceContextActionButton.Enabled = true;
                SelectedService = ServicelistView.SelectedItems[0].SubItems[0].Text;
                string SelectedServiceStatus = ServicelistView.SelectedItems[0].SubItems[1].Text;
                if ((SelectedServiceStatus.CompareTo(ServiceControllerStatus.Stopped.ToString()) == 0) || (SelectedServiceStatus.CompareTo(ServiceControllerStatus.StopPending.ToString()) == 0))
                {
                    ServiceContextActionButton.Text = "Start Service";
                    ServiceAction = ServiceActionType.StartService;
                }
                else
                    if ((SelectedServiceStatus.CompareTo(ServiceControllerStatus.Running.ToString()) == 0) || (SelectedServiceStatus.CompareTo(ServiceControllerStatus.StartPending.ToString()) == 0))
                    {
                        ServiceContextActionButton.Text = "Stop Service";
                        ServiceAction = ServiceActionType.StopService;
                    }
                    else
                    {
                        ServiceContextActionButton.Enabled = false;
                        ServiceAction = ServiceActionType.NoAction;
                    }
            }
            else
            {
                ServiceContextActionButton.Enabled = false;
                ServiceAction = ServiceActionType.NoAction;
            }
        }

        private void RefreshLabel_Click(object sender, EventArgs e)
        {

        }

        private void RefreshPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RefreshListButton_Click(object sender, EventArgs e)
        {
            if (MachineListDropdown.SelectedIndex >= 0)
            {
                try
                {
                    RefreshServiceList();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Communication with the remote system failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a machine and then continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





    }
}
