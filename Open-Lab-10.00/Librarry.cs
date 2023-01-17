using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._00
{
    internal class Librarry
    {
        int numberOfBooks;
        int numberOfStudents;
        public static List<string> studentsList = new List<string>();
        public static List<Book> booksList = new List<Book>();
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
        public List<Book> BooksList
        {
            get { return booksList; }
            set { booksList = value; }
        }
        public List<string> StudentsList
        {
            get { return studentsList; }
            set { studentsList = value; }
        }
        public override string ToString()
        {
            var mylist = booksList.ConvertAll(x => x.ToString());
            return String.Format($"pocet studentov: {NumberOfStudents}\npocet knih: " +
                $"{NumberOfBooks}\nstudenti: " + string.Join(", ", studentsList) + "\nknizocky: " + string.Join(", ", booksList));

        }
    }
    


}

