using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_Performance : System.Web.UI.Page
{
    static int pageindex = 10;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //给Repeater绑定数据
            txtPageNum.Text = pageindex.ToString();
            AspNetPager2.PageSize = pageindex;
            AspNetPagerBind();
            AspNetPager1_PageChanged(sender, e);
        }
    }
    //AspNetPager分页控件的数据绑定
    public void AspNetPagerBind()
    {
        //第一步，找到绑定数据赋值给dt
        DataTable dt = BLL.AdminManager.SelectAllPerformance();
        //将当前数据源中的总条数赋值给分页控件的总条数
        this.AspNetPager2.RecordCount = dt.Rows.Count;
        //实例化分页数据源控件
        PagedDataSource psd = new PagedDataSource();
        //启动分页功能
        psd.AllowPaging = true;
        //将分页控件页数复制给分页数据源控件
        psd.PageSize = this.AspNetPager2.PageSize;
        //当前页索引复制
        psd.CurrentPageIndex = this.AspNetPager2.CurrentPageIndex - 1;
        //重新赋值为页面级视图
        psd.DataSource = dt.DefaultView;
        this.rptList.DataSource = psd;
        this.rptList.DataBind();
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        AspNetPagerBind();
    }

}