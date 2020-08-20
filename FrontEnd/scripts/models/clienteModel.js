;(function (angular) {
    'use strict';

    angular.module('myApp.models')
        .factory('ModeloCliente', [
                function ModeloCliente() {
                    var Modelo = function () {
                        var _modeloCliente = this;
                        _modeloCliente.identificador = undefined;
                        _modeloCliente.nome = undefined;
                        _modeloCliente.endereco = undefined;
                        _modeloCliente.telefone = undefined;
                        _modeloCliente.dataNascimento = undefined;                        
                        return _modeloCliente;
                    };

                    return Modelo;
                }
            ]
        );
}(window.angular));

