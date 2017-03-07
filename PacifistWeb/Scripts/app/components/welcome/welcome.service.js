pacifist.service("welcomeService", function ($http) {
    this.createUser = function () {
        var promise = $http.post("Welcome/CreateUser").then(function (response) {
            // The then function here is an opportunity to modify the response
            console.log(response);
            // The return value gets picked up by the then in the controller.
            return response.data;
        });
        // Return the promise to the controller
        return promise;
    };
});
