using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Csharp_training_202605.Models;
using Microsoft.Extensions.Logging;

namespace Csharp_training_202605.Controllers;

            
public class DepartmentListController : Controller
{
    // private readonly ILogger<DepartmentListController> _logger;
    // /// <summary>
    // /// 従業員登録サービスインターフェイス
    // /// </summary>
    // private readonly IDepartmentListService _employeeRListService;
    // /// <summary>
    // /// 従業員登録ViewModelをEmployeeに変換するアダプター
    // /// </summary>
    // private readonly DepartmentListViewModelAdapter _adapter;
    // /// <summary>
    // /// TempDataを通じて一時的にViewModelを保存・復元するためのクラス
    // /// </summary>
    // private readonly  TempDataStore<EDepartmentListViewModel> _empDataStore;

    // /// <summary>
    // /// コンストラクタ
    // /// </summary>
    // /// <param name="logger">ロガー</param>
    // /// <param name="employeeListService">従業員登録サービスインターフェイス</param>
    // /// <param name="employeeListViewModelAdapter">従業員登録ViewModelをEmployeeに変換するアダプター</param>
    // /// <param name="empDataStore">TempDataを通じて一時的にViewModelを保存・復元するためのクラス</param>
    // public DepartmentListController(
    //     ILogger<EmployeeListController> logger,
    //     IDepartmentListService employeeListService,
    //     DepartmentListViewModelAdapter employeeListViewModelAdapter,
    //     TempDataStore<DepartmentListViewModel> empDataStore)
    // {
    //     _logger = logger;
    //     _employeeListService = employeeRListService;
    //     _adapter = employeeListViewModelAdapter;
    //     _empDataStore = empDataStore;
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