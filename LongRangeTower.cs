using System;

namespace ObjectPractice
{
    
    class LongRangeTower : Tower
    {
        
        protected override int Range {get;} = 2;

        public LongRangeTower (MapLocation location) : base (location)
        {}
    }

}