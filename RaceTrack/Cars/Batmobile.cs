using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars {
    class Batmobile : RaceCar {

        public Batmobile()
        {
            Name = "Batmoblie";
            TopSpeed = 110;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} starts");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} is stopping!");
            base.Brake();
        }

    }
}
