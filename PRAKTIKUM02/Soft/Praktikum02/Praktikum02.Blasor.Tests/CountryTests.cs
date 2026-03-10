using Praktikum02.Blasor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum02.Blasor.Tests
{
    [TestClass]
    public class CountryTests : BaseTests<Country>
    {
        [TestMethod]
        public void NameTest()
        {
            Assert.IsNotNull(obj);
            obj.Name = "Estonia";
            Assert.AreEqual("Estonia", obj.Name);
        }

        [TestMethod]
        public void CodeTest()
        {
            Assert.IsNotNull(obj);
            obj.Code = "EE";
            Assert.AreEqual("EE", obj.Code);
        }
    }
}
