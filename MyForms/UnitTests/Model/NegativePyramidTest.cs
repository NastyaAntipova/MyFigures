﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figure;
using NUnit.Framework;

namespace UnitTests.Model
{
    [TestFixture]
    public class NegativePyramidTest
    {
        [Test]
        [TestCase(-1, TestName = "Тестирование Count при присваивании -1.")]
        public void PyramidTes(int S)
        {
            var pyr = new Pyramid();
            Assert.Throws<ArgumentException>(() => { pyr.S = S; });
        }

    }
}
