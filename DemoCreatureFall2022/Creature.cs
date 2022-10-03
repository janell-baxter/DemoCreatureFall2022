using System;
using System.Collections.Generic;
using System.Text;
using static DemoCreatureFall2022.Utility;

namespace DemoCreatureFall2022
{
    public enum HealthStatus
    {
        NotHealthy,
        Healthy,
        VeryHealthy
    }
    public class Creature
    {
        public HealthStatus Health = HealthStatus.Healthy;
        public string CommonName = "Anonymous Creature";
        public bool Asleep = false;


        public virtual void Move()
        {
            Print($"{CommonName} begins to move...");
        }

        public void Eat(Creature creature)
        {
            Print($"{CommonName} consumes {creature.CommonName}");
        }

        public void CheckSleepState()
        {
            if (Asleep)
            {
                Print($"{CommonName} is sleeping");
            }
            else
            {
                Print($"{CommonName} is awake");
            }
        }

        public void ChangeSleepState()
        {
            Asleep = !Asleep;
            //if (Asleep)
            //    Asleep = false;
            //else
            //    Asleep = true;
        }

        public string ShowCreatureState()
        {
            if (Health == HealthStatus.NotHealthy)
            {
                return "This creature is not doing well : (";
            }
            return "The creatue is okay health-wise.";

        }

    }
}