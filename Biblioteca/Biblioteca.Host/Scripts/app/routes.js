app.config(['$routeProvider',
 function ($routeprovider) {
     $routeprovider
       .when('/', {
           templateUrl: "/Scripts/app/home/home.template.html",
           controller:"homeController"
       })
     .otherwise({
         redirecTo:'/'
     })
 }]);