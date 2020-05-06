using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using System.Data.SqlClient;
using System.Data;

namespace MOONLY.DataAccess.Update
{
  public  class CapNhatDuLieuSanPham
    {
        private SanPham _sanpham;
        public SanPham Sanpham
        {
            get { return _sanpham; }
            set { _sanpham = value; }
        }
        public void CapNhatSanphammoi()
        {
            KetNoi chuoiketnoi = new KetNoi();
            SqlConnection conect = new SqlConnection(chuoiketnoi.ConnectionString());
            conect.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conect;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "Sanpham_UpDate";
            com.Parameters.Add("@IdDanhMucSanPham", SqlDbType.Int).Value =
            Sanpham.Iddanhmucsanpham;
            com.Parameters.Add("@TenSanPham", SqlDbType.NVarChar).Value =
            Sanpham.Ten;
            com.Parameters.Add("@IdHinhSanPham", SqlDbType.Int).Value =
            Sanpham.Idhinhsanpham;
            com.Parameters.Add("@DuLieuHinhSanPham", SqlDbType.Image).Value =
            Sanpham.Dulieuhinhsanpham;
            com.Parameters.Add("@MoTaSanPham", SqlDbType.NText).Value =
            Sanpham.Mota;
            com.Parameters.Add("@GiaSanPham", SqlDbType.Int).Value =
            Sanpham.Giasanpham;
            com.Parameters.Add("@IdSanPham ", SqlDbType.Int).Value =
            Sanpham.Idsanpham;
            com.ExecuteNonQuery();
        }
    }
}
