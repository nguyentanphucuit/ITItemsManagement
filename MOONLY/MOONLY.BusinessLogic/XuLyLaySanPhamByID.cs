using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.DataAccess.Select;
using MOONLY.Common;
using System.Web.UI.WebControls;

namespace MOONLY.BusinessLogic
{
   public class XuLyLaySanPhamByID
    {
        private SanPham _sanpham;
        private SqlDataSource _ketqua;
        public SqlDataSource Ketqua
        {
            get { return _ketqua; }
            set { _ketqua = value; }
        }
        public SanPham Sanpham
        {
            get { return _sanpham; }
            set { _sanpham = value; }
        }
        public void Thucthi()
        {
            TruyVanDuLieuSanPhamByID truyvansanphamtbyid = new
            TruyVanDuLieuSanPhamByID();
            truyvansanphamtbyid.Sanpham = Sanpham;
            Ketqua = truyvansanphamtbyid.Laydulieu();
            GridView grid = new GridView();
            grid.DataSource = Ketqua;
            grid.DataBind();
            Sanpham.Ten = grid.Rows[0].Cells[1].Text.ToString();
            Sanpham.Mota = grid.Rows[0].Cells[4].Text.ToString();
            Sanpham.Giasanpham = Convert.ToInt32(grid.Rows[0].Cells[5].Text.ToString());
            Sanpham.Idsanpham = int.Parse(grid.Rows[0].Cells[0].Text.ToString());
            Sanpham.Danhmucsanpham.Tendanhmucsanpham = grid.Rows[0].Cells[2].Text.ToString();
            Sanpham.Idhinhsanpham = int.Parse(grid.Rows[0].Cells[3].Text.ToString());
        }

    }
}
