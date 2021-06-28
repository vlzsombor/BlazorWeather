using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherServer.Geo
{
    public class Geolocation
    {
        private readonly IJSRuntime _js;

        public Geolocation(IJSRuntime js)
        {
            this._js = js;
        }


        public async ValueTask<bool> HasGeolcationFeature()
            => await _js.InvokeAsync<bool>("blazorGeolocation.hasGeolocaitonFeature");


        private Action<Position> OnGetPosition;

        [JSInvokable]
        public void RaiseOnGetPosition(Position p) =>
            OnGetPosition?.Invoke(p);

        private Action<PositionError> OnGetPositionError;

        [JSInvokable]
        public void RaiseOnGetPositionError(PositionError err)
            => OnGetPositionError?.Invoke(err);


        public async ValueTask GetCurrentPosition(
            Action<Position> onSuccess,
            Action<PositionError> onError,
            PositionOptions options = null)
        {
            OnGetPosition = onSuccess;
            OnGetPositionError = onError;
            await _js.InvokeVoidAsync("blazorGeolocation.getCurrentPosition",
            DotNetObjectReference.Create(this), options);
        }
    }
}
