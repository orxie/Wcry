<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin_kqgl.master" AutoEventWireup="true" CodeFile="Msg.aspx.cs" Inherits="admin_Msg" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link href="CSS/style.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="JS/jquery-1.8.2.min.js"></script>
    <script type="text/javascript" src="JS/lhgdialog/lhgdialog.js?skin=idialog"></script>
    <script type="text/javascript" src="JS/layout.js"></script>
    <script type="text/javascript" src="JS/lhgcore.min.js"></script>
    <script type="text/javascript" src="JS/lhgcalendar.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="place">
            <span>位置:</span>
            <ul class="placeul">
                <li><a href="#">首页</a></li>
                <li><a href="#">审核请假单</a></li>
            </ul>
        </div>
        <div class="rightinfo">
            <!--列表-->
            <asp:Repeater ID="rptList" runat="server" onitemcommand="rptList_ItemCommand" >
                <HeaderTemplate>
                    <table class="tablelist">
                        <thead>
                            <tr>
                                <th width="60px;">姓名</th>
                                <th  width="80px;">请假原因</th>
                                <th  width="50px;">请假类型</th>
                                 <th  width="80px;">请假描述</th>
                                <th  width="150px;">开始日期</th>
                                <th width="150px;">结束日期</th>
                                <th width="150px;">提交请假日期</th>
                                <th width="150px;">状态</th>
                            </tr>
                        </thead>
                        <tbody>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("Name")%></td>
                        <td><%#Eval("Cause")%></td>
                        <td><%#Eval("Tpname")%></td>
                        <td><%#Eval("TpDescrib")%></td>
                        <td><%#string.Format("{0:yyyy/mm/dd}", Eval("Beginday"))%></td>
                        <td><%#string.Format("{0:yyyy/mm/dd}", Eval("EndDay"))%></td>
                        <td><%#string.Format("{0:yyyy/mm/dd}", Eval("SubmitDay"))%></td>
                        <td>
                           <asp:LinkButton ID="LinkButton1" runat="server"  CommandArgument='<%#Eval("ID") %>' CommandName="tongguo">
                                <font color ="#066D96">[通过]</font>
                           &nbsp;&nbsp;
                            </asp:LinkButton>

                            <asp:LinkButton ID="lbtnDelCa" runat="server" CommandArgument='<%#Eval("ID") %>'  CommandName="fouding">
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
                    <span>显示</span><asp:TextBox ID="txtPageNum" runat="server" CssClass="pagenum"   AutoPostBack="True"></asp:TextBox><span>条/页</span>
                </div>
                <div id="PageContent" runat="server" class="default">
                    <webdiyer:AspNetPager ID="AspNetPager2" runat="server" FirstPageText="首页"  
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

