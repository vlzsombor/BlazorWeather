using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherServer.Geo
{
    public class Position
    {
        public Coords Coords { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
