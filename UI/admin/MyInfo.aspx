<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin_renzi.master" AutoEventWireup="true" CodeFile="MyInfo.aspx.cs" Inherits="MyInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 <link href="CSS/style.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="JS/jquery-1.8.2.min.js"></script>
    <script type="text/javascript" src="JS/lhgdialog/lhgdialog.js?skin=idialog"></script>
    <script type="text/javascript" src="JS/jquery/Validform_v5.3.2_min.js"></script>
    <script type="text/javascript" src="JS/layout.js"></script>
    <script type="text/javascript" src="JS/pinyin.js"></script>
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
                <li><a href="#">我的信息</a></li>
            </ul>
        </div>

        <div class="formbody">
            <div class="formtitle"><span>我的信息</span></div>

            <!--/我的信息-->
            <div class="tab-content">
                <dl>
                    <dl>
                        <dt>姓名</dt>
                        <dd>
                            <asp:Literal ID="Litreal_name" runat="server"></asp:Literal></dd>
                    </dl>

                    <dl>
                        <dt>账号</dt>
                        <dd>
                            <asp:Literal ID="Lituser_name" runat="server"></asp:Literal></dd>
                    </dl>
                    <dl>
                        <dt>职位</dt>
                        <dd>
                             <asp:Literal ID="litzw" runat="server"></asp:Literal></dd>
                    </dl>
                    <dl id="bmxx" runat="server">
                        <dt>所属部门</dt>
                        <dd>
                            <asp:Literal ID="Litdepot_category_name" runat="server"></asp:Literal></dd>
                    </dl>
                     <dl>
                        <dt>新登录密码</dt>
                        <dd>
                            <asp:TextBox ID="txtPassword" runat="server" CssClass="input normal" TextMode="Password" datatype="*6-20" nullmsg="请输入新密码" errormsg="密码范围在6-20位之间" sucmsg=" "></asp:TextBox>
                            <span class="Validform_checktip">*</span></dd>
                    </dl>

                    <dl>
                        <dt>新确认密码</dt>
                        <dd>
                            <asp:TextBox ID="txtPassword1" runat="server" CssClass="input normal" TextMode="Password" datatype="*" recheck="txtPassword" nullmsg="请再输入一次新密码" errormsg="两次输入的密码不一致" sucmsg=" "></asp:TextBox>
                            <span class="Validform_checktip">*</span></dd>
                    </dl>

                    
                    <dl>
                        <dt>&nbsp</dt>
                        <dd>
                           </dd>
                    </dl>

                    
                  
            </div>

            <!--/我的信息-->
        </div>


        <!--工具栏-->
        <div class="user">
            <div class="btn-list">
                <asp:Button ID="btnSubmit" runat="server" Text="提交保存" CssClass="btn" 
                    onclick="btnSubmit_Click" />
                <input name="btnReturn" type="button" value="返回上一页" class="btn yellow" onclick="javascript: history.back(-1);" />
            </div>
            <div class="clear"></div>
        </div>
        <!--/工具栏-->

</asp:Content>

