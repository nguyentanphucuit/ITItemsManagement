using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;
using MOONLY.Common;

namespace MOONLY.DataAccess.Select
{
   public class TruyVanDuLieuSanPhamByID
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
            sqldata.SelectCommand = "SanPhamByID_Select";
            sqldata.SelectParameters.Add("IdSanPham ", Sanpham.Idsanpham.ToString());
            return sqldata;
        }
    }
}
