using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_of_the_city
{
    public class Bus : Transport
    {
        public Bus(string name) : base(name, 20, 30) { }
    }
}
