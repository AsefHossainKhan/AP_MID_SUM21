app.controller("addcategory", function ($scope, $http, ajax, $location) {
  function error(error) {
    console.log(error);
  }

  function addSuccess() {
    $location.path("/categories");
  }

  $scope.addcategory = function (category) {
    ajax.post(
      "https://localhost:44367/api/Category/Add",
      category,
      addSuccess,
      error
    );
  };
});
