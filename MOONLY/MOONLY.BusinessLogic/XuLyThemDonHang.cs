using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.DataAccess.Insert;
using MOONLY.Common;
using System.Web.UI.WebControls;

namespace MOONLY.BusinessLogic
{
   public class XuLyThemDonHang
    {
        private DonHang _donhang;
        public DonHang Donhang
        {
            get { return _donhang; }
            set { _donhang = value; }
        }
        public void Thucthi()
        {
            ChenDuLieuDonHang chendulieudonhang = new ChenDuLieuDonHang();
            ChenDuLieuChiTietDonHang chenchitietdonhang = new ChenDuLieuChiTietDonHang();
            chendulieudonhang.Donhang = this.Donhang;
            GridView g = new GridView();
            g.DataSource = chendulieudonhang.chenVaLaydulieu();
            g.DataBind();
            Donhang.Iddonhang = int.Parse(g.Rows[0].Cells[0].Text);
            chenchitietdonhang.Chitietdonhang = Donhang.Chitietdonhang;
            for (int i = 0; i < Donhang.Chitietdonhang.Sanpham.Length; i++)
            {
                chenchitietdonhang.Chitietdonhang.Iddonhang = Donhang.Iddonhang;
                chenchitietdonhang.Chitietdonhang.Idsanpham =
                Donhang.Chitietdonhang.Sanpham[i].Idsanpham;
                chenchitietdonhang.Chitietdonhang.Soluong =
                Donhang.Chitietdonhang.Sanpham[i].Soluong;
                chenchitietdonhang.chendulieuchitiet();
            }
        }
    }
}
