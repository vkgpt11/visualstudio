/// <autosync enabled="true"/>
/// <reference path="Angular/lib/angular.js"/>
/// <reference path="app.js"/>
/// <reference path="Angular/lib/angular.min.js" />
/// <reference path="Angular/lib/angular.route.min.js" />


angular.module("photoBrowser", []).service("imageService", function ($http) {
    return {
        getImages: function () {
            return $http.get("/JsonData/Imagesjson.json", { responseType: "json" });
        }
    }
})
.controller("photoList", function ($scope,imageService) {
    $scope.images = imageService.getImages().then(function (images) {
        $scope.images = images.data;
        console.log($scope.images);
    });
    //
})