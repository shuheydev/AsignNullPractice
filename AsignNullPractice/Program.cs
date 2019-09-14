using System;

namespace AsignNullPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new MyObject(10);

            var b = a;

            Console.WriteLine($"a: {a.MyInt}");
            Console.WriteLine($"after b=a b: {b.MyInt}");

            b.MyInt = b.MyInt - 5;

            Console.WriteLine($"after b-5 a: {a.MyInt}");
            Console.WriteLine($"after b-5 b: {b.MyInt}");

            b = null;

            Console.WriteLine($"after b=null a: {a.MyInt}");
            Console.WriteLine($"after b=null b: {b?.MyInt}");
        }
    }

    class MyObject
    {
        public MyObject(int value)
        {
            MyInt = value;
        }
        public int MyInt { get; set; }
    }
}
