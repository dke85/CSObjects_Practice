namespace ObjectPractice{
    
    class Map
    {
        public readonly int Width;
        public readonly int Height;

    public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public bool OnMap ( Point point)
        {
            //Define if a point is within bounds
            //bool inBounds = point.X >= 0 && point.X <Width && point.Y >=0 && point.Y<Height;

            //Same thing below but using or to determine if out of bounds
            //bool outOfBounds = point.X < 0 || point.X >= Width || point.Y < 0 || point.Y >= Height;

            //Same thing as outOfBounds but using the not operator.
            //bool inBounds = !(point.X < 0 || point.X >= Width || point.Y < 0 || point.Y >= Height);

            //inBounds = !outOfBounds;

            //return inBounds;

            return point.X >= 0 && point.X <Width && 
                   point.Y >=0 && point.Y<Height;
        }
    }

}