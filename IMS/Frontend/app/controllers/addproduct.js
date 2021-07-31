app.controller("addproduct", function ($scope, $http, ajax, $location) {
  ajax.get("https://localhost:44367/api/Category/GetAll", success, error);
  function success(response) {
    $scope.categories = response.data;
  }
  function error(error) {
    console.log(error);
  }

  function addSuccess() {
    $location.path("/products");
  }

  // $scope.addproduct = function() {
  //   var product = $scope.product;
  //   debugger;
  // }

  $scope.addproduct = function (product) {
    ajax.post(
      "https://localhost:44367/api/Product/Add",
      product,
      addSuccess,
      error
    );
  };
});
