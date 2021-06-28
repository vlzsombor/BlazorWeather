window.blazorGeolocation = {

    toSerializable: function (e) {
        return {
            "coords": {
                "latitude": e.coords.latitude,
                "longitude": e.coords.longitude
            },
            "timestamp": new Date(e.timestamp)
        };
    },

    hasGeolocaitonFeature: function () {

        navigator.geolocation.getCurrentPosition(success, error);
        return navigator.geolocation ? true : false;
    },

    getCurrentPosition: function (geolocationRef, options) {
        function onSuccess(result) {
            return geolocationRef.invokeMethodAsync('RaiseOnGetPosition',
                blazorGeolocation.toSerializeable(result));
        };
        function onError(er) {
            return geolocationRef
                .invokeMethodAsync('RaiseOnGetPositionError', er.code);
        };
        navigator.geolocation
            .getCurrentPosition(onSuccess, onError, options);
    },
};



getCurrentPosition(PositionCallback successCallback,
    optional PositionErrorCallback errorCallback,
    optional PositionOptions options);
PositionCallback = void (Position position);
PositionErrorCallback = void (PositionError positionError);