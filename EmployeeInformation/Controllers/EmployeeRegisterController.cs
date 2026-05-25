using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Csharp_training_202605.Models;
using Microsoft.Extensions.Logging;
using Csharp_training_202605.Presentations.ViewModels;
using Csharp_training_202605.Applications.Services;
using Csharp_training_202605.Presentations.Controllers;

namespace Csharp_training_202605.Controllers;

public class EmployeeRegisterController : Controller
{
   /// <summary>
    /// ロガー
    /// </summary>
    private readonly ILogger<EmployeeRegisterController> _logger;
    /// <summary>
    /// 従業員登録サービスインターフェイス
    /// </summary>
    private readonly IEmployeeRegisterService _employeeRegisterService;
    /// <summary>
    /// 従業員登録ViewModelをEmployeeに変換するアダプター
    /// </summary>
    private readonly EmployeeRegisterViewModelAdapter _adapter;
    /// <summary>
    /// TempDataを通じて一時的にViewModelを保存・復元するためのクラス
    /// </summary>
    private readonly  TempDataStore<EmployeeRegisterViewModel> _deptDataStore;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="logger">ロガー</param>
    /// <param name="employeeRegisterService">従業員登録サービスインターフェイス</param>
    /// <param name="employeeRegisterViewModelAdapter">従業員登録ViewModelをEmployeeに変換するアダプター</param>
    /// <param name="empDataStore">TempDataを通じて一時的にViewModelを保存・復元するためのクラス</param>
    public EmployeeRegisterController(
        ILogger<EmployeeRegisterController> logger,
        IEmployeeRegisterService employeeRegisterService,
        DepartmentRegisterViewModelAdapter employeeRegisterViewModelAdapter,
        TempDataStore<EmployeeRegisterViewModel> empDataStore)
    {
        _logger = logger;
        _employeeRegisterService = employeeRegisterService;
        _adapter = employeeRegisterViewModelAdapter;
        _deptDataStore = empDataStore;
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