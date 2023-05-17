using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd.oop.inheritance.CSharp.Main.LibraryItems
{
    public class Library 
    {
        List<LibraryItem> listLibraryItems = new List<LibraryItem>();
     

        public void addToStock(Article item)
        {
            listLibraryItems.Add(item);
        }

        public void addToStock(Book item)
        {
            listLibraryItems.Add(item);
        }

        public void addToStock(Newspaper item)
        {
            listLibraryItems.Add(item);
        }

        // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
        // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)
        public string checkInArticle(string title)
        {

            List<Article> filtered = (List<Article>)listLibraryItems.Where(article => article.title.Equals(title));

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutArticle(string title)
        {
            List<Article> filtered = (List<Article>)listLibraryItems.Where(article => article.title.Equals(title));

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }

        public string checkInBook(string title)
        {
            List<Book> filtered = (List<Book>)listLibraryItems.Where(book => book.Equals(title));

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutBook(string title)
        {
            List<Book> filtered = (List<Book>)listLibraryItems.Where(book => book.Equals(title));

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }

        public string checkInNewspaper(string title)
        {
            List<Newspaper> filtered = (List<Newspaper>)listLibraryItems.Where(newspaper => newspaper.title.Equals(title));

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutNewspaper(string title)
        {
            List<Newspaper> filtered = (List<Newspaper>)listLibraryItems.Where(newspaper => newspaper.title.Equals(title));

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }
    }
}
