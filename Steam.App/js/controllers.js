var steamApp = angular.module('steamApp', []);
var config = {
    baseUrl: 'http://localhost:'
};

var data = {
    games: [{
        name: 'Counter Strike: Gobal Offensive',
        id: 730
    },
    {
        name: 'Another test game',
        id: 12
    }]
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

    $scope.steamId = '76561197969877387';
    $scope.statFilter = '';
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

});