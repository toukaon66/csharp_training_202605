using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Csharp_training_202605.Applications.Domains;
using System.Collections.Generic;
namespace Csharp_training_202605.Presentations.ViewModels;

public class DepartmentListViewModel
{
    [Display(Name = "部署名")]
    public string? DeptName { get; set; } = string.Empty;

     [Display(Name = "部署番号")]
    public int? DeptId { get; set; } = 0;


    public void SetDepartments(List<Department> departments)
    {
        // SelectListItemのリストを作成
        var DepartmentsList = new List<SelectListItem>();
        foreach (var dept in departments)
        {
            if (dept.Id.HasValue)
            {
                var item = new SelectListItem();
                item.Value = dept.Id.Value.ToString();
                item.Text = string.IsNullOrEmpty(dept.Name) ? "(名称未設定)" : dept.Name;
                DepartmentsList.Add(item);
            }
        }
        Departments = DepartmentsList;
    }

    public List<SelectListItem>? Departments { get; set; } = null;

    public override string ToString()
    {
        return $" DeptId={DeptId} , DeptName={DeptName} , Departments={Departments}";
    }
}
