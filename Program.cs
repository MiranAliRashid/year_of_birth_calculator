using System;

namespace date_of_birth_calculator
{
    class Program
    {
        public static void birth_calculator(int age)
        {
            
            int year = 2021-age;
            
            Console.WriteLine("your year of birth is " + year);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter you age");

            birth_calculator(Convert.ToInt32 (Console.ReadLine()));

            

        }
    }
}
