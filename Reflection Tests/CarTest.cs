using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reflection;
using System;

namespace Reflection_Tests
{
    [TestClass]
    public class CarTest
    {
        Car car = new Car("FIAT", "124 Spider", "SUPERCAR", "2019", 200000.00m);
        [TestMethod]
        public void CarValueTest()
        {
            Assert.AreEqual("£200,000.00", car.Value());
        }

        [TestMethod]
        public void CarYearTest()
        {
            Assert.AreEqual("2019", car.Year());
        }

        [TestMethod]
        public void CarStringTest()
        {
            Assert.AreEqual("The FIAT 124 Spider with the registration of 'SUPERCAR' was registered in 2019 and has a value of £200,000.00", car.ToString());
        }
    }
}
