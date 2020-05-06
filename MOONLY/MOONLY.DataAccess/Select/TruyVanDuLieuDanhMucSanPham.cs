using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;
using MOONLY.Common;

namespace MOONLY.DataAccess.Select
{
   public class TruyVanDuLieuDanhMucSanPham
    {
        private DanhMucSanPham _danhmucsanpham;
        public DanhMucSanPham Danhmucsanpham
        {
            get { return _danhmucsanpham; }
            set { _danhmucsanpham = value; }
        }
        public SqlDataSource Laydulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "DanhMucSanPham_Select";
            return sqldata;
        }
    }
}
