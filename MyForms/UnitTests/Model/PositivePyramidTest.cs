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
        [TestCase(4, 3, TestName = "Тестирование Count при присваивании значений.")]
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
