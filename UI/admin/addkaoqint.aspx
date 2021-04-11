<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin_kqgl.master" AutoEventWireup="true" CodeFile="addkaoqint.aspx.cs" Inherits="admin_addkaoqint" %>

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
                <li><a href="#">添加考勤</a></li>
            </ul>
        </div>
        <div class="formbody">
            <div id="usual1" class="usual">
                <div class="itab">
                    <ul>
                        <li><a href="" class="selected">添加员工</a></li>

                    </ul>
                </div>
                <!--增加新员工-->
                  <div class="tab-content">
                    <dl>
                        <dt>员工id</dt>
                        <dd>
                            <asp:TextBox ID="txtNickName" runat="server" MaxLength="100" CssClass="input normal" datatype="*" errormsg="" Width="100"></asp:TextBox>
                            <span class="Validform_checktip">*</span>
                        </dd>
                    </dl>
                     <dl>
                        <dt>类型</dt>
                        <dd>
                            <span class="rule-single-select">
                                <asp:DropDownList ID="DropDownList1" runat="server" datatype="*" errormsg="请选择" sucmsg=" ">
                                    <asp:ListItem Value="未知">--请选择--</asp:ListItem>
                                    <asp:ListItem Value="1">早退</asp:ListItem>
                                    <asp:ListItem Value="2">迟到</asp:ListItem>
                                    <asp:ListItem Value="3">旷工</asp:ListItem>
                                    <asp:ListItem Value="4">其他</asp:ListItem>
                                </asp:DropDownList>
                            </span>
                            <span class="Validform_checktip">*</span>
                        </dd>
                    </dl>
                  
                    <dl>
                          <dt>记录时间</dt>
                        <dd>
                          <div class="input-date">
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="input date" onfocus="WdatePicker({dateFmt:'yyyy-MM-dd'})" datatype="/^\s*$|^\d{4}\-\d{1,2}\-\d{1,2}$/" errormsg="请选择正确的日期" sucmsg=" " />
                                <i>日期</i>
                            </div>
                            <span class="Validform_checktip">*</span>
                        </dd>
                    </dl>
                    <dl>
                          <dt>&nbsp</dt>
                        <dd>
                          <div class="input-date">
                               
                            </div>
                            <span class="Validform_checktip"></span>
                        </dd>
                    </dl>
            <!--工具栏-->
            <div class="addkaoqing">
                <div class="btn-list">
                    <asp:Button ID="btnSubmit" runat="server" Text="提交保存 " CssClass="btn" OnClick="btnSubmit_Click" />
                </div>
                <div class="clear"></div>
            </div>
            <!--/工具栏-->
        </div>
</asp:Content>

