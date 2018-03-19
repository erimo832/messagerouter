; var statusManager = (function ($) { //moment
    var obj = {};
    //private
    var dataset = [];
    var cmpName = "name"; //default value

    //public functions
    obj.init = function (compareColumn) {
        cmpName = compareColumn;
    };
    obj.add = function (status) {
        //Add so we don't need to know the key column name
        var found = false;

        for (var i = 0; i < dataset.length; i++) {
            if (dataset[i][cmpName] === status[cmpName]) {
                found = true;
                dataset[i] = status;
                break;
            }
        }

        //new object
        if(!found)
            dataset.push(status);
    };

    //bug sort don't works
    obj.orderedList = function () { return dataset.sort(function (a, b) { return (a[cmpName].toLowerCase() > b[cmpName].toLowerCase() ? 1 : 0) }); }
    
    return obj;
}(jQuery));