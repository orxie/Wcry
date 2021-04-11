using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using System.Data;

public partial class admin_SelectALLUser : System.Web.UI.Page
{
    static int pageindex=10;
   protected void Page_Load(object sender, EventArgs e)
   {
       //绑定下拉框
       DataTable dt = BLL.UserManager.SelectBmleibie();
       ddlbm.DataSource = dt;
       ddlbm.DataValueField = dt.Columns[0].ColumnName;
       ddlbm.DataTextField = dt.Columns[1].ColumnName;
       ddlbm.DataBind();

   }

   //AspNetPager分页控件的数据绑定
   public void AspNetPagerBind()
   {
       //第一步，找到绑定数据赋值给dt
       DataTable dt = BLL.AdminManager.SelectAllInfo();
       //将当前数据源中的总条数赋值给分页控件的总条数
       this.AspNetPager1.RecordCount = dt.Rows.Count;
       //实例化分页数据源控件
       PagedDataSource psd = new PagedDataSource();
       //启动分页功能
       psd.AllowPaging = true;
       //将分页控件页数复制给分页数据源控件
       psd.PageSize = this.AspNetPager1.PageSize;
       //当前页索引复制
       psd.CurrentPageIndex = this.AspNetPager1.CurrentPageIndex - 1;
       //重新赋值为页面级视图
       psd.DataSource = dt.DefaultView;
       this.rptList.DataSource = psd;
       this.rptList.DataBind();
      
   }
   protected void AspNetPager1_PageChanged(object sender, EventArgs e)
   {
       lbtnSearch_Click( sender, e);
   }

    protected void lbtnSearch_Click(object sender, EventArgs e)
    {
        UserInfo user = new UserInfo();
        user.Name = txtuser_name.Text;
        user.ID = txtuser_id.Text;
        user.IdCard = txtuser_idCard.Text;
        user.TelePhone = txtuser_telePhone.Text;
        user.Department = ddlbm.SelectedValue;
        //第一步，找到绑定数据赋值给dt
        DataTable dt = BLL.AdminManager.SelectMhcx(user);
        //将当前数据源中的总条数赋值给分页控件的总条数
        this.AspNetPager1.RecordCount = dt.Rows.Count;
        //实例化分页数据源控件
        PagedDataSource psd = new PagedDataSource();
        //启动分页功能
        psd.AllowPaging = true;
        //将分页控件页数复制给分页数据源控件
        psd.PageSize = this.AspNetPager1.PageSize;
        //当前页索引复制
        psd.CurrentPageIndex = this.AspNetPager1.CurrentPageIndex - 1;
        //重新赋值为页面级视图
        psd.DataSource = dt.DefaultView;
        this.rptList.DataSource = psd;
        this.rptList.DataBind();
        
    }
    protected void txtPageNum_TextChanged(object sender, EventArgs e)
    {

        if (string.IsNullOrWhiteSpace(txtPageNum.Text))
        {
            pageindex = 10;
        }

        pageindex = Convert.ToInt32(txtPageNum.Text);
        AspNetPager1.PageSize = pageindex;
        AspNetPagerBind();
    }
    protected void rptList_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "delete")
        {
            string id = e.CommandArgument.ToString();
            if (BLL.AdminManager.daleteUser(id) == 1)
            {
                Response.Redirect("~/admin/SelectALLUser.aspx");
            }
        }
    }
}