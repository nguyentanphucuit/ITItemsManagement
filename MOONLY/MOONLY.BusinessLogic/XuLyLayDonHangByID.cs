using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.DataAccess.Select;
using System.Web.UI.WebControls;
using MOONLY.Common;

namespace MOONLY.BusinessLogic
{
   public class XuLyLayDonHangByID
    {
        private DonHang _donhang;
        public DonHang Donhang
        {
            get { return _donhang; }
            set { _donhang = value; }
        }
        private SqlDataSource _ketqua;
        public SqlDataSource Ketqua
        {
            get { return _ketqua; }
            set { _ketqua = value; }
        }
        public void Thucthi()
        {
            TruyVanDuLieuDonHangByID donhangbyid = new
            TruyVanDuLieuDonHangByID();
            donhangbyid.Donhang = this.Donhang;
            Ketqua = donhangbyid.Laydulieu();
            GridView grid = new GridView();
            grid.DataSource = Ketqua;
            grid.DataBind();
            if (grid.Rows.Count > 0)
            {
                if (grid.Rows[0].Cells[1].Text.ToString() != "&nbsp;")
                //grid.Rows[0].Cells[1]phu thuoc cau truy van, lay cot ngay xu ly don hang
                {
                    Donhang.Ngayxulydonhang =
                    Convert.ToDateTime(grid.Rows[0].Cells[1].Text.ToString());
                }
                Donhang.Trackingnumber =
                grid.Rows[0].Cells[3].Text.ToString().Replace("&nbsp;", "");
                Donhang.Idtinhtrangdonhang = int.Parse(grid.Rows[0].Cells[2].Text.ToString());

            }
        }
    }
}
