

var myApp = angular.module('myModule', []);

myApp.controller("myController", myController);


myApp.service('validatorService', validatorService);


myApp.directive('teduShopDirective', teduShopDirective);



myController.$inject = ['$scope', 'validatorService'];

function myController($scope, validatorService) {
    $scope.num = 1;
    $scope.checkNumber = function() {
        $scope.abc = validatorService.checkNumber($scope.num);
    }
}


function validatorService()
{
    return {
        checkNumber: checkNumber
    }

    function checkNumber(input) {
        if (input % 2 == 0) {
           return 'This is event';
        } else {
            return 'This is old';
        }

        
    }
}

function teduShopDirective() {
    return {
        restrict: "A",
        template : "<h1>Đẹp trai có gì sai </h1>"
    }
    
}
