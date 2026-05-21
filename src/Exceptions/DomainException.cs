using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_Sample.Exceptions;
/// <summary>
/// ドメインルール違反を表す例外クラス
/// </summary>
public class DomainException : Exception
{
    public DomainException(string message) 
    : base() {}
    public DomainException(string message, Exception innerException) 
    : base(message, innerException) {}
}