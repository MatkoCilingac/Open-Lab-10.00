using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._00
{
    internal class Book
    {

        private string category;
        private string title;
        private int pages;
        private int releasedate;
        private string author;

        public Book()
        {
            category = "-1";
            title = "-1";
            pages = -1;
            releasedate = -1;
            author = "-1";  
        }
        public Book (int iPages, string sTitle)
        {
            category = "-1";
            releasedate=-1;
            author="-1";
            this.title = sTitle;
            this.pages = iPages;
        }
        public Book(string sCategory, string sTitle, int iPages, int iReleasedate, string sAuthor)
        {
            this.category = sCategory;
            this.title=sTitle;
            this.pages = iPages;
            this.releasedate = iReleasedate;
            this.author = sAuthor;
        }
    
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public int Pages
        {
            get { return pages; }
            set
            {
                pages = value;
                if (pages < 0)
                {
                    pages = 1;
                }

            }
        }

        public int Releasedate
        {
            get { return releasedate; }
            set
            {
                releasedate = value;

                if (releasedate > 2021 | releasedate < 1450)
                {
                    releasedate = -1;
                }
            }

        }
    

    public override string ToString()
    {
        return ($"{category}\n{title}\n{releasedate}\n{author}\n{pages}"); }

           

        

    }
}
