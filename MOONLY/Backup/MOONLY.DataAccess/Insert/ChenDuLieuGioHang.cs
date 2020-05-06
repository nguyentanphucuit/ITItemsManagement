using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;
using MOONLY.Common;

namespace MOONLY.DataAccess.Insert
{
    public class ChenDuLieuGioHang
    {
        private GioHang _giohang;
        public GioHang Giohang
        {
            get { return _giohang; }
            set { _giohang = value; }
        }
        public void chendulieugiohang()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.InsertCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.InsertCommand = "GioHang_Insert";
            sqldata.InsertParameters.Add("CartGUID", Giohang.Cartguid);
            sqldata.InsertParameters.Add("IDSanPham", Giohang.Idsanpham.ToString());
            sqldata.InsertParameters.Add("SoLuong", Giohang.Soluong.ToString());
            sqldata.Insert();
        }
    }
}
