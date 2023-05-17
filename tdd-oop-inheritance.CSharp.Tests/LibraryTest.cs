using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd.oop.inheritance.CSharp.Main.LibraryItems;
using tdd.oop.inheritance.CSharp.Main.LibraryItems.Concrete;

namespace tdd.oop.inheritance.CSharp.Tests
{
    [TestFixture]
    public class LibraryTest
    {
        [Test]
        public void CountItemsInLibrary()
        {
            Library library = new Library();
            library.addToStock(new Newspaper("The C# Times"));
            library.addToStock(new Newspaper("The C# Daily"));

            int result = 2;

            Assert.AreEqual(result, library.Items.Count);
        }
        [Test]
        public void NewsPaperCantCheckout()
        {
            Library library = new Library();
            library.addToStock(new Newspaper("The C# Times"));
            Assert.IsTrue(library.Items[0].IsCheckoutable==false);
        }
        [Test]
        public void ArticleCanCheckout()
        {
            Author author = new Author() { name = "Nigel" };
            Article article = new Article("The C# Article", author);
            Library library = new Library();

            library.addToStock(article);
            Assert.IsTrue(library.Items[0].IsCheckoutable == true);
        }
        [Test]
        public void CallCheckoutArticle()
        {
            Author author = new Author() { name = "Nigel" };
            Article article = new Article("The C# Article", author);
            Library library = new Library();

            library.addToStock(article);
            
            string expected = "item has been checked out";
            string result = library.Items[0].checkOut();

            Assert.AreEqual(library.Items[0].onLoan, true);
            Assert.AreEqual(expected, result);

        }

    }
}
