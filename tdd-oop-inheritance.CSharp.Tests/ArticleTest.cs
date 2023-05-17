using NUnit.Framework;
using tdd.oop.inheritance.CSharp.Main.LibraryItems;
using tdd.oop.inheritance.CSharp.Main.LibraryItems.Concrete;
using tdd.oop.inheritance.CSharp.Main.LibraryItems.Interfaces;

namespace tdd.oop.inheritance.CSharp.Tests
{
    [TestFixture]
    public class ArticleTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            IAuthor author = new Author() { name="Dave" };
            Article article = new Article("JUnit Rocks", author);
            Assert.AreEqual("item has been checked out", article.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
            {
                IAuthor author = new Author() { name = "Dave" };
                Article article = new Article("JUnit Rocks", author);
                article.checkOut();

                Assert.AreEqual("item is currently on loan", article.checkOut());
            }

        [Test]
        public void shouldCheckInIfOnLoan()
            {
            Author author = new Author() { name = "Dave" };
            Article article = new Article("JUnit Rocks", author);
            article.checkOut();

                Assert.AreEqual("item has been checked in", article.checkIn());
            }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
            {
                Author author = new Author() { name = "Dave" };
                Article article = new Article("JUnit Rocks", author);

                Assert.AreEqual("item is not currently on loan", article.checkIn());
            }

        [Test]
        public void testAuthorInArticle()        
        {
            IAuthor author = new Author();
            author.name = "Nigel";
            author.website = "nigel.com";
            Article article = new Article("JUnit Rocks", author);

            Assert.IsTrue(article.Author.name == "Nigel");
        }
        
    }
}