using RaceTrack.RaceTrack.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Drivers {
    class Batman : Driver {
        public Batman(RaceCar car) : base(car)
        {
            Name = "Bruce Wayne";
            SkillLevel = 15;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }


    }
}
