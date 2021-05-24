using System;

namespace ObjectPractice
{
    class Objects
    {
        public static void Main()
        {
            //Tower tower = new Tower();
            Map map = new Map(8, 5);

            //int area = map.Width * map.Height;
            
            //Point point = new Point(4, 2); <--substituting maplocation for Point as a subclass
            //MapLocation x = new MapLocation(4, 2);
            try
            {
                Path path = new Path(
                    new [] {
                        new MapLocation(0,2, map),
                        new MapLocation(1,2, map),
                        new MapLocation(2,2, map),
                        new MapLocation(3,2, map),
                        new MapLocation(4,2, map),
                        new MapLocation(5,2, map),
                        new MapLocation(6,2, map),
                        new MapLocation(7,2, map)
                    }
                );

                Invader[] invaders =
                {
                    new Invader(path),
                    new Invader(path),
                    new Invader(path),
                    new Invader(path)
                };

                Tower[] towers ={
                    new Tower (new MapLocation(1, 3, map)),
                    new Tower (new MapLocation(3, 3, map)),
                    new Tower (new MapLocation(5, 3, map))
                };

                Level level = new Level(invaders)
                {
                    Towers = towers
                };

                bool playerWon = level.Play();

                Console.WriteLine("Player " + (playerWon? "won" : "lost"));

                /*
                Replaced by properties
                MapLocation location = path.GetLocationAt(8);

                if(location != null)
                {
                    Console.WriteLine(location.X + "," + location.Y);
                }*/

                /* Removed since set was made private
                Invader invader = new Invader();
                MapLocation location = new MapLocation(0, 0, map);

                invader.Location = location;

                location = invader.Location;
                */

            //MapLocation mapLocation = new MapLocation(20, 20, map);
            //    MapLocation[**moved to new Path path**] path = ;
            }
            catch(OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(GameDefenseException)
            {
                Console.WriteLine("Unhandled GameDefenseException");                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unhandled Exception  " + ex);
            }
            //bool isOnMap = map.OnMap(point);
            //Console.WriteLine(isOnMap);

            //Point x = new MapLocation (4, 2); <--can be used instead of MapLocation
            
            //Point p = mapLocation;
            
            //point = new Point(8, 5);
            //isOnMap = map.OnMap(point);
            //Console.WriteLine(isOnMap);

            //map.OnMap(new MapLocation(0,0));

            //x is now a map location and point.
            
            //Console.WriteLine(mapLocation.DistanceTo(5,5));

            //Test 'is a' checks
            
            //Console.WriteLine(mapLocation is MapLocation);
            //Console.WriteLine(mapLocation is Point);

            Point point = new Point(0,0);
            Console.WriteLine(point is MapLocation);


        }
    }
}
