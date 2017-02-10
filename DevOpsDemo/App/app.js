(function () {
    'use strict';

    angular.module('devopdemo', [
        // Angular modules
        'ngAnimate',
        'ngRoute'

        // Custom modules

        // 3rd Party Modules
        
    ])
    .controller('tempController', ['$http', '$scope', function ($http, $scope) {
        $scope.f2c = {};

        $scope.convertf2c = function () {
            console.log("fval=", $scope.f2c.fval);
            $http.get('/api/f2c/' + $scope.f2c.fval)
            .success(function (response) {
                console.log("response", response);
                $scope.f2c.cval = response.ConvertedValue;
            })
        };

        $scope.c2f = {};
        $scope.convertc2f = function () {
            console.log("cval=", $scope.c2f.cval);
            $http.get('/api/c2f/' + $scope.c2f.cval)
            .success(function (response) {
                console.log("response", response);
                $scope.c2f.fval = response.ConvertedValue;
            })
        };

    }])
    ;
})();
