using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// 自定义异常基类
/// </summary>
public class MisException : Exception
{
    public MisException(string msg) : base(msg)
    {
        
    }


}