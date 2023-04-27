using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Coffee : ICoffee
    {
        public string GetDescription() => "Coffe";

        public double GetCost() => 1.0;
    }
}
