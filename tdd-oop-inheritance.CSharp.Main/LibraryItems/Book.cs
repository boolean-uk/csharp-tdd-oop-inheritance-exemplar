

namespace tdd.oop.inheritance.CSharp.Main.LibraryItems
{
    public class Book : LibraryItem
    {
        
        public Book(string title) : base(title)
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
