using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Manager 的摘要说明
/// </summary>
public class Manager
{
    private string id;          //工号
    private string name;        //姓名
    private string pwd;         //密码
    private int level;          //权限级别
    private string last_login;  //最后登陆时间
    private string reg_time;    //注册时间
    private int status;         //账号状态

    public Manager()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
}