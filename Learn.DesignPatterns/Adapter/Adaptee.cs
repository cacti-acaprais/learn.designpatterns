using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Learn.DesignPatterns.Adapter
{
    public class Adaptee
    {
        public int Add(IEnumerable<int> numbers)
            => numbers.Sum();
    }
}
