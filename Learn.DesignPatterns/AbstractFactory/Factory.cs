using System;
using System.Collections.Generic;
using System.Text;

namespace Learn.DesignPatterns.AbstractFactory
{
    public class Factory : IFactory
    {
        public IOperation Create()
            => new Operation();
    }
}
