using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_用户控件_WebUserControl : System.Web.UI.UserControl
{
    public int a;
    protected void Page_Load(object sender, EventArgs e)
    {
        AspNetPagerBind();
    }
    public void AspNetPagerBind()
    {
        this.rptList.DataSource = BLL.AdminManager.SelectAllInfobyshu(a);
        this.rptList.DataBind();
    }
}