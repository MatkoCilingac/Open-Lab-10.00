using System;
using System.Reflection;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.Category("Roman");
            LOTR.Title("Lord Of The Rings");
            LOTR.Releasedate("30.10.1989");
            LOTR.Author("Michal Bernat");
            LOTR.Pages(10000);
            LOTR.Vypis();
            
        }
    }
}
