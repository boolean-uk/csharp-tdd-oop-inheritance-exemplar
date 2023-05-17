﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd.oop.inheritance.CSharp.Main.LibraryItems
{
    public class Newspaper : LibraryItem
    {
      
        public Newspaper(string title) : base(title)
        {
            
        }
      

        public string checkIn()
        {
            return "newspapers are not available for loan";
        }

        public string checkOut()
        {
            return "newspapers are not available for loan";
        }
    }
}
