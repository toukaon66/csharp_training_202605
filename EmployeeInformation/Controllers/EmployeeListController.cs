using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Csharp_training_202605.Models;
using Microsoft.Extensions.Logging;

namespace Csharp_training_202605.Controllers;

public class EmployeeListController : Controller
{
    private readonly ILogger<EmployeeRegisterController> _logger;

    public EmployeeListController(ILogger<EmployeeRegisterController> logger)
    {
        _logger = logger;
    }

    public IActionResult Enter()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}