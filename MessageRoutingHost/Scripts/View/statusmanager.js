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
        
    obj.orderedList = function () {
        if (dataset.length <= 1)
            return dataset;
        
        return dataset.sort(function (a, b) {
            // ignore upper and lowercase
            var nameA = a[cmpName].toUpperCase();
            var nameB = b[cmpName].toUpperCase();
            if (nameA < nameB) {
                return -1;
            }
            if (nameA > nameB) {
                return 1;
            }

            // names must be equal
            return 0;
        });
    }
    
    return obj;
}(jQuery));