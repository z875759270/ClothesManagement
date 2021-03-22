using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        ManagerMis managerMis = new ManagerMis();
        string uname = tbxUsername.Text.Trim();
        //将用户密码使用MD5机制进行存储至数据库
        //string upsw = FormsAuthentication.HashPasswordForStoringInConfigFile(tbxPsw.Text.Trim(), "MD5").ToLower();
        string upsw = tbxPsw.Text.Trim();

        int login_res = managerMis.CheckUser(uname, upsw);
        if (login_res != -1)
        {
            string temp = FormsAuthentication.HashPasswordForStoringInConfigFile(login_res.ToString().Trim(), "MD5").ToLower();
            Session["UserID"] = login_res;
            Session["UserName"] = uname;
            Response.Redirect("index.aspx?id=" + temp);
        }
        else
        {
            lblLoginError.Text = "登陆失败！检查用户名或密码！";
        }
    }
}