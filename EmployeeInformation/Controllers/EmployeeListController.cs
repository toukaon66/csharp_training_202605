using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Csharp_training_202605.Models;

namespace Csharp_training_202605.Controllers;

public class EmployeeRegisterController : Controller
{
    private readonly ILogger<EmployeeRegisterController> _logger;

    public EmployeeRegisterController(ILogger<EmployeeRegisterController> logger)
    {
        _logger = logger;
    }

    public 
}