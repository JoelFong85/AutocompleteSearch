angular.module('SearchApp', [])
    .controller('searchController', function ($scope, $http) {

        $scope.searchKey = "";
        $scope.topRepoList = [];
        $scope.errorMsg = "";
        $scope.showErrorMsg = false;

        $scope.SearchGithub = () => {

            if (event.keyCode === 37 || event.keyCode === 38 || event.keyCode === 39 || event.keyCode === 40) {
                return;
            }

            $http({
                url: "/api/Search/SearchGithubRepos",
                method: "POST",
                data: { 'searchKey': $scope.searchKey }
            }).then(function successCallback(response) {

                $scope.topRepoList = response.data;

                if ($scope.topRepoList && $scope.topRepoList.length) {
                    $scope.hideAutocomplete = false;
                    $scope.showErrorMsg = false;
                }
                else {
                    $scope.hideAutocomplete = true;
                    $scope.showErrorMsg = true;
                    $scope.errorMsg = "No repos found";
                }

            }, function errorCallback(response) {

                $scope.errorMsg = response.data['ExceptionMessage'];
                $scope.showErrorMsg = true;

            });
        }

        $scope.FillTextBox = (chosenRepo) => {
            $scope.searchKey = chosenRepo;
            $scope.hideAutocomplete = true;
        }

    });