//var homeModule = angular.module("homeModule", []);
'use strict'

// Declare app level module which depends on filters, and services
var homeController = angular.module('homeController', ['homeController.controllers', function () {
}])
//Configure the routes
.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when('', {
        templateUrl: '/home/Events',
        controller: 'homeController'
    });
    $routeProvider.when('/binding', {
        templateUrl: '/home/bindingexample',
        controller: 'BindingController'
    });
    $routeProvider.when('/sms', {
        templateUrl: '/app/partials/smsview.html',
        controller: 'SmsController'
    });

    $routeProvider.when('/help', {
        templateUrl: '/app/partials/help.html',
        controller: 'HelpController'
    });

    $routeProvider.otherwise({ redirectTo: '/sms' });
}]);