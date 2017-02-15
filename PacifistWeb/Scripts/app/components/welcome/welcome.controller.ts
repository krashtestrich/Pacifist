var welcomeController = ($scope, $location, welcomeService) => {
    $scope.greeting = "Hola!";
    $scope.enterGame = () => {
        welcomeService.createUser();
        $location.path("/game");
    }
};

//Register controller with module  
pacifist.controller("welcomeController", welcomeController);  