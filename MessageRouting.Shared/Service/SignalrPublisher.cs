using MessageRouting.Shared.Model;
using Microsoft.AspNet.SignalR.Client;
using System;
using System.Data;
using ConnectionState = Microsoft.AspNet.SignalR.Client.ConnectionState;

namespace MessageRouting.Shared.Service
{
    public class SignalrPublisher : ISignalrPublisher
    {
        //for testing
        public event EventHandler<string> StatusChanged;

        #region private members

        private string host;
        private string hubName;
        private HubConnection connection;
        
        private IHubProxy PublisherHubProxy { get; set; }

        #endregion

        #region constructor

        public SignalrPublisher(string hostName, string hub)
        {
            /*             
             // Could be taken from app config directly?
             // If not found just don't start it
             // http://localhost:50107/
             // MessageRoutingBus             
             */

            host = hostName;
            hubName = hub;
            
            //connection.TraceLevel = TraceLevels.All;            
            //TextWriter
            //connection.TraceWriter 


            //ServicePointManager.DefaultConnectionLimit = 10;
            
            Connect();
        }

        #endregion

        #region connection method

        private void Connect()
        {
            try
            {
                if (PublisherHubProxy == null || connection.State != ConnectionState.Connected)
                {
                    connection = new HubConnection(host);
                    PublisherHubProxy = connection.CreateHubProxy(hubName);

                    //for reconnect
                    connection.Closed += ConnectionClosed;

                    //most for logging
                    connection.StateChanged += ConnectionStateChanged;
                    connection.Error += ConnectionError;

                    //could have an wait or await on it. If its sequence is importans
                    connection.Start().Wait();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion
        
        #region Connection events

        private void ConnectionStateChanged(StateChange obj)
        {
            var msg = string.Format("SignalR status chaged new: {0}, old: {1}, for host: {2}, hub: {3}", obj.NewState.ToString(), obj.OldState, host, hubName);

            LogConnectionInformation(msg, null);
        }

        private void ConnectionError(Exception obj)
        {
            LogConnectionInformation("", obj);
        }

        private void ConnectionClosed()
        {
            Connect();
        }

        #endregion

        #region implementation of interface

        public void Publish(Message msg)
        {
            try
            {
                if (connection.State == ConnectionState.Connected)
                {
                    PublisherHubProxy.Invoke("Publish", msg);
                }

            }
            catch (Exception ex)
            {
                LogConnectionInformation("", ex);
            }
        }

        #endregion


        #region Logging

        private void LogConnectionInformation(string msg, Exception ex)
        {
            //Not logging exceptions now
            if (StatusChanged != null && msg != string.Empty)
            {
                StatusChanged(this, msg);
            }
        }

        #endregion
    }
}
