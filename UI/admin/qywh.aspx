<%@ Page Title="" Language="C#" MasterPageFile="~/admin/qiantai.master" AutoEventWireup="true" CodeFile="qywh.aspx.cs" Inherits="admin_banner" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="/CSS/style.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="JS/jquery-1.8.2.min.js"></script>
    <script type="text/javascript" src="JS/jquery/Validform_v5.3.2_min.js"></script>
    <script type="text/javascript" src="JS/lhgdialog/lhgdialog.js?skin=idialog"></script>
    <script type="text/javascript" src="JS/datepicker/WdatePicker.js"></script>
    <script type="text/javascript" src="JS/layout.js"></script>
    <script type="text/javascript" src="JS/pinyin.js"></script>
    <script type="text/javascript" charset="utf-8" src="/editor/kindeditor-min.js"></script>
    <script type="text/javascript" charset="utf-8" src="/editor/lang/zh_CN.js"></script>
    <script type="text/javascript">
        $(function () {
            //初始化表单验证
            $("#form1").initValidform();
            //初始化编辑器
            var editor = KindEditor.create('#txtContent', {
                width: '80%',
                height: '350px',
                resizeType: 1,
                uploadJson: '../tools/upload_ajax.ashx?action=EditorFile&IsWater=1',
                fileManagerJson: '../tools/upload_ajax.ashx?action=ManagerFile',
                allowFileManager: true
            });

        });
       </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="place">
            <span>位置：</span>
            <ul class="placeul">
                <li><a href="">首页</a></li>
                <li><a href="">网页管理</a></li>
                <li><a href="#">企业文化</a></li>
            </ul>
        </div>

        <div class="formbody">
            <div class="formtitle"><span>企业文化修改</span></div>
            <!--/公告信息-->
            <div class="tab-content">

                <dl>
                    <dt>企业文化标题</dt>
                    <dd>
                        <asp:TextBox ID="txttitle" runat="server" Width="600" CssClass="input normal" datatype="*2-100" sucmsg=" " />
                        <span class="Validform_checktip">*公告标题最多10个字符</span>
                    </dd>
                </dl>
                <dl>
                    <dt>企业文化详情</dt>
                    <dd>
                        <asp:TextBox ID="TextBox1" runat="server" Width="600" CssClass="input normal" datatype="*2-100" sucmsg=" " />
                        <span class="Validform_checktip">*公告标题最多20个字符</span>
                    </dd>
                </dl>
            </div>
            <!--/公告信息-->

        </div>

        <!--工具栏-->
        <div class="banner">
            <div class="btn-list">
                <asp:Button ID="btnSubmit" runat="server" Text="保存信息" CssClass="btn" 
                    nclick="btnfile_Click" onclick="btnSubmit_Click" />
            </div>
            <div class="clear"></div>
        </div>
        <!--/工具栏-->
</asp:Content>

