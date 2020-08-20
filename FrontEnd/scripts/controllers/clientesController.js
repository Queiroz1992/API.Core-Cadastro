;(function(ng) {
    'use strict';
  
    angular.module('myApp.clientes', ['ngRoute', 'myApp.services'])
    .config(['$routeProvider', function($routeProvider) {
      $routeProvider.when('/clientes', {
        templateUrl: 'views/clientes.html',
        controller: 'ClientesController',
        controllerAs: 'clientesController'
      });
    }])
    .controller('ClientesController', [
      'clienteService',
      'ModeloCliente',
       function ClientesControllerFn(clienteService, ModeloCliente) {
          let self = this;
          
          self.clientes = [];

          
          self.cliente = new ModeloCliente();
  
          self.obterTodos = function() {
  
            clienteService.obterTodos().then( data => {
              console.log(data);
              self.clientes = data;
            })
          }

          self.novo = function() {  
            self.cliente = new ModeloCliente();
          }

          self.cadastrarCliente = function() {   
              debugger   
              var cliente = self.cliente;            //modeloCliente.identificador = clienteContrato.identificador;
                clienteService.cadastrarCliente(cliente).then( data => {
                  self.obterTodos();
                  return self;
                })
          }

          self.atualizarCliente = function() {   
            var cliente = self.cliente;            //modeloCliente.identificador = clienteContrato.identificador;
            clienteService.atualizarCliente(cliente).then( data => {
              self.obterTodos();
              return self;
            })
            
          }

          self.excluirCliente = function() {   
            clienteService.excluirCliente(self.cliente.identificador).then( data => {
              self.obterTodos();
              return self;
            })
            
          }

          self.selecionaCliente = function(cliente) {
              cliente.dataNascimento = new Date(cliente.dataNascimento + 'Z');
              self.cliente = cliente;
              console.log(self.cliente);
          }

          self.transformaDatacliente = function(savedDate){
            
           let dateSplit = savedDate.split('-');
           return dateSplit[2].substr(0,2) +'/' + ('0'+ (dateSplit[1])).slice(-2) + '/' + dateSplit[0];
          }
          
          self.obterTodos();
  
          return self;
        }
      ]);
  }(window.angular));