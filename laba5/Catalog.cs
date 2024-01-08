using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;


namespace laba5
{
    public class Catalog
    {
        private List<Book> allBooks;

        public List<Book> AllBooks
        {
            get { return allBooks; }
        }

        public Catalog()
        {
            allBooks = new List<Book>();
        }

        public void AddTrack(Book book)
        {
            allBooks.Add(book);
        }

        public List<Book> SearchByNameOfBook(string name_of_book)
        {
            List<Book> book = allBooks.FindAll(book => book.name_of_book == name_of_book);
            return book;
        }
        public List<Book> SearchByAutor(string autor)
        {
            List<Book> book = allBooks.FindAll(book => book.autor == autor);
            return book;
        }
        public List<Book> SearchByISBN(int ISBN)
        {
            List<Book> book = allBooks.FindAll(book => book.ISBN == ISBN);
            return book;
        }
        public List<Book> SearchByFragment(string fragment)
        {
            List<Book> book = allBooks.FindAll(book => book.Text.Contains(fragment));
            return book;
        }
        public List<Book> SearchByKeyWord(string KeyWord)
        {
            List<Book> found = new List<Book>();
            foreach (Book book in allBooks)
            {
                bool bT = book.Text.Contains(KeyWord);
                bool bA = book.annotation.Contains(KeyWord);
                if (bT || bA)
                {
                    found.Add(book);
                }
                else
                {
                    continue;
                }
            }
            if (found.Count > 0)
            {
                foreach (Book book in found)
                {
                    bool bT = book.Text.Contains(KeyWord);
                    bool bA = book.annotation.Contains(KeyWord);

                    if (bT && bA)
                    {
                        book.count += Regex.Matches(book.Text, KeyWord, RegexOptions.IgnoreCase).Count;
                        book.count += Regex.Matches(book.annotation, KeyWord, RegexOptions.IgnoreCase).Count;
                    }
                    else
                    {
                        if (bT)
                        {
                            book.count += Regex.Matches(book.Text, KeyWord, RegexOptions.IgnoreCase).Count;
                            book.flag = false;

                        }
                        else
                        {
                            book.count += Regex.Matches(book.annotation, KeyWord, RegexOptions.IgnoreCase).Count;
                        }
                    }

                }
                found.Sort((x, y) => x.count.CompareTo(y.count));
                found.Reverse();
            }
            return found;
        }
    }
}