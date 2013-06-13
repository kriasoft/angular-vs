/// 
/// Filters
/// -------------------------------------------------------------------------------------------------------------------
/// <reference path="_references.ts" />

angular.module('app.filters', [])
    .filter('interpolate', [<any> 'version', function (version) {
        return function (text) {
            return String(text).replace(/\%VERSION\%/mg, version);
        }
    }]);