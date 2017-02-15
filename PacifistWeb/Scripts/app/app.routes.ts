pacifist.config(($routeProvider, $locationProvider) => {
    $routeProvider

        // route for the home page
        .when("/", {
            templateUrl: Controller.variables.componentPath + "/welcome/welcome.html",
            controller: "welcomeController"
        })

        // route for the about page
        .when("/game", {
            templateUrl: Controller.variables.componentPath + "/game/game.html",
            controller: "gameController"
        });

    $locationProvider.html5Mode(true);
});