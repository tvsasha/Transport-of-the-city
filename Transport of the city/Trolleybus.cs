using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_of_the_city
{
    public class Trolleybus : Transport
    {
        public Trolleybus(string name) : base(name, 30, 20) { }

        public static bool operator ==(Trolleybus t1, Trolleybus t2)
        {
            return t1.Capacity == t2.Capacity;
        }

        public static bool operator !=(Trolleybus t1, Trolleybus t2)
        {
            return !(t1 == t2);
        }

        public static bool operator <(Trolleybus t1, Trolleybus t2)
        {
            return t1.Capacity < t2.Capacity;
        }

        public static bool operator >(Trolleybus t1, Trolleybus t2)
        {
            return t1.Capacity > t2.Capacity;
        }

        public static bool operator <=(Trolleybus t1, Trolleybus t2)
        {
            return t1.Capacity <= t2.Capacity;
        }

        public static bool operator >=(Trolleybus t1, Trolleybus t2)
        {
            return t1.Capacity >= t2.Capacity;
        }
    }
}
