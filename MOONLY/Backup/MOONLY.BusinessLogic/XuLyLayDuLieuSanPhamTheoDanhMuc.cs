using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using System.Web.UI.WebControls;
using MOONLY.DataAccess.Select;

namespace MOONLY.BusinessLogic
{
   public class XuLyLayDuLieuSanPhamTheoDanhMuc
    {
        private SanPham _sanpham;

        public SanPham Sanpham
        {
            get { return _sanpham; }
            set { _sanpham = value; }
        }
        private SqlDataSource _Ketqua;

        public SqlDataSource Ketqua
        {
            get { return _Ketqua; }
            set { _Ketqua = value; }
        }
        public void Thucthi()
        {
            TruyVanDuLieuSanPhamTheoDanhMuc truyvansanphamtheodanhmuc = new TruyVanDuLieuSanPhamTheoDanhMuc();
            truyvansanphamtheodanhmuc.Sanpham = this.Sanpham;
            Ketqua = truyvansanphamtheodanhmuc.Laydulieu();
        }

    }
}
