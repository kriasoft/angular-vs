/// <reference path="Controllers.ts" />

'use strict';

declare var angular, $routeProvider;

angular.module('App', [])
    .config([<any>'$routeProvider', function($routeProvider: any) {
        $routeProvider.when('/home', {templateUrl: 'views/home.html', controller: 'HomeCtrl'});
        $routeProvider.when('/about', {templateUrl: 'views/about.html', controller: 'AboutCtrl'});
        $routeProvider.otherwise({redirectTo: '/home'});
    }]);
