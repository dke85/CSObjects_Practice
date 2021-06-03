using System;

namespace ObjectPractice
{
    
    class Tower
    {
        
        private const int _range = 1;
        private const int _power = 1;
        private const double _accuracy = .75;

        private static readonly System.Random _random = new System.Random();
        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccessfulShot()
        {
            return Tower._random.NextDouble() < _accuracy;
        }

        public void FireOnInvaders(Invader[] invaders)
        {

            /*int index = 0;

            while(index < invaders.Length)
            {
                Invader invader = invaders[index];
                // Do stuff with invader

                index++;
            }
            Same as for loop*/

            /*for(int i = 0; i < invaders.Length; i++)
            {
                Invader invader = invaders[i];
                //Do stuff with invader
            }
            Same as foreach loop*/

            foreach(Invader invader in invaders)
            {
                // Do stuff with invaders
                if(invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    if(IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(_power);
                        
                        if(invader.IsNeutralized)
                        {
                            Console.WriteLine("Neutralized and invader!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Shot at and misses an invader");
                    }
                    
                    break;
                }
            }
        }
    }
}