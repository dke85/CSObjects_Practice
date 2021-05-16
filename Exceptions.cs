using System;

namespace ObjectPractice
{
    class GameDefenseException : Exception
    {
        public GameDefenseException(){
            
        }
        public GameDefenseException(string message) : base(message)
        {

        }
    }

    class OutOfBoundsException : GameDefenseException
    {
        public OutOfBoundsException()
        {

        }
        public OutOfBoundsException(string message) : base(message)
        {

        }
    }

}