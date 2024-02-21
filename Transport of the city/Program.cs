namespace Transport_of_the_city
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transport trolleybus1 = new Trolleybus("Trolleybus1");
            Transport trolleybus2 = new Trolleybus("Trolleybus2");

            if (trolleybus1 == trolleybus2)
            {
                Console.WriteLine("Trolleybuses have the same capacity");
            }
            else if (trolleybus1 < trolleybus2)
            {
                Console.WriteLine("Trolleybus1 has less capacity than Trolleybus2");
            }

            Transport bus = new Bus("Bus");
            Transport ferry = new Ferryboat("Ferry");

            if (bus > ferry)
            {
                Console.WriteLine("Bus has greater capacity than Ferry");
            }
        }
    }
}