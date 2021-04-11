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
        //首先获取上传控件中文件的地址
        string fullfilenam = FileUpload1.PostedFile.FileName;
        //其次从上传的路径中获取文件名，采用字符串分割的方法
        string filename = fullfilenam.Substring(fullfilenam.LastIndexOf("\\") + 1);
        //分割上传文件的后缀，用来限制上传文件格式
        string type = fullfilenam.Substring(fullfilenam.LastIndexOf(".") + 1);
        //判断文件上传的后缀名类型 ,当前格式可以自定义，写出自己需要的格式即可
        if (type == "xls" || type == "doc" || type == "jpg" || type == "png")
        {
            //将文件保存在当前服务器路径中自己新建的文件(file)中
            //将当前文件保存的路径做一个完整拼接。用于待会存放数据库
            string savefilename = Server.MapPath("~/images") + "\\" + filename;
            if (savefilename == "")
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript'>alert('当前文件路径不存在')</script>");
                return;
            }
            //将文件进行保存操作
            FileUpload1.PostedFile.SaveAs(savefilename);

            //将当前文件信息全部保存到数据库中，用于下载的时候进行读取
            banner bann = new banner();
            bann.Banner_bg = filename;
            bann.Banner_text =txttitle.Text;
            bann.Banner_text1 = TextBox1.Text;

            //执行添加操作
            if (BLL.AdminManager.AddBanner(bann)>0)
            {
                //弹出对话框表示文件保存成功
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript'>alert('文件上传成功')</script>");
                txttitle.Text = "";
                TextBox1.Text = "";
            }

        }
        else
        {
            //给出文件上传失败的提示
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript'>alert('文件上传失败')</script>");

        }
    }
}