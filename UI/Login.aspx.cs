using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }


    protected void Button1_Click1(object sender, EventArgs e)
    {
        if (this.Yhid.Text != "" && this.Sex.Text != "")
        {
            UserInfo US = new UserInfo();
            US.PassWord = Sex.Text.Trim();
            US.ID = Yhid.Text;
            if (UserManager.UserLogin(US) == 1)
            {
                Session["id"] = US.ID;
                this.Yhid.Text = "";
                this.Sex.Text = "";

                // 权限判定
                switch (UserManager.UserAuthority(US))
                {
                    case 1:
                        ///前台管理
                        Response.Redirect("~/admin/banner.aspx");
                        break;
                    case 2:
                        ///人资管理
                        Response.Redirect("~/admin/SelectALLUser.aspx");
                        break;
                    case 3:
                        ///考勤管理
                        Response.Redirect("~/admin/Msg.aspx");
                        break;
                    default:
                        Response.Redirect("~/UserInfoManager.aspx");
                        break;
                }
            }

            else
            {
                Response.Write("<script>alert('登录失败,帐号或密码错误！')</script>");
            }
        }
        else
        {
            Response.Write("<script>alert('密码或用户名不能为空');</script>");
        }
    }
}
