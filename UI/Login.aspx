 <%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<%@ Register Assembly="WebValidates" Namespace="WebValidates" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Wcry人资管理系统登录页面</title>
    <!--JQ层叠样式表-->
	<link rel="stylesheet" href="JQ/animate.css"   type="text/css"/>
  	<link rel="stylesheet" href="JQ/vegas.min.css" type="text/css" />
    <link rel="stylesheet" href="JQ/bootstrap.min.css" type="text/css" />
    <!--页面样式表-->
	<link rel="stylesheet" href="Css/idnex_style.css" type="text/css" />
    <!-- javscript js -->
	<script src="JQ/jquery.js" type="text/javascript"></script>
    <script src="JQ/vegas.min.js" type="text/javascript"></script>
    <script  src="JQ/wow.min.js" type="text/javascript"></script>
    <script src="Js/Login.js" type="text/javascript"></script>
    <script src="JQ/bootstrap.min.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <!--主页面-->
    <section id="intro" class="parallax-section">
	    <div class="container">
		    <div class="row">
		      <div class="col-md-12 col-sm-12">
		        <h1 class="wow bounceIn"  data-wow-delay="0.8s">Wcry人资管理系统</h1>
                 <a  data-toggle="modal" data-target="#login1" href="#" id="btn1" class="btn btn-primary btn-lg  btn-danger  smoothScroll wow fadeInUp"  data-wow-delay="2.3s">登陆</a> </div>
		    </div>
	    </div>
    </section>
    <!-- 登录窗口 -->
        <div id="login1" class="modal fade modal-top">
         <div class="modal-dialog ">
             <div class="modal-content">
                <div class="modal-body">
                    <button class="close" data-dismiss="modal">
                         <span>&times;</span>
                    </button>
                 </div>
                 <div class="modal-title">
                    <h1 class="text-center">登录</h1>
                 </div>
                  <form class="form-group" id="login"  ="">
                <div class="modal-body">
                             <div class="form-group">
                                <label for="">帐号</label>
                                <asp:TextBox ID="Yhid" class="form-control" runat="server"></asp:TextBox> 
                            </div>
                            <div class="form-group">
                               <label for="">密码</label>
                                 <asp:TextBox ID="Sex" class="form-control" type="password" runat="server"></asp:TextBox>
                             </div>
                            <div class="text-right">
                                <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="登录" 
                                    onclick="Button1_Click1" />
                                 <button class="btn btn-danger"   data-dismiss="modal">取消</button>
                             </div>
                             </div>
                  </form>
               </div>
           </div>
        </div>
    </form>
</body>
</html>
