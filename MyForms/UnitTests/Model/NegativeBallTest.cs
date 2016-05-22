using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Figure;

namespace UnitTests.Model
{
    [TestFixture]
    public class NegativeBallTest
    {
        [TestCase(-1, TestName = "Тестирование Count при присваивании -1.")]
        public void CalculateVolume_Test(int radius)
        {
                var rad = new Ball();
                Assert.Throws<ArgumentException>(() => { rad.radius = radius; }, "Ошибка!");
        }
    }
 }

