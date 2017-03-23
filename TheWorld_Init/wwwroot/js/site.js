//site.js
(function () {


    var e = $("#username");
    e.text("New jQuery");
    
    var main = $("#TopSide");

    main.on("mouseenter",
        function () {
            main.style = "background-color: #888;";
        });

    main.on("mouseleave",
        function () {
            main.style = "";
        });

    
    var sidebarAndWrapper = $("#sidebar,#wrapper");
    $("#sidebarToggleButton").on("click",
        function () {
            sidebarAndWrapper.toggleClass("hide-sidebar");
            if (sidebarAndWrapper.hasClass("hide-sidebar")) {
                $(this).text("Show Sidebar");
                console.log("Show Sidebar");
            } else {
                $(this).text("Hide Sidebar");
                console.log("Hide Sidebar");
            }
        });
})();