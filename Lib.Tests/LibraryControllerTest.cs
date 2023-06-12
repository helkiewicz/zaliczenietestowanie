using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zaliczenie_.net.Controllers;
using zaliczenie_.net.Models;

namespace Lib.Tests
{
    public class LibraryControllerTest
    {
        private LibraryContext _context;
        private LibrariesController _controller;

        [SetUp]
        public void Setup()
        {
            // Set up the mock database context
            var options = new DbContextOptionsBuilder<LibraryContext>()
                .UseInMemoryDatabase(databaseName: "TestLibrary")
                .Options;
            _context = new LibraryContext(options);

            // Add sample data to the in-memory database
            _context.Books.Add(new Library { idBook = 1, Tittle = "Book 1", Author = "Author 1", Section = "Section 1", Status = Status.Available });
            _context.Books.Add(new Library { idBook = 2, Tittle = "Book 2", Author = "Author 2", Section = "Section 2", Status = Status.Available });
            _context.SaveChanges();

            // Create the controller instance
            _controller = new LibrariesController(_context);
        }



        [Test]
        public async Task DeleteConfirmed_WithValidId_RedirectsToIndex()
        {
            int bookId = 1;

            var result = await _controller.DeleteConfirmed(bookId) as RedirectToActionResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ActionName);
        }

        [Test]
        public async Task Details_WithInvalidId_ReturnsNotFoundResult()
        {
            int bookId = 100;

            var result = await _controller.Details(bookId);

            Assert.IsInstanceOf<NotFoundResult>(result);
        }

    }
}
