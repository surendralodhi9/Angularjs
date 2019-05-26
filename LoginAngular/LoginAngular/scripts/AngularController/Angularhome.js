var app = angular.module('homeapp', []);

app.controller("HomeController", function ($scope, $http) {


    $scope.btntext = "Login";
    $scope.login = function () {

        $scope.btn = "Please wait...";
        $http({

            method: "POST",
            url: '/Home/Userlogin',
            data: $scope.username


        }).success(function (d) {

            $scope.btntext = 'Login';
            if (d == 1) {
                window.location.href = '/Home/dashboard';

            }
            else {

                alert(d);
            }
            $scope.username = null;

        }).error(function () {

            alert('faild');
        })
    }

})