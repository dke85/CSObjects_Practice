using System;

namespace ObjectPractice
{
    interface IInvader
    {
        MapLocation Location{get;}

        int Health {get;}

        //True if the invasder has reached the end of the path
        bool HasScored {get;}

        bool IsNeutralized {get;}

        bool IsActive {get;}

        void Move();

        void DecreaseHealth (int factor);
    }

}