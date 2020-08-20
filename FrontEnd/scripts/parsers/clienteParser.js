;(function(angular) {
    'use strict';

    angular.module('myApp.parsers')
        .factory('clienteParser', [
                'ModeloCliente',
                function ClienteParser(ModeloCliente) {
                    var self = this;

                    self.converter = function (clienteContrato) {
                        var modeloCliente = new ModeloCliente();
                        modeloCliente.identificador = clienteContrato.identificador;
                        modeloCliente.nome = clienteContrato.nome;
                        modeloCliente.endereco = clienteContrato.endereco;
                        modeloCliente.telefone = clienteContrato.telefone;
                        modeloCliente.dataNascimento = clienteContrato.dataNascimento;

                        return modeloCliente;
                    };

                    return self;
                }
            ] 
        );
}(window.angular));