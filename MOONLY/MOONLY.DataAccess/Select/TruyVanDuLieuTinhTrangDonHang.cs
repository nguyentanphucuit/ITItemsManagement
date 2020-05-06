using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;

namespace MOONLY.DataAccess.Select
{
  public  class TruyVanDuLieuTinhTrangDonHang
    {
      public SqlDataSource Laydulieu()
      {
          SqlDataSource sqldata = new SqlDataSource();
          KetNoi chuoiketnoi = new KetNoi();
          sqldata.ConnectionString = chuoiketnoi.ConnectionString();
          sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
          sqldata.SelectCommand = "TinhTrangDonHang_Select";
          return sqldata;
      }

    }
}
