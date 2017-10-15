/* requiers ref to jquery and query param */
$(document).ready(function () {

    /* Should refactor to  a init theme method? */
    var theme = getQueryParam("theme");

    if (!(theme == null || theme == "")) {
        $("head link#theme").attr("href", "/css/themes/" + theme + ".css");
    }

    var size = getQueryParam("size");

    if (!(size == null || size == "")) {
        $("body").css("font-size", size + "px");
    }       
});