using Microsoft.VisualStudio.TestTools.UnitTesting;
using Formulas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulas.Tests {
    [TestClass()]
    public class Class1Tests {
        [TestMethod()]
        public void testThisTest() {
            var c1 = new Class1();

            Assert.AreEqual(5, c1.testThis());
        }
    }
}