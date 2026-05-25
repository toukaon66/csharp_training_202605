using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Csharp_training_202605.Applications.Domains;
namespace Csharp_training_202605.Presentations.ViewModels;
/// <summary>
/// 部署登録ViewModelクラス
/// </summary>
public class DepartmentRegisterViewModel
{
    /// <summary>
    ///部署名
    /// </summary>
    [Display(Name = "部署名")]
     [StringLength(20, ErrorMessage = "氏名は20文字以内で入力してください")]
    [Required(ErrorMessage = "{0}は入力必須です。")]
    public string? DeptName { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"Name={DeptName} ";
    }
}
