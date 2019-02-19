namespace DeskConnect
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MenuStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Location = new System.Drawing.Point(0, 102);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1022, 571);
            this.ContentPanel.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox2.Image = global::DeskConnect.Properties.Resources.Banner_Raw;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1025, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // MenuStrip
            // 
            this.MenuStrip.AutoSize = false;
            this.MenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.MenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MenuStrip.Location = new System.Drawing.Point(0, 73);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1037, 27);
            this.MenuStrip.TabIndex = 4;
            this.MenuStrip.Text = "toolStrip1";
            this.MenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip_ItemClicked);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 671);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ContentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "#DestConnect Details ";
            this.Load += new System.EventHandler(this.Home_Load);
            this.VisibleChanged += new System.EventHandler(this.Home_VisibleChanged);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.ToolStrip MenuStrip;
    }
}

