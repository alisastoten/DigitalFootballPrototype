using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Homework8
{
    public class NormalBall : IBall
    {
        protected string _balltype;
        protected int _diameter;
        protected double _goalDepth;
        protected double _weight;
        protected string _sponsorName;
        private string _code;
        protected int _firstLetters;
        protected int _randNums;
        private int _scoredGoal;
        private int _notScoredGoal;

        public NormalBall()
        { }

        public NormalBall(string sponsorsName)
        {
            _sponsorName = sponsorsName;
            _diameter = 70;
            _goalDepth = 1.7;
            _weight = 450 / 1000.0; // initial was in g -> kg
            _firstLetters = 4;
            _randNums = 5;
            _balltype = "normal ball";
        }

        public void CreateCode()
        {
            if (_sponsorName.Length < _firstLetters)
            {
                Console.WriteLine($"Creating code for {_balltype}...\nSponsors name is too short to create a code.");
            }
            else
            {
                Random rnd = new Random();
                for (int i = 0; i < _firstLetters; i++)
                {
                    _code += _sponsorName[i];
                }
                for (int i = 0; i < _randNums; i++)
                {
                    int num = rnd.Next(0, 10);
                    _code += Convert.ToString(num);
                }

                Console.WriteLine($"Code for {_balltype} is {_code}.");
            }
        }

        public bool AxisIsCorrect(int a, int b)
        {
            // both a and b have to be between -45 and 45
            if (a >= -45 && a <= 45)
            {
                if (b >= -45 && b <= 45)
                {
                    return true;
                }
            }
            return false;
        }

        public double CalculateAverageSpeed(int a, int b, int seconds)
        {
            if (!AxisIsCorrect(a, b) || seconds < 0)
            {
                Console.WriteLine("The start and end points can only be between -45 and 45. Seconds cannot be 0.");
                return 0.0; //  <- is there a better way?
            }
            // Did the ball enter the goal (whole ball has to be in goal)
            DidBallEnterGoal(b);
            double speed = Math.Abs((b - a) / (double)seconds); //one of the numbers in the expression must be of floating-point type
            return speed;
        }

        public void DidBallEnterGoal(int endPointOfBall) // ball moved A -> B, B is endpoint
        {
            // goal coordinates are either 45 or -45. Use math.abs on ball coordinate and only compare with 45
            double radius = (double)_diameter / 2 / 100; // find radius in m not cm
            if (Math.Abs(endPointOfBall) - radius >= 45 - _goalDepth) // middle point of ball - radius = point where the ball has to be in the goal at least
                _scoredGoal++;
            else
                _notScoredGoal++;
        }

        public void CalculateKineticEnergy(int velocity)
        {
            if (velocity <= 0)
                Console.WriteLine("Velocity cannot be 0 or less than zero.");
            else
            {
                double kineticEnergy = _weight * velocity * velocity / 2.0; // at least one has to be double here -> 2.0 
                Console.WriteLine($"Kinetic energy of {_balltype} is {Math.Round(kineticEnergy, 2)}.");
            }
        }

        public void DisplayGoalAttempts()
        {
            Console.WriteLine($"\nFailed goal attempts: {_notScoredGoal}\n" +
                              $"Successful goal attempts: {_scoredGoal}");
        }
    }
}
