using NUnit.Framework;
using zaliczenie_.net.Models;

namespace Lib.Tests
{
    [TestFixture]
    public class ErrorViewModelTests
    {
        [Test]
        public void ShowRequestId_ReturnsTrue_WhenRequestIdIsNotNullOrEmpty()
        {
            var errorViewModel = new ErrorViewModel
            {
                RequestId = "12345"
            };

            var showRequestId = errorViewModel.ShowRequestId;

            Assert.IsTrue(showRequestId);
        }

        [Test]
        public void ShowRequestId_ReturnsFalse_WhenRequestIdIsNullOrEmpty()
        {
            var errorViewModel1 = new ErrorViewModel(); // RequestId is null by default
            var errorViewModel2 = new ErrorViewModel
            {
                RequestId = string.Empty
            };

            var showRequestId1 = errorViewModel1.ShowRequestId;
            var showRequestId2 = errorViewModel2.ShowRequestId;

            Assert.IsFalse(showRequestId1);
            Assert.IsFalse(showRequestId2);
        }
    }
}