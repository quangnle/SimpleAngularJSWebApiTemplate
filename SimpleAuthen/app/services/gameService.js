'use strict';
app.factory('gameService', ['$http', function ($http) {

    var serviceBase = ngAuthSettings.apiServiceBaseUri;
    var gameServiceFactory = {};

    var _test = function () {

        return $http.get(serviceBase + 'api/game').then(function (results) {
            return results;
        });
    };

    gameServiceFactory.test = _test;

    return gameServiceFactory;

}]);