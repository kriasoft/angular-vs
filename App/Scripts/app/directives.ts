/// 
/// Directives
/// -------------------------------------------------------------------------------------------------------------------
/// <reference path="_references.ts" />

angular.module('app.directives', [])
    .directive('appVersion', [<any> 'version', function (version) {
        return function (scope, elm, attrs) {
            elm.text(version);
        };
    }]);