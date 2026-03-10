using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Praktikum02.Blasor.Data;

namespace Praktikum02.Blasor.Tests
{
    [TestClass]
    public class GetRandomTests
    {
        [TestMethod]
        public void Int32_Returns_Value_In_Range()
        {
            var value = GetRandom.Int32(1, 10);

            Assert.IsTrue(value >= 1 && value < 10);
        }
    }
}
