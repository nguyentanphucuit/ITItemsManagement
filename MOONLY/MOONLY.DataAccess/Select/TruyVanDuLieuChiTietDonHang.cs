using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using System.Web.UI.WebControls;

namespace MOONLY.DataAccess.Select
{
  public  class TruyVanDuLieuChiTietDonHang
    {
        private ChiTietDonHang _chitietdonhang;
        public SqlDataSource Laydulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "ChiTietDonHang_Select";
            sqldata.SelectParameters.Add("Iddonhang", Chitietdonhang.Iddonhang.ToString());
            return sqldata;
        }
        public ChiTietDonHang Chitietdonhang
        {
            get { return _chitietdonhang; }
            set { _chitietdonhang = value; }
        }
    }
}
