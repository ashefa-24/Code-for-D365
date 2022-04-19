using System;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, rem, sum = 0,temp;
            Console.WriteLine("Enter the number: ");
            number = int.Parse(Console.ReadLine());
            temp = number;
            while(number>0)
            {
                rem = number % 10;
                sum = (sum * 10) + rem;
                number = number / 10;
            }
            if(temp==sum)
            {
                Console.Write("The given number is Palindrome.");
            }
            else
            {
                Console.Write("The given number is not a palindrome");
            }
        }
    }
}
