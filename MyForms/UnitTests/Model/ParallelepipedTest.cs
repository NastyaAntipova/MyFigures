using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figure;
using NUnit.Framework;

namespace UnitTests.Model
{
    /// <summary>
    /// Набор тестов для класса Параллелепипед
    /// </summary>
    /// 
    [TestFixture]
    public class ParallelepipedTest
    {
        [TestCase(2, 5, 10, 100)]
        [TestCase(1, 5, 5, 25)]
        public void CalculateVolume(int a, int b, int c, int expected)
        {
            var parallel = new Parallelepiped();
            parallel.a = a;
            parallel.b = b;
            parallel.c = c;
            var actual = parallel.CalculateVolume();
            Assert.AreEqual(expected, actual);
        }
        
    }
}
