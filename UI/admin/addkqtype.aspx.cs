using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

public partial class admin_addkqtype : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        AttendanceInfo att = new AttendanceInfo();
        att.Name = txtNickName.Text;
        att.Introduce = txtAddress.Text;
        if (rblSex.SelectedValue == "加分")
        {
            att.Praise = Convert.ToInt32(TextpassWord.Text);
            att.Punish = 0;
        }
        else
        {
            att.Punish = Convert.ToInt32(TextpassWord.Text);
            att.Praise = 0;
        }
        if (BLL.AdminManager.addATTTYPE(att) == 1)
        {
            Response.Write("<script>alert('成功')</script>");
            txtNickName.Text = "";
            txtAddress.Text = "";
            TextpassWord.Text = "";
        }
        else
        {
            Response.Write("<script>alert('失败')</script>");
        }
    }
}