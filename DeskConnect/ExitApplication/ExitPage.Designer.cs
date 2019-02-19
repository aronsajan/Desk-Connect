namespace ExitApplication
{
    partial class ExitPage
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
            this.ExitConfirmationLabel = new System.Windows.Forms.Label();
            this.YesButton = new System.Windows.Forms.Button();
            this.QuestionImage = new System.Windows.Forms.PictureBox();
            this.NoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitConfirmationLabel
            // 
            this.ExitConfirmationLabel.AutoSize = true;
            this.ExitConfirmationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitConfirmationLabel.Location = new System.Drawing.Point(360, 155);
            this.ExitConfirmationLabel.Name = "ExitConfirmationLabel";
            this.ExitConfirmationLabel.Size = new System.Drawing.Size(302, 25);
            this.ExitConfirmationLabel.TabIndex = 0;
            this.ExitConfirmationLabel.Text = "Are you sure you want to exit?";
            // 
            // YesButton
            // 
            this.YesButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.YesButton.Location = new System.Drawing.Point(397, 201);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(112, 31);
            this.YesButton.TabIndex = 1;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // QuestionImage
            // 
            this.QuestionImage.Image = global::ExitApplication.Properties.Resources.Icon_question;
            this.QuestionImage.Location = new System.Drawing.Point(293, 139);
            this.QuestionImage.Name = "QuestionImage";
            this.QuestionImage.Size = new System.Drawing.Size(64, 59);
            this.QuestionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QuestionImage.TabIndex = 3;
            this.QuestionImage.TabStop = false;
            // 
            // NoButton
            // 
            this.NoButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NoButton.Location = new System.Drawing.Point(513, 201);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(112, 31);
            this.NoButton.TabIndex = 4;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // ExitPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.QuestionImage);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.ExitConfirmationLabel);
            this.Name = "ExitPage";
            this.Size = new System.Drawing.Size(1022, 567);
            this.Load += new System.EventHandler(this.ExitPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuestionImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExitConfirmationLabel;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.PictureBox QuestionImage;
        private System.Windows.Forms.Button NoButton;
    }
}
