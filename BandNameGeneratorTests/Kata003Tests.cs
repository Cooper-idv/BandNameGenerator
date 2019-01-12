using Microsoft.VisualStudio.TestTools.UnitTesting;
using BandNameGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandNameGenerator.Tests
{
    [TestClass()]
    public class Kata003Tests
    {
        [TestMethod()]
        public void BandNameGeneratorTest()
        {
            Assert.AreEqual("", Kata003.BandNameGenerator(""));
            Assert.AreEqual("The X", Kata003.BandNameGenerator("x"));
            Assert.AreEqual("The Knife", Kata003.BandNameGenerator("knife"));
            Assert.AreEqual("Tartart", Kata003.BandNameGenerator("tart"));
            Assert.AreEqual("Sandlesandles", Kata003.BandNameGenerator("sandles"));
            Assert.AreEqual("The Bed", Kata003.BandNameGenerator("bed"));
        }
    }
}