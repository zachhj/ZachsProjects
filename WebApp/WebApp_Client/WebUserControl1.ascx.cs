using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp_Domain;

namespace WebApp_Client
{
   public partial class WebUserControl1 : System.Web.UI.UserControl
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         if (IsPostBack)
         {

         }
         else
         {
         }
      }


      public void LoginCheck()
      {
         var user = usernameText.Text;
         var pass = passwordText.Text;

         if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
         {
            return;
         }

         else
         {

            if (DomainHelper.CheckPerson(user, pass))
            {

               var cookieID = DomainHelper.MakeCookie(user, pass);
               var cookie = new HttpCookie("web", cookieID);
               cookie.HttpOnly = true;

               Response.Cookies.Add(cookie);
               Response.Redirect("./default.aspx");

            }

            clearLogin();
         }
      }

      private void clearLogin()
      {
         usernameText.Text = string.Empty;
         passwordText.Text = string.Empty;
      }

      protected void loginButton_Click(object sender, EventArgs e)
      {
         LoginCheck();
      }

      protected void clearButton_Click(object sender, EventArgs e)
      {
         if (!IsPostBack)
         {
            clearLogin();
         }
      }
   }
}