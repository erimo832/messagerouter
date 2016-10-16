/*
using page must have to divs with the name 'serverStatus' and 'message'

Example:
<div id="serverStatus" class="error"></div>
<div id="message"></div>
*/

//TODO: refactor connection part and subscription part


var infoMsg;
var topic = ['#'];

function startSignalrConnection(msg)
{
    var msghub = $.connection.messageRoutingBus;
    infoMsg = msg;

    $('#serverStatus').hide();

    registerForEvents(msghub);

    return msghub;
}


function registerToServer(msghub) {
    var name = getQueryParam("name");

    var topics = getQueryParam("topic");
    if (topics != null) {
        topic = topics.split(",");
    }

    if (name == null) {
        $('#message').html(infoMsg);
        return;
    }

    msghub.server.subscribe(name, topic);
}

/*******************************************
* register server events
*******************************************/
function registerForEvents(msghub) {

    msghub.client.connectionEstablished = function (message) {
        var encodedMsg = $('<div />').text(message).html();

        $('#serverStatus').text(encodedMsg);
        $('#serverStatus').show();

        //Show for only 10sec
        setTimeout(function () {
            $('#serverStatus').hide();
        }, 10000);
    };

    // Start the connection.
    $.connection.hub.start().done(function () {
        registerToServer(msghub);
    });


    $.connection.hub.disconnected(function () {
        $('#serverStatus').text("disconnected from server, lasterror: " + $.connection.hub.lastError.message);
        $('#serverStatus').show();

        //reconnect
        setTimeout(function () {
            $.connection.hub.start().done(function () {
                registerToServer(msghub);
                $('#serverStatus').hide();
            });
        }, 5000); // Restart connection after 5 seconds.

    });

    $.connection.hub.reconnecting(function () {
        $('#serverStatus').text("reconnecting to server");
        $('#serverStatus').show();
    });

    $.connection.hub.reconnected(function () {
        $('#serverStatus').text("reconnected to server");
        $('#serverStatus').show();
        registerToServer(msghub);

        //Show for only 10sec
        setTimeout(function () {
            $('#serverStatus').hide();

        }, 10000);
    });
}