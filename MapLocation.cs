using System;

namespace ObjectPractice
{

    // the : denotes subclass ie MapLocation is a Point.
    class MapLocation : Point
    {

        public MapLocation(int x, int y, Map map) : base(x,y)
        {
            if (!map.OnMap(this))
            {
                throw new OutOfBoundsException(x + "," + y + " is outside theboundaries of the map.");
            }
        }

        public bool InRangeOf(MapLocation location, int range)
        {
            return DistanceTo(location) <= range;
        }
    }
}
