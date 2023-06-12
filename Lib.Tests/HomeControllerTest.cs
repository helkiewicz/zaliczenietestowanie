using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using zaliczenie_.net.Controllers;
using zaliczenie_.net.Models;

namespace Lib.Tests
{ 
public class HomeControllerTests
{
    private HomeController _controller;
    private ILogger<HomeController> _logger;

    [SetUp]   
    public void Setup()
    {
        _logger = new LoggerFactory().CreateLogger<HomeController>();
        _controller = new HomeController(_logger);
    }

    [Test]
    public void Index_ReturnsViewResult()
    {
        var result = _controller.Index();

        Assert.IsInstanceOf<ViewResult>(result);
    }


    [Test]
    public void Error_ReturnsViewResultWithModel()
    {
        var result = _controller.Error();

        Assert.IsInstanceOf<ViewResult>(result);
        var viewResult = (ViewResult)result;
        Assert.IsInstanceOf<ErrorViewModel>(viewResult.Model);
    }
}

}