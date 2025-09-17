using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Graphicsweb.Models
{

    public class handlDb
    {
        SqlConnection cn;

        public handlDb()
        {

            cn = new SqlConnection("server=WINDOWS-SNAEAQL; database=Pratics; integrated security=True");
                /*SqlConnection( ConfigurationManager.ConnectionStrings["Pratics"].ToString());*/
            

        }
        public bool InsertData(ClintData cd)
        {
            string st = "Insert into Clint(Name,Mobile,Email,Plan,Descripson) values('" + cd.Name + "','" + cd.Mobile + "','" + cd.Email + "','" + cd.Plan + "','" + cd.Descripson + "')";
            SqlCommand cmd = new SqlCommand(st,cn);
            cn.Open();
          int i=  cmd.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
                {
                return true;
                 }
            else
            {
                return false;
            }
           
           
        }

    }
}