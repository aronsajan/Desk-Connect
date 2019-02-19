using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using DeskConnectEngine.CoreSystem.BatchSubsystem;
using DeskConnectEngine.CoreSystem;
using DeskConnectEngine.CoreSystem.CommandExecutor.RemoteExecutor;
using DeskConnectEngine.CoreSystem.NetworkSubsystem;
using DeskConnectEngine.CoreSystem.DeskConnectSubsystem.SystemListDataRepository;

namespace BatchProcessorUI
{
    public partial class BatchProcessorScreenUI : UserControl
    {
        public BatchProcessorScreenUI()
        {
            InitializeComponent();
        }

        private void HasCmdLineCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (HasCmdLineCheck.Checked == true)
            {
                CmdLineText.Enabled = true;
            }
            else
            {
                CmdLineText.Enabled = false;
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            GetBatchFilename();
        }

        private void GetBatchFilename()
        {
            openFileDialog1.Filter = "Batch Files|*.bat";
            openFileDialog1.Title = "Select Batch File";
            openFileDialog1.FileName = string.Empty;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Filename = openFileDialog1.FileName;
                string Extension = Path.GetExtension(Filename);
                string BatchExtn = ConfigurationSettings.AppSettings["BatchExtension"];
                if (Extension.ToLower().CompareTo(BatchExtn.ToLower()) != 0)
                {
                    MessageBox.Show("You can select only batch files", "Batch File Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    BatchFileLocText.Text = openFileDialog1.FileName;
                }

            }
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            ExecuteBatch();
        }


        private void ExecuteBatch()
        {
            try
            {
                ValidateInput();
                BatchExecuteParameters ExecParams = new BatchExecuteParameters();
               
                if (HasCmdLineCheck.Checked)
                {
                    ExecParams.HasCommandLineArguments = true;
                    ExecParams.CommandLineArguments = CmdLineText.Text;
                }
                else
                {
                    ExecParams.HasCommandLineArguments = false;
                }

                ExecParams.ShowBatchExecution = ShowWindowCheck.Checked;
                ExecParams.RemoteExecuteLocation = RemoteExecLocText.Text;
                BatchFile BatchFileEntity = new BatchFile(BatchFileLocText.Text);
                ExecParams.BatchFile = BatchFileEntity;
                ExecuteBatchFile ExecBatch = new ExecuteBatchFile();
                ExecBatch.BatchOperationParameters = ExecParams;
                IResult ExecResult = RemoteExecute(ExecBatch);
                if (ExecResult.Result == ExecutionResultType.Passed)
                {
                    MessageBox.Show("Batch File " + Path.GetFileName(BatchFileLocText.Text) + " has been successfully executed on the remote machine " + RemoteMachine, "Remote Batch Execution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Batch File " + Path.GetFileName(BatchFileLocText.Text)+" failed to execute on the remote machine "+RemoteMachine+" due to the following reason : "+ExecResult.FailureException.Message,"Remote Batch Execution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details\n" + ex.Message, "Required data missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string RemoteMachine
        {
            get
            {
                return (MachineDropdown.SelectedItem.ToString());
            }
        }

        private void InitControls()
        {
            ConfigurationManager MachineRepository = new ConfigurationManager();
            SystemRepositoryRoot Repository = MachineRepository.ReadRepository();
            foreach (SystemAttributes Machine in Repository.SystemRepository)
            {
                MachineDropdown.Items.Add(Machine.SystemName);
            }
        }

        private IResult RemoteExecute(ExecuteBatchFile BatchExecuteEntity)
        {
            RemoteExecutionManager RemoteExecutor = new RemoteExecutionManager();
            RemoteExecutor.Command = BatchExecuteEntity;
            NetworkParameters NetParams = new NetworkParameters();
            NetParams.RemoteSystemName = RemoteMachine;
            RemoteExecutor.NetParams = NetParams;
            IResult Result = RemoteExecutor.Execute();
            return Result;

        }

        private void ValidateInput()
        {
            if (BatchFileLocText.Text.Length == 0)
            {
                throw new ApplicationException("Batch file not specified");
            }
            if (HasCmdLineCheck.Checked)
            {
                if (CmdLineText.Text.Length == 0)
                {
                    throw new ApplicationException("Command Line Arguments not specified");
                }
            }

            if (RemoteExecLocText.Text.Length == 0)
            {
                throw new ApplicationException("Remote batch file execution location not specified");
            }

        }

        private void BatchProcessorScreenUI_Load(object sender, EventArgs e)
        {
            InitControls();
        }



    }
}
