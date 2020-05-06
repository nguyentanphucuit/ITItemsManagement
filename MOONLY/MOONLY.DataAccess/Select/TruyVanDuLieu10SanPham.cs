using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;

namespace MOONLY.DataAccess.Select
{
   public class TruyVanDuLieu10SanPham
    {
       public SqlDataSource Laydulieu()
       {
           SqlDataSource sqldata = new SqlDataSource();
           KetNoi chuoiketnoi = new KetNoi();
           sqldata.ConnectionString = chuoiketnoi.ConnectionString();
           sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
           sqldata.SelectCommand = "SanPham10_Select";
           return sqldata;
       }
    }
}
