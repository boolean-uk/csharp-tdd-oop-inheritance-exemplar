
using tdd.oop.inheritance.CSharp.Main.LibraryItems.Base;

namespace tdd.oop.inheritance.CSharp.Main.LibraryItems
{
    public class Newspaper : LibraryItem
    {
      
        public Newspaper(string title) : base(title)
        {
            this.IsCheckoutable = false;
        }
      

        public string checkIn()
        {
            return "newspapers are not available for loan";
        }

        public override string checkOut()
        {
            return "newspapers are not available for loan";
        }        
    }
}
