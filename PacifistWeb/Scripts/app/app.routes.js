pacifist.config(function ($routeProvider, $locationProvider) {
    $routeProvider
        .when("/", {
        templateUrl: Controller.variables.componentPath + "/welcome/welcome.html",
        controller: "welcomeController"
    })
        .when("/game", {
        templateUrl: Controller.variables.componentPath + "/game/game.html",
        controller: "gameController"
    });
    $locationProvider.html5Mode(true);
});
