using System;

namespace username
{
    class Program
    {
        private static string userName;

        static void Main(string[] args)
        {
            int x = 5;
            int y = 9;

            int total = x + y;
            int total1 = x - y;
            int total2 = x * y;

            Console.WriteLine(total);
            Console.WriteLine(total1);
            Console.WriteLine(total2);


            Console.WriteLine("Enter the username: ");

            string userName = Console.ReadLine();

            Console.WriteLine("Username is: " + userName );

            comparision.comparisionprogram();
            
        }
    }
}
