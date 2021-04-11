<%@ WebHandler Language="C#" Class="Handler" %>

using System;
using System.Web;
using Model;
using BLL;
//引入序列化命名空间
using System.Collections.Generic;
using System.Web.Script.Serialization;


public class Handler : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        List<UserInfo> list = new List<UserInfo>();
        UserInfo us = new UserInfo();
        

    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}