app.controller("specificorder", function ($scope, $http, ajax, $routeParams) {
  var id = $routeParams.id;
  ajax.get("https://localhost:44367/api/order/info/" + id, success, error);
  function success(response) {
    $scope.productOrders = response.data.productorders;
    $scope.total = 0;
    $scope.productOrders.forEach((item) => {
      $scope.total += item.product_quantity * item.product_price;
    });
    $scope.order = response.data;
  }
  function error(error) {
    console.log(error);
  }

  function secondSuccess(response) {
    $scope.orderInfo = response.data;
  }

  // ajax.get(
  //   "https://localhost:44367/api/Order/Info/" + id,
  //   secondSuccess,
  //   error
  // );
});
