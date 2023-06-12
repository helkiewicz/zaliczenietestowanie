using NUnit.Framework;
using zaliczenie_.net.Models;


namespace Lib.Tests
{
    public class Tests
    {
        private Library library;

        [SetUp]
        public void Setup()
        {
            library = new Library();
            library.Tittle = "invalid title";
        }

        [Test]
        public void Title_ShouldStartWithCapitalLetter()
        {
            library.Tittle = "invalid title";

            bool isValid = IsTitleValid(library.Tittle);

            Assert.IsFalse(isValid);
        }

        [Test]
        public void Author_ShouldStartWithCapitalLetter()
        {
            library.Author = "invalid author";

            bool isValid = IsAuthorValid(library.Author);

            Assert.IsFalse(isValid);
        }

        private bool IsTitleValid(string Tittle)
        {
            return !string.IsNullOrEmpty(Tittle) && char.IsUpper(Tittle[0]);
        }

        private bool IsAuthorValid(string author)
        {
            return !string.IsNullOrEmpty(author) && char.IsUpper(author[0]);
        }

    }
}
