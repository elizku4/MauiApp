using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum02.Blasor.Tests
{
    [TestClass]
    public abstract class BaseTests<T> where T : class, new()
    {
        protected T? obj;

        [TestInitialize]
        public void Setup()
        {
            obj = new T();
        }

        [TestMethod]
        public void ClassExistsTest()
        {
            Assert.IsNotNull(obj);
        }
    }
}
