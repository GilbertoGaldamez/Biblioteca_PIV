app.service('editorialService', // se declara el nombre del componente del servicio
    [
            '$http', // se inyecta la funcion de angular http
            'miConfiguracion',
            function($http,miConfiguracion){
                
                function obtenerEditoriales() { // esta funcion obtendra los editoriales del bd
                    return $http.get(miConfiguracion.urlBackend+ 'Api/Editorial'); // a la funcion http se le envia la ruta con el get
                }
                function agregarEditorial(nuevaEditorial) { // funcion para agregar
                    return $http.post(miConfiguracion.urlBackend+ 'Api/Editorial', nuevaEditorial);
                }
                function editarEditorial(editorial) { // funcion para editar
                    return $http.put(miConfiguracion.urlBackend + 'Api/Editorial/' + editorial.Id, editorial);

                }
                function eliminarEditorial(editorial) { // funcion para eliminar
                    return $http.delete(miConfiguracion.urlBackend + 'Api/Editorial/' + editorial.Id);
                }

                return {
                    obtenerEditoriales: obtenerEditoriales, // este objeto enlista lo que el servicio genera
                    agregarEditorial: agregarEditorial,
                    editarEditorial: editarEditorial,
                    eliminarEditorial: eliminarEditorial
                }
            }
    ]
);