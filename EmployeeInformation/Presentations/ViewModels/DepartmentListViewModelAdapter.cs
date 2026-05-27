using Csharp_training_202605.Applications.Adapters;
using Csharp_training_202605.Applications.Domains;
namespace Csharp_training_202605.Presentations.ViewModels;

public class DepartmentListViewModelAdapter : IRestorer<Department, DepartmentListViewModel> ,IConverter<Department, DepartmentListViewModel>
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
 

    public static implicit operator DepartmentListViewModelAdapter(DepartmentRegisterViewModelAdapter v)
    {
        throw new NotImplementedException();
    }


    public DepartmentListViewModel Convert(Department department)
    {
        //リターン用の変数
       var departmentListViewModel = new DepartmentListViewModel();
        int? no = department.Id;
        string? name =  department.Name;
    //departmentListViewModelのプロパティに値をセットする
    departmentListViewModel.DeptId = no;
    departmentListViewModel.DeptName = name;
       return departmentListViewModel;
    }

    
}