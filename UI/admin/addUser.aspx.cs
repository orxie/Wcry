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
            ddlzw.DataSource = BLL.AdminManager.SelecZWType();
            ddlzw.DataTextField = "PostName";
            ddlzw.DataValueField = "PostID";
            ddlzw.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        UserInfo user = new UserInfo();
        user.Name = this.txtNickName.Text.Trim().ToString();
        user.Education = this.DropDownList1.Text.ToString();
        user.PostId = Convert.ToInt32(ddlzw.SelectedValue);
        user.Marry = this.ddlhy.Text.ToString();
        user.Sex = this.rblSex.Text.ToString();
        user.WorkDay = this.TextBox1.Text.ToString();
        user.PassWord = this.TextpassWord.Text.ToString();
        user.Birthday = this.txtBirthday.Text.ToString();
        user.StartDay = Convert.ToDateTime(this.TextBox2.Text);
        user.IdCard = this.TextBox3.Text.ToString();
        user.TelePhone = this.txtMobile.Text.ToString();
        user.Address = this.txtAddress.Text.ToString();
        user.Email = this.txtEmail.Text.ToString();
        user.Career = this.txtCareer.Text.ToString();
        user.ID = this.txtID.Text.ToString();
        user.BankAccount = this.txtBankAccount.Text.ToString();
        if (BLL.AdminManager.AddUser(user) == 1)
        {
            Response.Write("<script>alert('成功')</script>");
            txtNickName.Text = "";
            DropDownList1.Text = "1";
            ddlhy.Text = "1";
            rblSex.Text = "1";
            TextBox1.Text = "";
            txtBirthday.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            txtMobile.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtCareer.Text = "";
            txtID.Text = "";
            txtBankAccount.Text = "";
        }
        else
        {
            Response.Write("<script>alert('失败')</script>");
        }
    }
}