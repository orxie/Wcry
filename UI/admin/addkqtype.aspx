<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin_kqgl.master" AutoEventWireup="true" CodeFile="addkqtype.aspx.cs" Inherits="admin_addkqtype" %>

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
                <li><a href="#">添加考勤类别</a></li>
            </ul>
        </div>
        <div class="formbody">
            <div id="usual1" class="usual">
                <div class="itab">
                    <ul>
                        <li><a href="" class="selected">添加考勤类别</a></li>

                    </ul>
                </div>
                <!--增加新员工-->

                  <div class="tab-content">
                    <dl>
                        <dt>类型名称</dt>
                        <dd>
                            <asp:TextBox ID="txtNickName" runat="server" MaxLength="100" CssClass="input normal" datatype="*" errormsg="" Width="100"></asp:TextBox>
                            <span class="Validform_checktip">*</span>
                        </dd>
                    </dl>
                    <dl>
                        <dt>详细介绍</dt>
                        <dd>
                            <asp:TextBox ID="txtAddress" runat="server" CssClass="input normal"></asp:TextBox></dd>
                    </dl>

                    <dl>
                        <dt>奖惩</dt>
                        <dd>
                            <div class="rule-multi-radio">
                                <asp:RadioButtonList ID="rblSex" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                    <asp:ListItem Value="加分" Selected="True">加分&nbsp;</asp:ListItem>
                                    <asp:ListItem Value="减分">减分&nbsp;</asp:ListItem>
                                </asp:RadioButtonList>
                            </div>
                        </dd>
                    </dl>
                    <dl>
                        <dt>分数</dt>
                        <dd>
                           <asp:TextBox ID="TextpassWord" runat="server" CssClass="input normal" datatype="n" errormsg="" MaxLength="18"></asp:TextBox>
                            <span class="Validform_checktip">*</span>
                        </dd>
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
            <div class="addkqtyp">
                <div class="btn-list">
                    <asp:Button ID="btnSubmit" runat="server" Text="提交保存 " CssClass="btn" OnClick="btnSubmit_Click" />
                </div>
                <div class="clear"></div>
            </div>
            <!--/工具栏-->
        </div>

</asp:Content>

