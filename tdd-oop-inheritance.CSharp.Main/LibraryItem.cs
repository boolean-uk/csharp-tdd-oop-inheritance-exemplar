using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd.oop.inheritance.CSharp.Main
{
    public abstract class LibraryItem
    {
        public LibraryItem(string title)
        {
            this.title = title;
        }
        public bool isOnLoan()
        {
            return onLoan;
        }
        public string title { get; set; }
        public bool onLoan { get; set; } = false;
           

    }
}
