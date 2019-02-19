namespace ProcessManagerUI
{
    partial class ProcessManagerControl
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
            this.MachineNameCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GoLabel = new System.Windows.Forms.Label();
            this.GoImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProcessListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.StopProcessButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(117)))), ((int)(((byte)(146)))));
            this.panel1.Controls.Add(this.MachineNameCombo);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.GoLabel);
            this.panel1.Controls.Add(this.GoImage);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 41);
            this.panel1.TabIndex = 0;
            // 
            // MachineNameCombo
            // 
            this.MachineNameCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MachineNameCombo.DropDownWidth = 364;
            this.MachineNameCombo.FormattingEnabled = true;
            this.MachineNameCombo.Location = new System.Drawing.Point(104, 9);
            this.MachineNameCombo.Name = "MachineNameCombo";
            this.MachineNameCombo.Size = new System.Drawing.Size(364, 24);
            this.MachineNameCombo.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(525, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "New Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GoLabel
            // 
            this.GoLabel.AutoSize = true;
            this.GoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(84)))), ((int)(((byte)(10)))));
            this.GoLabel.ForeColor = System.Drawing.Color.White;
            this.GoLabel.Location = new System.Drawing.Point(485, 12);
            this.GoLabel.Name = "GoLabel";
            this.GoLabel.Size = new System.Drawing.Size(23, 16);
            this.GoLabel.TabIndex = 4;
            this.GoLabel.Text = "Go";
            this.GoLabel.Click += new System.EventHandler(this.GoLabel_Click);
            // 
            // GoImage
            // 
            this.GoImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(84)))), ((int)(((byte)(10)))));
            this.GoImage.Location = new System.Drawing.Point(472, 5);
            this.GoImage.Name = "GoImage";
            this.GoImage.Size = new System.Drawing.Size(48, 31);
            this.GoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GoImage.TabIndex = 3;
            this.GoImage.TabStop = false;
            this.GoImage.Click += new System.EventHandler(this.GoLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "System Name";
            // 
            // ProcessListView
            // 
            this.ProcessListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.ProcessListView.FullRowSelect = true;
            this.ProcessListView.Location = new System.Drawing.Point(0, 41);
            this.ProcessListView.Name = "ProcessListView";
            this.ProcessListView.Size = new System.Drawing.Size(1020, 485);
            this.ProcessListView.TabIndex = 1;
            this.ProcessListView.UseCompatibleStateImageBehavior = false;
            this.ProcessListView.View = System.Windows.Forms.View.Details;
            this.ProcessListView.SelectedIndexChanged += new System.EventHandler(this.ProcessListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Process Name";
            this.columnHeader1.Width = 800;
            // 
            // StopProcessButton
            // 
            this.StopProcessButton.Location = new System.Drawing.Point(908, 532);
            this.StopProcessButton.Name = "StopProcessButton";
            this.StopProcessButton.Size = new System.Drawing.Size(111, 26);
            this.StopProcessButton.TabIndex = 2;
            this.StopProcessButton.Text = "Stop Process";
            this.StopProcessButton.UseVisualStyleBackColor = true;
            this.StopProcessButton.Click += new System.EventHandler(this.StopProcessButton_Click);
            // 
            // ProcessManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StopProcessButton);
            this.Controls.Add(this.ProcessListView);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProcessManagerControl";
            this.Size = new System.Drawing.Size(1022, 567);
            this.Load += new System.EventHandler(this.ProcessManagerControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GoLabel;
        private System.Windows.Forms.PictureBox GoImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView ProcessListView;
        private System.Windows.Forms.Button StopProcessButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ComboBox MachineNameCombo;
    }
}
