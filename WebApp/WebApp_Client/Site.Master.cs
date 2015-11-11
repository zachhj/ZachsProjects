using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_Client
{
   public partial class Site : System.Web.UI.MasterPage
   {
      protected void Page_Load(object sender, EventArgs e)
      {

      }

      protected void StartPage_Click(object sender, EventArgs e)
      {
         Response.Redirect("./StartPage.aspx");
      }

      protected void FreeContent_Click(object sender, EventArgs e)
      {
         Response.Redirect("./FreeContent.aspx");
      }

      protected void Login_Click(object sender, EventArgs e)
      {
         Response.Redirect("./login.aspx");
      }

      protected void Default_Click(object sender, EventArgs e)
      {
         Response.Redirect("./default.aspx");
      }

      protected void SiteLoginButton_Click(object sender, EventArgs e)
      {
         LoginPanel.Visible = !LoginPanel.Visible;
         siteLoginButton.Text = LoginPanel.Visible ? "close login menu" : "open login menu";
      }

      
   }
}