namespace DeskConnectMessageNotifier
{
    partial class MessageNotifierWindow
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
            this.OKButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BannerLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NotifyText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(229, 216);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(81, 28);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.BannerLabel);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 64);
            this.panel1.TabIndex = 1;
            // 
            // BannerLabel
            // 
            this.BannerLabel.AutoSize = true;
            this.BannerLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BannerLabel.ForeColor = System.Drawing.Color.White;
            this.BannerLabel.Location = new System.Drawing.Point(9, 20);
            this.BannerLabel.Name = "BannerLabel";
            this.BannerLabel.Size = new System.Drawing.Size(268, 23);
            this.BannerLabel.TabIndex = 0;
            this.BannerLabel.Text = "Desk Connect Message Notifier";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(-5, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 1);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(1, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(537, 1);
            this.panel3.TabIndex = 3;
            // 
            // NotifyText
            // 
            this.NotifyText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotifyText.Location = new System.Drawing.Point(6, 72);
            this.NotifyText.Multiline = true;
            this.NotifyText.Name = "NotifyText";
            this.NotifyText.ReadOnly = true;
            this.NotifyText.Size = new System.Drawing.Size(526, 125);
            this.NotifyText.TabIndex = 4;
            this.NotifyText.TextChanged += new System.EventHandler(this.NotifyText_TextChanged);
            // 
            // MessageNotifierWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 254);
            this.Controls.Add(this.NotifyText);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageNotifierWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "You have a new message";
            this.Load += new System.EventHandler(this.MessageNotifierWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label BannerLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox NotifyText;
    }
}

