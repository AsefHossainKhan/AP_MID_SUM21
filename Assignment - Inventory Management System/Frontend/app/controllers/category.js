app.controller("category", function ($scope, $http, ajax) {
  ajax.get("https://localhost:44367/api/Category/GetAll", success, error);
  function success(response) {
    $scope.categories = response.data;
  }
  function error(error) {}
});
