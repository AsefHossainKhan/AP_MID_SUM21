app.controller("order", function ($scope, $http, ajax) {
  ajax.get("https://localhost:44367/api/order/getall", success, error);
  function success(response) {
    $scope.orders = response.data;
    $scope.orders.forEach(element => {
      var v = new Date(element.created_at);
      element.orderDate = v.toDateString();
      element.orderTime = v.toLocaleTimeString().substr(0,10);
    });
  }
  function error(error) {
    console.log(error);
  }
});
