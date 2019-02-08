using System;
using System.Collections.Generic;
using System.Text;

namespace Learn.DesignPatterns.Strategy
{
    public interface IOperationStrategy
    {
        int Compute(int first, int second);
    }
}
