/*******************************************
* functions
*******************************************/

//Gets value from a key in the querystring
function getQueryParam(paramName, defaultValue) {
    //Remove first ? character
    var query = location.search.substring(1);

    if (query.length > 0) {
        //Display date time
        query = query.split("%20").join(" ");
        query = query.split("%23").join("#");
        query = query.split("%27").join("'");
        

        var params = query.split("&");

        //style, format, offset
        for (i = 0; i < params.length; i++) {

            var keyVal = params[i].split("=");
            if (keyVal[0] == paramName) {
                return keyVal[1];
            }
        }
    }

    if (typeof defaultValue != 'undefined')
        return defaultValue;

    return null;
}

//Gets value from a css class and property
//ex: var color = getStyleRuleValue('color', '.chart-color');
function getStyleRuleValue(style, selector) {
    for (var i = 0; i < document.styleSheets.length; i++) {
        var mysheet = document.styleSheets[i];
        var myrules = mysheet.cssRules ? mysheet.cssRules : mysheet.rules;
        for (var j = 0; j < myrules.length; j++) {
            if (myrules[j].selectorText && myrules[j].selectorText.toLowerCase() === selector) {
                return myrules[j].style[style];
            }
        }

    }
};