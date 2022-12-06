using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._00
{
    internal class Book
    {
        
        private string category; 
        private string title;
        private int pages;
        private string releasedate;
        private string author;    
        public string Category(string xcategory)
        {
            this.category = xcategory;
            return category;
        }
        public string Title(string xtitle)
        {
            this.title = xtitle;
            return title;
        }
        public string Releasedate(string xreleasedate)
        {
            this.releasedate = xreleasedate;
            return releasedate;
        }
        public string Author (string xauthor)
        {
            this.author = xauthor;
            return author;
        }
        public int Pages(int xpages)
        {
            this.pages = xpages;
            return pages;
        }
        public void Vypis()
        {
            Console.WriteLine(category , title , releasedate , author , pages);
           

        }

    }
}
