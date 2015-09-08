steamApp.factory('playerService', ['$http', function($http) {
    return {
        test: 'test!',
        getCsgoStats: function(steamId, callback) {
            $http
                .get('http://localhost:55129/api/PlayerStats/' + steamId + '/730')
                .success(function(data) {
                    callback(data)
                });
        }
    };
}]);