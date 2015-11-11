using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp_Data
{
   public class AdoData
   {

      private readonly string connection = ConfigurationManager.ConnectionStrings["AdoData"].ConnectionString;


      /// <summary>
      /// 
      /// </summary>
      /// <param name="command"></param>
      /// <param name="c"></param>
      /// <param name="table"></param>
      /// <returns></returns>
      /// 



      public void DataWriter(string title, string duration)
      {

         
         SqlCommand cmd = new SqlCommand();
         SqlParameter t = new SqlParameter("Title", title);
         SqlParameter d = new SqlParameter("Duration", duration);

         string cmdTxt = "INSERT INTO OctoberDB.Theater.Movie(Title, Duration) VALUES (@Title,@Duration)";

         using (SqlConnection conn = new SqlConnection(connection))
         {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdTxt;

            cmd.ExecuteNonQuery();

            conn.Close();
         }
         
      }


      /// <summary>
      /// 
      /// </summary>
      /// <param name="table"></param>
      /// <param name="c"></param>
      /// <returns></returns>
      public List<string> DataAdapter(string table, List<String> c)
      {
         DataSet ds = new DataSet();
         SqlDataAdapter da = new SqlDataAdapter();
         SqlCommand cmd = new SqlCommand();
         String cmdTxt = "select ";

         foreach (string collum in c)
         {
            cmdTxt += collum + ", ";
         }

         cmdTxt = cmdTxt.Substring(0, cmdTxt.Length - 2);

         cmdTxt += " from " + table;

         Console.WriteLine(cmdTxt);
         Console.WriteLine("");

         using (SqlConnection conn = new SqlConnection(connection))
         {
            cmd.Connection = conn;

            cmd.CommandText = cmdTxt;

            da.SelectCommand = cmd;
            da.Fill(ds);
         }

         Console.WriteLine("Number of entries: " + ds.Tables[0].Rows.Count);
         Console.WriteLine("");

         List<string> people = new List<string>();

         foreach (DataRow item in ds.Tables[0].Rows)
         {
            String currentRow = "";
            foreach (var i in c)
            {
               Console.Write(i + ": ");
               Console.WriteLine(item[i].ToString());
               currentRow += i + ": ";
               currentRow += item[i].ToString() + " ";
            }
            people.Add(currentRow);
            Console.WriteLine("");
         }

         return people;

      }



      /// <summary>
      /// 
      /// </summary>
      /// <param name="command"></param>
      /// <param name="c"></param>
      /// <param name="table"></param>
      /// <returns></returns>
      public List<string> selectDataReader(string table, List<String> c)
      {
         
         SqlDataReader dr;
         SqlCommand cmd = new SqlCommand();
         var people = new List<string>();
         String cmdTxt = "select ";


         foreach (string collum in c)
         {
            cmdTxt += collum + ", ";
         }

         cmdTxt = cmdTxt.Substring(0, cmdTxt.Length - 2);

         cmdTxt += " from " + table;

         Console.WriteLine(cmdTxt);
         
         using (SqlConnection conn = new SqlConnection(connection))
         {

            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdTxt;

            dr = cmd.ExecuteReader();


            Console.WriteLine("number of fields: " + dr.FieldCount);
            Console.WriteLine("");
            while (dr.Read())
            {

               String currentRow = "";
                  foreach (var i in c)
                  {
                     Console.Write(i + ": ");
                     Console.WriteLine(dr[i].ToString());
                     currentRow += i + ": ";
                     currentRow += dr[i].ToString() + " ";
                  }
                  Console.WriteLine("");
                  people.Add(currentRow);

               }
            }

         

         return people;

      }






   }
}
