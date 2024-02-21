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

        public static bool operator ==(Bus t1, Bus t2)
        {
            return t1.Capacity == t2.Capacity;
        }

        public static bool operator !=(Bus t1, Bus t2)
        {
            return !(t1 == t2);
        }

        public static bool operator <(Bus t1, Bus t2)
        {
            return t1.Capacity < t2.Capacity;
        }

        public static bool operator >(Bus t1, Bus t2)
        {
            return t1.Capacity > t2.Capacity;
        }

        public static bool operator <=(Bus t1, Bus t2)
        {
            return t1.Capacity <= t2.Capacity;
        }

        public static bool operator >=(Bus t1, Bus t2)
        {
            return t1.Capacity >= t2.Capacity;
        }
    }
}
