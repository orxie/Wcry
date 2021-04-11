

<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin_renzi.master" AutoEventWireup="true" CodeFile="TrainUser.aspx.cs" Inherits="admin_SelectALLUser" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
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
            <span>位置:</span>
            <ul class="placeul">
                <li><a href="#">首页</a></li>
                <li><a href="#">培训申请</a></li>
            </ul>
        </div>
            <!--列表-->
            <asp:Repeater ID="rptList" runat="server" onitemcommand="rptList_ItemCommand">
                <HeaderTemplate>
                    <table class="tablelist">
                        <thead>
                            <tr>
                                <th width="60px;">培训名称</th>
                                <th  width="50px;">培训地点</th>
                                <th  width="80px;">培训时间</th>
                                <th  width="50px;">培训教师</th>
                                 <th  width="80px;">联系电话</th>
                                <th  width="150px;">培训详情</th>
                                <th width="150px;">操作</th>
                            </tr>
                        </thead>
                        <tbody>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("Name")%></td>
                        <td><%#Eval("Address")%></td>
                        <td><%#Eval("Date")%></td>
                        <td><%#Eval("Teacher")%></td>
                        <td><%#Eval("phone")%></td>
                        <td><%#Eval("TrainDetails")%></td>
                        <td>
                     <asp:LinkButton ID="LinkButton1" runat="server"  CommandArgument='<%#Eval("TrainId") %>' CommandName="xiugai">
                                <font color ="#066D96">[发布]</font>
                                &nbsp&nbsp
                            </asp:LinkButton>

                            <asp:LinkButton ID="lbtnDelCa" runat="server"  CommandArgument='<%#Eval("TrainId") %>' CommandName="delete">
                                <font color ="red">[否定]</font>

                            </asp:LinkButton>
                       </td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    <%#rptList.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"17\"><font color=red><font color=red>暂无记录</font></font></td></tr>" : ""%>
   </tbody>
    </table>
                </FooterTemplate>
            </asp:Repeater>


            <div class="pagelist">
                <div class="l-btns">
                    <span>显示</span><asp:TextBox ID="txtPageNum" runat="server" CssClass="pagenum"  OnTextChanged="txtPageNum_TextChanged" AutoPostBack="True"></asp:TextBox><span>条/页</span>
                </div>
                <div id="PageContent" runat="server" class="default">
                 <webdiyer:AspNetPager ID="AspNetPager1" runat="server"
                        FirstPageText="首页"  
                        LastPageText="尾页"
                        PrevPageText="上一页"  
                        NextPageText="下一页" 
                        EnableTheming="true" 
                        onpagechanged="AspNetPager1_PageChanged" 
                        Width="100%" 
                        AlwaysShow="true" 
                        PageIndexBoxType="DropDownList"
                        TextBeforePageIndexBox="转动"
                        HorizontalAlign="Center"  
                        UrlPaging="True"
                        CssClass="paginator">
                    </webdiyer:AspNetPager>
                </div>
        </div>
</asp:Content>

