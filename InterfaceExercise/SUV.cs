using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV:IVehicle
    {
        public bool HasCargoHold { get; set; }
        public bool HasTVScreens  { get; set; }

        public string Logo { get; set; }
        public string Slogan { get; set; }

        public int NumberOfWheels { get; set; }
        public bool HasHeadLights { get; set; }
        public bool HasTailLights { get; set; }
        public string FuelGrade { get; set; }
    }
}
