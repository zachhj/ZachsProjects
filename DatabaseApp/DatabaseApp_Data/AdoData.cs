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



       public List<string> DataAdapter(String command, List<String> c, string table)
       {
          DataSet ds = new DataSet();

          SqlDataAdapter da = new SqlDataAdapter();
          SqlCommand cmd = new SqlCommand();


          String cmdTxt = "";

             cmdTxt += command + " ";

             foreach(string collum in c)
             {
                cmdTxt += collum + ", ";
             }

             cmdTxt = cmdTxt.Substring(0, cmdTxt.Length-2);

             cmdTxt += " from " + table;

             Console.WriteLine(cmdTxt);

          using (SqlConnection conn = new SqlConnection(connection))
          {
             cmd.Connection = conn;

             cmd.CommandText = cmdTxt;

             da.SelectCommand = cmd;
             da.Fill(ds);
          }

          Debug.WriteLine(ds.Tables[0].Rows.Count);
          List<string> people = new List<string>();

          foreach (DataRow item in ds.Tables[0].Rows)
          {
             String currentRow = "";
             foreach(var i in c)
             {
                Console.WriteLine(item);
                currentRow += item[i].ToString() + " ";
             }
             //Debug.WriteLine(people.Add(item["Firstname"].ToString() + " - " + item["Lastname"].ToString()));
          }

          return people;

       }


       public List<string> DataReader(String command, List<String> c, string table)
       {

          SqlDataReader dr;
          SqlCommand cmd = new SqlCommand();

          var people = new List<string>();

          String cmdTxt = "";

          cmdTxt += command + " ";

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


             while (dr.Read())
             {

                String currentRow = "";
                foreach (var i in c)
                {
                   currentRow += dr[i].ToString() + " ";
                }


                people.Add(currentRow);
             }

             conn.Close();
          }

          return people;

       }






    }
}
