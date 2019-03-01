/* TODO: IMPLEMENT */

var mqttConnection = (function ($) {
    var obj = {};
    //private

    //public
    obj.onMessage;
    obj.onStatusChange;
    obj.onError;
    obj.ConnectionEnum;    
    obj.connect = function () {
    };
    obj.ping = function () {
        if (typeof obj.onStatusChange === "function") {
            obj.onStatusChange("pong");
        }
    }


    return obj;
}(jQuery));
