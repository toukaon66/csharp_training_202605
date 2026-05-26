using Csharp_training_202605.Applications.Repositories;
using Csharp_training_202605.Applications.Domains;
using Csharp_training_202605.Exceptions;
using Csharp_training_202605.Infrastructures.Context;
using Csharp_training_202605.Applications.Services;
namespace Csharp_training_202605.Applications.Services.Impls;
/// <summary>
/// 従業員登録サービスインターフェイスの実装
/// </summary>
public class EmployeeListService : IEmployeeListService
{

    /// <summary>
    /// アプリケーション用DbContext
    /// </summary>
    private readonly AppDbContext _context;
    /// <summary>
    /// ドメインオブジェクト:部署のCRUD操作インターフェイス
    /// </summary>
    private readonly IDepartmentRepository _departmentRepository;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="context">アプリケーション用DbContext</param>
    /// <param name="departmentRepository">部署のCRUD操作インターフェイス</param>
    public EmployeeListService(
        AppDbContext context,
        IDepartmentRepository departmentRepository)
    {
        _context = context;
        _departmentRepository = departmentRepository;
    }

    /// <summary>
    /// すべての部署を取得する
    /// </summary>
    /// <returns></returns>
    public List<Department> GetDepartments()
    {
        return _departmentRepository.FindAll();
    }

    public List<Employee> GetEmployees()
    {
        throw new NotImplementedException();
    }
}