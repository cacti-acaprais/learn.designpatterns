using System;
using System.Collections.Generic;
using System.Text;

namespace Learn.DesignPatterns.AbstractFactory
{
    public class Operation : IOperation
    {
        public int Compute(int first, int second)
            => first + second;
    }
}
