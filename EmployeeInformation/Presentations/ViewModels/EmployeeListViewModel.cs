using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Csharp_training_202605.Applications.Domains;
using System.Collections.Generic;
namespace Csharp_training_202605.Presentations.ViewModels;
/// <summary>
/// 部署登録ViewModelクラス
/// </summary>
public class EmployeeListViewModel
{
    [Display(Name = "社員ID")]
    public int? Id { get; set; } = 0;
    [Display(Name = "氏名")]
    public string? Name { get; set; } = string.Empty;

     [Display(Name = "部署番号")]
    public Department? DeptId { get; set; } 

     [Display(Name = "所属部署")]
    public string? DeptName { get; set; } = string.Empty;


    public void SetEmployees(List<Employee> employees)
    {
        // SelectListItemのリストを作成
        var EmployeeList = new List<SelectListItem>();
        foreach (var emp in employees)
        {
            if (emp.Id.HasValue)
            {
                var item = new SelectListItem();
                item.Value = emp.Id.Value.ToString();
                item.Text = string.IsNullOrEmpty(emp.Name) ? "(名称未設定)" : emp.Name;
                EmployeeList.Add(item);
            }
        }
        Employees = EmployeeList;
    }
    

    public List<SelectListItem>? Employees { get; set; } = null;

    public override string ToString()
    {
        return $" Id={Id} , Name={Name} , Department={DeptName}";
    }
}

