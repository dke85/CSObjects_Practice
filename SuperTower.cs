using System;

namespace ObjectPractice
{
    
    class SuperTower : Tower
    {
        
        protected override int Range {get;} = 2;
        protected override double Accuracy {get;} = 1;
        protected override int Power {get;} = 2;

        public SuperTower (MapLocation location) : base (location)
        {}
    }

}