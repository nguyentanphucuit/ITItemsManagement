using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using System.Web.UI.WebControls;

namespace MOONLY.DataAccess.Insert
{
   public class ChenDuLieuChiTietDonHang
    {
        private ChiTietDonHang _chitietdonhang;
        public ChiTietDonHang Chitietdonhang
        {
            get { return _chitietdonhang; }
            set { _chitietdonhang = value; }
        }
        public void chendulieuchitiet()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.InsertCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.InsertCommand = "ChiTietDonHang_Insert";
            sqldata.InsertParameters.Add("IDDonhang", Chitietdonhang.Iddonhang.ToString());
            sqldata.InsertParameters.Add("IDsanpham", Chitietdonhang.Idsanpham.ToString());
            sqldata.InsertParameters.Add("Soluongsanpham", Chitietdonhang.Soluong.ToString());
            sqldata.Insert();
        }
    }
}
