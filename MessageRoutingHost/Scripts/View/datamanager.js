; var datapointManager = (function ($) { //moment
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

    obj.getTimestampArray = function () { return dataset.map(item => { return new Date(item.Timestamp); }) }; //item => (ECMA script 6), function (item) (ECMA script 5)
    obj.getValueArray = function () { return dataset.map(item => { return item.Value; }) };       

    return obj;
}(jQuery));