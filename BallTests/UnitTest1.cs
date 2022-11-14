using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework8;

namespace BallTests
{
    [TestClass]
    public class UnitTest1
    {
        private NormalBall ball = new NormalBall("grx"); // randomly chosen
        [TestMethod]
        public void AxisIsCorrectTest_46_43_false()
        {
            Assert.AreEqual(ball.AxisIsCorrect(46,43),false);
        }
        
        [TestMethod]
        public void AxisIsCorrectTest_39_41_true()
        {
            Assert.AreEqual(ball.AxisIsCorrect(39,41),true);
        }

        [TestMethod]
        public void CalcAverageSpeedTest_0_40_20s_resIs2()
        {
            double result = ball.CalculateAverageSpeed(0, 40, 20);
            Assert.AreEqual(2,result,0.1);
        }

        [TestMethod]
        public void CalcAverageSpeedTest_46_46_20s_resIs0()
        {
            double result = ball.CalculateAverageSpeed(46, 46, 20);
            Assert.AreEqual(0, result, 0.1);
        }
    }
}
