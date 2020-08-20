'use strict';

angular.module('myApp', [
  'ngRoute',
  'myApp.home',
  'myApp.empresas',
  'myApp.clientes'
]).
config(['$locationProvider', '$routeProvider', function($locationProvider, $routeProvider) {
  $locationProvider.hashPrefix('!');

  $routeProvider.otherwise({redirectTo: '/home'});
}]);
angular.module('myApp.models', []);
angular.module('myApp.parsers', ['myApp.models']);
angular.module('myApp.services', ['myApp.parsers']);