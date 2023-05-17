using NUnit.Framework;
using tdd.oop.inheritance.CSharp.Main.LibraryItems;
using tdd.oop.inheritance.CSharp.Main.LibraryItems.Concrete;
using tdd.oop.inheritance.CSharp.Main.LibraryItems.Interfaces;

namespace tdd.oop.inheritance.CSharp.Tests
{
    [TestFixture]
    public class BookTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            IAuthor author = new Author() { name = "Dave" };
            Book book = new Book("JUnit Rocks", author);
            Assert.AreEqual("item has been checked out", book.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            IAuthor author = new Author() { name = "Dave" };
            Book book = new Book("JUnit Rocks", author);
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            IAuthor author = new Author() { name = "Dave" };
            Book book = new Book("JUnit Rocks", author);
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            IAuthor author = new Author() { name = "Dave" };
            Book book = new Book("JUnit Rocks", author);

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }
        [Test]
        public void test()
        {

        }
    }
}