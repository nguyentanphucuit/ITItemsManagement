using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using System.Web.UI.WebControls;

namespace MOONLY.DataAccess.Select
{
   public class TruyVanDuLieuDanhMucMaster
    {
        private DanhMucSanPham _danhmucsp;

        public DanhMucSanPham Danhmucsp
        {
            get { return _danhmucsp; }
            set { _danhmucsp = value; }
        }
        public SqlDataSource Laydulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "DanhMucSanPhamMaster_Select";
            return sqldata;
        }

    }
}
