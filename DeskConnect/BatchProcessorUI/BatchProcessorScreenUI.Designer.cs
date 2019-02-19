namespace BatchProcessorUI
{
    partial class BatchProcessorScreenUI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.MachineDropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BatchFileLabel = new System.Windows.Forms.Label();
            this.BatchFileLocText = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.HasCmdLineCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmdLineText = new System.Windows.Forms.TextBox();
            this.ShowWindowCheck = new System.Windows.Forms.CheckBox();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.RemoteExecLocText = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(117)))), ((int)(((byte)(146)))));
            this.panel1.Controls.Add(this.MachineDropdown);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 41);
            this.panel1.TabIndex = 0;
            // 
            // MachineDropdown
            // 
            this.MachineDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MachineDropdown.DropDownWidth = 364;
            this.MachineDropdown.FormattingEnabled = true;
            this.MachineDropdown.Location = new System.Drawing.Point(102, 11);
            this.MachineDropdown.Name = "MachineDropdown";
            this.MachineDropdown.Size = new System.Drawing.Size(364, 21);
            this.MachineDropdown.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "System Name";
            // 
            // BatchFileLabel
            // 
            this.BatchFileLabel.AutoSize = true;
            this.BatchFileLabel.BackColor = System.Drawing.Color.White;
            this.BatchFileLabel.Location = new System.Drawing.Point(20, 28);
            this.BatchFileLabel.Name = "BatchFileLabel";
            this.BatchFileLabel.Size = new System.Drawing.Size(54, 13);
            this.BatchFileLabel.TabIndex = 1;
            this.BatchFileLabel.Text = "Batch File";
            // 
            // BatchFileLocText
            // 
            this.BatchFileLocText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BatchFileLocText.Location = new System.Drawing.Point(202, 102);
            this.BatchFileLocText.Name = "BatchFileLocText";
            this.BatchFileLocText.ReadOnly = true;
            this.BatchFileLocText.Size = new System.Drawing.Size(453, 20);
            this.BatchFileLocText.TabIndex = 2;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(661, 98);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(27, 27);
            this.BrowseButton.TabIndex = 3;
            this.BrowseButton.Text = "...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // HasCmdLineCheck
            // 
            this.HasCmdLineCheck.AutoSize = true;
            this.HasCmdLineCheck.BackColor = System.Drawing.Color.White;
            this.HasCmdLineCheck.Location = new System.Drawing.Point(44, 152);
            this.HasCmdLineCheck.Name = "HasCmdLineCheck";
            this.HasCmdLineCheck.Size = new System.Drawing.Size(188, 17);
            this.HasCmdLineCheck.TabIndex = 4;
            this.HasCmdLineCheck.Text = "Command Line Arguments Present";
            this.HasCmdLineCheck.UseVisualStyleBackColor = false;
            this.HasCmdLineCheck.CheckedChanged += new System.EventHandler(this.HasCmdLineCheck_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Command Line Argument ";
            // 
            // CmdLineText
            // 
            this.CmdLineText.Enabled = false;
            this.CmdLineText.Location = new System.Drawing.Point(202, 200);
            this.CmdLineText.Name = "CmdLineText";
            this.CmdLineText.Size = new System.Drawing.Size(453, 20);
            this.CmdLineText.TabIndex = 6;
            // 
            // ShowWindowCheck
            // 
            this.ShowWindowCheck.AutoSize = true;
            this.ShowWindowCheck.BackColor = System.Drawing.Color.White;
            this.ShowWindowCheck.Location = new System.Drawing.Point(44, 297);
            this.ShowWindowCheck.Name = "ShowWindowCheck";
            this.ShowWindowCheck.Size = new System.Drawing.Size(153, 17);
            this.ShowWindowCheck.TabIndex = 7;
            this.ShowWindowCheck.Text = "Show Command Execution";
            this.ShowWindowCheck.UseVisualStyleBackColor = false;
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Location = new System.Drawing.Point(934, 528);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(75, 26);
            this.ExecuteButton.TabIndex = 8;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(0, 518);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1022, 1);
            this.panel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Remote Execution Location";
            // 
            // RemoteExecLocText
            // 
            this.RemoteExecLocText.Location = new System.Drawing.Point(202, 247);
            this.RemoteExecLocText.Name = "RemoteExecLocText";
            this.RemoteExecLocText.Size = new System.Drawing.Size(453, 20);
            this.RemoteExecLocText.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(17, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(981, 446);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BatchFileLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(973, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Remote Batch Execution Parameters";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BatchProcessorScreenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoteExecLocText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.ShowWindowCheck);
            this.Controls.Add(this.CmdLineText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HasCmdLineCheck);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.BatchFileLocText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "BatchProcessorScreenUI";
            this.Size = new System.Drawing.Size(1022, 567);
            this.Load += new System.EventHandler(this.BatchProcessorScreenUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BatchFileLabel;
        private System.Windows.Forms.TextBox BatchFileLocText;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.CheckBox HasCmdLineCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CmdLineText;
        private System.Windows.Forms.CheckBox ShowWindowCheck;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RemoteExecLocText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox MachineDropdown;
    }
}
