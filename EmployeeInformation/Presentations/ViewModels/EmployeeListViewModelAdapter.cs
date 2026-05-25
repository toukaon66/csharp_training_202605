using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Csharp_training_202605.Applications.Domains;
using Csharp_training_202605.Applications.Adapters;

namespace Csharp_training_202605.Presentations.ViewModels;
/// <summary>
/// 部署登録ViewModelクラス
/// </summary>
// public class EmployeeListViewModelAdapter: IRestorer<Employee, EmployeeListViewModel>
// {
    //  public Employee Restore(EmployeeListViewModelAdapter target)
    //  {
        // // Department(部署)を作成する
        // var department = new Department(target.DeptId!.Value,target.DeptName);
        // // 登録するEmployee(従業員)を作成する
        // var employee = new Employee(target.Name!, department);
        // return employee;
    //  }

    // public static implicit operator EmployeeListViewModelAdapter(DepartmentRegisterViewModelAdapter v)
    // {
    //     throw new NotImplementedException();
    //}
// }