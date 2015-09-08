var data = {
    games: [
        {
            name: 'Counter Strike: Gobal Offensive',
            id: 730
        },
        {
            name: 'Another test game',
            id: 12
        }
    ],
    weapons: ['ak47','m4a1','awp','hkp2000','p250','deagle','p90','fiveseven','glock','negev','famas','ssg08','tec9','galilar','bizon','aug','sawedoff','hegrenade','elite','mp7','mag7','ump45','nova','xm1014','knife','sg556','mp9','mac10','m249','scar20','g3sg1','molotov','taser']
};

var steamApp = angular.module('steamApp', ['ngRoute', 'angular-loading-bar']);

steamApp.config(['$routeProvider', 'cfpLoadingBarProvider', function($routeProvider, cfpLoadingBarProvider) {
    cfpLoadingBarProvider.includeSpinner = false;

    $routeProvider
        .when('/player', {
            templateUrl: 'partials/player.html',
            controller: 'PlayerController'
        })
        .when('/player/:steamId', {
            templateUrl: 'partials/player.html',
            controller: 'PlayerController'
        })
        .when('/another', {
            templateUrl: 'partials/another.html',
            controller: 'AnotherController'
        })
        .otherwise({
            redirectTo: 'player'
        });
}]);

steamApp.controller('PlayerController',
    ['$scope', '$routeParams', 'playerService',
    function ($scope, $routeParams, playerService) {

        $scope.submitHandler = function(steamId) {
            location.href = '/#/player/' + steamId;
        };

        $scope.getStats = function(steamId) {
            playerService.getCsgoStats(steamId, function(data) {
                $scope.playerStats = data;
            });
        };

        $scope.getOrder = function() {
            return $scope.statOrder + $scope.statOrderProperty;
        };

        $scope.getFilter = function() {
            var separator = ($scope.statFilter.length !== 0 && $scope.statWeaponFilter.length !== 0) ? '_' : '',
                filter = $scope.statFilter + separator + $scope.statWeaponFilter;

            return filter;
        }

        $scope.weapons = data.weapons;
        $scope.statFilter = '';
        $scope.statWeaponFilter = '';
        $scope.statOrderProperty = 'name';
        $scope.statOrder = '';

        if($routeParams.steamId) {
            $scope.steamId = $routeParams.steamId;
            $scope.getStats($routeParams.steamId);
        }
    }]
);

steamApp.controller('AnotherController', function($scope) {
    console.log('AnotherController');
});