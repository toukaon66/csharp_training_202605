using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Csharp_training_202605.Applications.Domains;
namespace Csharp_training_202605.Presentations.ViewModels;

public class DepartmentListViewModel
{
    [Display(Name = "部署名")]
    public string? Name { get; set; } = string.Empty;

     [Display(Name = "部署番号")]
    public int? DeptId { get; set; } = 0;


    public void SetDepartments(List<Department> departments)
    {
        // SelectListItemのリストを作成
        var selectItems = new List<SelectListItem>();
        foreach (var dept in departments)
        {
            if (dept.Id.HasValue)
            {
                var item = new SelectListItem();
                item.Value = dept.Id.Value.ToString();
                item.Text = string.IsNullOrEmpty(dept.Name) ? "(名称未設定)" : dept.Name;
                selectItems.Add(item);
            }
        }
        Departments = selectItems;
    }
}
