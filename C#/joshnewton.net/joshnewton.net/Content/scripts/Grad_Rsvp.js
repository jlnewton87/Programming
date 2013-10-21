var comingDiv;
var notComingDiv;
$(document).ready(function () {
    comingDiv = document.getElementById("yay");
    notComingDiv = document.getElementById("nay");

    $("#coming").click(function() {
        $(comingDiv).dialog({
            modal: true,
            width:"600px",
            title: "RSVP",
            buttons: {
                "Submit": function () {
                    $("button").attr('disabled','disabled');
                    var data = {
                        NumInParty: $("#numInParty").val(),
                        Message: $("#messageToGradComing").val(),
                        AttendeeId: $("#attendeeId").val(),
                        willCome:true
                    };
                    $.ajax({
                        complete: function () {
                            $("button").removeAttr('disabled');
                        },
                        url: $("#postURL").val(),
                        data: data,
                        method: "POST"
                    }).done(function(){
                        window.location.href = $("#redirectUrl").val();
                    });
                },
                Cancel: function () {
                    $(this).dialog("close");
                }
            }
        });
    });

    $("#notComing").click(function() {
        $(notComingDiv).dialog({
            modal: true,
            width: "600px",
            title: "RSVP",
            buttons: {
                "Submit": function () {
                    $("button").attr('disabled', 'disabled');
                    var data = {
                        NumInParty: 0,
                        Message: $("#messageToGradNotComing").val(),
                        AttendeeId: $("#attendeeId").val(),
                        willCome: false
                    };
                    $.ajax({
                        complete: function () {
                            $("button").removeAttr('disabled');
                        },
                        url: $("#postURL").val(),
                        data: data,
                        method: "POST"
                    }).done(function () {
                        window.location.href = $("#redirectUrl").val();
                    });
                },
                Cancel: function () {
                    $(this).dialog("close");
                }
            }
        });
    });

    }
);