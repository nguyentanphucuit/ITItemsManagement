using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;

namespace MOONLY.DataAccess.Select
{
   public class TruyVanDuLieuTimSanPham
    {
       public SqlDataSource Laydulieu(string Tieuchuan)
       {
           SqlDataSource sqldata = new SqlDataSource();
           KetNoi chuoiketnoi = new KetNoi();
           sqldata.ConnectionString = chuoiketnoi.ConnectionString();
           sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
           sqldata.SelectCommand = "SanPham_SelectSearch";
           sqldata.SelectParameters.Add("tieuchuantim", Tieuchuan);
           return sqldata;
       }
    }
}
