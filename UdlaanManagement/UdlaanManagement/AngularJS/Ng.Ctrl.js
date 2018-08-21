(function () {
    'use strict';

    angular
        .module('Test')
        .controller('HomeController', HomeController);

    function HomeController($scope) {

        $scope.Testname = 'MVC Angularjs Application';
        $scope.Test = 'C# Corner';
        $scope.happy = 'Happy Coding';


    }
})();


