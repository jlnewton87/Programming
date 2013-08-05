//Create main tabs for UI
$(function () {
    var tabs = $("#main-content").tabs();
    $("#btnLogin")
        .button()
        .click(function(event){
            WL.login();
            event.preventDefault();
        });

    $("#btnAddTab")
        .button()
        .click(function (event) {
            addSnipTab();
            event.preventDefault();
        });


    function addSnipTab() {
        var ul = tabs.find("ul");
        $("<li><a href='#snipTab'>Snippet Keeper</a></li>").appendTo(ul);
        $("<div id='snipTab'><p>New Content</p></div>").appendTo(tabs);
        tabs.tabs("refresh");
    }

    WL.Event.subscribe("auth.login", onLogin);


    WL.init({
        client_id: APP_CLIENT_ID,
        redirect_uri: REDIRECT_URL,
        scope: "wl.signin",
        response_type: "token"
    });


    function onLogin(session) {
        if (!session.error) {
            WL.api({
                path: "me",
                method: "GET"
            }).then(
                function (response) {
                    alert(response.first_name);
                },
                function (responseFailed) {
                    alert("Error calling API: " + responseFailed.error.message);
                }
            );
        }
        else {
            alert("Error signing in: " + session.error_description);
        }
    }


});

