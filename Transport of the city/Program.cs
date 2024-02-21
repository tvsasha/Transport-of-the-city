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
                Console.WriteLine("Троллейбусы имеют одинаковую вместимость");
            }
            else if (trolleybus1 < trolleybus2)
            {
                Console.WriteLine("первый троллейбус имеет меньшую вместимость, чем второй троллейбус");
            }

            Transport bus = new Bus("Bus");
            Transport ferry = new Ferryboat("Ferry");

            if (bus > ferry)
            {
                Console.WriteLine("Автобус имеет большую вместимость, чем Паром");
            }
        }
    }
}