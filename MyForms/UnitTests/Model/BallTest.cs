using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Figure;


namespace UnitTests.Model
{

    /// <summary>
    /// Набор тестов для класса Ball
    /// </summary>
    /// 
    [TestFixture]
    public class BallTest
    {
        [Test]
        public void Tests()
        {
            
            var ball = new Ball();
            ball.radius = 2;
            var expectedVolume = 25.132741228718345;
            var actualVolume = ball.CalculateVolume();
            Assert.AreEqual(expectedVolume, actualVolume); 

        }
    }
    
}
