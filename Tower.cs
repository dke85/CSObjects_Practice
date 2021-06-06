using System;

namespace ObjectPractice
{
    
    class Tower
    {
        
        protected virtual int Range {get;} = 1;
        protected virtual int Power {get;} = 1;
        protected virtual double Accuracy {get;} = .75;

        private static readonly System.Random _random = new System.Random();
        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccessfulShot()
        {
            return Tower._random.NextDouble() < Accuracy;
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
                if(invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if(IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(Power);
                        
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