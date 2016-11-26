app.controller(
    'homeController', // nombre del controler debe ser unico
    [
        '$scope', //le da acceso al controlador lo que tiene acceso o no
        function ($scope) {
            $scope.saludo = "Hola mundo con angular y controlador"; // el saludo se crea como un miembro

        }
    ]
    

    );