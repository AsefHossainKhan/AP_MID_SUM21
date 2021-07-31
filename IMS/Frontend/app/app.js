var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/homepage.html",
        controller: 'home'
    })
    .when("/products", {
        templateUrl : "views/pages/products.html",
        controller: 'products'
    })
    .when("/addproduct", {
        templateUrl : "views/pages/addproduct.html",
        controller: 'addproduct'
    })
    .otherwise({
        redirectTo:"/"
    });

}]);
