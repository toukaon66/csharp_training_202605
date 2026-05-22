using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Csharp_training_202605.Models;
using Microsoft.Extensions.Logging;
using Csharp_training_202605.Presentations.ViewModels;

namespace Csharp_training_202605.Controllers;

public class EmployeeRegisterController : Controller
{
    private readonly ILogger<EmployeeRegisterController> _logger;

    public EmployeeRegisterController(ILogger<EmployeeRegisterController> logger)
    {
        _logger = logger;
    }
    public IActionResult Enter()
    {
        return View();
    }

    public IActionResult Confirm(EmployeeRegisterViewModel viewModel)
    {
        if(!ModelState.IsValid)
        {
            return View("Enter",viewModel);
        }
        return View();
    }
    public IActionResult Complete()
    {
        return View();
    }


    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}