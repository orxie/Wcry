<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin_renzi.master" AutoEventWireup="true" CodeFile="updateUser.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <script type="text/javascript">
        $(function () {
            //初始化表单验证
            $("#form1").initValidform();
        });

    </script>
    <script src="JS/datepicker/WdatePicker.js" type="text/javascript"></script>
    <link href="CSS/style.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="JS/jquery-1.8.2.min.js"></script>
    <script type="text/javascript" src="JS/lhgdialog/lhgdialog.js?skin=idialog"></script>
    <script type="text/javascript" src="JS/layout.js"></script>
    <script type="text/javascript" src="JS/lhgcore.min.js"></script>
    <script type="text/javascript" src="JS/lhgcalendar.min.js"></script>
    <script type="text/javascript">
        $(function () {
            //顶部导航切换
            $(".nav li a").click(function () {
                $(".nav li a.selected").removeClass("selected")
                $(this).addClass("selected");
            })
        })  
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div class="place">
            <span>位置：</span>
            <ul class="placeul">
                <li><a href="">首页</a></li>
                <li><a href="">人事管理</a></li>
                <li><a href="#">修改员工信息</a></li>
            </ul>
        </div>
        <div class="formbody">
            <div id="usual1" class="usual">
                <div class="itab">
                    <ul>
                        <li><a href="" class="selected">修改员工信息</a></li>

                    </ul>
                </div>
                <!--增加新员工-->

                  <div class="tab-content">
                    <dl>
                        <dt>员工姓名</dt>
                        <dd>
                            <asp:TextBox ID="txtNickName" runat="server" MaxLength="100" CssClass="input normal" datatype="*" errormsg="" Width="100"></asp:TextBox>
                            <span class="Validform_checktip">*</span>
                        </dd>
                    </dl>
                     <dl>
                        <dt>学历</dt>
                        <dd>
                            <span class="rule-single-select">
                                <asp:DropDownList ID="ddlxl" runat="server" datatype="*" errormsg="请选择" 
                                sucmsg=" ">
                                    <asp:ListItem Value="未知">--请选择--</asp:ListItem>
                                    <asp:ListItem Value="中专">中专</asp:ListItem>
                                    <asp:ListItem Value="大专">大专</asp:ListItem>
                                    <asp:ListItem Value="本科">本科</asp:ListItem>
                                    <asp:ListItem Value="研究生">研究生</asp:ListItem>
                                    <asp:ListItem Value="博士">博士</asp:ListItem>
                                    <asp:ListItem Value="其他">其他</asp:ListItem>
                                </asp:DropDownList>
                            </span>
                            <span class="Validform_checktip">*</span>
                        </dd>
                    </dl>
                    
                    <dl>
                          <dt>职位</dt>
                        <dd>
                             <span class="rule-single-select">
                                <asp:DropDownList ID="ddlzw" runat="server" datatype="*" errormsg="请选择" sucmsg=" ">
                                   
                                </asp:DropDownList>
                            </span>
                            <span class="Validform_checktip">*</span>
                        </dd>
                    </dl>
                    <dl>
                          <dt>婚姻情况</dt>
                        <dd>
                            <span class="rule-single-select">
                                <asp:DropDownList ID="ddlhy" runat="server" datatype="*" errormsg="请选择" sucmsg=" ">
                                     <asp:ListItem Value="未知">--请选择--</asp:ListItem>
                                     <asp:ListItem Value="已婚">已婚</asp:ListItem>
                                     <asp:ListItem Value="未婚">未婚</asp:ListItem>
                                </asp:DropDownList>
                            </span>
                            <span class="Validform_checktip">*</span></dd>
                    </dl>
                    
                    <dl>
                        <dt>性别</dt>
                        <dd>
                            <div class="rule-multi-radio">
                                <asp:RadioButtonList ID="rblSex" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                    <asp:ListItem Value="男" Selected="True">男&nbsp;</asp:ListItem>
                                    <asp:ListItem Value="女">女&nbsp;</asp:ListItem>
                                </asp:RadioButtonList>
                            </div>
                        </dd>
                    </dl>
                    
                    <dl>
                          <dt>入职日期</dt>
                        <dd>
                          <div class="input-date">
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="input date" onfocus="WdatePicker({dateFmt:'yyyy-MM-dd'})" datatype="/^\s*$|^\d{4}\-\d{1,2}\-\d{1,2}$/" errormsg="请选择正确的日期" sucmsg=" " />
                                <i>日期</i>
                            </div>
                            <span class="Validform_checktip">*</span>
                        </dd>
                    </dl>
                    <dl>
                        <dt>生日日期</dt>
                        <dd>
                            <div class="input-date">
                                <asp:TextBox ID="txtBirthday" runat="server" CssClass="input date" onfocus="WdatePicker({dateFmt:'yyyy-MM-dd'})" datatype="/^\s*$|^\d{4}\-\d{1,2}\-\d{1,2}$/" errormsg="请选择正确的日期" sucmsg=" " />
                                <i>日期</i>
                            </div>
                            <span class="Validform_checktip">*</span>
                        </dd>
                    </dl>
                     <dl>
                        <dt>合同生效日期</dt>
                        <dd>
                              <div class="input-date">
                                <asp:TextBox ID="TextBox2" runat="server" CssClass="input date" onfocus="WdatePicker({dateFmt:'yyyy-MM-dd'})" datatype="/^\s*$|^\d{4}\-\d{1,2}\-\d{1,2}$/" errormsg="请选择正确的日期" sucmsg=" " />
                                <i>日期</i>
                            </div>
                            <span class="Validform_checktip">*</span>
                        </dd>
                    </dl>
                    <dl>
                        <dt>登陆密码</dt>
                        <dd>
                           <asp:TextBox ID="TextpassWord" runat="server" CssClass="input normal" datatype="n" errormsg="" MaxLength="18"></asp:TextBox>
                            <span class="Validform_checktip">*</span>
                        </dd>
                    </dl>
                    <dl>
                        <dt>证件号码</dt>
                        <dd>
                           <asp:TextBox ID="TextBox3" runat="server" CssClass="input normal" datatype="n" errormsg="" MaxLength="18"></asp:TextBox>
                            <span class="Validform_checktip">*</span>
                        </dd>
                    </dl>
                    <dl>
                        <dt>手机号码</dt>
                        <dd>
                            <asp:TextBox ID="txtMobile" runat="server" CssClass="input normal" datatype="n" errormsg="" MaxLength="11"></asp:TextBox>
                            <span class="Validform_checktip">*</span></dd>
                    </dl>
                    <dl>
                        <dt>联系地址</dt>
                        <dd>
                            <asp:TextBox ID="txtAddress" runat="server" CssClass="input normal"></asp:TextBox></dd>
                    </dl>
                   
                    <dl>
                        <dt>邮箱账号</dt>
                        <dd>
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="input normal"></asp:TextBox>
                        </dd>
                    </dl>
                    <dl>
                        <dt>专业</dt>
                        <dd>
                            <asp:TextBox ID="txtCareer" runat="server" CssClass="input normal"></asp:TextBox></dd>
                    </dl>
                   
                    <dl>
                          <dt>登陆账号</dt>
                        <dd>
                            <asp:TextBox ID="txtID" runat="server" CssClass="input normal"
                                datatype="n" sucmsg=" " MaxLength="20"></asp:TextBox>
                            <span class="Validform_checktip">*</span></dd>
                    </dl>
                    <dl>
                          <dt>银行账号</dt>
                        <dd>
                            <asp:TextBox ID="txtBankAccount" runat="server" CssClass="input normal"
                                datatype="n" sucmsg=" " MaxLength="20"></asp:TextBox>
                            <span class="Validform_checktip">*</span></dd>
                    </dl>
                    <dl>
                          <dt>&nbsp</dt>
                        <dd>
                            </dd>
                    </dl>
                </div>
                <!--增加新员工-->
            </div>

            <!--工具栏-->
        <div class="page-footer">
            <div class="btn-list">
                <asp:Button ID="btnSubmit" runat="server" Text="提交保存" CssClass="btn" OnClick="btnSubmit_Click" />
                <input name="btnReturn" type="button" value="返回上一页" class="btn yellow" onclick="javascript: history.back(-1);" />
            </div>
            <div class="clear"></div>
        </div>
            <!--/工具栏-->
        </div>

</asp:Content>

