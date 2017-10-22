var communicationFactory = (function ($) {
    var obj = {};
    
    //public
    obj.init = function (protocol) {
        if (protocol == "signalr") {
            signalrConnection.ConnectionEnum = obj.ConnectionEnum;
            obj.broker = signalrConnection;
        } else if (protocol == "mqtt") {
            mqttConnection.ConnectionEnum = obj.ConnectionEnum;
            obj.broker = mqttConnection;
        }
        else {
            console.log("Invalid communication protocol");
        }

        return obj;
    };
    obj.ConnectionEnum = {
        Connected: "Connected",
        Reconnecting: "Reconnecting",
        Disconnected: "Disconnected",
    };

    return obj;
}(jQuery));