namespace ProcessManagerUI.NewProcess
{
    partial class NewProcessParameters
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProgramText = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.RemoteMachineLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(117)))), ((int)(((byte)(146)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 54);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "New Process Parameters";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(77)))));
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 1);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Machine Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Program";
            // 
            // ProgramText
            // 
            this.ProgramText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProgramText.Location = new System.Drawing.Point(100, 107);
            this.ProgramText.Name = "ProgramText";
            this.ProgramText.Size = new System.Drawing.Size(307, 20);
            this.ProgramText.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(0, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(488, 1);
            this.panel3.TabIndex = 5;
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Location = new System.Drawing.Point(376, 165);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(103, 25);
            this.ExecuteButton.TabIndex = 6;
            this.ExecuteButton.Text = "Execute Program";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // RemoteMachineLabel
            // 
            this.RemoteMachineLabel.AutoSize = true;
            this.RemoteMachineLabel.Location = new System.Drawing.Point(97, 77);
            this.RemoteMachineLabel.Name = "RemoteMachineLabel";
            this.RemoteMachineLabel.Size = new System.Drawing.Size(99, 13);
            this.RemoteMachineLabel.TabIndex = 7;
            this.RemoteMachineLabel.Text = "##RemoteMachine";
            // 
            // NewProcessParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 200);
            this.Controls.Add(this.RemoteMachineLabel);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ProgramText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewProcessParameters";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desk Connect";
            this.Load += new System.EventHandler(this.NewProcessParameters_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProgramText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RemoteMachineLabel;
    }
}