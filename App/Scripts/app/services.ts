/// 
/// Services
/// -------------------------------------------------------------------------------------------------------------------
/// <reference path="_references.ts" />

// Demonstrate how to register services. In this case it is a simple value service.
angular.module('app.services', [])
    .value('version', '0.1');