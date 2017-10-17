; var chartManager = (function ($) {
    var obj = {};
    var ctx = null;
    var myChart = null;
    //private

    //public
    obj.init = function (elementName) {
        ctx = $("#" + elementName);
    };
    obj.draw = function (config) {
        if (ctx != null) {
            //reset chart
            if (myChart != null) {
                myChart.destroy();
            }

            myChart = new Chart(ctx, config);
        } else { console.log("chartManager must be initialized"); }
    };

    return obj;
}(jQuery));