using System;
using System.Windows.Forms;
using MessageRouting.Shared.Service;
using MessageRouting.Shared.Model;
using MessageRouting.Shared.Model.Objects;
using TestFormPublisher.Helpers;

namespace TestFormPublisher
{
    public partial class Form1 : Form
    {            
        private ISignalrPublisher Publiser { get; set; }

        public Form1()
        {
            InitializeComponent();

            // http://localhost:50107/
            // MessageRoutingBus  

            //Publiser = new SignalrPublisher(@"http://localhost:50107/", "MessageRoutingBus");
            //Publiser = new SignalrPublisher(@"http://SESDEN822.vcn.ds.volvo.net:8122/", "MessageRoutingBus");
            //Publiser = new SignalrPublisher(@"http://localhost:50107/", "MessageRoutingBus");
            //Publiser = new SignalrPublisher(@"http://192.168.1.61/signalr/", "MessageRoutingBus");

            //Publiser.StatusChanged += Publiser_StatusChanged;

            tbxDvTimestamp.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ff");
        }

        #region SignalR connection

        private void btnStartPublisher_Click(object sender, EventArgs e)
        {
            try
            {
                Publiser = new SignalrPublisher(cbHost.Text, tbxHub.Text);

                Publiser.StatusChanged += Publiser_StatusChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Publiser_StatusChanged(object sender, string e)
        {
            if (lblStatus.InvokeRequired)
            {
                Invoke(new Action(() => Publiser_StatusChanged(sender, e)));
            }

            lblStatus.Text = e;
        }

        #endregion

        private void bntPublish_Click(object sender, EventArgs e)
        {
            try
            {

                var message = new 
                {
                    Topic = tbxTopic.Text,
                    DataArea = GetJsonObject()
                    //Text = tbxMessage.Text,
                    //Level = tbxLevel.Text
                };

                var msg = JsonHelper<object>.ToJson(message);

                Publiser.Publish(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void btnStartEmulation_Click(object sender, EventArgs e)
        {
            try
            {
                int cnt = Convert.ToInt32(tbxSendCount.Text);

                for (int i = 0; i < cnt; i++)
                {
                    var message = new 
                    {
                        Topic = tbxTopicEmulation.Text.Replace("[0]", i.ToString()),
                        //Text = tbxMessageEmulation.Text.Replace("[0]", i.ToString()),
                        //Level = tbxLevelEmulation.Text.Replace("[0]", i.ToString())
                    };

                    var msg = JsonHelper<object>.ToJson(message);

                    Publiser.Publish(msg);

                    lblEmulationStats.Text = string.Format("Stats: \r\n # {0}", i);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        

        private void btnDvNow_Click(object sender, EventArgs e)
        {
            tbxDvTimestamp.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ff");
        }


        private string GetJsonObject()
        {
            if (tcMessages.SelectedTab == tpMessage)
            {
                var obj = new TextObject
                {
                    Text = tbxMessage.Text,
                    Level = tbxLevel.Text
                };

                return JsonHelper<TextObject>.ToJson(obj);
            }
            else if (tcMessages.SelectedTab == tpDataValue)
            {
                var obj = new DataValueObject
                {
                    Value = Convert.ToDouble(tbxDvValue.Text),
                    Timestamp = DateTime.Parse(tbxDvTimestamp.Text)
                };
                return JsonHelper<DataValueObject>.ToJson(obj);
            }
            else if (tcMessages.SelectedTab == tpEmulation)
            {
                MessageBox.Show("Can't publish in emulation mode");
            }

            return "";
        }
    }
}
