﻿using System;
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
            LOTR.Category = "Roman";
            LOTR.Title = "Lord Of The Rings";
            LOTR.Releasedate = 1989;
            LOTR.Author = "Michal Bernat";
            LOTR.Pages = 10000;
            Book LOTR3 = new Book();
            Book LOTR2 = new Book(int iPages, string sTitle);    
            Book Hobbit = new Book();
            Console.WriteLine(LOTR.ToString());
            
        }
    }
}
