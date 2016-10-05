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
            this.tbxHostName = new System.Windows.Forms.TextBox();
            this.tbxHub = new System.Windows.Forms.TextBox();
            this.btnStartPublisher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxTopic
            // 
            this.tbxTopic.Location = new System.Drawing.Point(16, 15);
            this.tbxTopic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxTopic.Name = "tbxTopic";
            this.tbxTopic.Size = new System.Drawing.Size(419, 22);
            this.tbxTopic.TabIndex = 0;
            this.tbxTopic.Text = "topic";
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(16, 79);
            this.tbxMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(419, 22);
            this.tbxMessage.TabIndex = 1;
            this.tbxMessage.Text = "message";
            // 
            // tbxLevel
            // 
            this.tbxLevel.Location = new System.Drawing.Point(16, 47);
            this.tbxLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxLevel.Name = "tbxLevel";
            this.tbxLevel.Size = new System.Drawing.Size(419, 22);
            this.tbxLevel.TabIndex = 2;
            this.tbxLevel.Text = "level";
            // 
            // bntPublish
            // 
            this.bntPublish.Location = new System.Drawing.Point(245, 111);
            this.bntPublish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntPublish.Name = "bntPublish";
            this.bntPublish.Size = new System.Drawing.Size(191, 28);
            this.bntPublish.TabIndex = 3;
            this.bntPublish.Text = "Publish";
            this.bntPublish.UseVisualStyleBackColor = true;
            this.bntPublish.Click += new System.EventHandler(this.bntPublish_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(16, 295);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            // 
            // tbxHostName
            // 
            this.tbxHostName.Location = new System.Drawing.Point(16, 217);
            this.tbxHostName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxHostName.Name = "tbxHostName";
            this.tbxHostName.Size = new System.Drawing.Size(419, 22);
            this.tbxHostName.TabIndex = 5;
            this.tbxHostName.Text = "http://sesden822:8122/signalr/";
            // 
            // tbxHub
            // 
            this.tbxHub.Location = new System.Drawing.Point(444, 217);
            this.tbxHub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxHub.Name = "tbxHub";
            this.tbxHub.Size = new System.Drawing.Size(419, 22);
            this.tbxHub.TabIndex = 6;
            this.tbxHub.Text = "MessageRoutingBus";
            // 
            // btnStartPublisher
            // 
            this.btnStartPublisher.Location = new System.Drawing.Point(16, 249);
            this.btnStartPublisher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStartPublisher.Name = "btnStartPublisher";
            this.btnStartPublisher.Size = new System.Drawing.Size(180, 28);
            this.btnStartPublisher.TabIndex = 7;
            this.btnStartPublisher.Text = "Connect";
            this.btnStartPublisher.UseVisualStyleBackColor = true;
            this.btnStartPublisher.Click += new System.EventHandler(this.btnStartPublisher_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 569);
            this.Controls.Add(this.btnStartPublisher);
            this.Controls.Add(this.tbxHub);
            this.Controls.Add(this.tbxHostName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.bntPublish);
            this.Controls.Add(this.tbxLevel);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.tbxTopic);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox tbxHostName;
        private System.Windows.Forms.TextBox tbxHub;
        private System.Windows.Forms.Button btnStartPublisher;
    }
}

