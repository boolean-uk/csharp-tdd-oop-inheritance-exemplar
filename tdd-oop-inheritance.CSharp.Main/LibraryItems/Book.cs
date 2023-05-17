
using tdd.oop.inheritance.CSharp.Main.LibraryItems.Base;
using tdd.oop.inheritance.CSharp.Main.LibraryItems.Interfaces;

namespace tdd.oop.inheritance.CSharp.Main.LibraryItems
{
    public class Book : LibraryItem, IAuthorable
    {
        IAuthor _author;
        public Book(string title, IAuthor author) : base(title)
        {
            _author = author;
            this.IsCheckoutable = true;
        }

        public IAuthor Author { get { return _author; }set { _author = value; } }

    }
}
