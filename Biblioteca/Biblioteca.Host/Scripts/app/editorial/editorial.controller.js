app.controller('editorialController', [
    '$scope',
    'editorialService', // angular inyecta el servicio al controlador
    function ($scope, editorialService) {
        $scope.editoriales = [];

        $scope.editorialActual = {

            Id: '0',
            Nombre: ''

        };
        // .then tiene 2 funciones: La primera cuando reponde OK, y la segunda cuando responde ERROR
        $scope.accionActual = 'Agregar';
        $scope.obtenerEditoriales = function () {
            editorialService.obtenerEditoriales()
            .then(function (response) {
                $scope.editoriales = response.data;
            });
        }
        $scope.salvarEditorial = function () {
            if ($scope.accionActual === 'Agregar') {
                editorialService.agregarEditorial($scope.editorialActual)
                .then(function (response) {
                    $scope.obtenerEditoriales();
                    $scope.limpiar();
                    alert('Editorial Agregada');
                });
            }
            else if ($scope.accionActual === 'Editar') {
                editorialService.editarEditorial($scope.editorialActual)
               .then(function (response) {
                   $scope.obtenerEditoriales();
                   $scope.limpiar();
                   alert('Editorial Editada');
               });
            }
            else if ($scope.accionActual === 'Eliminar') {
                editorialService.eliminarEditorial($scope.editorialActual)
               .then(function (response) {
                   $scope.obtenerEditoriales();
                   $scope.limpiar();
                   alert('Editorial Eliminada');
               }, function(error) {
                   alert('Error eliminando editorial');
               });

            }
        }

            $scope.limpiar = function () {
                $scope.accionActual = 'Agregar';
                $scope.editorialActual = {
                    Id: '0',
                    Nombre: ''

                }
            }

            $scope.editar = function (editorial) {
                $scope.accionActual = 'Editar';
                $scope.editorialActual = JSON.parse(JSON.stringify(editorial));
            }

            $scope.eliminar = function (editorial) {
                $scope.accionActual = 'Eliminar';
                $scope.editorialActual = JSON.parse(JSON.stringify(editorial));
            }

        
        $scope.obtenerEditoriales();
    }
    ]
);