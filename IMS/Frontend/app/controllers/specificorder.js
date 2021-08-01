app.controller("specificorder", function ($scope, $http, ajax, $routeParams) {
  var id = $routeParams.id;
  ajax.get("https://localhost:44367/api/order/"+id, success, error);
  function success(response) {
    $scope.productOrders = response.data;
    $scope.total = 0;
    $scope.productOrders.forEach(item => {
      $scope.total += item.product_quantity * item.product_price;
    });
  }
  function error(error) {}
});
