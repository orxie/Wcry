using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

public partial class admin_Default : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { 
            UserInfo user1 = new UserInfo();
            user1.ID = Request.QueryString["UID"];
            user1 = BLL.AdminManager.SelectUserInfoByid(user1.ID);
            this.txtNickName.Text = user1.Name;
            this.ddlxl.SelectedValue = user1.Education;
            ddlzw.SelectedValue = user1.PostId.ToString();
            ddlhy.SelectedValue = user1.Marry;
            rblSex.SelectedValue = user1.Sex;
            TextBox1.Text = user1.WorkDay.Substring(0, 10);
            txtBirthday.Text = user1.Birthday.Substring(0, 10);
            TextpassWord.Text = user1.PassWord.ToString();
            this.TextBox2.Text = user1.StartDay.ToString().Substring(0, 10);
            TextBox3.Text = user1.IdCard;
            txtMobile.Text = user1.TelePhone;
            txtAddress.Text = user1.Address;
            txtEmail.Text = user1.Email;
            txtCareer.Text = user1.Career;
            txtID.Text = user1.ID;
            txtBankAccount.Text = user1.BankAccount;
 
        }
       
        ddlzw.DataSource = BLL.AdminManager.SelecZWType();
        ddlzw.DataTextField = "PostName";
        ddlzw.DataValueField = "PostID";
        ddlzw.DataBind();

       
    }
    
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        UserInfo user = new UserInfo();
        user.Name = this.txtNickName.Text.Trim().ToString();
        user.Education = this.ddlxl.Text.ToString();
        user.PostId = Convert.ToInt32(ddlzw.SelectedValue);
        user.Marry = this.ddlhy.Text.ToString();
        user.Sex = this.rblSex.Text.ToString();
        user.WorkDay = this.TextBox1.Text.ToString();
        user.Birthday = this.txtBirthday.Text.ToString();
        user.PassWord = this.TextpassWord.Text.ToString();
        user.StartDay = Convert.ToDateTime(this.TextBox2.Text);
        user.IdCard = this.TextBox3.Text.ToString();
        user.TelePhone = this.txtMobile.Text.ToString();
        user.Address = this.txtAddress.Text.ToString();
        user.Email = this.txtEmail.Text.ToString();
        user.Career = this.txtCareer.Text.ToString();
        user.ID = this.txtID.Text.ToString();
        user.BankAccount = this.txtBankAccount.Text.ToString();
        if (BLL.AdminManager.UpdataUser(user) == 1)
        {
            Response.Write("<script>alert('成功')</script>");
        }
        else
        {
            Response.Write("<script>alert('失败')</script>");
        }
    }
}