<%@ Control Language="C#" AutoEventWireup="true" CodeFile="WebUserControl.ascx.cs" Inherits="admin_用户控件_WebUserControl" %>
            <!--列表-->
<div>
            <asp:Repeater ID="rptList" runat="server">
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
        </div>