using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._00
{
    internal class Librarry
    {
        int numberOfBooks;
        int numberOfStudents;
        public static List <string> studentsList = new List <string> ();
        public static List<string> booksList = new List<string>();
        public int NumberOfBooks
        {
            get { return numberOfBooks; }
            set { numberOfBooks = value; }
        }
        public int NumberOfStudents
        {
            get { return numberOfStudents; }
            set { numberOfStudents = value; }

        }
        public List<string> BooksList
        {
            get { return booksList; }
            set { booksList = value; }
        }
            public List<string> StudentsList
        {
            get { return studentsList; }
            set { studentsList = value; }
        }
    }


}

