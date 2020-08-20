;(function(angular) {
    'use strict';

    angular.module('myApp.services')
        .factory('empresaService', [
            '$http',
            '$q',
            'empresaParser',
            function($http, $q, empresaParser) {
                var self = this;

                self.obterTodos = function() {
                    return $http.get("http://localhost:61374/empresas").then(function(result){
                        var empresas = [];
                        result.data.forEach(e => {
                             empresas.push(empresaParser.converter(e));
                         });
                         console.log(empresas);
                         return empresas;
                    })
                };

                return self;
            }
        ]);
}(window.angular));
