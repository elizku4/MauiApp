using Praktikum02.Blasor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum02.Blasor.Tests
{
    [TestClass]
    public sealed class MovieTests : BaseTests<Movie>
    {
        [TestMethod]
        public void TitleTest()
        {
            Assert.IsNotNull(obj);
            obj.Title = "Fight Club";
            Assert.AreEqual("Fight Club", obj.Title);
        }

        [TestMethod]
        public void GenreTest()
        {
            Assert.IsNotNull(obj);
            obj.Genre = "Drama";
            Assert.AreEqual("Drama", obj.Genre);
        }
        [TestMethod]
        public void PriceTest()
        {
            Assert.IsNotNull(obj);
            obj.Price = 63m;
            Assert.AreEqual(63m, obj.Price);
        }
    }

    }
