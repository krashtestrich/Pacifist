var welcomeController = function ($scope, $location, welcomeService) {
    $scope.greeting = "Hola!";
    $scope.enterGame = function () {
        welcomeService.createUser().then(function (response) {
            alert("willies!");
            $location.path("/game");
        });
    };
};
//Register controller with module  
pacifist.controller("welcomeController", welcomeController);
