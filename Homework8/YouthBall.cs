using System;
using System.Collections.Generic;
using System.Text;

namespace Homework8
{
    class YouthBall : NormalBall
    {

        public YouthBall(string sponsorsName)
        {
            _sponsorName = sponsorsName;
            _diameter = 56;
            _goalDepth = 1.4;
            _weight = 380 / 1000.0; // initial was in g -> kg
            _firstLetters = 3;
            _randNums = 3;
            _balltype = "youth ball";
        }
    }
}
