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
            this.tbxHub = new System.Windows.Forms.TextBox();
            this.btnStartPublisher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSendCount = new System.Windows.Forms.TextBox();
            this.btnStartEmulation = new System.Windows.Forms.Button();
            this.tcMessages = new System.Windows.Forms.TabControl();
            this.tpMessage = new System.Windows.Forms.TabPage();
            this.tpEmulation = new System.Windows.Forms.TabPage();
            this.lblEmulationStats = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTopicEmulation = new System.Windows.Forms.TextBox();
            this.tbxMessageEmulation = new System.Windows.Forms.TextBox();
            this.tbxLevelEmulation = new System.Windows.Forms.TextBox();
            this.tpDataValue = new System.Windows.Forms.TabPage();
            this.tbxDvValue = new System.Windows.Forms.TextBox();
            this.tbxDvTimestamp = new System.Windows.Forms.TextBox();
            this.btnDvNow = new System.Windows.Forms.Button();
            this.cbHost = new System.Windows.Forms.ComboBox();
            this.tcMessages.SuspendLayout();
            this.tpMessage.SuspendLayout();
            this.tpEmulation.SuspendLayout();
            this.tpDataValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxTopic
            // 
            this.tbxTopic.Location = new System.Drawing.Point(12, 106);
            this.tbxTopic.Name = "tbxTopic";
            this.tbxTopic.Size = new System.Drawing.Size(636, 20);
            this.tbxTopic.TabIndex = 0;
            this.tbxTopic.Text = "topic";
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(6, 32);
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(315, 20);
            this.tbxMessage.TabIndex = 1;
            this.tbxMessage.Text = "message";
            // 
            // tbxLevel
            // 
            this.tbxLevel.Location = new System.Drawing.Point(6, 6);
            this.tbxLevel.Name = "tbxLevel";
            this.tbxLevel.Size = new System.Drawing.Size(315, 20);
            this.tbxLevel.TabIndex = 2;
            this.tbxLevel.Text = "level";
            // 
            // bntPublish
            // 
            this.bntPublish.Location = new System.Drawing.Point(15, 394);
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
            this.lblStatus.Location = new System.Drawing.Point(12, 77);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            // 
            // tbxHub
            // 
            this.tbxHub.Location = new System.Drawing.Point(333, 13);
            this.tbxHub.Name = "tbxHub";
            this.tbxHub.Size = new System.Drawing.Size(315, 20);
            this.tbxHub.TabIndex = 6;
            this.tbxHub.Text = "MessageRoutingBus";
            // 
            // btnStartPublisher
            // 
            this.btnStartPublisher.Location = new System.Drawing.Point(12, 39);
            this.btnStartPublisher.Name = "btnStartPublisher";
            this.btnStartPublisher.Size = new System.Drawing.Size(135, 23);
            this.btnStartPublisher.TabIndex = 7;
            this.btnStartPublisher.Text = "Connect";
            this.btnStartPublisher.UseVisualStyleBackColor = true;
            this.btnStartPublisher.Click += new System.EventHandler(this.btnStartPublisher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Count";
            // 
            // tbxSendCount
            // 
            this.tbxSendCount.Location = new System.Drawing.Point(9, 131);
            this.tbxSendCount.Name = "tbxSendCount";
            this.tbxSendCount.Size = new System.Drawing.Size(146, 20);
            this.tbxSendCount.TabIndex = 9;
            this.tbxSendCount.Text = "100";
            // 
            // btnStartEmulation
            // 
            this.btnStartEmulation.Location = new System.Drawing.Point(508, 174);
            this.btnStartEmulation.Name = "btnStartEmulation";
            this.btnStartEmulation.Size = new System.Drawing.Size(143, 23);
            this.btnStartEmulation.TabIndex = 11;
            this.btnStartEmulation.Text = "Start emulation";
            this.btnStartEmulation.UseVisualStyleBackColor = true;
            this.btnStartEmulation.Click += new System.EventHandler(this.btnStartEmulation_Click);
            // 
            // tcMessages
            // 
            this.tcMessages.Controls.Add(this.tpMessage);
            this.tcMessages.Controls.Add(this.tpDataValue);
            this.tcMessages.Controls.Add(this.tpEmulation);
            this.tcMessages.Location = new System.Drawing.Point(12, 150);
            this.tcMessages.Name = "tcMessages";
            this.tcMessages.SelectedIndex = 0;
            this.tcMessages.Size = new System.Drawing.Size(665, 229);
            this.tcMessages.TabIndex = 12;
            // 
            // tpMessage
            // 
            this.tpMessage.Controls.Add(this.tbxMessage);
            this.tpMessage.Controls.Add(this.tbxLevel);
            this.tpMessage.Location = new System.Drawing.Point(4, 22);
            this.tpMessage.Name = "tpMessage";
            this.tpMessage.Padding = new System.Windows.Forms.Padding(3);
            this.tpMessage.Size = new System.Drawing.Size(657, 203);
            this.tpMessage.TabIndex = 0;
            this.tpMessage.Text = "Message";
            this.tpMessage.UseVisualStyleBackColor = true;
            // 
            // tpEmulation
            // 
            this.tpEmulation.Controls.Add(this.lblEmulationStats);
            this.tpEmulation.Controls.Add(this.label2);
            this.tpEmulation.Controls.Add(this.tbxTopicEmulation);
            this.tpEmulation.Controls.Add(this.tbxMessageEmulation);
            this.tpEmulation.Controls.Add(this.tbxLevelEmulation);
            this.tpEmulation.Controls.Add(this.tbxSendCount);
            this.tpEmulation.Controls.Add(this.btnStartEmulation);
            this.tpEmulation.Controls.Add(this.label1);
            this.tpEmulation.Location = new System.Drawing.Point(4, 22);
            this.tpEmulation.Name = "tpEmulation";
            this.tpEmulation.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmulation.Size = new System.Drawing.Size(657, 203);
            this.tpEmulation.TabIndex = 2;
            this.tpEmulation.Text = "Load emulation";
            this.tpEmulation.UseVisualStyleBackColor = true;
            // 
            // lblEmulationStats
            // 
            this.lblEmulationStats.AutoSize = true;
            this.lblEmulationStats.Location = new System.Drawing.Point(416, 28);
            this.lblEmulationStats.Name = "lblEmulationStats";
            this.lblEmulationStats.Size = new System.Drawing.Size(34, 13);
            this.lblEmulationStats.TabIndex = 16;
            this.lblEmulationStats.Text = "Stats:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "[0] adds the message number sent";
            // 
            // tbxTopicEmulation
            // 
            this.tbxTopicEmulation.Location = new System.Drawing.Point(6, 28);
            this.tbxTopicEmulation.Name = "tbxTopicEmulation";
            this.tbxTopicEmulation.Size = new System.Drawing.Size(315, 20);
            this.tbxTopicEmulation.TabIndex = 12;
            this.tbxTopicEmulation.Text = "topic";
            // 
            // tbxMessageEmulation
            // 
            this.tbxMessageEmulation.Location = new System.Drawing.Point(6, 80);
            this.tbxMessageEmulation.Name = "tbxMessageEmulation";
            this.tbxMessageEmulation.Size = new System.Drawing.Size(315, 20);
            this.tbxMessageEmulation.TabIndex = 13;
            this.tbxMessageEmulation.Text = "message [0]";
            // 
            // tbxLevelEmulation
            // 
            this.tbxLevelEmulation.Location = new System.Drawing.Point(6, 54);
            this.tbxLevelEmulation.Name = "tbxLevelEmulation";
            this.tbxLevelEmulation.Size = new System.Drawing.Size(315, 20);
            this.tbxLevelEmulation.TabIndex = 14;
            this.tbxLevelEmulation.Text = "level";
            // 
            // tpDataValue
            // 
            this.tpDataValue.Controls.Add(this.btnDvNow);
            this.tpDataValue.Controls.Add(this.tbxDvTimestamp);
            this.tpDataValue.Controls.Add(this.tbxDvValue);
            this.tpDataValue.Location = new System.Drawing.Point(4, 22);
            this.tpDataValue.Name = "tpDataValue";
            this.tpDataValue.Padding = new System.Windows.Forms.Padding(3);
            this.tpDataValue.Size = new System.Drawing.Size(657, 203);
            this.tpDataValue.TabIndex = 1;
            this.tpDataValue.Text = "DataValue";
            this.tpDataValue.UseVisualStyleBackColor = true;
            // 
            // tbxDvValue
            // 
            this.tbxDvValue.Location = new System.Drawing.Point(6, 6);
            this.tbxDvValue.Name = "tbxDvValue";
            this.tbxDvValue.Size = new System.Drawing.Size(191, 20);
            this.tbxDvValue.TabIndex = 0;
            this.tbxDvValue.Text = "1,0";
            // 
            // tbxDvTimestamp
            // 
            this.tbxDvTimestamp.Location = new System.Drawing.Point(6, 32);
            this.tbxDvTimestamp.Name = "tbxDvTimestamp";
            this.tbxDvTimestamp.Size = new System.Drawing.Size(191, 20);
            this.tbxDvTimestamp.TabIndex = 1;
            // 
            // btnDvNow
            // 
            this.btnDvNow.Location = new System.Drawing.Point(204, 28);
            this.btnDvNow.Name = "btnDvNow";
            this.btnDvNow.Size = new System.Drawing.Size(41, 23);
            this.btnDvNow.TabIndex = 2;
            this.btnDvNow.Text = "now";
            this.btnDvNow.UseVisualStyleBackColor = true;
            this.btnDvNow.Click += new System.EventHandler(this.btnDvNow_Click);
            // 
            // cbHost
            // 
            this.cbHost.AutoCompleteCustomSource.AddRange(new string[] {
            "http://localhost:50107/",
            "http://sesden833:8123/signalr/",
            "http://sesden833:8122/signalr/"});
            this.cbHost.FormattingEnabled = true;
            this.cbHost.Items.AddRange(new object[] {
            "http://localhost:50107/",
            "http://sesden833:8122/signalr/",
            "http://sesden833:8123/signalr/"});
            this.cbHost.Location = new System.Drawing.Point(12, 13);
            this.cbHost.Name = "cbHost";
            this.cbHost.Size = new System.Drawing.Size(315, 21);
            this.cbHost.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 462);
            this.Controls.Add(this.cbHost);
            this.Controls.Add(this.tbxTopic);
            this.Controls.Add(this.bntPublish);
            this.Controls.Add(this.tcMessages);
            this.Controls.Add(this.btnStartPublisher);
            this.Controls.Add(this.tbxHub);
            this.Controls.Add(this.lblStatus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tcMessages.ResumeLayout(false);
            this.tpMessage.ResumeLayout(false);
            this.tpMessage.PerformLayout();
            this.tpEmulation.ResumeLayout(false);
            this.tpEmulation.PerformLayout();
            this.tpDataValue.ResumeLayout(false);
            this.tpDataValue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxTopic;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.TextBox tbxLevel;
        private System.Windows.Forms.Button bntPublish;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox tbxHub;
        private System.Windows.Forms.Button btnStartPublisher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSendCount;
        private System.Windows.Forms.Button btnStartEmulation;
        private System.Windows.Forms.TabControl tcMessages;
        private System.Windows.Forms.TabPage tpMessage;
        private System.Windows.Forms.TabPage tpEmulation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTopicEmulation;
        private System.Windows.Forms.TextBox tbxMessageEmulation;
        private System.Windows.Forms.TextBox tbxLevelEmulation;
        private System.Windows.Forms.Label lblEmulationStats;
        private System.Windows.Forms.TabPage tpDataValue;
        private System.Windows.Forms.Button btnDvNow;
        private System.Windows.Forms.TextBox tbxDvTimestamp;
        private System.Windows.Forms.TextBox tbxDvValue;
        private System.Windows.Forms.ComboBox cbHost;
    }
}

