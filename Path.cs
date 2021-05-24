namespace ObjectPractice{
    
    class Path
    {
        private readonly MapLocation[] _path;
        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public int Length => _path.Length;

        public MapLocation GetLocationAt(int pathStep)
        {
            /*if(pathStep < _path.Length){
                return _path[pathStep];
            }
            else
            {
                return null;
            }*/

            //parenthesis not needed below or could be added
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }
    }
}