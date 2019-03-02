var mqttConnection = (function ($) {
    var obj = {};
    var topic = ['#'];
    var config;
    var client;
    
    var connectSuccess = function () {
        if (typeof obj.onStatusChange === "function") {
            obj.onStatusChange(obj.ConnectionEnum.Connected, "Connected to " + config.brokerurl);
        }

        for (var i = 0; i < topic.length; i++) {
            client.subscribe(topic[i], { qos: 0 });
        }
    };

    var errorConnectionLost = function (message) { 
        if (typeof obj.onError === "function") {
            obj.onError(message.errorMessage);
        }

        if (typeof obj.onStatusChange === "function") {
            obj.onStatusChange(obj.ConnectionEnum.Disconnected, "Disconnected from " + config.brokerurl);
        }

        //reconnect timer
        setTimeout(function () {
            if (typeof obj.onStatusChange === "function") {
                obj.onStatusChange(obj.ConnectionEnum.Reconnecting, "Reconnecting to " + config.brokerurl);
            }

            startConnection();
        }, 10000);
    };

    //Connect Options
    var options = {
        timeout: 3,
        //Gets Called if the connection has sucessfully been established
        onSuccess: connectSuccess,
        //Gets Called if the connection could not be established
        onFailure: errorConnectionLost
    };
    
    //private
    function startConnection() {
        //Using the HiveMQ public Broker, with a random client Id
        client = new Messaging.Client(config.brokerurl, config.port, "myclientid_" + parseInt(Math.random() * 100, 10));

        //Gets  called if the websocket/mqtt connection gets disconnected for any reason
        client.onConnectionLost = errorConnectionLost;

        client.onMessageArrived = function (message) {
            if (typeof obj.onMessage === "function") {
                obj.onMessage(message.payloadString, message.destinationName);
            }
        };       
        
        client.connect(options);
    }

    //public 
    obj.onMessage;
    obj.onStatusChange;
    obj.onError;
    obj.ConnectionEnum;
    obj.connect = function (settings) {        
        config = settings;
        
        startConnection();
    };

    return obj;
}(jQuery));