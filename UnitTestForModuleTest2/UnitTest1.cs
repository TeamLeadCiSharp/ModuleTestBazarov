using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModuleTestBazaro;
using System;

namespace UnitTestForModuleTest2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateLionEnclosureArea_CalculatesCorrectly()
        {
            IEnclosure enclosure = new Enclosure(5, 6);
            IAnimal lion = new Animal("Lion", enclosure);
            double result = lion.Enclosure.Area;
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void CalculateElephantEnclosureArea_CalculatesCorrectly()
        {
            IEnclosure enclosure = new Enclosure(10, 12);
            IAnimal elephant = new Animal("Elephant", enclosure);
            double result = elephant.Enclosure.Area;
            Assert.AreEqual(120, result);
        }

        [TestMethod]
        public void CalculateTigerEnclosureArea_CalculatesCorrectly()
        {
            IEnclosure enclosure = new Enclosure(6, 8);
            IAnimal tiger = new Animal("Tiger", enclosure);
            double result = tiger.Enclosure.Area;
            Assert.AreEqual(48, result);
        }
    }
}
