using Csharp_training_202605.Applications.Domains;
namespace Csharp_training_202605.Applications.Services;

/// <summary>
/// 従業員登録サービスインターフェイス
/// </summary>
public interface IEmployeeListService 
{
    /// <summary>
    /// すべての部署を取得する
    /// </summary>
    /// <returns></returns>
    List<Department> GetDepartments();
    List<Employee> GetEmployees();
}