angular.module('app', [
    'app.filters', 
    'app.services', 
    'app.directives', 
    'app.controllers'
]).config([
    '$locationProvider', 
    '$routeProvider', 
    function ($locationProvider, $routeProvider) {
        $locationProvider.html5Mode(true);
        $routeProvider.when('/view1', {
            templateUrl: 'views/view1',
            controller: 'FirstCtrl'
        }).when('/view2', {
            templateUrl: 'views/view2',
            controller: 'SecondCtrl'
        }).otherwise({
            redirectTo: '/view1'
        });
    }]);
