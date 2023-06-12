using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using NUnit.Framework;
using zaliczenie_.net.Models;

namespace Lib.Tests
{
    [TestFixture]
    public class LibraryContextTests
    {
        private DbContextOptions<LibraryContext> _options;

        [SetUp]
        public void Setup()
        {
            _options = new DbContextOptionsBuilder<LibraryContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;
        }

        [Test]
        public void Books_DbSet_Should_Not_Be_Null()
        {
            using (var context = new LibraryContext(_options))
            {
                var books = context.Books;

                Assert.NotNull(books);
            }
        }

        [Test]
        public void Tittle_DbSet_Should_Not_Be_Null()
        {
            using (var context = new LibraryContext(_options))
            {
                var tittle = context.Tittle;

                Assert.NotNull(tittle);
            }
        }
    }
}