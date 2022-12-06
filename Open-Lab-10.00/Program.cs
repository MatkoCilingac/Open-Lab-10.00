using System;
using System.Reflection;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.title = "Lord Of The Rings";
            Console.WriteLine(LOTR.title);
        }
    }
}
