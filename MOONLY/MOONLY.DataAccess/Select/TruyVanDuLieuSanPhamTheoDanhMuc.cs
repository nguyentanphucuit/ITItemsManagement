using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using System.Web.UI.WebControls;

namespace MOONLY.DataAccess.Select
{
  public  class TruyVanDuLieuSanPhamTheoDanhMuc
    {
        private SanPham _sanpham;

        public SanPham Sanpham
        {
            get { return _sanpham; }
            set { _sanpham = value; }
        }
        public SqlDataSource Laydulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "SanPhamTheoDanhMuc_Select";
            sqldata.SelectParameters.Add("IdDanhMucSanPham", Sanpham.Iddanhmucsanpham.ToString());
            return sqldata;
        }

    }
}
