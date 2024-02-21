using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_of_the_city
{
    public class Transport
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public decimal Fare { get; set; }

        public Transport(string name, int capacity, decimal fare)
        {
            Name = name;
            Capacity = capacity;
            Fare = fare;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Transport other = (Transport)obj;
            return Capacity == other.Capacity;
        }

        public override int GetHashCode()
        {
            return Capacity.GetHashCode();
        }

        public static bool operator ==(Transport t1, Transport t2)
        {
            return t1.Equals(t2);
        }

        public static bool operator !=(Transport t1, Transport t2)
        {
            return !(t1 == t2);
        }

        public static bool operator <(Transport t1, Transport t2)
        {
            return t1.Capacity < t2.Capacity;
        }

        public static bool operator >(Transport t1, Transport t2)
        {
            return t1.Capacity > t2.Capacity;
        }

        public static bool operator <=(Transport t1, Transport t2)
        {
            return t1.Capacity <= t2.Capacity;
        }

        public static bool operator >=(Transport t1, Transport t2)
        {
            return t1.Capacity >= t2.Capacity;
        }
    }
}
