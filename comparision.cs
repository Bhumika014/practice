using System;

namespace username
{
    class comparision
    {
        

        public static void comparisionprogram()
        {

            Console.WriteLine("Enter number a:");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number b:");

            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("a is greater than b");
            }
            else if (a < b)
            {
                Console.WriteLine("a is  less than b");
            }
            else
                Console.WriteLine("a is equal to b");


            return;
            
        }
    }
}
