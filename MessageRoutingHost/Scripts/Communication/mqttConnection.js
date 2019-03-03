var mqttConnection = (function ($) {
    var obj = {};
    var topic = []; //['#'];
    var config;
    var client;
    var isConnected = false;
    
    var connectSuccess = function () {
        isConnected = true;
        if (typeof obj.onStatusChange === "function") {
            obj.onStatusChange(obj.ConnectionEnum.Connected, "Connected to " + config.brokerurl);
        }

        for (var i = 0; i < topic.length; i++) {
            client.subscribe(topic[i], { qos: 0 });
        }
    };

    var errorConnectionLost = function (message) {
        isConnected = false;

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
        }, 5000);
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
                var msg = parsePayload(message.payloadString);
                obj.onMessage(msg, message.destinationName);
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
    obj.addSubscriptions = function (topics) {
        topic = topics.split(",");
    };
    obj.publish = function (message, topic) {
        if (isConnected) {
            var msg = new Messaging.Message(message);
            msg.destinationName = topic;
            msg.qos = 1; // 0=At most once,1=At least once, 2=Exactly once
            client.send(msg);
        } else {
            if (typeof obj.onError === "function") {
                obj.onError("Not connected so unable to publish");
            }
        }
    };

    return obj;
}(jQuery));