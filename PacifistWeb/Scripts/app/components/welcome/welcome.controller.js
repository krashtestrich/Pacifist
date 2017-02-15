var welcomeController = function ($scope, $location, welcomeService) {
    $scope.greeting = "Hola!";
    $scope.enterGame = function () {
        welcomeService.createUser();
        $location.path("/game");
    };
};
//Register controller with module  
pacifist.controller("welcomeController", welcomeController);
