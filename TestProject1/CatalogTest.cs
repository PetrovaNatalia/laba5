using Microsoft.VisualStudio.TestTools.UnitTesting;
using laba5;

namespace TestProject
{
    [TestClass]
    public class CatalogTest
    {
        [TestMethod]
        public void TestAddTrack()
        {
            // Arrange
            Catalog catalog = new Catalog();
            Book book = new Book("1","1",1,"1", "1", "1");

            // Act
            catalog.AddTrack(book);

            // Assert
            Assert.AreEqual(1, catalog.AllBooks.Count);
            Assert.AreEqual(book, catalog.AllBooks[0]);
        }

        [TestMethod]
        public void TestSearchByNameOfBook()
        {
            // Arrange
            Catalog catalog = new Catalog();
            Book book1 = new Book("Book1","Autor1", 123456789, "Annotation1", "Summary1", "Text1" );
            Book book2 = new Book("Book2", "Autor2", 1234567890, "Annotation2", "Summary2", "Text2");

            catalog.AddTrack(book1);
            catalog.AddTrack(book2);

            // Act
            var result = catalog.SearchByNameOfBook("Book1");

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(book1, result[0]);
        }
        public void TestSearchByAutor()
        {
            // Arrange
            Catalog catalog = new Catalog();
            Book book1 = new Book("Book1", "Autor1", 123456789, "Annotation1", "Summary1", "Text1");
            Book book2 = new Book("Book2", "Autor2", 1234567890, "Annotation2", "Summary2", "Text2");

            catalog.AddTrack(book1);
            catalog.AddTrack(book2);

            // Act
            var result = catalog.SearchByAutor("Autor1");

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(book1, result[0]);
        }
        public void TestSearchByISBN()
        {
            // Arrange
            Catalog catalog = new Catalog();
            Book book1 = new Book("Book1", "Autor1", 123456789, "Annotation1", "Summary1", "Text1");
            Book book2 = new Book("Book2", "Autor2", 1234567890, "Annotation2", "Summary2", "Text2");

            catalog.AddTrack(book1);
            catalog.AddTrack(book2);

            // Act
            var result = catalog.SearchByISBN(123456789);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(book1, result[0]);
        }

        public void TestSearchByFragment()
        {
            // Arrange
            Catalog catalog = new Catalog();
            Book book1 = new Book("Book1", "Autor1", 123456789, "Annotation1", "Summary1", "Text1 Text3 Text5");
            Book book2 = new Book("Book2", "Autor2", 1234567890, "Annotation2", "Summary2", "Text2");

            catalog.AddTrack(book1);
            catalog.AddTrack(book2);

            // Act
            var result = catalog.SearchByFragment("Text3");

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(book1, result[0]);
        }
        public void TestSearchByKeyWord()
        {
            // Arrange
            Catalog catalog = new Catalog();
            Book book1 = new Book("Book1", "Autor1", 123456789, "Annotation1 key_word", "Summary1", "Text1 key_word");
            Book book2 = new Book("Book2", "Autor2", 1234567890, "Annotation2", "Summary2", "Text2 key_word");

            catalog.AddTrack(book1);
            catalog.AddTrack(book2);

            // Act
            var result = catalog.SearchByKeyWord("key_word");

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(book1, result[0]);
            Assert.AreEqual(book2, result[1]);
        }
    }
}
