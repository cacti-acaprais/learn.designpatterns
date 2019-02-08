using Learn.DesignPatterns.Strategy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learn.DesignPatterns.Test
{
    [TestClass]
    public class StrategyTest
    {
        [TestMethod]
        public void AdditionStrategy()
        {
            OperationContext operationContext = new OperationContext(new AdditionStrategy());
            int result = operationContext.Compute(4, 2);

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void SubstractionStrategy()
        {
            OperationContext operationContext = new OperationContext(new SubstractionStrategy());
            int result = operationContext.Compute(4, 2);

            Assert.AreEqual(2, result);
        }
    }
}
