using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using tdd.oop.inheritance.CSharp.Main.LibraryItems.Base;

namespace tdd.oop.inheritance.CSharp.Main.LibraryItems.Concrete;

public class Library
{
    private List<LibraryItem> _items = new List<LibraryItem>();


    public void addToStock(LibraryItem item)
    {
        _items.Add(item);
    }
    public string checkOutLibraryItem(string name)
    {
        var item = _items.Where(i => i.title == name).FirstOrDefault();

        if (item != null)
        {
            if (item.IsCheckoutable == true)
            {
                return item.checkOut();
            }
            else
            {
                return "item is not available for checkout";
            }

        }
        return "item is not part of the library's collection";
    }

    public List<LibraryItem> Items { get { return _items; } }




    // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
    // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)
    //public string checkInArticle(string title)
    //{

    //    List<Article> filtered = (List<Article>)listLibraryItems.Where(article => article.title.Equals(title));

    //    if (filtered.Count() < 1)
    //    {
    //        return "item is not part of the library's collection";
    //    }

    //    return filtered[0].checkIn();
    //}

    //public string checkOutArticle(string title)
    //{
    //    throw new NotImplementedException();
    //    List<Article> filtered = (List<Article>)listLibraryItems.Where(article => article.title.Equals(title));

    //    if (filtered.Count() < 1)
    //    {
    //        return "item is not part of the library's collection";
    //    }

    //    return filtered[0].checkOut();
    //}

    //public string checkInBook(string title)
    //{
    //    List<Book> filtered = (List<Book>)listLibraryItems.Where(book => book.Equals(title));

    //    if (filtered.Count() < 1)
    //    {
    //        return "item is not part of the library's collection";
    //    }

    //    return filtered[0].checkIn();
    //}

    //public string checkOutBook(string title)
    //{
    //    throw new NotImplementedException();
    //    List<Book> filtered = (List<Book>)listLibraryItems.Where(book => book.Equals(title));

    //    if (filtered.Count() < 1)
    //    {
    //        return "item is not part of the library's collection";
    //    }

    //    return filtered[0].checkOut();
    //}


}
