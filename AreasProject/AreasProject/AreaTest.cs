using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AreasProject
{
    [TestFixture]
    class AreaTest
    {
        [Test]

        public void AreaTest1()
        {
            Area a = new Area();

            double r = 4.0;
            double expectedValue = 50.27;
            double actualValue = a.AreaC(r);

            Assert.AreEqual(expectedValue, actualValue);

        }

        [Test]

        public void PerimeterTest()
        {
            Area a = new Area();

            double r = 4.0;
            double expectedValue = 25.13;
            double actualValue = a.Perimeter(r);

            Assert.AreEqual(expectedValue, actualValue);

        }

    }
}
