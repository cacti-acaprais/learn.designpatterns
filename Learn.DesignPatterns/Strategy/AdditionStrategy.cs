using System;
using System.Collections.Generic;
using System.Text;

namespace Learn.DesignPatterns.Strategy
{
    public class AdditionStrategy : IOperationStrategy
    {
        public int Compute(int first, int second)
            => first + second;
    }
}
