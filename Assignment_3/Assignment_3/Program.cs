using System;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.Write("Enter a character : ");
            ch = Convert.ToChar(Console.ReadLine());
            if(ch=='a' || ch=='e' || ch=='i' || ch=='o' || ch=='u' || ch=='A' || ch=='E' || ch=='I' || ch=='O' || ch=='U')
            {
                Console.WriteLine(ch + " is a vowel");
            }
            else
            {
                Console.Write(ch + " is not a vowel");
            }
        }
    }
}
