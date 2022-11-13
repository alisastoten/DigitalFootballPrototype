using System;

namespace Homework8
{
    class Program
    {
        static void Main(string[] args)
        {
            NormalBall normal = new NormalBall("UXgdR");
            double speed;
            Random rnd = new Random();
            normal.CreateCode();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\nCalculating kinetic energy for normal ball with velocity {i}...");
                normal.CalculateKineticEnergy(i);
            }

            for (int i = 0; i < 20; i++)
            {
                int rnd1 = rnd.Next(-51, 51);
                int rnd2 = rnd.Next(-51, 51);
                Console.WriteLine($"\nCalculating normal ball speed with axis {rnd1} and {rnd2} and 20 seconds.");
                speed = normal.CalculateAverageSpeed(rnd1, rnd2, 20);
                Console.WriteLine($"The speed is {speed}.");
            }

            normal.DisplayGoalAttempts();

            Console.WriteLine("\n\n\n--== Checking with different ball: Youth ball ==--\n\n");

            YouthBall yb = new YouthBall("ytBN");
            yb.CreateCode();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\nCalculating kinetic energy for youth ball with velocity {i}...");
                yb.CalculateKineticEnergy(i);
            }

            for (int i = 0; i < 20; i++)
            {
                int rnd1 = rnd.Next(-51, 51);
                int rnd2 = rnd.Next(-51, 51);
                Console.WriteLine($"\nCalculating youth ball speed with axis {rnd1} and {rnd2} and 20 seconds.");
                speed = yb.CalculateAverageSpeed(rnd1, rnd2, 20);
                Console.WriteLine($"The speed is {speed}.");
            }
            
            yb.DisplayGoalAttempts();

        }
    }
}
