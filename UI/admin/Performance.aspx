<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin_kqgl.master" AutoEventWireup="true" CodeFile="Performance.aspx.cs" Inherits="admin_Performance" %>

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
                <li><a href="">工资发放状态</a></li>
            </ul>
        </div>
        <div class="rightinfo">
            <!--列表-->
            <asp:Repeater ID="rptList" runat="server" >
                <HeaderTemplate>
                    <table class="tablelist">
                        <thead>
                            <tr>
                                <th width="60px;">员工姓名</th>
                                <th  width="50px;">奖励金额</th>
                                <th  width="80px;">惩罚金额</th>
                                <th  width="50px;">基本金额</th>
                                 <th  width="80px;">实发金额</th>
                                <th  width="150px;">发放时间</th>
                                <th width="150px;">绩效总分</th>
                                 <th width="150px;">发放状态</th>
                            </tr>
                        </thead>
                        <tbody>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("Name")%></td>
                        <td><%#Eval("Bonus")%></td>
                        <td><%#Eval("Forfeit")%></td>
                        <td><%#Eval("Money")%></td>
                        <td><%#Eval("Dough")%></td>
                        <td><%#Eval("Time")%></td>
                        <td><%#Eval("Total")%></td>
                        <td><%# DataBinder.Eval(Container.DataItem, "State").ToString() == "0" ? "未发放" : "发放"%></td>
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
                    <webdiyer:AspNetPager ID="AspNetPager2" runat="server"
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

