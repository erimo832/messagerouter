/*var dataManager = (function (parent, $) {
    var my = parent.ajax = parent.ajax || {};

    my.get = function (url, params, callback) {
        // ok, so I'm cheating a bit :)
        return $.getJSON(url, params, callback);
    };

    // etc...   

    return parent;
}(dataManager || {}, jQuery));*/

var datapointManager = (function ($) { //moment
    var obj = {};
    //private
    var dataset = [];
    var maxdataPoints = 10;
    var saveWindowSec = 36000; //10h

    function clearOldData() {
        var latest = dataset[dataset.length - 1];

        while (dataset.length > maxdataPoints) {
            dataset.shift();
        }
         
        //maybe change from now to latest value                
        while (dataset.length > 0) {
            if (moment.duration(moment(latest.Timestamp).diff(moment(dataset[0].Timestamp))).asSeconds() > saveWindowSec) {
                dataset.shift();
                i++;
            } else { break; }            
        }
    }
    
    //public functions
    obj.init = function (maxNumberOfDataPoints, saveWindowSeconds) {
        maxdataPoints = maxNumberOfDataPoints;
        saveWindowSec = saveWindowSeconds;
    };
    obj.add = function (dataPoint) {
        dataset.push(dataPoint);
        clearOldData();
    };
    obj.getTimestampArray = function () { return dataset.map(function (item) { return new Date(item.Timestamp); }) };
    obj.getValueArray = function () { return dataset.map(function (item) { return item.Value; }) };

    return obj;
}(jQuery));