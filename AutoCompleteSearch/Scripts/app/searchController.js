angular.module('SearchApp', [])
    .controller('searchController', function ($scope, $http) {

        console.log("aaa");
        $scope.testVar = "Hello world";
        console.log("bbb");

        //$http.post('/api/Search', { 'questionId': option.questionId, 'optionId': option.id })
        //    .success(function (data, status, headers, config) {
        //        $scope.correctAnswer = (data === true);
        //        $scope.working = false;
        //    }).error(function (data, status, headers, config) {
        //        $scope.title = "Oops... something went wrong";
        //        $scope.working = false;
        //    });


        //$scope.answered = false;
        //$scope.title = "loading question...";
        //$scope.options = [];
        //$scope.correctAnswer = false;
        //$scope.working = false;

        //$scope.answer = function () {
        //    return $scope.correctAnswer ? 'correct' : 'incorrect';
        //};
    });