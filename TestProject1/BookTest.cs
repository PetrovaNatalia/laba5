using laba5;

namespace TestProject1
{
    [TestClass]
    public class BookTest
    {
        [TestMethod]
        public void BookTestMethod()
        {
            // Arrange
            string name = "Test Book";
            string autor = "Test Autor";
            int isbn = 1234567890;
            string annotation = "Test Annotation";
            string summary = "Test Summary";
            string text = "Test Text";

            // Act
            Book book = new Book(name, autor, isbn, annotation, summary, text);

            // Assert
            Assert.AreEqual(name, book.Name_of_book);
            Assert.AreEqual(autor, book.Autor);
            Assert.AreEqual(isbn, book.ISBN);
            Assert.AreEqual(annotation, book.Annotation);
            Assert.AreEqual(summary, book.Summary);
            Assert.AreEqual(text, book.text);
        }
    }
}