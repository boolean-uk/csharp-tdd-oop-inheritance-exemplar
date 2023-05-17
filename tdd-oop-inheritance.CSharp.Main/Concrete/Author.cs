using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd.oop.inheritance.CSharp.Main.LibraryItems.Interfaces;

namespace tdd.oop.inheritance.CSharp.Main.LibraryItems.Concrete
{
    public class Author : IAuthor
    {
        public string name { get; set; }
        public string website { get; set; }
        public string contactInfo { get; set; }
    }
}
