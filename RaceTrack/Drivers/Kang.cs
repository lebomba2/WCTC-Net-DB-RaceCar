using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Kang : Driver
    {
        public Kang(RaceCar car) : base(car)
        {
            Name = "Alien Kang";
            SkillLevel = 11;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
