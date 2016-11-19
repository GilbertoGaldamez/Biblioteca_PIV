app.controller(
    'homeController',
    [
        '$scope',
        function ($scope) {           //esta funcion es el controlador. aqui va todo lo que quiero que haga
            $scope.saludo = "hola mundo con angular y el controlador";
        }
    ]

    );