using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using System.Web.UI.WebControls;

namespace MOONLY.DataAccess.Insert
{
   public class ChenDuLieuNguoiDung
    {
        private NguoiDung _nguoidung;
        public NguoiDung Nguoidung
        {
            get { return _nguoidung; }
            set { _nguoidung = value; }
        }
        public void chendulieunguoidung()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.InsertCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.InsertCommand = "NguoiDung_Insert";
            sqldata.InsertParameters.Add("HoTen", Nguoidung.Hoten.ToString());
            sqldata.InsertParameters.Add("TenDangNhap", Nguoidung.Tendangnhap.ToString());
            sqldata.InsertParameters.Add("DiaChi", Nguoidung.Diachi.ToString());
            sqldata.InsertParameters.Add("MaDienThoai", Nguoidung.Madienthoai.ToString());
            sqldata.InsertParameters.Add("SoDienThoai", Nguoidung.Sodienthoai.ToString());
            sqldata.InsertParameters.Add("SoFax", Nguoidung.Sofax.ToString());
            sqldata.InsertParameters.Add("Email", Nguoidung.Email.ToString());
            sqldata.InsertParameters.Add("IDKieuNguoiDung", Nguoidung.Idkieunguoidung.ToString());
            sqldata.InsertParameters.Add("MatKhau", Nguoidung.Matkhau.ToString());
            sqldata.Insert();

        }
    }
}
