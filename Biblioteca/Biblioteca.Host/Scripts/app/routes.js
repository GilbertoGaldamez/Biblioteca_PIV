// aqui se configuran las rutas
//api.config carga todos los modulos
app.config(['$routeProvider',
    function ($routerProvider) {
        $routerProvider
        .when('/', {   // cuando la ruta cumpla el homee que imprima lo siguiente linea
            templateUrl: "/Scripts/app/home/home.template.html",
            controller: "homeController" // este controlador se asocia a la vista de arriba
        })
            .when('/editoriales', {
                templateUrl: "/Scripts/app/editorial/editorial.template.html",
                controller: "editorialController"
            })
        .otherwise({ // si no encuentra la ruta adecuada que regrese al home
            reditecTo: '/'
        })
    }


]);