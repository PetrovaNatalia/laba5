using laba5;
using Microsoft.VisualBasic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace laba5
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
       private Catalog catalog;

       public MainWindow()
       {
           InitializeComponent();
           catalog = new Catalog();
           trackListView.ItemsSource = catalog.AllBooks;

       }

       private void AddBook_Click(object sender, RoutedEventArgs e)
       {

           var book = ReadBook();
           catalog.AddTrack(book);


           RefreshBooks();
           trackListView.ItemsSource = catalog.AllBooks;
       }

       private void RefreshBooks()
       {
           trackListView.Items.Refresh();
       }

       private void ShowAllBooks_Click(object sender, RoutedEventArgs e)
       {
           trackListView.ItemsSource = catalog.AllBooks;
       }

       private void SearchByNameOfBook_Click(object sender, RoutedEventArgs e)
       {
            string name_of_book = Interaction.InputBox("Введите название книги:", "Название", "");
            var books = catalog.SearchByNameOfBook(name_of_book);
           trackListView.ItemsSource = books;
       }
        public void SearchByAutor_Click(object sender, RoutedEventArgs e)
        {
            string autor = Interaction.InputBox("Введите автора книги:", "Автор", "");
            var books = catalog.SearchByAutor(autor);
            trackListView.ItemsSource = books;
        }

        public void SearchByISBN_Click(object sender, RoutedEventArgs e)
        {
            int ISBN = int.Parse(Interaction.InputBox("Введите ISBN:", "ISBN", ""));
            var books = catalog.SearchByISBN(ISBN);
            trackListView.ItemsSource = books;
        }

        public void SearchByFragment_Click(object sender, RoutedEventArgs e)
        {
            string fragment = Interaction.InputBox("Введите фрагмент книги:", "Фрагмент", "");
            var books = catalog.SearchByFragment(fragment);
            trackListView.ItemsSource = books;
        }

        public void SearchByKeyWord_Click(object sender, RoutedEventArgs e)
        {
            string key_word = Interaction.InputBox("Введите ключевое слово:", "Ключевое слово", "");
            var books = catalog.SearchByKeyWord(key_word);
            trackListView.ItemsSource = books;
        }
        public void cancelButton_Click(object sender, RoutedEventArgs e) =>
    DialogResult = false;
        private Book ReadBook()
       {
           string name_of_book = Interaction.InputBox("Введите название книги:", "Название", "");
           string autor = Interaction.InputBox("Введите автора книги:", "Автор", "");
           int ISBN = int.Parse(Interaction.InputBox("Введите ISBN:", "ISBN", ""));
           string annotation = Interaction.InputBox("Введите аннотацию:", "Аннотация", "");
           string summary = Interaction.InputBox("Введите краткое содержание:", "Содержание", "");
           string Text = Interaction.InputBox("Введите текст  книги:", "Текст", "");
           return new Book(name_of_book, autor, ISBN, annotation, summary, Text);
       }
    }
}