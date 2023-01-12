using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Open_Lab_10._00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.Category = "roman";
            LOTR.Title = "Lord Of The Rings";
            LOTR.Releasedate = 1989;
            LOTR.Author = "Michal Bernat";
            LOTR.Pages = 10000;
            Book LOTR3 = new Book();
            Book LOTR2 = new Book( 30, "kniha1" );    
            Book Hobbit = new Book("roman","kniha2", 150, 2005, "cigon");
            Hobbit.Category = Book.categoryList[4]; 
            Console.WriteLine(LOTR.ToString());
            Console.WriteLine(Hobbit.ToString());
            Console.WriteLine(LOTR2.ToString());
            Console.WriteLine(LOTR3.ToString());
            
        }
    }
}
