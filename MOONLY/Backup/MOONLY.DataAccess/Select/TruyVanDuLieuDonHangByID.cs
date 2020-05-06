using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using System.Web.UI.WebControls;

namespace MOONLY.DataAccess.Select
{
   public class TruyVanDuLieuDonHangByID
    {
        private DonHang _donhang;
        public DonHang Donhang
        {
            get { return _donhang; }
            set { _donhang = value; }
        }
        public SqlDataSource Laydulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "DonHangByID_Select";
            sqldata.SelectParameters.Add("IDDonHang", Donhang.Iddonhang.ToString());
            return sqldata;
        }
    }
}
