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
        if (!IsPostBack)
        {
           string id  = Request.QueryString["UID"];
            AttendanceInfo user1 = BLL.AdminManager.SelectattInfoByid(id);
            txtNickName.Text = user1.Name;
            txtAddress.Text = user1.Introduce;
            if (user1.Punish == 0)
            {
                rblSex.SelectedValue = "加分";
                TextpassWord.Text = user1.Praise.ToString();
            }
            else 
            {
                rblSex.SelectedValue = "减分";
                TextpassWord.Text = user1.Punish.ToString();
            }
        }
       
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        AttendanceInfo att = new AttendanceInfo();
        att.AtId = Convert.ToInt32( Request.QueryString["UID"]);
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
        if (BLL.AdminManager.upatttapyByID(att) == 1)
        {
            Response.Write("<script>alert('成功')</script>");

        }
        else
        {
            Response.Write("<script>alert('失败')</script>");
        }
    }
}