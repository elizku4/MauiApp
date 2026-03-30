using Microsoft.VisualStudio.TestTools.UnitTesting;
using Praktikum02.Aids;

namespace Praktikum02.Blasor.Tests;

[TestClass]
public class PropertyAdapterTests
{
    private class TestClass
    {
        public int IntProp { get; set; }
        public string StringProp { get; set; } = "";
    }

    [TestMethod]
    public void SetValueTest()
    {
        var obj = new TestClass();
        var adapter = new PropertyAdapter(obj, nameof(TestClass.IntProp));

        adapter.SetValue(123);

        Assert.AreEqual(123, obj.IntProp);
    }
}
