//Move 
$('#body').keyup(function (event) {
    if (event.which == 82) {
        resetView();
    }
});

//Move to 
function resetView() {
    //Clear dataset
    dataset = [];

    if (myBarChart != null) {
        myBarChart.destroy();
    }
}