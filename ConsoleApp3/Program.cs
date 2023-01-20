using System;
namespace inlämmning
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in 5 namn");
            string[] name = new string[5];

            for (int i = 0; i < 5; i++)
            {
                name[i] = Console.ReadLine();
            }

            Console.WriteLine("namnerna är: ");
            for (int i = 0; i < 5; i++)
                Console.WriteLine(name[i]);



        }
    }
}
