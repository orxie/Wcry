using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

public partial class MyInfo : System.Web.UI.Page
{

    string id;
    protected void Page_Load(object sender, EventArgs e)
    {
        Init();
    }
    //页加载
    private void Init() 
    {
        id = Session["id"].ToString();
        UserInfo user = BLL.UserManager.SelectAllInfoByName(id);
        Litreal_name.Text = user.Name;
        Lituser_name.Text = user.ID.ToString();
        litzw.Text = user.Post;
        Litdepot_category_name.Text = user.Department;
        
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        UserInfo user = new UserInfo();
        user.ID = id;
        user.PassWord = this.txtPassword1.Text;
        if (BLL.AdminManager.updatePassByID(user) == 1)
        {
            ClientScript.RegisterStartupScript(typeof(string), "print", "<script>alert('" + "修改成功" + "');window.location.href ='MyInfo.aspx'</script>");
        }
        else {
            Response.Write("<script>alert('登录失败,帐号或密码错误！')</script>");
        }
    }
}