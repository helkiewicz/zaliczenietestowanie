using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using zaliczenie_.net.Models;

namespace Lib.Tests
{
    [TestFixture]
    public class UserContextTests
    {
        [Test]
        public void UserContext_Constructor_SetsOptionsCorrectly()
        {
            var options = new DbContextOptions<UserContext>();
      
            var userContext = new UserContext(options);
       
            Assert.IsNotNull(userContext);
        }
    }
}