using System;
using System.Collections.Generic;
using System.Text;

namespace Learn.DesignPatterns.AbstractFactory
{
    public interface IFactory
    {
        IOperation Create();
    }
}
