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
    static int pageindex = 10;
    protected void Page_Load(object sender, EventArgs e)
    {


        if (!IsPostBack)
        {
            //给Repeater绑定数据
            txtPageNum.Text = pageindex.ToString();
            AspNetPager1.PageSize = pageindex;
            AspNetPagerBind();
            AspNetPager1_PageChanged(sender, e);
        }

    }

    //AspNetPager分页控件的数据绑定
    public void AspNetPagerBind()
    {
        //第一步，找到绑定数据赋值给dt
        DataTable dt = BLL.AdminManager.SelectAllTrain();
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
        AspNetPagerBind();
    }

    protected void lbtnDelCa_Click(object sender, EventArgs e)
    {
    }
    protected void lbtnSearch_Click(object sender, EventArgs e)
    {


    }
    protected void txtPageNum_TextChanged(object sender, EventArgs e)
    {

    }
    protected void rptList_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "delete")
        {
            string id = e.CommandArgument.ToString();
            Train tr = new Train();
            tr.TrainId = Convert.ToInt32( id);
            tr.State = 2;
            if (BLL.AdminManager.updateStateByid(tr) == 1)
            {
                Response.Redirect("~/admin/TrainUser.aspx");
            }
        }
        if (e.CommandName == "xiugai")
        {
            string id = e.CommandArgument.ToString();
            Train tr = new Train();
            tr.TrainId = Convert.ToInt32(id);
            tr.State = 1;
            if (BLL.AdminManager.updateStateByid(tr) == 1)
            {
                Response.Redirect("~/admin/TrainUser.aspx");
            }
        }
    }
}