angular.module('SearchApp', [])
    .controller('searchController', function ($scope, $http) {

        $scope.testVar = "Hello world";
        $scope.searchKey = "";
        $scope.topRepoList = [];

        $scope.SearchGithub = () => {
            console.log($scope.searchKey);

            $http({
                url: "/api/Search/SearchGithubRepos",
                method: "POST",
                data: { 'searchKey': $scope.searchKey }
            }).then(function successCallback(response) {
                // this callback will be called asynchronously
                // when the response is available
                $scope.topRepoList = response.data;
                $scope.hideAutocomplete = false;
            }, function errorCallback(response) {
                // called asynchronously if an error occurs
                // or server returns response with an error status.
                $scope.error = response.statusText;
            });
        }

        $scope.FillTextBox = (chosenRepo) => {
            console.log("111 " + chosenRepo);
            $scope.searchKey = chosenRepo;
            $scope.hideAutocomplete = true;
        }

    });