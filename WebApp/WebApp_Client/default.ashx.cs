using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp_Domain;

namespace WebApp_Client
{
   /// <summary>
   /// Summary description for _default1
   /// </summary>
   public class _default1 : IHttpHandler
   {

      public void ProcessRequest(HttpContext context)
      {
         var cookie = context.Request.Cookies.Get("web");
         if ((cookie == null || !DomainHelper.checkUser(cookie.Value)) && context.Request.HttpMethod == "GET")
         {
            context.Response.Redirect("./login.aspx");
         }
         if (context.Request.HttpMethod == "GET" && DomainHelper.checkUser(cookie.Value))
         {
            context.Server.Transfer("./default.aspx");
         }
         if(context.Request.HttpMethod == "POST")
         {
            context.Server.Transfer("./default.aspx", true);
         }
         context.Response.Redirect("./default.aspx");
      }

      public bool IsReusable
      {
         get
         {
            return false;
         }
      }
   }
}