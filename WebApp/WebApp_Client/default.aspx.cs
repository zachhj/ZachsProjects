using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp_Domain;

namespace WebApp_Client
{
   public partial class _default : System.Web.UI.Page
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         if (IsPostBack)
         {

         }
         else
         {
            FillBox(DomainHelper.PersonLoader());
            var cookie = Request.Cookies.Get("web");
            if (cookie == null || !DomainHelper.checkUser(cookie.Value))
            {
               Response.Redirect("./login.aspx");
            }
         }

      }


      private void FillBox(IEnumerable<Person> people)
      {
         nameList.Items.Clear();
         
         foreach (var item in people.ToList())
         {
            nameList.Items.Add(item.ToString());
         }
      }


      private void FillDrop(IEnumerable<Person> people)
      {
         nameDrop.Items.Clear();
         foreach (var item in people.ToList())
         {
            nameDrop.Items.Add(item.ToString());
         }
      }


      private void searchButton()
      {
         var a = nameText.Text;
         nameText.Equals("");

         List<Person> p = new List<Person>();

         List<Person> pl = DomainHelper.PersonLoader().ToList();

         foreach(Person person in pl)
         {
            if(person.FirstName.Equals(a)  || person.LastName.Equals(a))
            {
               p.Add(person);  
            }
         }

         FillBox(p);

      }

      private void searchSuggest()
      {
         string a = nameText.Text;
         var b = a.Length;

         List<Person> p = new List<Person>();

         List<Person> pl = DomainHelper.PersonLoader().ToList();

         foreach (Person person in pl)
         {
            if (person.FirstName.Contains(a) || person.LastName.Contains(a))
            {
               p.Add(person);
            }
         }

         FillDrop(p);
      }

      protected void nameButton_Click(object sender, EventArgs e)
      {
         //searchButton();
      }

      protected void nameText_TextChanged(object sender, EventArgs e)
      {
         searchSuggest();
      }



   }
}