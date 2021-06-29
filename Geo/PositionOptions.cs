using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherServer.Geo
{
    public class PositionOptions
    {
        public bool EnableHighAccuracy { get; set; } = false;
        public int Timeout { get; set; }
        public int MaximumAge { get; set; } = 0;
    }
}
