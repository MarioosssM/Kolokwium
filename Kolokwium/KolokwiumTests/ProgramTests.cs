using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kolokwium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void FishesTest()
        {
            int[] a = new int[] { 4, 3, 2, 1, 5 };
            int[] b = new int[] { 0, 1, 0, 0, 0 };
            Assert.AreEqual(2, Program.Fishes(a, b));
            // Assert.Fail();
            int[] c = new int[] { 4, 3, 2, 1, 5 };
            int[] d = new int[] { 0, 0, 1, 0, 0 };
            Assert.AreEqual(1, Program.Fishes(c, d));
        }
    }
}