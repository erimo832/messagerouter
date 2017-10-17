var communicationFactory = (function ($) {
    var obj = {};
    
    //public
    obj.init = function (protocol) {
        if (protocol == "signalr") {
            obj.broker = signalrConnection;
        } else if (protocol == "mqtt") {
            obj.broker = mqttConnection;
        }
        else {
            console.log("Invalid communication protocol");
        }

        return obj;
    };

    return obj;
}(jQuery));