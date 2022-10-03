using System;
using System.Collections.Generic;
using System.Text;
using static DemoCreatureFall2022.Utility;

namespace DemoCreatureFall2022
{
    class Spider: Creature
    {

        public override void Move()
        {
            base.Move();
            Print("The spider moves on its web!");

        }
    }
}
