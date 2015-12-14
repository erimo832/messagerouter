using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessageRouting.Shared.Service;
using MessageRouting.Shared.Model;


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
            //Publiser = new SignalrPublisher(@"http://sesden822:8122/", "MessageRoutingBus");
            //Publiser = new SignalrPublisher(@"http://localhost:50107/", "MessageRoutingBus");
            Publiser = new SignalrPublisher(@"http://192.168.1.8/", "MessageRoutingBus");

            Publiser.StatusChanged += Publiser_StatusChanged;
        }

        void Publiser_StatusChanged(object sender, string e)
        {
            if (lblStatus.InvokeRequired)
            {
                Invoke(new Action(() => Publiser_StatusChanged(sender, e)));
            }

            lblStatus.Text = e;
        }



        private void bntPublish_Click(object sender, EventArgs e)
        {
            var msg = new MessageRouting.Shared.Model.Message 
            {
                 Topic = tbxTopic.Text,
                 Text = tbxMessage.Text,
                 Level = tbxLevel.Text
            };

            Publiser.Publish(msg);
        }



    }
}
