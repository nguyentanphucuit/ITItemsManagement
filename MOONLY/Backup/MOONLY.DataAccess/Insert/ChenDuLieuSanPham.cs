using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using MOONLY.Common;
using System.Data;

namespace MOONLY.DataAccess.Insert
{
   public class ChenDuLieuSanPham
    {
        private SanPham _sanpham;
        public SanPham Sanpham
        {
            get { return _sanpham; }
            set { _sanpham = value; }
        }
        public void ChenDuLieu()
        {
            KetNoi chuoiketnoi = new KetNoi();
            SqlConnection conect = new SqlConnection(chuoiketnoi.ConnectionString());
            conect.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conect;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "SanPham_Insert";
            com.Parameters.Add("@dulieuhinhsanpham", SqlDbType.Image).Value = Sanpham.Dulieuhinhsanpham;
            com.Parameters.Add("@TenSanPham", SqlDbType.NVarChar).Value = Sanpham.Ten;
            com.Parameters.Add("@IDDanhMucSanPham", SqlDbType.Int).Value = Sanpham.Iddanhmucsanpham;
            com.Parameters.Add("@MoTaSanPham", SqlDbType.NVarChar).Value = Sanpham.Mota;
            com.Parameters.Add("@GiaSanPham", SqlDbType.Int).Value = Sanpham.Giasanpham;
            com.ExecuteNonQuery();
        }
    }
}
