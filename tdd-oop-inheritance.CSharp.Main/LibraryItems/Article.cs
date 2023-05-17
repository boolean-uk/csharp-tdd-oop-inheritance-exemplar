using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using tdd.oop.inheritance.CSharp.Main.LibraryItems.Base;
using tdd.oop.inheritance.CSharp.Main.LibraryItems.Interfaces;

namespace tdd.oop.inheritance.CSharp.Main.LibraryItems
{
    public class Article : LibraryItem, IAuthorable
    {
       
        IAuthor _author;

        public Article(string title, IAuthor author) : base(title)        
        {            
            _author = author;
            this.IsCheckoutable= true;
        }

        public IAuthor Author { get { return _author; } set { _author = value; } }

            
    }
}
