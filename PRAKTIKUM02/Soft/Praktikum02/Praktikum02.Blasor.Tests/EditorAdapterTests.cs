using Praktikum02.Aids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum02.Blasor.Tests
{
    [TestClass]
    public class EditorAdapterTests
    {
        private class TestClass
        {
            public int A { get; set; }
            public string B { get; set; } = "";
        }

        [TestMethod]
        public void PropertiesCountTest()
        {
            var obj = new TestClass();
            var adapter = new EditorAdapter(obj);

            var props = adapter.Properties.ToList();

            Assert.AreEqual(2, props.Count);
        }
    }
}
