using System;

namespace ObjectPractice
{
    
    abstract class Invader
    {
        // ** note used ** private MapLocation _location;

/*
        public MapLocation GetLocation()
        {
            return _location;
        }

        public void SetLocation(MapLocation value)
        {
            _location = value;
        }
        */

        /* Replaced by shorter auto property
        public MapLocation Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
        }
        */
        private readonly Path _path;
        private int _pathStep = 0;

        protected virtual int StepSize { get; } = 1;

        /*public MapLocation Location { 
            get
                {
                    return _path.GetLocationAt(_pathStep);
                }
            }
            --The below is 'Symantic Sugar' for this
            */
        public MapLocation Location => _path.GetLocationAt(_pathStep);

        public virtual int Health { get; protected set; } = 2;

        //True if the invasder has reached the end of the path
        public bool HasScored {get { return _pathStep >= _path.Length;}}

        public bool IsNeutralized => Health <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);

        public Invader(Path path)
        {
            _path = path;
        }

        /*public void Move()
        {
            _pathStep += 1;
        }
        Can be rewritten as below
        */
        public void Move() => _pathStep += StepSize;

        public virtual void DecreaseHealth (int factor)
        {
                Health -= factor;
                Console.WriteLine("Shot at and hit an invader!");
            
        }
    }
}