using System;
using System.Collections.Generic;
using System.Text;

namespace Homework8
{
    interface IBall
    {
        double CalculateAverageSpeed(int a, int b, int seconds);
        void CalculateKineticEnergy(int velocity);
        void DisplayGoalAttempts();
        void CreateCode();
        void DidBallEnterGoal(int endPointOfBall);
    }
}
