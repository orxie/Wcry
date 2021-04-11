<%@ WebHandler Language="C#" Class="report_server" %>

using System;
using System.Web;
using DAL;
using Model;

public class report_server : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) 
    {
         
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}