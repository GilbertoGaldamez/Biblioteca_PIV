// Tarea 6
// Gilberto Galdamez | 61411121

app.config(['$routeProvider',
    function ($routerProvider) {
        $routerProvider
        .when('/', {
            templateUrl: "/Scripts/app/home/home.template.html",
            controller: "homeController" 
        })
            .when('/editoriales', {
                templateUrl: "/Scripts/app/editorial/editorial.template.html",
                controller: "editorialController"
            })
            .when('/libros', {      // Agregada la ruta de libros
                templateUrl: "/Scripts/app/libro/libro.template.html",
                controller: "libroController"
            })
        .otherwise({ 
            reditecTo: '/'
        })
    }


]);