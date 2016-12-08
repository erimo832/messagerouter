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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSendCount = new System.Windows.Forms.TextBox();
            this.btnStartEmulation = new System.Windows.Forms.Button();
            this.Single = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTopicEmulation = new System.Windows.Forms.TextBox();
            this.tbxMessageEmulation = new System.Windows.Forms.TextBox();
            this.tbxLevelEmulation = new System.Windows.Forms.TextBox();
            this.lblEmulationStats = new System.Windows.Forms.Label();
            this.Single.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxTopic
            // 
            this.tbxTopic.Location = new System.Drawing.Point(6, 6);
            this.tbxTopic.Name = "tbxTopic";
            this.tbxTopic.Size = new System.Drawing.Size(315, 20);
            this.tbxTopic.TabIndex = 0;
            this.tbxTopic.Text = "topic";
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(6, 58);
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(315, 20);
            this.tbxMessage.TabIndex = 1;
            this.tbxMessage.Text = "message";
            // 
            // tbxLevel
            // 
            this.tbxLevel.Location = new System.Drawing.Point(6, 32);
            this.tbxLevel.Name = "tbxLevel";
            this.tbxLevel.Size = new System.Drawing.Size(315, 20);
            this.tbxLevel.TabIndex = 2;
            this.tbxLevel.Text = "level";
            // 
            // bntPublish
            // 
            this.bntPublish.Location = new System.Drawing.Point(178, 84);
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
            // tbxHostName
            // 
            this.tbxHostName.Location = new System.Drawing.Point(12, 13);
            this.tbxHostName.Name = "tbxHostName";
            this.tbxHostName.Size = new System.Drawing.Size(315, 20);
            this.tbxHostName.TabIndex = 5;
            this.tbxHostName.Text = "http://sesden833:8123/signalr/";
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
            // Single
            // 
            this.Single.Controls.Add(this.tabPage1);
            this.Single.Controls.Add(this.tabPage2);
            this.Single.Location = new System.Drawing.Point(12, 102);
            this.Single.Name = "Single";
            this.Single.SelectedIndex = 0;
            this.Single.Size = new System.Drawing.Size(665, 229);
            this.Single.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbxTopic);
            this.tabPage1.Controls.Add(this.tbxMessage);
            this.tabPage1.Controls.Add(this.bntPublish);
            this.tabPage1.Controls.Add(this.tbxLevel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(657, 203);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Single";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblEmulationStats);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tbxTopicEmulation);
            this.tabPage2.Controls.Add(this.tbxMessageEmulation);
            this.tabPage2.Controls.Add(this.tbxLevelEmulation);
            this.tabPage2.Controls.Add(this.tbxSendCount);
            this.tabPage2.Controls.Add(this.btnStartEmulation);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(657, 203);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Load emulation";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // lblEmulationStats
            // 
            this.lblEmulationStats.AutoSize = true;
            this.lblEmulationStats.Location = new System.Drawing.Point(416, 28);
            this.lblEmulationStats.Name = "lblEmulationStats";
            this.lblEmulationStats.Size = new System.Drawing.Size(34, 13);
            this.lblEmulationStats.TabIndex = 16;
            this.lblEmulationStats.Text = "Stats:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 462);
            this.Controls.Add(this.Single);
            this.Controls.Add(this.btnStartPublisher);
            this.Controls.Add(this.tbxHub);
            this.Controls.Add(this.tbxHostName);
            this.Controls.Add(this.lblStatus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Single.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSendCount;
        private System.Windows.Forms.Button btnStartEmulation;
        private System.Windows.Forms.TabControl Single;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTopicEmulation;
        private System.Windows.Forms.TextBox tbxMessageEmulation;
        private System.Windows.Forms.TextBox tbxLevelEmulation;
        private System.Windows.Forms.Label lblEmulationStats;
    }
}

