using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.Observer
{
    public class EarthQuake
    {
        public EarthQuake(double latitude, double logitude, double magnitude, DateTime dateTime)
        {
            Latitude = latitude;
            Logitude = logitude;
            Magnitude = magnitude;
            DateTime = dateTime;
        }

        public double Latitude { get; set; }
        public double Logitude { get; set; }
        public double Magnitude { get; set; }
        public DateTime DateTime { get; set; }



    }
}
