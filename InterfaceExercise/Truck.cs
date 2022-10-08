using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck:IVehicle
    {
        public bool HasTrailer { get; set; }
        public bool IsCommercial { get; set; }

        public string Logo { get; set; }
        public string Slogan { get; set; }

        public int NumberOfWheels { get; set; }
        public bool HasHeadLights { get; set; }
        public bool HasTailLights { get; set; }
        public string FuelGrade { get; set; }
    }
}
