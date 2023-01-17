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
            Book LOTR2 = new Book(30, "kniha1");
            Book Hobbit = new Book("roman", "kniha2", 150, 2005, "cigon");
            Hobbit.Category = Book.categoryList[4];
            Console.WriteLine(LOTR.ToString());
            Console.WriteLine(Hobbit.ToString());
            Console.WriteLine(LOTR2.ToString());
            Console.WriteLine(LOTR3.ToString());

            Librarry schoollibrarry = new Librarry();
            Book anj = new Book("ucebnica", "Project5", 158, 1988, "Oxford");
            Book sjl = new Book("ucebnica", "Slovensky jazyk", 300, 1578, "vydavatelstvoSK");
            Book elk = new Book("ucebnica", "elektronika", 1500, 2008, "peter sovik");
            Book fig = new Book("ucebnica", "financie v praxi", 300, 1999, "vydavatelstvoSK");
            schoollibrarry.StudentsList.Add("John");
            schoollibrarry.StudentsList.Add("Poul");
            schoollibrarry.BooksList.Add(anj);
            schoollibrarry.BooksList.Add(sjl);
            schoollibrarry.BooksList.Add(elk);
            schoollibrarry.BooksList.Add(fig);
            schoollibrarry.NumberOfBooks = 4;
            schoollibrarry.NumberOfStudents = 2;
            Console.WriteLine(schoollibrarry.ToString());

        }
    }
}
