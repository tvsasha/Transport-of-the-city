using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_of_the_city
{    
        public class Ferryboat : Transport
        {
        public Ferryboat(string name) : base(name, 50, 100) { }

        public static bool operator ==(Ferryboat t1, Ferryboat t2)
        {
            return t1.Capacity == t2.Capacity;
        }

        public static bool operator !=(Ferryboat t1, Ferryboat t2)
        {
            return !(t1 == t2);
        }

        public static bool operator <(Ferryboat t1, Ferryboat t2)
        {
            return t1.Capacity < t2.Capacity;
        }

        public static bool operator >(Ferryboat t1, Ferryboat t2)
        {
            return t1.Capacity > t2.Capacity;
        }

        public static bool operator <=(Ferryboat t1, Ferryboat t2)
        {
            return t1.Capacity <= t2.Capacity;
        }

        public static bool operator >=(Ferryboat t1, Ferryboat t2)
        {
            return t1.Capacity >= t2.Capacity;
        }
    }    
}
