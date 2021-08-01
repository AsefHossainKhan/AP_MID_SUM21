app.controller("placeorder", function ($scope, $http, ajax, $location) {
  ajax.get("https://localhost:44367/api/product/allproducts", success, error);
  function success(response) {
    $scope.products = response.data;
  }
  function error(error) {
    console.log(error);
  }
  function addSuccess() {
    $location.path("/orders");
  }
  $scope.cart = []

  $scope.placeorder = function() {
    $scope.products.forEach(element => {
      if(element.count>0){
        var productOrder = {
          product_id: element.id,
          product_price: element.price,
          product_quantity: element.count
        }
        $scope.cart.push(productOrder);
      }
    });
    console.log($scope.cart);
    ajax.post(
      "https://localhost:44367/api/Order/Place",
      $scope.cart,
      addSuccess,
      error
    );
    $scope.cart = []
  }
});
