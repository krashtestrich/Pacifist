var Controller;
(function (Controller) {
    var Variables = (function () {
        function Variables() {
            this.componentPath = "Scripts/app/components";
        }
        return Variables;
    }());
    Controller.variables = new Variables();
})(Controller || (Controller = {}));
