using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// SystemLoad 的摘要说明
/// </summary>
public class SystemLoad
{
    public SystemLoad()
    {
        
    }


    /// <summary>
    /// 获取用户名
    /// </summary>
    /// <param name="m_id">用户id</param>
    /// <returns>用户名</returns>
    public string GetUserName(int m_id)
    {
        string cmdStr = "select m_name from [manager] where m_id=" + m_id + "and m_status=1";
        try
        {
            string res = DAO.dbTools.GetObject(cmdStr).ToString();
            return res;
        }
        catch (Exception e)
        {
            System.Diagnostics.Debug.WriteLine(e.ToString());
            return null;
        }
    }
}