using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// ManagerMis 的摘要说明
/// </summary>
public class ManagerMis
{
    public ManagerMis()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    #region 业务逻辑层
    /// <summary>
    /// 用户登录
    /// </summary>
    /// <param name="uName">用户名</param>
    /// <param name="uPsw">密码</param>
    /// <returns name="x">返回该用户ID</returns>
    public int CheckUser(string uName, string uPsw)
    {
        try
        {
            string cmdStr = "select * from [manager] where m_name=@Account and m_pwd=@Password and m_status=1";
            SqlParameter[] paras = new SqlParameter[] {
            new SqlParameter("Account",uName),
            new SqlParameter("Password",uPsw)
            };
            DataTable dt = DAO.dbTools.GetTable(cmdStr, paras);
            int x = Convert.ToInt32(dt.Rows[0][0].ToString());
            if (x > 0)
            {
                return x;
            }
            else
                return -1;
        }
        catch (Exception e)
        {
            System.Diagnostics.Debug.WriteLine("error:" + e);
            return -1;
        }
    }
    #endregion
}