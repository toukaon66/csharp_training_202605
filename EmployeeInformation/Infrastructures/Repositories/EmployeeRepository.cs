using Csharp_training_202605.Infrastructures.Context;
using Csharp_training_202605.Applications.Domains;
using Csharp_training_202605.Applications.Repositories;
using Csharp_training_202605.Infrastructures.Adapters;
using Csharp_training_202605.Exceptions;
using System;
namespace Csharp_training_202605.Infrastructures.Repositories;
/// <summary>
/// ドメインオブジェクト:従業員のCRUD操作インターフェイスの実装
/// </summary>
public class EmployeeRepository : IEmployeeRepository
{
    /// <summary>
    /// アプリケーション用DbContext
    /// </summary>
    private readonly AppDbContext _context;
    /// <summary>
    /// ドメインモデル:従業員と従業員エンティティの相互変換インターフェイスの実装
    /// </summary>
    private readonly EmployeeEntityAdapter _adapter;
    
    private readonly DepartmentEntityAdapter _dptAdapter;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="context"></param>
    /// <param name="adapter"></param>
    public EmployeeRepository(AppDbContext context, EmployeeEntityAdapter adapter,DepartmentEntityAdapter dptAdapter)
    {
        _context = context;
        _adapter = adapter;
        _dptAdapter = dptAdapter;
    }

    /// <summary>
    /// 従業員を永続化する
    /// </summary>
    /// <param name="employee">永続化対象の従業員</param>
    public void Create(Employee employee)
    {
        try
        {
            var entity = _adapter.Convert(employee);
            _context.Employees.Add(entity);
            _context.SaveChanges();
        }
        catch (Exception e)
        {
            throw new InternalException(
                "従業員の永続化ができませんでした。", e);
        }
    }

    public Employee? FindById(int id)
    {
        try
        {
            var result = _context.Employees.FirstOrDefault(e => e.EmpId == id);
            if (result == null)
            {
                return null;
            }
            return _adapter.Restore(result);
        }
        catch (Exception e)
        {
            throw new InternalException(
                "指定された従業員Idの従業員を取得できませんでした。", e);
        }
    }

     public List<Department> FindAll()
    {
        try
        {
            var entities = _context.Departments.ToList();
            var results = new List<Department>();
            foreach (var entity in entities)
            {
                results.Add(_dptAdapter.Restore(entity));
            }   
            return results;
        }
        catch (Exception e)
        {
            throw new InternalException(
                "すべての部署を取得できませんでした。", e);
        }
    }

}