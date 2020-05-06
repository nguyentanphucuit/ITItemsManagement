using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using System.Web.UI.WebControls;

namespace MOONLY.DataAccess.Update
{
   public class CapNhatDuLieuGioHang
    {
        private GioHang _giohang;
        public GioHang Giohang
        {
            get { return _giohang; }
            set { _giohang = value; }
        }
        public void capnhatdulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.UpdateCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.UpdateCommand = "GioHang_Update";
            sqldata.UpdateParameters.Add("SoLuong", Giohang.Soluong.ToString());
            sqldata.UpdateParameters.Add("IDGioHang", Giohang.Idgiohang.ToString());
            sqldata.Update();
        }
    }
}
