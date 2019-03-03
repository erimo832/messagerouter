﻿var signalrConnection = (function ($) {
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
        hub.client.newMessage = function (message, topic) {
            if (typeof obj.onMessage === "function") {
                var msg = parsePayload(message);
                obj.onMessage(msg, topic);
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
    obj.connect = function (settings) {
        hub = $.connection.messageRoutingBus;

        if (settings.name)
            name = settings.name;
        
        if (settings.topic) {
            topic = settings.topic.split(",");;
        }
        
        registerEvents(hub);
    };

    return obj;
}(jQuery));