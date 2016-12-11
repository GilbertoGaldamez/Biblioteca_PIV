// configuracion para angular para la aplicacion
// se crea un modulo al cual se le asigna un nombre junto con un arreglo
// ngRoute sirve para enrutar las clases sin afectar las mismas
var app = angular.module('BibliotecaPIVApp', ['ngRoute', 'ngMessages']);

app.constant('miConfiguracion',
    {
        // constant es una funcion en angular para predeterminar la direccion del server o del local host al cual
        // se enlaza y recibe las llamadas
        "urlBackend": "http://localhost:50295/"
    }
    
    );