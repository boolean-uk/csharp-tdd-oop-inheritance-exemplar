using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd.oop.inheritance.CSharp.Main.LibraryItems.Base
{
    public abstract class LibraryItem
    {        
        private bool _onLoan = false;
        public LibraryItem(string title)
        {
            this.title = title;
        }
        private bool isOnLoan()
        {
            return _onLoan;
        }
        public virtual string checkIn()
        {
            if (!isOnLoan())
            {
                return "item is not currently on loan";
            }

            onLoan = false;

            return "item has been checked in";
        }

        public virtual string checkOut()
        {
            if (isOnLoan())
            {
                return "item is currently on loan";
            }

            onLoan = true;

            return "item has been checked out";
        }


        public string title { get; set; }
        public bool onLoan { get { return _onLoan; } set { _onLoan = value; } }
        public bool IsCheckoutable { get; set; }
    }
}
