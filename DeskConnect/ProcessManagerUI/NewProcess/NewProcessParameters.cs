using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DeskConnectEngine.CoreSystem.CommandExecutor.RemoteExecutor;
using DeskConnectEngine.CoreSystem.ProcessSubsystem;
using DeskConnectEngine.CoreSystem.NetworkSubsystem;
using DeskConnectEngine.CoreSystem;
using System.IO;

namespace ProcessManagerUI.NewProcess
{
    public partial class NewProcessParameters : Form
    {
        public NewProcessParameters()
        {
            InitializeComponent();
        }

        private void NewProcessParameters_Load(object sender, EventArgs e)
        {
            InitControls();
        }
        [Description("Property that gets or sets the name of the remote machine")]
        public string RemoteMachineName
        {
            get;
            set;
        }

        private void InitControls()
        {
            RemoteMachineLabel.Text = RemoteMachineName;

        }

        private IResult StartProgram(string ProgramPath)
        {
            StartProcess ProcStart = new StartProcess();
            ProcessParameters ProcParam = new ProcessParameters();
            NetworkParameters NetParams = new NetworkParameters();
            NetParams.RemoteSystemName = RemoteMachineName;
            ProcParam.ProcessName = ProgramPath;
            ProcStart.ProcessParameters = ProcParam;
            RemoteExecutionManager RemoteExec = new RemoteExecutionManager();
            RemoteExec.Command = ProcStart;
            RemoteExec.NetParams = NetParams;
            IResult ExecResult = RemoteExec.Execute();

            return ExecResult;


        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            try
            {
                IResult ExecResult = StartProgram(ProgramText.Text);
                if (ExecResult.Result == ExecutionResultType.Passed)
                {
                    MessageBox.Show("Program, " + Path.GetFileName(ProgramText.Text) + ", has been successfully started on the remote machine " + RemoteMachineName, "Desk Connect - Remote Process Activator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ParentUserControl.RetrieveAllProcesses();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Program " + Path.GetFileName(ProgramText.Text) + " failed to start on the remote machine " + RemoteMachineName + " due to the following reason : " + ExecResult.FailureException.Message, "Desk Connect - Remote Process Activator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Communication with the remote system failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ProcessManagerControl ParentUserControl
        {
            get;
            set;
        }



    }
}
