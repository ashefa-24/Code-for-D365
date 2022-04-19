using System;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter the number:");
            num = Int32.Parse(Console.ReadLine());
            if(num % 2 ==0)
            {
                Console.WriteLine("The given number is Even Number and the number is : "+ num);
            }
            else
            {
                Console.WriteLine("The given number is Odd number and the number is : "+ num);
            }
            Console.ReadKey();
        }
    }
}
