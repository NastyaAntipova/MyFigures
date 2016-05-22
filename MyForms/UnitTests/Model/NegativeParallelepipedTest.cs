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
    class NegativeParallelepipedTest
    {
        [Test]
        [TestCase(-6, TestName = "Тестирование Count при присваивании -1.")]
        public void ParallTest(int a)
        {
            var parallel = new Parallelepiped();
            Assert.Throws<ArgumentException>(() => { parallel.a = a; });
        }
    }
}
