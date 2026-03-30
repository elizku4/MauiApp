using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Praktikum02.Aids;

namespace Praktikum02.Blasor.Tests
{
    [TestClass]
    public class TypeExtensionsTests
    {
        private class TestClass
        {
            public int A { get; set; }
            public string B { get; set; } = "";
        }

        [TestMethod]
        public void GetPropertyNamesTest()
        {
            var props = typeof(TestClass).GetPropertyNames();

            Assert.IsTrue(props.Contains("A"));
            Assert.IsTrue(props.Contains("B"));
        }
    }
}
