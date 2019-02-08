using System;
using System.Collections.Generic;
using System.Text;

namespace Learn.DesignPatterns.Adapter
{
    public class Adapter : Adaptee, ITarget
    {
        public int Add(int first, int second)
            => Add(new[] { first, second });
    }
}
