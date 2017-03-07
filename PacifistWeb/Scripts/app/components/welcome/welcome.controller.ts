var welcomeController = ($scope, $location, welcomeService) => {
    $scope.greeting = "Hola!";
    $scope.enterGame = () => {
        welcomeService.createUser().then(response => {
            alert("willies!");
            $location.path("/game");
        });
    }
};

//Register controller with module  
pacifist.controller("welcomeController", welcomeController);  