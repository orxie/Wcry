using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_admin_renzi : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
      
    }
    protected void lbtnExit_Click(object sender, EventArgs e)
    {
        Session["id"] = "";
        Response.Write("<script>parent.location.href='/Login.aspx'</script>");
        Response.End();
    }
}   
