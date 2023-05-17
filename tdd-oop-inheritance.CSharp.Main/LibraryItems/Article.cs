﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd.oop.inheritance.CSharp.Main.LibraryItems
{
    public class Article : LibraryItem
    {
        public Article(string title) : base(title)
        {
        }



        public string checkIn()
        {
            if (!isOnLoan())
            {
                return "item is not currently on loan";
            }

            onLoan = false;

            return "item has been checked in";
        }

        public string checkOut()
        {
            if (isOnLoan())
            {
                return "item is currently on loan";
            }

            onLoan = true;

            return "item has been checked out";
        }
    }
}
