using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using System.Web.UI.WebControls;
using MOONLY.DataAccess.Select;

namespace MOONLY.BusinessLogic
{
   public class XuLyLayHinhSanPham
    {
        private SanPham _sanpham;
        public SanPham Sanpham
        {
            get { return _sanpham; }
            set { _sanpham = value; }
        }
        private SqlDataSource _ketqua;
        public SqlDataSource Ketqua
        {
            get { return _ketqua; }
            set { _ketqua = value; }
        }
        public void Thucthi()
        {
            TruyVanDuLieuHinhSanPhamByID chonhinhsanpham = new
            TruyVanDuLieuHinhSanPhamByID();
            chonhinhsanpham.Sanpham = this.Sanpham;
            Ketqua = chonhinhsanpham.Laydulieu();
        }
    }
}
