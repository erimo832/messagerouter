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
using TestFormPublisher.Service;

namespace TestFormPublisher
{
    public partial class Form1 : Form
    {
       /* private IHubProxy _proxy;
        public IHubProxy PublisherHubProxy
        {
            get
            {
                if (_proxy == null)
                {
                    var hubConnection = new HubConnection("http://localhost:50107/");                    
                    _proxy = hubConnection.CreateHubProxy("MessageRoutingBus");

                    
                    
                    hubConnection.Closed += hubConnection_Closed;
                    hubConnection.Reconnecting += hubConnection_Reconnecting;
                    hubConnection.StateChanged += hubConnection_StateChanged;

                    hubConnection.Start().Wait(new TimeSpan(0, 0, 10));
                    
                }

                return _proxy;
            }
        }

        private void hubConnection_StateChanged(StateChange obj)
        {
            switch (obj.NewState)
            {
                case Microsoft.AspNet.SignalR.Client.ConnectionState.Connected:
                    lblStatus.Text = string.Format("New state: {0}, old state: {1}", obj.NewState.ToString(), obj.OldState);
                    break;
                case Microsoft.AspNet.SignalR.Client.ConnectionState.Connecting:
                    lblStatus.Text = string.Format("New state: {0}, old state: {1}", obj.NewState.ToString(), obj.OldState);
                    break;
                case Microsoft.AspNet.SignalR.Client.ConnectionState.Disconnected:
                    lblStatus.Text = string.Format("New state: {0}, old state: {1}", obj.NewState.ToString(), obj.OldState);
                    break;
                case Microsoft.AspNet.SignalR.Client.ConnectionState.Reconnecting:
                    lblStatus.Text = string.Format("New state: {0}, old state: {1}", obj.NewState.ToString(), obj.OldState);
                    break;
                default:
                    break;
            }
        }

        void hubConnection_Reconnecting()
        {
            lblStatus.Text = "hubConnection_Reconnecting";
        }

        void hubConnection_Closed()
        {
            lblStatus.Text = "hubConnection_Closed";
        }*/

        private ISignalrPublisher Publiser { get; set; }

        public Form1()
        {
            InitializeComponent();

            //stockTickerHubProxy.On<Stock>("UpdateStockPrice", stock => Console.WriteLine("Stock update for {0} new price {1}", stock.Symbol, stock.Price));

            // http://localhost:50107/
            // MessageRoutingBus  

            Publiser = new SignalrPublisher(@"http://localhost:50107/", "MessageRoutingBus");

            Publiser.StatusChanged += Publiser_StatusChanged;
        }

        void Publiser_StatusChanged(object sender, string e)
        {
            lblStatus.Text = e;
        }

        private void bntPublish_Click(object sender, EventArgs e)
        {
            var msg = new Message 
            {
                 Topic = tbxTopic.Text,
                 Text = tbxMessage.Text,
                 Level = tbxLevel.Text
            };

            Publiser.Publish(msg);
        }



    }
}
