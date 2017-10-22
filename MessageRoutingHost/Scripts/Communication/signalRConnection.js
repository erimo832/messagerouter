var signalrConnection = (function ($) {
    var obj = {};
    var hub;
    var topic = ['#'];
    var name = "NoDefinedName";
    
    //private        
    function registerEvents() {
        hub.client.connectionEstablished = function (message) {                
            if (typeof obj.onStatusChange === "function") {               
                obj.onStatusChange(obj.ConnectionEnum.Connected, message);
            }
        };
        hub.client.newMessage = function (msg) {
            if (typeof obj.onMessage === "function") {
                obj.onMessage(msg);
            }
        };
        $.connection.hub.disconnected(function () {
            if (typeof obj.onError === "function") {
                obj.onError($.connection.hub.lastError.message);
            }

            if (typeof obj.onStatusChange === "function") {
                obj.onStatusChange(obj.ConnectionEnum.Disconnected, "Disconnected from signalr server");
            }

            //reconnect
            setTimeout(function () {
                $.connection.hub.start().done(function () {
                    startSubscription(hub);
                });
            }, 5000); // Restart connection after 5 seconds.

        });
        $.connection.hub.reconnecting(function () {
            if (typeof obj.onStatusChange === "function") {
                obj.onStatusChange(obj.ConnectionEnum.Reconnecting, "Reconnecting to signalr server");
            }
        });
        $.connection.hub.reconnected(function () {
            if (typeof obj.onStatusChange === "function") {
                obj.onStatusChange(obj.ConnectionEnum.Connected, "Reconnected to signalr server");
            }

            startSubscription(hub);
        });        
        // Start the connection.
        $.connection.hub.start().done(function () {            
            startSubscription(hub);
        });
    }

    function startSubscription(srv) {        
        //connect to server
        srv.server.subscribe(name, topic);
    }

    //public
    obj.onMessage;
    obj.onStatusChange;
    obj.onError;
    obj.ConnectionEnum;
    obj.connect = function (connectionName, subscriptionTopics) {
        hub = $.connection.messageRoutingBus;

        if(connectionName)
            name = connectionName;
        
        if (subscriptionTopics) {
            topic = subscriptionTopics.split(",");;
        }
        
        registerEvents(hub);
    };

    return obj;
}(jQuery));