using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figure;
using NUnit.Framework;

namespace UnitTests.Model
{
    [TestFixture]
    public class PositiveBallClass
    {
        [Test]
        [TestCase(4, TestName = "Тестирование Count при присваивании 4.")]
        public void PositiveBall(int rad)
        {
            var posball = new Ball();
            posball.radius = rad;   
        }
    }
}
