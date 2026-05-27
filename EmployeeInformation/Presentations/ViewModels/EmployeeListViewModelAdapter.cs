using Csharp_training_202605.Applications.Adapters;
using Csharp_training_202605.Applications.Domains;
namespace Csharp_training_202605.Presentations.ViewModels;

public class EmployeeListViewModelAdapter : IRestorer<Department, DepartmentListViewModel>
{
    /// <summary>
    /// EmployeeRegisterViewModelをドメインオブジェクト:Employeeに変換する
    /// </summary>
    /// <param name="target">EmployeeRegisterViewModel</param>
    /// <returns>ドメインオブジェクト:Employee</returns>
    public Department Restore(DepartmentListViewModel target)
    {
        // Department(部署)を作成する
        var department = new Department(target.DeptName);
        return department;

    }


    public static implicit operator EmployeeListViewModelAdapter(EmployeeRegisterViewModelAdapter v)
    {
        throw new NotImplementedException();
    }


    public EmployeeListViewModel Convert(Employee employee)
    {
        //リターン用の変数
        var employeeListViewModel = new EmployeeListViewModel();
        int? no = employee.Id;
        string name = employee.Name;
        Department? department = employee.Department;
        string? dname = department?.Name;
        //departmentListViewModelのプロパティに値をセットする
        employeeListViewModel.Id = no;
        employeeListViewModel.Name = name;
        employeeListViewModel.DeptId = department;
        employeeListViewModel.DeptName = dname;
        return employeeListViewModel;
    }


}