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

    /// <summary>
    /// 空参构造
    /// </summary>
    public Manager()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    /// <summary>
    /// 全参构造
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="pwd"></param>
    /// <param name="level"></param>
    /// <param name="last_login"></param>
    /// <param name="reg_time"></param>
    /// <param name="status"></param>
    public Manager(string id, string name, string pwd, int level, string last_login, string reg_time, int status)
    {
        this.id = id;
        this.name = name;
        this.pwd = pwd;
        this.level = level;
        this.last_login = last_login;
        this.reg_time = reg_time;
        this.status = status;
    }

    /// <summary>
    /// getter setter方法
    /// </summary>
    public string Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }
    public string Pwd { get => pwd; set => pwd = value; }
    public int Level { get => level; set => level = value; }
    public string Last_login { get => last_login; set => last_login = value; }
    public string Reg_time { get => reg_time; set => reg_time = value; }
    public int Status { get => status; set => status = value; }
}