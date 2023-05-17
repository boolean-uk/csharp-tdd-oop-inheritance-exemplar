using NUnit.Framework;
using tdd.oop.inheritance.CSharp.Main;
using tdd.oop.inheritance.CSharp.Main.LibraryItems;

namespace tdd.oop.inheritance.CSharp.Tests
{
    [TestFixture]
    public class NewspaperTest
    {
        [Test]
        public void shouldBeUnavailableForCheckIn()
        {
            Newspaper newspaper = new Newspaper("The Daily Java");
            Assert.AreEqual("newspapers are not available for loan", newspaper.checkIn());
        }

        [Test]
        public void shouldBeUnavailableForCheckOut()
        {
            Newspaper newspaper = new Newspaper("The Daily Java");
            Assert.AreEqual("newspapers are not available for loan", newspaper.checkOut());
        }
    }
}