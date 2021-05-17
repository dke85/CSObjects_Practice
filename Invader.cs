namespace ObjectPractice{
    
    class Invader
    {
        private MapLocation _location;

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
        public MapLocation Location { get; private set; }
    }
}