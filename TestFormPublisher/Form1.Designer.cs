namespace TestFormPublisher
{
    partial class Form1
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
            this.tbxTopic = new System.Windows.Forms.TextBox();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.tbxLevel = new System.Windows.Forms.TextBox();
            this.bntPublish = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxTopic
            // 
            this.tbxTopic.Location = new System.Drawing.Point(12, 12);
            this.tbxTopic.Name = "tbxTopic";
            this.tbxTopic.Size = new System.Drawing.Size(315, 20);
            this.tbxTopic.TabIndex = 0;
            this.tbxTopic.Text = "topic";
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(12, 64);
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(315, 20);
            this.tbxMessage.TabIndex = 1;
            this.tbxMessage.Text = "message";
            // 
            // tbxLevel
            // 
            this.tbxLevel.Location = new System.Drawing.Point(12, 38);
            this.tbxLevel.Name = "tbxLevel";
            this.tbxLevel.Size = new System.Drawing.Size(315, 20);
            this.tbxLevel.TabIndex = 2;
            this.tbxLevel.Text = "level";
            // 
            // bntPublish
            // 
            this.bntPublish.Location = new System.Drawing.Point(184, 90);
            this.bntPublish.Name = "bntPublish";
            this.bntPublish.Size = new System.Drawing.Size(143, 23);
            this.bntPublish.TabIndex = 3;
            this.bntPublish.Text = "Publish";
            this.bntPublish.UseVisualStyleBackColor = true;
            this.bntPublish.Click += new System.EventHandler(this.bntPublish_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(519, 64);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 462);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.bntPublish);
            this.Controls.Add(this.tbxLevel);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.tbxTopic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxTopic;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.TextBox tbxLevel;
        private System.Windows.Forms.Button bntPublish;
        private System.Windows.Forms.Label lblStatus;
    }
}

