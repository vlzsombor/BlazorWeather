using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherServer.Geo
{
    public enum PositionError
    {
        PERMISSION_DENIED = 1,
        POSITION_UNAVAILABLE,
        TIMEOUT
    }
}
