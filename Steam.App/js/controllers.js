var steamApp = angular.module('steamApp', []);
var config = {
    baseUrl: 'http://localhost:'
};

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

steamApp.controller('ProfileCtrl', function ($scope, $http) {

    var service = {
        getCsgoStats: function(steamId, callback) {
            $http
                .get('http://localhost:55129/api/PlayerStats/' + steamId + '/730')
                .success(function(data) {
                    callback(data)
                });
        }
    };

    $scope.weapons = data.weapons;
    $scope.steamId = '76561197969877387';
    $scope.statFilter = '';
    $scope.statWeaponFilter = '';
    $scope.statOrderProperty = 'name';
    $scope.statOrder = '';

    $scope.getStats = function(steamId) {
        service.getCsgoStats(steamId, function(data) {
            $scope.playerStats = data;
        });
    };

    $scope.getOrder = function() {
        return $scope.statOrder + $scope.statOrderProperty;
    };

    $scope.getFilter = function() {
        var separator = ($scope.statFilter.length === 0) ? '' : ' ',
            filter = $scope.statFilter + separator + $scope.statWeaponFilter;

        return filter;
    }

});