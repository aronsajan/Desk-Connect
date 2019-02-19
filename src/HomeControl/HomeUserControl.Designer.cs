namespace HomeControl
{
    partial class HomeUserControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUserControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RemoveFromListButton = new System.Windows.Forms.Button();
            this.AddToListButton = new System.Windows.Forms.Button();
            this.SystemNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MachineListView = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeveloperLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(117)))), ((int)(((byte)(146)))));
            this.panel1.Controls.Add(this.RemoveFromListButton);
            this.panel1.Controls.Add(this.AddToListButton);
            this.panel1.Controls.Add(this.SystemNameText);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 39);
            this.panel1.TabIndex = 8;
            // 
            // RemoveFromListButton
            // 
            this.RemoveFromListButton.Enabled = false;
            this.RemoveFromListButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RemoveFromListButton.Location = new System.Drawing.Point(637, 7);
            this.RemoveFromListButton.Name = "RemoveFromListButton";
            this.RemoveFromListButton.Size = new System.Drawing.Size(109, 23);
            this.RemoveFromListButton.TabIndex = 3;
            this.RemoveFromListButton.Text = "Remove";
            this.RemoveFromListButton.UseVisualStyleBackColor = true;
            this.RemoveFromListButton.Click += new System.EventHandler(this.RemoveFromListButton_Click);
            // 
            // AddToListButton
            // 
            this.AddToListButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddToListButton.Location = new System.Drawing.Point(505, 7);
            this.AddToListButton.Name = "AddToListButton";
            this.AddToListButton.Size = new System.Drawing.Size(126, 23);
            this.AddToListButton.TabIndex = 2;
            this.AddToListButton.Text = "Add to connection list";
            this.AddToListButton.UseVisualStyleBackColor = true;
            this.AddToListButton.Click += new System.EventHandler(this.AddToListButton_Click);
            // 
            // SystemNameText
            // 
            this.SystemNameText.Location = new System.Drawing.Point(94, 9);
            this.SystemNameText.Name = "SystemNameText";
            this.SystemNameText.Size = new System.Drawing.Size(405, 20);
            this.SystemNameText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "System Name";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icon-computer-32x32.png");
            // 
            // MachineListView
            // 
            this.MachineListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MachineListView.Location = new System.Drawing.Point(0, 39);
            this.MachineListView.Name = "MachineListView";
            this.MachineListView.Size = new System.Drawing.Size(1022, 487);
            this.MachineListView.TabIndex = 9;
            this.MachineListView.UseCompatibleStateImageBehavior = false;
            this.MachineListView.SelectedIndexChanged += new System.EventHandler(this.MachineListView_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(117)))), ((int)(((byte)(146)))));
            this.panel2.Controls.Add(this.DeveloperLabel);
            this.panel2.Location = new System.Drawing.Point(-1, 542);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1023, 25);
            this.panel2.TabIndex = 10;
            // 
            // DeveloperLabel
            // 
            this.DeveloperLabel.AutoSize = true;
            this.DeveloperLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeveloperLabel.ForeColor = System.Drawing.Color.White;
            this.DeveloperLabel.Location = new System.Drawing.Point(6, 5);
            this.DeveloperLabel.Name = "DeveloperLabel";
            this.DeveloperLabel.Size = new System.Drawing.Size(176, 14);
            this.DeveloperLabel.TabIndex = 0;
            this.DeveloperLabel.Text = "Developed by Aron Sajan Philip";
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MachineListView);
            this.Controls.Add(this.panel1);
            this.Name = "HomeUserControl";
            this.Size = new System.Drawing.Size(1022, 567);
            this.Load += new System.EventHandler(this.HomeUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddToListButton;
        private System.Windows.Forms.TextBox SystemNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RemoveFromListButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView MachineListView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label DeveloperLabel;


    }
}
