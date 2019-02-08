using System;
using System.Collections.Generic;
using System.Text;

namespace Learn.DesignPatterns.AbstractFactory
{
    public interface IOperation
    {
        int Compute(int first, int second);
    }
}
