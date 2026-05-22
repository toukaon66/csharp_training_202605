using Csharp_training_202605.Applications.Domains;
namespace Csharp_training_202605.Applications.Services;
/// <summary>
/// 従業員登録サービスインターフェイス
/// </summary>
public interface IDepartmentRegisterService 
{
    /// <summary>
    /// 新しい部署を登録する
    /// </summary>
    /// <param name="department"></param>
    void Register(Department department);
}