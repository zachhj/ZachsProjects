﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_Client
{
   public partial class timecontrol : System.Web.UI.UserControl
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         timeLabel.Text = DateTime.Now.ToString();
      }

      protected void timeButton_Click(object sender, EventArgs e)
      {

      }
   }
}