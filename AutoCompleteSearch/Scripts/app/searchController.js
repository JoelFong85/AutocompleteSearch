angular.module('SearchApp', [])
    .controller('searchController', function ($scope, $http) {

        $scope.searchKey = "";
        $scope.topRepoList = [];

        $scope.SearchGithub = () => {

            $http({
                url: "/api/Search/SearchGithubRepos",
                method: "POST",
                data: { 'searchKey': $scope.searchKey }
            }).then(function successCallback(response) {

                $scope.topRepoList = response.data;
                $scope.hideAutocomplete = false;

            }, function errorCallback(response) {

                //what to do if there's an error
                $scope.error = response.statusText;

            });

        }

        $scope.FillTextBox = (chosenRepo) => {
            $scope.searchKey = chosenRepo;
            $scope.hideAutocomplete = true;
        }

    });