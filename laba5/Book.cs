using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    public class Book : INotifyPropertyChanged
    {
        public string name_of_book;
        public string autor;
        public int isbn;
        public string annotation;
        public string summary;
        public string Text;
        public int count = 0;
        public bool flag = true;
        public string Name_of_book
        {
            get { return name_of_book; }
            set
            {
                name_of_book = value;
                OnPropertyChanged(nameof(Name_of_book));
            }
        }

        public string Autor
        {
            get { return autor; }
            set
            {
                autor = value;
                OnPropertyChanged(nameof(Autor));
            }
        }

        public int ISBN
        {
            get { return isbn; }
            set
            {
                isbn = value;
                OnPropertyChanged(nameof(isbn));
            }
        }

        public string Annotation
        {
            get { return annotation; }
            set
            {
                annotation = value;
                OnPropertyChanged(nameof(Annotation));
            }
        }

        public string Summary
        {
            get { return summary; }
            set
            {
                summary = value;
                OnPropertyChanged(nameof(Summary));
            }
        }

        public string text
        {
            get { return Text; }
            set
            {
                Text = value;
                OnPropertyChanged(nameof(text));
            }
        }
        public Book(string name_of_book, string autor, int isbn, string annotation, string summary, string Text)
        {
            Name_of_book = name_of_book;
            Autor = autor;
            ISBN = isbn;
            Annotation = annotation;
            Summary = summary;
            text = Text;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}