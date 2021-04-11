using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

public partial class admin_addkaoqint : System.Web.UI.Page
{
    string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            id = Session["id"].ToString();

        }
        catch (Exception)
        {
            Response.Write("<script>alert('长时间未操作请重新登陆')</script>");
            Response.Redirect("~/Login.aspx");
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
         Attendance att = new Attendance();
         att.UserId = Convert.ToInt32(txtNickName.Text);
         att.AtId = Convert.ToInt32(DropDownList1.SelectedValue);
         att.Record = Convert.ToDateTime(TextBox1.Text);
         att.AtUserID=Convert.ToInt32(id);
         if (BLL.AdminManager.Addat(att) == 1)
         {
             Response.Write("<script>alert('成功')</script>");
         }
         else
         {
             Response.Write("<script>alert('失败')</script>");
         }
    }
}