//site.js
(function () {


    var e = $("#username");
    e.text("New jQuery");

    var main1 = $("#main");

    main1.on("mouseenter",
        function () {
            main1.style.backgroundColor = "#222";
        });

    main1.on("mouseleave",
        function () {
            main1.style.backgroundColor = "";
        });


    var $sidebarAndWrapper = $("#sidebar,#wrapper");
    $("#sidebarToggleButtonButton").on("click",
        function () {
            $sidebarAndWrapper.toggleClass("hide-sidebar");
            if ($sidebarAndWrapper.hasClass("hide-sidebar")) {
                $(this).text("Show Sidebar");
            } else {
                $(this).text("Hide Sidebar");

            }
        });


})();