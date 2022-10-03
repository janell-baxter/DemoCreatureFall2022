using System;
using System.Collections.Generic;
using System.Text;
using static DemoCreatureFall2022.Utility;

namespace DemoCreatureFall2022
{
    class Pig: Animal, IFly
    {
        public void Fly()
        {
            //throw new NotImplementedException();
        }

        public override void Move()
        {
            base.Move();
            Print("The pig begins to fly!");

        }


    }
}
