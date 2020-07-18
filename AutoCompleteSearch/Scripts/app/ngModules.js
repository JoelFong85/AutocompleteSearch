angular.module('SearchApp')
    .directive('disableArrows', function () {

        function disableArrows(event) {
            if (event.keyCode === 37 || event.keyCode === 38 || event.keyCode === 39 || event.keyCode === 40) {
                event.preventDefault();
            }
        }

        return {
            link: function (scope, element, attrs) {
                element.on('keyup', disableArrows);
            }
        };
    });