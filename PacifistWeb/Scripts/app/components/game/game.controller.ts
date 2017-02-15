var gameController = $scope => {
    $scope.greeting = "Hola!";
};


//Register controller with module  
pacifist.controller("gameController", gameController);  