using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Configuration;

namespace MOONLY.DataAccess
{
   public class KetNoi
    {
       public string ConnectionString()
       {
           return
           WebConfigurationManager.ConnectionStrings["SQLCONN"].ConnectionString;
           //Tra ve chuoi ket noi voi sql server cua bien SQLCONN. SQLCONN la ten do ta dat.
       }
    }
}
