using System;
using System.Collections.Generic;
using System.Text;

namespace Learn.DesignPatterns.Strategy
{
    public class OperationContext
    {
        private readonly IOperationStrategy _operationStrategy;

        public OperationContext(IOperationStrategy operationStrategy)
        {
            _operationStrategy = operationStrategy ?? throw new ArgumentNullException(nameof(operationStrategy));
        }

        public int Compute(int first, int second)
            => _operationStrategy.Compute(first, second);
    }
}
