using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.Category = "Roman";
            LOTR.Title = "Lord Of The Rings";
            LOTR.Releasedate = 1989;
            LOTR.Author = "Michal Bernat";
            LOTR.Pages = 10000;
            Console.WriteLine(LOTR.ToString());
            
        }
    }
}
