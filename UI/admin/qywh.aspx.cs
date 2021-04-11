using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

public partial class admin_banner : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnfile_Click(object sender, EventArgs e)
    {
        
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
            qy qywh=new qy();
            qywh.Qywh = txttitle.Text;
            qywh.Qywhxq = TextBox1.Text;
            if (BLL.AdminManager.Addqywh(qywh) == 1)
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript'>alert('添加成功')</script>");
                txttitle.Text = "";
                TextBox1.Text = "";
            }
            else 
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript'>alert('添加失败')</script>");
            }
           
    }
}