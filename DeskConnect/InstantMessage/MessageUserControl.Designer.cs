namespace InstantMessage
{
    partial class MessageUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.ChatBoxList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.MessageText = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MachineDropDown = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(117)))), ((int)(((byte)(146)))));
            this.panel1.Controls.Add(this.MachineDropDown);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 41);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "System Name";
            // 
            // ChatBoxList
            // 
            this.ChatBoxList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.ChatBoxList.FullRowSelect = true;
            this.ChatBoxList.Location = new System.Drawing.Point(13, 73);
            this.ChatBoxList.Name = "ChatBoxList";
            this.ChatBoxList.Size = new System.Drawing.Size(981, 331);
            this.ChatBoxList.TabIndex = 1;
            this.ChatBoxList.UseCompatibleStateImageBehavior = false;
            this.ChatBoxList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Messages";
            this.columnHeader1.Width = 960;
            // 
            // MessageText
            // 
            this.MessageText.Location = new System.Drawing.Point(13, 435);
            this.MessageText.Multiline = true;
            this.MessageText.Name = "MessageText";
            this.MessageText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MessageText.Size = new System.Drawing.Size(981, 81);
            this.MessageText.TabIndex = 2;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(919, 529);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 29);
            this.SendButton.TabIndex = 3;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(13, 523);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(981, 1);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chat Box";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type your message here";
            // 
            // MachineDropDown
            // 
            this.MachineDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MachineDropDown.FormattingEnabled = true;
            this.MachineDropDown.Location = new System.Drawing.Point(97, 12);
            this.MachineDropDown.Name = "MachineDropDown";
            this.MachineDropDown.Size = new System.Drawing.Size(364, 21);
            this.MachineDropDown.TabIndex = 2;
            // 
            // MessageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.ChatBoxList);
            this.Controls.Add(this.panel1);
            this.Name = "MessageUserControl";
            this.Size = new System.Drawing.Size(1022, 567);
            this.Load += new System.EventHandler(this.MessageUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ChatBoxList;
        private System.Windows.Forms.TextBox MessageText;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ComboBox MachineDropDown;

    }
}
