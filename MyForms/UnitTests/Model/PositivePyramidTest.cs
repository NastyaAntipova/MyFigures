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
    public class PositivePyramidTest
    {
        [Test]
        [TestCase(4, 3, TestName = "Тестирование при присваивании значений 3,4")]
        [TestCase(1, 7, TestName = "Тестирование при присваивании значений 1,7")]
        public void PosPyramidTest(int S, int h)
        {
            {
                var pyram = new Pyramid();
                pyram.S = S;
                pyram.h = h;
            }
        }
    }
}
