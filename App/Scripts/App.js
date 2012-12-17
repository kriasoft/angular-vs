'use strict';
angular.module('App', []).config([
    '$routeProvider', 
    function ($routeProvider) {
        $routeProvider.when('/home', {
            templateUrl: 'views/home.html',
            controller: 'HomeCtrl'
        });
        $routeProvider.when('/about', {
            templateUrl: 'views/about.html',
            controller: 'AboutCtrl'
        });
        $routeProvider.otherwise({
            redirectTo: '/home'
        });
    }]);
