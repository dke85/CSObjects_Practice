using System;

namespace ObjectPractice
{
    
    class ShieldedInvader : Invader
    {
        private static Random _random = new Random();
        
        public ShieldedInvader(Path path) : base(path)
        {}
        public override void DecreaseHealth (int factor)
        {
            if(_random.NextDouble() < .5)
            {
                base.DecreaseHealth(factor);
            }
            else
            {
                Console.WriteLine("Shot at a shielded invader but it sustained no damage.");
            }
        }
    }

}