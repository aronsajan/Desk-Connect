namespace DeskConnectActiveListener.UI
{
    partial class ActiveListenerPref
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActiveListenerPref));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeveloperDetails = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Log = new System.Windows.Forms.Button();
            this.StartDeskConnectButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.StopListButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ListenerStatus = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desk Connect Active Listener";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 75);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DeskConnectActiveListener.Properties.Resources.DeskConnect_Logo_2;
            this.pictureBox1.Location = new System.Drawing.Point(8, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.DeveloperDetails);
            this.panel1.Location = new System.Drawing.Point(-1, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 24);
            this.panel1.TabIndex = 2;
            // 
            // DeveloperDetails
            // 
            this.DeveloperDetails.AutoSize = true;
            this.DeveloperDetails.ForeColor = System.Drawing.Color.White;
            this.DeveloperDetails.Location = new System.Drawing.Point(3, 5);
            this.DeveloperDetails.Name = "DeveloperDetails";
            this.DeveloperDetails.Size = new System.Drawing.Size(156, 13);
            this.DeveloperDetails.TabIndex = 0;
            this.DeveloperDetails.Text = "Developed by Aron Sajan Philip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Active Listener Status : ";
            // 
            // Log
            // 
            this.Log.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Log.Location = new System.Drawing.Point(9, 9);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(103, 31);
            this.Log.TabIndex = 6;
            this.Log.Text = "View Error Log";
            this.Log.UseVisualStyleBackColor = true;
            this.Log.Click += new System.EventHandler(this.Log_Click);
            // 
            // StartDeskConnectButton
            // 
            this.StartDeskConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StartDeskConnectButton.Location = new System.Drawing.Point(9, 46);
            this.StartDeskConnectButton.Name = "StartDeskConnectButton";
            this.StartDeskConnectButton.Size = new System.Drawing.Size(102, 37);
            this.StartDeskConnectButton.TabIndex = 7;
            this.StartDeskConnectButton.Text = "Start Desk Connect";
            this.StartDeskConnectButton.UseVisualStyleBackColor = true;
            this.StartDeskConnectButton.Click += new System.EventHandler(this.StartDeskConnectButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Location = new System.Drawing.Point(0, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(467, 1);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.StopListButton);
            this.panel4.Controls.Add(this.StartDeskConnectButton);
            this.panel4.Controls.Add(this.Log);
            this.panel4.Location = new System.Drawing.Point(0, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(122, 191);
            this.panel4.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(8, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 31);
            this.button3.TabIndex = 9;
            this.button3.Text = "Minimize To Tray";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // StopListButton
            // 
            this.StopListButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StopListButton.Location = new System.Drawing.Point(9, 89);
            this.StopListButton.Name = "StopListButton";
            this.StopListButton.Size = new System.Drawing.Size(102, 31);
            this.StopListButton.TabIndex = 8;
            this.StopListButton.Text = "Exit";
            this.StopListButton.UseVisualStyleBackColor = true;
            this.StopListButton.Click += new System.EventHandler(this.StopListButton_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SlateGray;
            this.panel5.Location = new System.Drawing.Point(1, 270);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(467, 1);
            this.panel5.TabIndex = 10;
            // 
            // ListenerStatus
            // 
            this.ListenerStatus.AutoSize = true;
            this.ListenerStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListenerStatus.Location = new System.Drawing.Point(274, 99);
            this.ListenerStatus.Name = "ListenerStatus";
            this.ListenerStatus.Size = new System.Drawing.Size(107, 16);
            this.ListenerStatus.TabIndex = 12;
            this.ListenerStatus.Text = "##ListenerStatus";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(138, 125);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 13;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ActiveListenerPref
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 294);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.ListenerStatus);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActiveListenerPref";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Active Listener Preference";
            this.Load += new System.EventHandler(this.ActiveListener_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DeveloperDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.Button StartDeskConnectButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button StopListButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label ListenerStatus;
        private System.Windows.Forms.Button RefreshButton;
    }
}