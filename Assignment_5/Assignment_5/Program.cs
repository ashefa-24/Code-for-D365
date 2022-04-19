using System;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int index, nextpos, val1, val2, number;
            Console.Write("Enter any number : ");
            number = int.Parse(Console.ReadLine());
            for(index=1; index<=number; index++)
            {
                for(nextpos=1;nextpos<=number-index;nextpos++)
                {
                    Console.Write(" ");
                }
                for(val1=1;val1<=index;val1++)
                {
                    Console.Write(val1);
                }
                for(val2=index-1;val2>=1;val2--)
                {
                    Console.Write(val2);
                }
                Console.Write("\n");
            }
        }
    }
}
