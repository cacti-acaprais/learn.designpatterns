using Learn.DesignPatterns.AbstractFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Learn.DesignPatterns.Test
{
    [TestClass]
    public class AbstractFactoryTest
    {
        [TestMethod]
        public void OperationTest()
        {
            IFactory factory = new Factory();
            IOperation operation = factory.Create();

            int result = operation.Compute(4, 2);
            Assert.AreEqual(6, result);
        }
    }
}
