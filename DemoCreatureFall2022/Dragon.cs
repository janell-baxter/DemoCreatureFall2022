using System;
using System.Collections.Generic;
using System.Text;
using static DemoCreatureFall2022.Utility;

namespace DemoCreatureFall2022
{
    class Dragon: Creature, IFly
    {
        public void Fly()
        {
            
        }

        public override void Move()
        {
            //base.Move();
            Print("The dragon jogs in his sneakers!");

        }
    }
}
