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
    .when("/categories", {
        templateUrl : "views/pages/categories.html",
        controller: 'category'
    })
    .when("/addcategory", {
        templateUrl : "views/pages/addcategory.html",
        controller: 'addcategory'
    })
    .when("/placeorder", {
        templateUrl : "views/pages/placeorder.html",
        controller: 'placeorder'
    })
    .when("/orders", {
        templateUrl : "views/pages/orders.html",
        controller: 'order'
    })
    .when("/orders/:id", {
        templateUrl : "views/pages/specificorder.html",
        controller: 'specificorder'
    })
    .otherwise({
        redirectTo:"/"
    });

}]);
