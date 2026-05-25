using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Csharp_training_202605.Models;
using Microsoft.Extensions.Logging;
using Csharp_training_202605.Presentations.Controllers;
using Csharp_training_202605.Presentations.ViewModels;

namespace Csharp_training_202605.Controllers;

public class EmployeeListController : Controller
{
    // /// <summary>
    // /// ロガー
    // /// </summary>
    // private readonly ILogger<EmployeeListController> _logger;
    // /// <summary>
    // /// 従業員登録サービスインターフェイス
    // /// </summary>
    // private readonly IEmployeeListService _EmployeeListService;
    // /// <summary>
    // /// 従業員登録ViewModelをEmployeeに変換するアダプター
    // /// </summary>
    // private readonly EmployeeListViewModelAdapter _adapter;
    // /// <summary>
    // /// TempDataを通じて一時的にViewModelを保存・復元するためのクラス
    // /// </summary>
    // private readonly  TempDataStore<EmployeeListViewModel> _deptDataStore;

    // /// <summary>
    // /// コンストラクタ
    // /// </summary>
    // /// <param name="logger">ロガー</param>
    // /// <param name="employeeRegisterService">従業員登録サービスインターフェイス</param>
    // /// <param name="employeeRegisterViewModelAdapter">従業員登録ViewModelをEmployeeに変換するアダプター</param>
    // /// <param name="empDataStore">TempDataを通じて一時的にViewModelを保存・復元するためのクラス</param>
    // public EmployeeListController(
    //     ILogger<EmployeeListController> logger,
    //     IEmployeeListService employeeListService,
    //     DepartmentRegisterViewModelAdapter employeeListViewModelAdapter,
    //     TempDataStore<EmployeeListViewModel> empDataStore)
    // {
    //     _logger = logger;
    //     _employeeListService = employeeListService;
    //     _adapter = employeeListViewModelAdapter;
    //     _deptDataStore = empDataStore;
    // }

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