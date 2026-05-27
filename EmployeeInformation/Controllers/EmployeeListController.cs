using Csharp_training_202605.Applications.Services;
using Csharp_training_202605.Presentations.ViewModels;
using Csharp_training_202605.Applications.Services.Impls;
using Csharp_training_202605.Presentations.Controllers;
using Microsoft.AspNetCore.Mvc;
using Csharp_training_202605.Models;
using System.Diagnostics;
namespace Csharp_training_202605.Presentations.Controllers;
/// <summary>
/// 従業員登録コントローラ
/// </summary>
[Route("EmployeeList")]
public class EmployeeListController : Controller
{
    /// <summary>
    /// ロガー
    /// </summary>
    private readonly ILogger<EmployeeListController> _logger;
    /// <summary>
    /// 従業員登録サービスインターフェイス
    /// </summary>
    private readonly IEmployeeListService _employeeListService;

    /// <summary>
    /// 従業員登録ViewModelをEmployeeに変換するアダプター
    /// </summary>
    private readonly EmployeeListViewModelAdapter _adapter;
    /// <summary>
    /// TempDataを通じて一時的にViewModelを保存・復元するためのクラス
    /// </summary>

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="logger">ロガー</param>
    /// <param name="employeeRegisterService">従業員登録サービスインターフェイス</param>
    /// <param name="employeeRegisterViewModelAdapter">従業員登録ViewModelをEmployeeに変換するアダプター</param>
    /// <param name="empDataStore">TempDataを通じて一時的にViewModelを保存・復元するためのクラス</param>
    public EmployeeListController(
        ILogger<EmployeeListController> logger,
        IEmployeeListService employeeListService,
        EmployeeListViewModelAdapter employeeListViewModelAdapter)
    {
        _logger = logger;
        _employeeListService = employeeListService;
        _adapter = employeeListViewModelAdapter;
        
    }
    [HttpGet("Enter")]
    public IActionResult Enter()
    {

        var employees = _employeeListService.GetEmployees();
        var results = new List<EmployeeListViewModel>();
        //ドメインからビューモデルにアダプターで変換
        foreach (var employee in employees)
        {
            
            results.Add(_adapter.Convert(employee,employee.Department!));
        }
        return View(results);
        // viewModelをviewに渡して画面表示する

    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    private void PopulateDepartments(EmployeeListViewModel viewModel)
    {
        // 従業員登録サービスから部署一覧を取得する
        var departments = _employeeListService.GetDepartments();
        var employees = _employeeListService.GetEmployees();
        // 部署一覧をEmployeeRegisterViewModelに登録する
        viewModel.SetEmployees(employees);
    }
}