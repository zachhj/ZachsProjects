using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp_Data
{
   public class AWData
   {
      private readonly string connection = ConfigurationManager.ConnectionStrings["AWData"].ConnectionString;

      public List<string> DataAdapter()
      {
         DataSet ds = new DataSet();

         SqlDataAdapter da = new SqlDataAdapter();
         SqlCommand cmd = new SqlCommand();


         using (SqlConnection conn = new SqlConnection(connection))
         {
            cmd.Connection = conn;
            cmd.CommandText = "select FirstName, LastName from Person.Person;";

            da.SelectCommand = cmd;
            da.Fill(ds);
         }


         List<string> people = new List<string>();

         foreach(DataRow item in ds.Tables[0].Rows)
         {
            people.Add(item["Firstname"].ToString() + " - " + item["Lastname"].ToString());
         }

         return people;

      }


      public List<string> DataReader()
      {

         SqlDataReader dr;
         SqlCommand cmd = new SqlCommand();

         var people = new List<string>();

         using (SqlConnection conn = new SqlConnection(connection))
         {

            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "select FirstName, LastName from Person.Person;";

            dr = cmd.ExecuteReader();

            
            while(dr.Read())
            {
               people.Add(dr["Firstname"].ToString() + " - " + dr["Lastname"].ToString());
            }

            conn.Close();
         }

         return people;

      }


   }
}
