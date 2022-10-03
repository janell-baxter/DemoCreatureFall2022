using System;
using System.Collections.Generic;
using System.Text;
using static DemoCreatureFall2022.Utility;

namespace DemoCreatureFall2022
{
    class World
    {
        List<Creature> Creatures = new List<Creature>() 
        { 
        new Dragon() {CommonName = "Firebreathing Gold Claw Dragon", Health = HealthStatus.VeryHealthy },
        new Spider() {CommonName = "Sixteen Legged Fireproof Spider", Health = HealthStatus.VeryHealthy },
        new Pig() {CommonName = "Magma-Skinned Pig", Health = HealthStatus.NotHealthy },
        new Human() {CommonName = "Plain Human" }

        };


        public void Start()
        {
            foreach(Creature c in Creatures)
            {
                Print($"{c.CommonName}");
                Print($"{c.ShowCreatureState()}");
            }


            Console.ReadKey();
        }
    }
}
