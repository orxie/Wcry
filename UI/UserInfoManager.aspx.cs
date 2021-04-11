using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using System.Data;

using System.Web.Script.Serialization;

public partial class UserInfoManager : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        init();
     
    }
   
    private void init() 
    {
        string id = "";
        try
        {
             id = Session["id"].ToString();

        }
        catch (Exception e)
        {
            Response.Write("<script>alert('长时间未操作请重新登陆')</script>");
            Response.Redirect("~/Login.aspx");
        }
       
        //绑定banner
        DataTable datab = BLL.UserManager.Selectbanner();

        string s1 = datab.Rows[3][0].ToString();
        string[] s11 = s1.Split('/');
        imgbg_1.Src = "~/images/" + s11[s11.Length - 1];
        BannerH1_3.InnerText = datab.Rows[0][1].ToString();
        BannerH3_3.InnerText = datab.Rows[0][2].ToString();

        string s2 = datab.Rows[1][0].ToString();
        string[] s21 = s2.Split('/');
        imgbg_2.Src = "~/images/" + s21[s21.Length - 1];
        BannerH1_2.InnerText = datab.Rows[1][1].ToString();
        BannerH3_2.InnerText = datab.Rows[1][2].ToString();

        string s3 = datab.Rows[2][0].ToString();
        string[] s31 = s3.Split('/');
        imgbg_3.Src = "~/images/" + s31[s31.Length - 1];
        BannerH1_1.InnerText = datab.Rows[2][1].ToString();
        BannerH3_1.InnerText = datab.Rows[2][2].ToString();

        string s4 = datab.Rows[0][0].ToString();
        string[] s41 = s4.Split('/');
        imgbg_4.Src = "~/images/" + s41[s41.Length - 1];
        
        //绑定培训计划
        Repeater1.DataSource = BLL.UserManager.SelectAllTrain();
        Repeater1.DataBind();
        
        //绑定请假信息
        Repeater2.DataSource = BLL.UserManager.SelectAllMsg();
        Repeater2.DataBind();
        
        //绑定员工信息
        UserInfo user = BLL.UserManager.SelectAllInfoByName(id);
        Label1.Text = user.ID;
        Label2.Text = user.Name;
        Label3.Text = user.Sex;
        Label5.Text = user.TelePhone;
        Label6.Text = user.Email;
        Label7.Text = user.WorkDay.Substring(0, 10);
        Label8.Text = user.Education;
        Label9.Text = user.Career;
        Label10.Text = user.Birthday.Substring(0,10);
        Label11.Text = user.IdCard;
        Label12.Text = user.Marry;
        Label13.Text = user.BankAccount;
        Label14.Text = user.Status.ToString();
        switch (user.Status)
        {
            case 0:
                Label14.Text="在职";
                break;
            case 1:
                Label14.Text="离职";
                break;
            case 2:
                Label14.Text = "退休";
                break;

        }

        Label15.Text = user.Address;
        Label16.Text = user.StartDay.ToString().Substring(0, 10);
        Label17.Text = user.Seniority.ToString();
        Label18.Text = user.Post.ToString();
        Label19.Text = user.Department; 
       
        //绑定员工姓名
        h3_3.InnerText = user.Name;
        
        //绑定企业文化
        DataTable Table = BLL.UserManager.Selectqywh();
        h4_1.InnerText = Table.Rows[0][0].ToString();
        p_1.InnerText = Table.Rows[0][1].ToString();
        h4_2.InnerText = Table.Rows[1][0].ToString();
        p_2.InnerText = Table.Rows[1][1].ToString();
        h4_3.InnerText = Table.Rows[2][0].ToString();
        p_3.InnerText = Table.Rows[2][1].ToString();
        h4_4.InnerText = Table.Rows[3][0].ToString();
        p_4.InnerText = Table.Rows[3][1].ToString();
        
        //绑定请假类型
        this.DdlType.DataSource = BLL.UserManager.SelecTqjType();
        this.DdlType.DataTextField = "Tpname";
        this.DdlType.DataValueField = "TpId";
        this.DdlType.DataBind();
        
        //绑定部门职位
        labzw.Text = user.Post.ToString();
        labbm.Text = user.Department;
        Label4.Text = user.Name;

        //绑定考勤
        this.Repeater3.DataSource = BLL.UserManager.selectKq(id);
        this.Repeater3.DataBind();

    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        if(TextBox4.Text==""|| TextBox5.Text=="" || Tex10.Text=="")
        {
            Response.Write("<script>alert('请填写完信息')</script>");
            return;
        }
        Msg_info msg = new Msg_info();
        msg.UserId = Label1.Text;
        msg.TpId = Convert.ToInt32(DdlType.SelectedValue);
        msg.Cause = Tex10.Text;
        msg.Beginday = Convert.ToDateTime(TextBox4.Text);
        msg.EndDay = Convert.ToDateTime(TextBox5.Text);
        msg.SubmitDay = DateTime.Now;
        msg.Stutas = 0;
        if (BLL.UserManager.ADDQJ(msg) == 1)
        {
            ClientScript.RegisterStartupScript(typeof(string), "print", "<script>alert('" + "提交成功" + "');window.location.href ='UserInfoManager.aspx'</script>");

        }
        else 
        {
            Response.Write("<script>alert('添加失败')</script>");
        }
    }
    protected void Button2_Click1(object sender, EventArgs e)
    {
        if (Tex1.Text == "" || Tex2.Text == "" || Tex3.Text == "" || Tex4.Text == "" || Tex5.Text == "" || Tex6.Text == "")
        {
            Response.Write("<script>alert('请填写完信息')</script>");
            return;
        }
        Train tr = new Train();
        tr.Name = Tex1.Text;
        tr.Address = Tex2.Text;
        tr.Teacher = Tex3.Text;
        tr.Date = Convert.ToDateTime(Tex4.Text);
        tr.State = 0;
        tr.phone = Tex5.Text;
        tr.TrainDetails = Tex6.Text;
        if (BLL.UserManager.ADDpx(tr) == 1)
        {
            Response.Write("<script>alert('提交成功')</script>");
            Tex1.Text="";
            Tex2.Text = "";
            Tex3.Text = "";
            Tex4.Text = "";
            Tex5.Text = "";
            Tex6.Text = "";

        }
        else
        {
            Response.Write("<script>alert('添加失败')</script>");
        }

    }
 
}
