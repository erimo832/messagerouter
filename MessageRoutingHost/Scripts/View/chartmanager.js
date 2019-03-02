//chart defaults
Chart.defaults.global.legend.display = false;
Chart.defaults.global.defaultFontStyle = "bold";

; var chartManager = (function ($) {
    var obj = {};
    //private
    var ctx = null;
    var srvStatus = null;
    var myChart = null;    
    var getConfig = null;

    var dataMgr = null;
    var connectionMgr = null;
    
    /* Callbacks */
    var messageReceived = function (message, topic) {
        var dataPoint = jQuery.parseJSON(message);

        dataMgr.add(dataPoint);

        draw(getConfig());
    };
    var communicationChanged = function (status, message) {
        if (status === connectionMgr.ConnectionEnum.Connected) {
            srvStatus.text(status + ": " + message);
            srvStatus.show();

            //Show for only 10sec
            setTimeout(function () {
                srvStatus.hide();
            }, 10000);
        }
        else {
            srvStatus.text(status + ": " + message);
            srvStatus.show();
        }
        console.log(message);
    };
    var communicationError = function (message) {
        console.log(message);
    };
    
    var draw = function (config) {        
        if (ctx != null) {
            //reset chart
            if (myChart != null) {
                myChart.destroy();
            }

            myChart = new Chart(ctx, config);
        } else { console.log("chartManager must be initialized"); }
    };

    //public
    obj.init = function (chartElementName, chartContainerElementName, statusElementName, dataManager, connectionManager, settings, getConfigFunction) {
        ctx = $("#" + chartElementName);
        srvStatus = $("#" + statusElementName);
        getConfig = getConfigFunction;

        dataMgr = dataManager;
        connectionMgr = connectionManager;

        //Set size of chart
        if (settings.size.width != null && settings.size.height != null) {
            $("#" + chartContainerElementName).css("width", settings.size.width + "vw");
            $("#" + chartContainerElementName).css("height", settings.size.height + "vh");
        }

        //Register for events
        connectionManager.broker.onMessage = messageReceived;
        connectionManager.broker.onStatusChange = communicationChanged;
        connectionManager.broker.onError = communicationError;

        //init data manager
        dataManager.init(settings.dataSettings.dataMaxNumberOfDataPoints, settings.dataSettings.dataSaveWindowSeconds);

        //start connection
        connectionManager.broker.connect(settings.communication);
    };

    return obj;
}(jQuery));