using Learn.DesignPatterns.Adapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Learn.DesignPatterns.Test
{
    [TestClass]
    public class AdapterTest
    {
        [TestMethod]
        public void AdditionTest()
        {
            Adapter.Adapter adapter = new Adapter.Adapter();
            ITarget target = adapter;
            Adaptee adaptee = adapter;

            int adapteeResult = adaptee.Add(new[] { 4, 2 });
            int adaptedResult = target.Add(4, 2);

            Assert.AreEqual(adaptedResult, adapteeResult);
        }
    }
}
