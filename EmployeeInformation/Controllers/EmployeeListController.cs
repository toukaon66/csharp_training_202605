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
[Route("DepartmentList")]
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
        ILogger<DepartmentListController> logger,
        IDepartmentListService employeeListService,
        DepartmentListViewModelAdapter departmentListViewModelAdapter)
    {
        _logger = logger;
        _employeeListService = employeeListService;
        _adapter = departmentListViewModelAdapter;
        
    }
    [HttpGet("Enter")]
    public IActionResult Enter()
    {

        var departments = _EmployeeListService.GetDepartments();
        var results = new List<DepartmentListViewModel>();
        //ドメインからビューモデルにアダプターで変換
        foreach (var department in departments)
        {
            results.Add(_adapter.Convert(department));
        }
        return View(results);
        // viewModelをviewに渡して画面表示する

    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    private void PopulateDepartments(EmployeeRegisterViewModel viewModel)
    {
        // 従業員登録サービスから部署一覧を取得する
        var departments = _departmentListService.GetDepartments();
        // 部署一覧をEmployeeRegisterViewModelに登録する
        viewModel.SetDepartments(departments);
    }
}