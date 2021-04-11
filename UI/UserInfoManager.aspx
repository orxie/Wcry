<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserInfoManager.aspx.cs"
    Inherits="UserInfoManager" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Wcry员工系统</title>
    <!--JQ层叠样式表-->
    <link rel="stylesheet" href="JQ/animate.css" type="text/css" />
    <link rel="stylesheet" href="JQ/vegas.min.css" type="text/css" />
    <link rel="stylesheet" href="JQ/bootstrap.min.css" type="text/css" />
    <!--页面样式表-->
    <link rel="stylesheet" href="Css/idnex_style.css" type="text/css" />
    <link rel="stylesheet" href="Css/nstyle.css" type="text/css" />
    <link href="Css/ygxt_style.css" rel="stylesheet" type="text/css" media="all" />
    <!-- javscript js -->
    <script src="JQ/My97DatePicker/WdatePicker.js" type="text/javascript"></script>
    <script src="JQ/jquery.js" type="text/javascript"></script>
    <script src="JQ/vegas.min.js" type="text/javascript"></script>
    <script src="JQ/wow.min.js" type="text/javascript"></script>
    <script src="Js/index_style.js" type="text/javascript"></script>
    <script src="JQ/bootstrap.min.js" type="text/javascript"></script>
    <script src="Js/echarts.js" type="text/javascript"></script>
  
</head>
<body>
    <form id="form1" runat="server">
        <!--导航条-->
        <div class="navbar navbar-fixed-top custom-navbar" role="navigation">
            <div class="container">
                <div class="navbar-header">
                    <button class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon icon-bar"></span><span class="icon icon-bar"></span><span class="icon icon-bar"></span>
                    </button>
                    <a href="#" class="navbar-brand">Wcry</a>
                </div>
                <div class="collapse navbar-collapse">
                    <ul class="nav navbar-nav navbar-right">
                        <li><a data-toggle="modal" data-target="#wdxx" href="#wdxx" class="smoothScroll">我的信息</a></li>
                        <li><a data-toggle="modal" data-target="#gwsb" href="#gwsb" class="smoothScroll">请假申请</a></li>
                        <li><a data-toggle="modal" data-target="#gshd" href="#gshd" class="smoothScroll">培训计划</a></li>
                        <li><a data-toggle="modal" data-target="#tzxx" href="#tzxx" class="smoothScroll">通知消息</a></li>
                        <li><a data-toggle="modal" data-target="#gywm" href="#gywm" class="smoothScroll">关于我们</a></li>
                    </ul>
                </div>
            </div>
        </div>

        <!--主页面-->
        <div class="wrap" id="wrap">
            <div class="wrapper">
                <div class="product_list" id="product_list">
                    <div class="product_box shoulei show">
                        <div class="bg_box">
                            <img id="imgbg_1" src="" alt="广告" runat="server" />
                        </div>
                        <div class="ALL">
                            <div class="ziti">
                                <h1>Welcome&nbsp;to&nbsp;Wcry办公管理系统</h1>
                                <hr />
                                <h3 id="h3_3" runat="server"></h3>
                            </div>
                        </div>
                    </div>
                    <div class="product_box xnet">
                        <div class="bg_box">
                            <img id="imgbg_2" src="" alt="广告" runat="server" />
                        </div>
                        <div class="ALL">
                            <div class="ziti">
                                <h1 id="BannerH1_1" runat="server">Welcome&nbsp;to&nbsp;Wcry办公管理系统</h1>
                                <hr />
                                <h3 id="BannerH3_1" runat="server"></h3>
                            </div>
                        </div>
                    </div>
                    <div class="product_box member">
                        <div class="bg_box">
                            <img id="imgbg_3" src="" alt="广告" runat="server" />
                        </div>
                        <div class="ALL">
                            <div class="ziti">
                                <h1 id="BannerH1_2" runat="server">Welcome&nbsp;to&nbsp;Wcry办公管理系统</h1>
                                <hr />
                                <h3 id="BannerH3_2" runat="server"></h3>
                            </div>
                        </div>
                    </div>
                    <div class="product_box xav">
                        <div class="bg_box">
                            <img id="imgbg_4" src="" alt="广告" runat="server" />
                        </div>
                        <div class="ALL">
                            <div class="ziti">
                                <h1 id="BannerH1_3" runat="server">Welcome&nbsp;to&nbsp;Wcry办公管理系统</h1>
                                <hr />
                                <h3 id="BannerH3_3" runat="server"></h3>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="product_btns" id="product_btns">
                    <div class="content">
                        <div class="btns_area">
                            <div class="btns_box" id="control_box">
                                <a href="" class="btn_xav"><span class="ic_member hide_txt png"></span></a><a href=""
                                    class="btn_xav"><span class="ic_member hide_txt png"></span></a><a href="" class="btn_xav">
                                        <span class="ic_member hide_txt png"></span></a><a href="" class="btn_xav"><span
                                            class="ic_member hide_txt png"></span></a><span class="ic_line" id="ic_line"></span>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="rpt_bg png" id="rpt_bg">
                </div>
            </div>
        </div>


        <!--内容页2-->
        <div class="gg">
            <!--我的现金流-->
            <div id="div2" class="nr1" style="width: 1040px; height: 380px;">
                <br />
                <h2>工资报表</h2>
                <div id="main" style="width: 1040px; height: 350px">
                </div>
                <script type="text/javascript">

                    $(function () {
                       
                        var url = "Handler.ashx";
                        //1.创建XMLHttpRequest
                        XMLHttpRequest = new XMLHttpRequest();
                        //2.设置回掉函数
                        XMLHttpRequest.onreadystatechange = function () {
                            if (XMLHttpRequest.readyState == 4 && XMLHttpRequest.status == 200) {
                                if (XMLHttpRequest.responseText == "") {
                                    return;
                                }

                                //获取服务器端返回的信息
                                var user = XMLHttpRequest.responseText;
                                //将字符串转换为json
                                var obj = eval(user);
                                alert(obj);
                                //for (var i = 0; i < obj.length; i++) {
                                //    document.getElementById("name").innerHTML += obj[i].Name + "&nbsp;";
                                //    document.getElementById("sex").innerHTML += obj[i].Sex + "&nbsp;";
                                //}
                            }
                        };
                        //3.初始化XMLHttpRequest\
                        XMLHttpRequest.open("get", url, true);
                        //4.发送请求
                        XMLHttpRequest.send();

                    });

                    $(function () {
                        var chart = document.getElementById('main');
                        var echart = echarts.init(chart);
                        var option = {
                            title: {
                                text: ''
                            },
                            tooltip: {
                                trigger: 'axis'
                            },
                            legend: {
                                data: ['工资']
                            },
                            grid: {
                                left: '3%',
                                right: '4%',
                                bottom: '3%',
                                containLabel: true
                            },
                            toolbox: {
                                feature: {
                                    saveAsImage: {}
                                }
                            },
                            xAxis: {
                                type: 'category',
                                boundaryGap: false,
                                data: ['6月', '7月', '8月', '9月', '10月', '11月', '12月']
                            },
                            yAxis: {
                                type: 'value'
                            },
                            series: [
                  {
                      name: '工资',
                      type: 'line',
                      stack: '工资',
                      data: [3000, 3200, 3600, 3700, 3700, 3900, 5000]
                  }

                            ]

                        };
                        echart.setOption(option);
                    });
                </script>
            </div>
            <br />
            <!--我的薪资-->
            <div id="Div1" class="nr1" style="width: 1040px; height: 400px;">
                <h2>绩效考核</h2>
                <br />
                <br />
                <br />
                <div id="Div3" style="width: 1040px; height: 350px">
                    <table style="width: 980px; height: 500px" border="1" class="t1">
                        <th>名称</th>
                        <th>时间</th>
                        <th>加分</th>
                        <th>扣分</th>
                        <th>操作人ID</th>
                        <asp:Repeater ID="Repeater3" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td><%#Eval("Name")%></td>
                                    <td><%#Eval("Record")%></td>
                                    <td><%#Eval("Praise")%></td>
                                    <td><%#Eval("Punish")%></td>
                                    <td><%#Eval("AtUserID")%></td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </table>
                </div>
            </div>
        </div>
        <!--企业文化-->
        <div class="gao">
            <div class="home_ w3layouts">
                <div class="home_grids_w3">
                    <div class="home_main">
                        <div class="col-md-7 col-sm-7 col-xs-7 img1 img-grid">
                            <div class="img_text_w3ls text-center">
                                <h4 id="h4_1" runat="server"></h4>
                                <span></span>
                                <p id="p_1" runat="server">
                                </p>
                            </div>
                        </div>
                        <div class="col-md-5 img2 col-sm-5 col-xs-5 img-grid">
                            <div class="img_text_w3ls text-center">
                                <h4 id="h4_2" runat="server"></h4>
                                <span></span>
                                <p id="p_2" runat="server">
                                </p>
                            </div>
                        </div>
                        <div class="clearfix">
                        </div>
                    </div>
                    <div class="home_main">
                        <div class="col-md-5 col-sm-5 col-xs-5 img3 img-grid ">
                            <div class="img_text_w3ls text-center">
                                <h4 id="h4_3" runat="server"></h4>
                                <span></span>
                                <p id="p_3" runat="server">
                                </p>
                            </div>
                        </div>
                        <div class="col-md-7 col-sm-7 col-xs-7 img4 img-grid">
                            <div class="img_text_w3ls text-center">
                                <h4 id="h4_4" runat="server"></h4>
                                <span></span>
                                <p id="p_4" runat="server">
                                </p>
                            </div>
                        </div>
                        <div class="clearfix">
                        </div>
                    </div>
                </div>
            </div>

            <!--备案信息-->
            <div class="baxx">
                <div class="baxx1">
                    WCry有限公司 蜀ICP备123456789号|ICP许可证号：蜀11223344556789<br />
                    Copyright&copy;2016-2017
                </div>
            </div>


            <!--隐藏Div-->

            <!--关于我们-->
            <div id="gywm" class=" modal fade ">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-body">
                            <button class="close" data-dismiss="modal">
                                <span>&times;</span>
                            </button>
                        </div>
                        <div class="modal-title">
                            <h3 class="text-center">关于我们</h3>
                        </div>
                        <div class="modal-body">
                            <p>
                                WCry·人力资源管理系统是为中小型公司员工人事部领导准备的人资信息的查看与管理的系统
                            </p>
                            <tr>
                                <td>联系电话：13152589556
                                </td>
                                <td>邮箱：371212933@qq.com
                                </td>
                            </tr>
                        </div>
                    </div>
                </div>
            </div>


            <!--我的信息-->
            <div id="wdxx" class=" modal fade ">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-body">
                            <button class="close" data-dismiss="modal">
                                <span>&times;</span>
                            </button>
                        </div>
                        <div class="modal-title">
                            <h3 class="text-center">我的信息</h3>
                        </div>
                        <div class="modal-body">
                            <table style="margin: 10px" height="380px" width="100%" id="mytab" border="1" class="t1">
                                <tr>
                                    <td>姓名:</td>
                                    <td>
                                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
                                    <td>账号:</td>
                                    <td>
                                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
                                    <td>性别:</td>
                                    <td>
                                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td>
                                </tr>
                                <tr class="a1">
                                    <td>部门名称:</td>
                                    <td>
                                        <asp:Label ID="Label19" runat="server" Text="Label"></asp:Label></td>
                                    <td>专业:</td>
                                    <td>
                                        <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label></td>

                                    <td>电子邮箱:</td>
                                    <td>
                                        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td>职位名称:</td>
                                    <td>
                                        <asp:Label ID="Label18" runat="server" Text="Label"></asp:Label></td>
                                    <td>学历:</td>
                                    <td>
                                        <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label></td>
                                    <td>入职日期:</td>
                                    <td>
                                        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label></td>
                                </tr>
                                <tr class="a1">
                                    <td>生日:</td>
                                    <td>
                                        <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label></td>
                                    <td>婚姻情况:</td>
                                    <td>
                                        <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label></td>
                                    <td>身份证号:</td>
                                    <td>
                                        <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td colspan="6" width="1200px"></td>
                                </tr>
                                <tr>
                                    <td>银行账号:</td>
                                    <td>
                                        <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label></td>
                                    <td>在职状况:</td>
                                    <td>
                                        <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label></td>
                                    <td>地址:</td>
                                    <td>
                                        <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label></td>
                                </tr>
                                <tr class="a1">
                                    <td>合同起始日期:</td>
                                    <td>
                                        <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label></td>
                                    <td>工龄:</td>
                                    <td>
                                        <asp:Label ID="Label17" runat="server" Text="Label"></asp:Label></td>
                                    <td>手机号:</td>
                                    <td>
                                        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></td>
                                </tr>

                            </table>
                        </div>
                    </div>
                </div>
            </div>



            <!--通知信息-->
            <div id="tzxx" class=" modal fade ">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-body">
                            <button class="close" data-dismiss="modal">
                                <span>&times;</span>
                            </button>
                        </div>
                        <div class="modal-title">
                            <h3 class="text-center">通知信息</h3>
                        </div>
                        <div class="modal-body">
                            <div class="modal-body">
                                <table width="100%" border="1" class="t1">
                                    <thead>
                                        <th width="10%">类型</th>
                                        <th width="40%">原因</th>
                                        <th width="40%">时间</th>
                                        <th width="10%">状态</th>
                                    </thead>
                                    <asp:Repeater ID="Repeater2" runat="server">
                                        <ItemTemplate>
                                            <tr>
                                                <td><%#Eval("Tpname")%></td>
                                                <td><%#Eval("Cause")%></td>
                                                <td><%#Eval("SubmitDay")%></td>
                                                <td><%# DataBinder.Eval(Container.DataItem,"Stutas").ToString() == "0"?"未读":"通过"%></td>
                                            </tr>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>


            <!--公文申报-->
            <div id="gwsb" class="modal fade">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-body">
                            <button class="close" data-dismiss="modal">
                                <span>&times;</span>
                            </button>
                        </div>
                        <div class="modal-title">
                            <h3 class="text-center">请假申请</h3>
                        </div>
                        <div class="modal-body">
                            <table width="100%" height="280px" class="t2">
                                <tr>
                                    <td>姓名:</td>
                                    <td>
                                        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td>职位:</td>
                                    <td>
                                        <asp:Label ID="labzw" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>部门:</td>
                                    <td>
                                        <asp:Label ID="labbm" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td align="left">类别:</td>
                                    <td colspan="5">
                                        <asp:DropDownList ID="DdlType" runat="server">
                                        </asp:DropDownList>
                                    </td>
                                </tr>

                                <tr>
                                    <td>请假时间:</td>
                                    <td>
                                        <asp:TextBox ID="TextBox4" runat="server" Height="30px" Width="200px" class="Wdate" type="text" onClick="WdatePicker({el:this,dateFmt:'yyyy-MM-dd HH:mm:ss'})"></asp:TextBox>
                                    </td>
                                    <td align="center">至</td>
                                    <td>
                                        <asp:TextBox ID="TextBox5" runat="server" Height="30px" Width="200px" class="Wdate" onClick="WdatePicker({el:this,dateFmt:'yyyy-MM-dd HH:mm:ss'})"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td>请假事由:</td>
                                    <td colspan="5">
                                        <asp:TextBox ID="Tex10" type="text" Style="height: 40PX; width: 490PX;" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                            <br />
                            <div class="text-right">
                                <asp:Button ID="Button2" class="btn btn-primary" runat="server" Text="提交" OnClick="Button1_Click1" />
                                <button class="btn btn-danger" data-dismiss="modal">取消</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>


            <!--培训计划-->
            <div id="gshd" class="modal fade">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-body">
                            <button class="close" data-dismiss="modal">
                                <span>&times;</span>
                            </button>
                        </div>
                        <div class="modal-title">
                            <h3 class="text-center">培训计划</h3>
                        </div>
                        <div class="modal-body">
                            <table width="100%" border="1" class="t1">
                                <th width="10%">名称</th>
                                <th width="10%">地点</th>
                                <th width="30%">时间</th>
                                <th>报名电话</th>
                                <th width="50%">培训详情</th>
                                <asp:Repeater ID="Repeater1" runat="server">
                                    <ItemTemplate>
                                        <tr>
                                            <td><%#Eval("Name") %></td>
                                            <td><%#Eval("Address")%></td>
                                            <td><%#string.Format("{0:yyyy/mm/dd}", Eval("Date"))%></td>
                                            <td><%#Eval("phone")%></td>
                                            <td><%#Eval("TrainDetails")%></td>
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </table>
                            <br />
                            <div class="text-right">
                                <asp:Button ID="Button1" data-toggle="modal" data-dismiss="modal" class="btn btn-primary" data-target="#pxsq" href="#pxsq" runat="server" Text="提交培训计划" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!--培训申请-->
        <div id="pxsq" class="modal fade">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-body">
                        <button class="close" data-dismiss="modal">
                            <span>&times;</span>
                        </button>
                    </div>
                    <div class="modal-title">
                        <h3 class="text-center">培训计划</h3>
                    </div>
                    <div class="modalp-body">
                        <div class="modal-body">
                            <table width="100%" height="280px" class="t2">
                                <tr>
                                    <td>名称:</td>
                                    <td>
                                        <asp:TextBox ID="Tex1" Height="30px" Width="190px" runat="server"></asp:TextBox>
                                    </td>
                                    <td>地点:</td>
                                    <td>
                                        <asp:TextBox ID="Tex2" Height="30px" Width="190px" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>教师:</td>
                                    <td>
                                        <asp:TextBox ID="Tex3" Height="30px" Width="190px" runat="server"></asp:TextBox>
                                    </td>
                                    <td>时间:</td>
                                    <td>
                                        <asp:TextBox ID="Tex4" runat="server" Height="30px" Width="190px" class="Wdate" type="text" onClick="WdatePicker({el:this,dateFmt:'yyyy-MM-dd HH:mm:ss'})"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>电话:</td>
                                    <td>
                                        <asp:TextBox ID="Tex5" Height="30px" Width="190px" runat="server"></asp:TextBox>
                                    </td>
                                    <td>详情:</td>
                                    <td>
                                        <asp:TextBox ID="Tex6" type="text" Style="height: 40PX; width: 190px;" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                            <br />
                            <div class="text-right">
                                <asp:Button ID="btnpx" class="btn btn-primary" runat="server" OnClick="Button2_Click1" Text="提交" />
                                <button class="btn btn-danger" data-dismiss="modal">取消</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
    </form>

    <script src="Js/UserManager.js" type="text/javascript"></script>
</body>
</html>
