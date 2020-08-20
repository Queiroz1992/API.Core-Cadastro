;(function(angular) {
    'use strict';

    angular.module('myApp.services')
        .factory('clienteService', [
            '$http',
            '$q',
            'clienteParser',
            'ModeloCliente',
            function($http, $q, clienteParser) {
                var self = this;

                self.obterTodos = function() {
                    
                    return $http.get("http://localhost:61374/cliente").then(function(result){
                        var clientes = [];
                        result.data.forEach(c => {
                             clientes.push(clienteParser.converter(c));
                         });
                         return clientes;
                    })
                };
                
                self.cadastrarCliente = function(cliente){
                    return $http.post("http://localhost:61374/cliente",cliente).then(function(result){
                        return result;
                    })     
                }

                self.atualizarCliente = function(cliente){
                    return $http.put("http://localhost:61374/cliente",cliente).then(function(result){
                         return result;
                    })     
                }

                self.excluirCliente = function(identificador){
                //     $http.defaults.headers["delete"] = {
                //         'Content-Type':'application/json,charset=utf-8'
                //    };
                    return $http.delete("http://localhost:61374/cliente/"+identificador).then(function(result){
                        return result;
                    })     
                }

                


                return self;
            }
        ]);
}(window.angular));