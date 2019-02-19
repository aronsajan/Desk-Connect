namespace SystemServiceHandler
{
    partial class ServiceHandlerUI
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
            this.RefreshListButton = new System.Windows.Forms.Button();
            this.MachineListDropdown = new System.Windows.Forms.ComboBox();
            this.GoLabel = new System.Windows.Forms.Label();
            this.GoImage = new System.Windows.Forms.PictureBox();
            this.SystemNameLabel = new System.Windows.Forms.Label();
            this.ServicelistView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ServiceContextActionButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(117)))), ((int)(((byte)(146)))));
            this.panel1.Controls.Add(this.RefreshListButton);
            this.panel1.Controls.Add(this.MachineListDropdown);
            this.panel1.Controls.Add(this.GoLabel);
            this.panel1.Controls.Add(this.GoImage);
            this.panel1.Controls.Add(this.SystemNameLabel);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 41);
            this.panel1.TabIndex = 0;
            // 
            // RefreshListButton
            // 
            this.RefreshListButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RefreshListButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RefreshListButton.Location = new System.Drawing.Point(531, 5);
            this.RefreshListButton.Name = "RefreshListButton";
            this.RefreshListButton.Size = new System.Drawing.Size(100, 31);
            this.RefreshListButton.TabIndex = 5;
            this.RefreshListButton.Text = "Refresh";
            this.RefreshListButton.UseVisualStyleBackColor = true;
            this.RefreshListButton.Click += new System.EventHandler(this.RefreshListButton_Click);
            // 
            // MachineListDropdown
            // 
            this.MachineListDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MachineListDropdown.FormattingEnabled = true;
            this.MachineListDropdown.Location = new System.Drawing.Point(108, 9);
            this.MachineListDropdown.Name = "MachineListDropdown";
            this.MachineListDropdown.Size = new System.Drawing.Size(364, 24);
            this.MachineListDropdown.TabIndex = 4;
            // 
            // GoLabel
            // 
            this.GoLabel.AutoSize = true;
            this.GoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(84)))), ((int)(((byte)(10)))));
            this.GoLabel.Location = new System.Drawing.Point(493, 12);
            this.GoLabel.Name = "GoLabel";
            this.GoLabel.Size = new System.Drawing.Size(23, 16);
            this.GoLabel.TabIndex = 2;
            this.GoLabel.Text = "Go";
            this.GoLabel.Click += new System.EventHandler(this.GoLabel_Click);
            // 
            // GoImage
            // 
            this.GoImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(84)))), ((int)(((byte)(10)))));
            this.GoImage.Location = new System.Drawing.Point(479, 5);
            this.GoImage.Name = "GoImage";
            this.GoImage.Size = new System.Drawing.Size(48, 31);
            this.GoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GoImage.TabIndex = 1;
            this.GoImage.TabStop = false;
            this.GoImage.Click += new System.EventHandler(this.GoLabel_Click);
            // 
            // SystemNameLabel
            // 
            this.SystemNameLabel.AutoSize = true;
            this.SystemNameLabel.Location = new System.Drawing.Point(15, 12);
            this.SystemNameLabel.Name = "SystemNameLabel";
            this.SystemNameLabel.Size = new System.Drawing.Size(87, 16);
            this.SystemNameLabel.TabIndex = 0;
            this.SystemNameLabel.Text = "System Name";
            // 
            // ServicelistView
            // 
            this.ServicelistView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServicelistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ServicelistView.FullRowSelect = true;
            this.ServicelistView.Location = new System.Drawing.Point(0, 44);
            this.ServicelistView.MultiSelect = false;
            this.ServicelistView.Name = "ServicelistView";
            this.ServicelistView.Size = new System.Drawing.Size(1022, 482);
            this.ServicelistView.TabIndex = 1;
            this.ServicelistView.UseCompatibleStateImageBehavior = false;
            this.ServicelistView.View = System.Windows.Forms.View.Details;
            this.ServicelistView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ServicelistView_MouseClick);
            this.ServicelistView.SelectedIndexChanged += new System.EventHandler(this.ServicelistView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Service Name";
            this.columnHeader1.Width = 750;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Status";
            this.columnHeader2.Width = 230;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Location = new System.Drawing.Point(1, 528);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1021, 1);
            this.panel2.TabIndex = 2;
            // 
            // ServiceContextActionButton
            // 
            this.ServiceContextActionButton.ForeColor = System.Drawing.Color.Black;
            this.ServiceContextActionButton.Location = new System.Drawing.Point(925, 534);
            this.ServiceContextActionButton.Name = "ServiceContextActionButton";
            this.ServiceContextActionButton.Size = new System.Drawing.Size(93, 26);
            this.ServiceContextActionButton.TabIndex = 3;
            this.ServiceContextActionButton.Text = "Start Service";
            this.ServiceContextActionButton.UseVisualStyleBackColor = true;
            this.ServiceContextActionButton.Click += new System.EventHandler(this.ServiceContextActionButton_Click);
            // 
            // ServiceHandlerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ServiceContextActionButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ServicelistView);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ServiceHandlerUI";
            this.Size = new System.Drawing.Size(1022, 567);
            this.Load += new System.EventHandler(this.ServiceHandlerUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SystemNameLabel;
        private System.Windows.Forms.PictureBox GoImage;
        private System.Windows.Forms.Label GoLabel;
        private System.Windows.Forms.ListView ServicelistView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ServiceContextActionButton;
        private System.Windows.Forms.ComboBox MachineListDropdown;
        private System.Windows.Forms.Button RefreshListButton;
    }
}
