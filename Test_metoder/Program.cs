using System;

namespace test_metoder1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal (bredd)");
            int bredd = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in ett heltal till (höjd)");
            int höjd = int.Parse(Console.ReadLine());

            Console.WriteLine("Arean på rektangeln är :" + AREA(bredd,höjd));


        }

        static int AREA(int bredd, int höjd)
        {
            int a = bredd * höjd;

            return a;
        }
    }
}