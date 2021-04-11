

<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin_renzi.master" AutoEventWireup="true" CodeFile="SelectALLUser.aspx.cs" Inherits="admin_SelectALLUser" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<%@ OutputCache Duration="60" VaryByParam="none" %>




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
                <li><a href="#">人事管理</a></li>
                <li><a href="#">员工信息</a></li>
            </ul>
        </div>
        <div class="rightinfo">
            <dl class="seachform">
                <dd>
                    <label>ID号</label><span class="single-select"><asp:TextBox ID="txtuser_id" runat="server" Width="120" CssClass="scinput"></asp:TextBox></span></dd>
                <dd>
                    <label>姓名</label><span class="single-select"><asp:TextBox ID="txtuser_name" runat="server" Width="70" CssClass="scinput"></asp:TextBox></span></dd>
                <dd>
                    <label>证件号</label><span class="single-select"><asp:TextBox ID="txtuser_idCard" runat="server" Width="160" CssClass="scinput"></asp:TextBox></span></dd>
                <dd>
                    <label>手机号</label><span class="single-select"><asp:TextBox ID="txtuser_telePhone" runat="server" Width="100" CssClass="scinput" MaxLength="11"></asp:TextBox></span></dd>
                <dd>
                    <label>部门</label>
                    <span class="rule-single-select">
                        <asp:DropDownList ID="ddlbm" runat="server"  >
                        </asp:DropDownList>
                    </span>
                </dd>
                 <dd class="cx">
                    <label>&nbsp&nbsp&nbsp</label>
                     <label>&nbsp&nbsp&nbsp</label>
                      <label>&nbsp&nbsp&nbsp</label>
                        <label>&nbsp&nbsp&nbsp</label>
                     <label>&nbsp&nbsp&nbsp</label>
                      <label>&nbsp&nbsp&nbsp</label>
                        <label>&nbsp&nbsp&nbsp</label>
                     <label>&nbsp&nbsp&nbsp</label>
                      <label>&nbsp&nbsp&nbsp</label>
                </dd>
                <dd class="cx">
                    <asp:Button ID="lbtnSearch" runat="server" CssClass="scbtn"  Text="查询" 
                        OnClick ="lbtnSearch_Click"></asp:Button>
                </dd>
            </dl>
            <!--列表-->
            <asp:Repeater ID="rptList" runat="server" onitemcommand="rptList_ItemCommand">
                <HeaderTemplate>
                    <table class="tablelist">
                        <thead>
                            <tr>
                                <th width="60px;">姓名</th>
                                <th width="60px;">账号</th>
                                <th  width="50px;">性别</th>
                                <th  width="80px;">专业</th>
                                <th  width="50px;">学历</th>
                                <th  width="75px;">职位</th>
                                <th  width="70px;">部门</th>
                                <th  width="110px;">地址</th>
                                <th width="100px;">手机账号</th>                           
                                <th width="100px;">身份证号</th>
                                <th width="100px;">生日</th>
                                <th width="100px;">入职日期</th>
                                <th width="150px;">操作</th>
                            </tr>
                        </thead>
                        <tbody>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("Name")%></td>
                        <td><%#Eval("ID")%></td>
                        <td><%#Eval("Sex")%></td>
                        <td><%#Eval("Career")%></td>
                        <td><%#Eval("Education")%></td>
                        <td><%#Eval("PostName")%></td>
                        <td><%#Eval("DeptName")%></td>
                        <td><%#Eval("Address")%></td>
                        <td><%#Eval("TelePhone")%></td>
                        <td><%#Eval("IdCard")%></td>
                        <td><%#string.Format("{0:yyyy/mm/dd}",Eval("Birthday")) %></td>
                        <td><%#string.Format("{0:yyyy/mm/dd}", Eval("WorkDay"))%></td>

                        <td>
                            <a href="updateUser.aspx?UID=<%#Eval("ID") %>" class="tablelink">
                                <font color ="#066D96">[修改]</font>
                            </a>&nbsp;&nbsp;

                            <asp:LinkButton ID="lbtnDelCa" runat="server"  OnClientClick="return confirm('是否真的要删除该会员？')" CommandArgument='<%#Eval("ID") %>' CommandName="delete">
                                <font color ="red">[删除]</font>

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
     </div>
</asp:Content>

