using System;

namespace ConstReadOnly
{
    class Program
    {
        int a;
        static int y = 20;
        const float pi = 3.14f;
        readonly bool flag;
        public Program(int a, bool flag)
        {
            this.a = a;
            this.flag = flag;
        }
        static void Main(string[] args)
        {

            Console.WriteLine(Program.y);
            Console.WriteLine(Program.pi);
            Program p = new Program(30, true);
            Program p1 = new Program(40, false);
            Console.WriteLine(p.a + "  " + p1.a);
            Console.WriteLine(p.flag + "  " + p1.flag);
            //Read only can be changed if we use constructor
        }
    }
}


