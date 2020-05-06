using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.DataAccess.Select;
using MOONLY.Common;
using System.Web.UI.WebControls;

namespace MOONLY.BusinessLogic
{
   public class XuLyDangNhapNguoiDung
    {
        private NguoiDung _nguoidung;
        private SqlDataSource _ketqua;
        public SqlDataSource Ketqua
        {
            get { return _ketqua; }
            set { _ketqua = value; }
        }
        private bool _dangnhaphople;
        public bool Dangnhaphople
        {
            get { return _dangnhaphople; }
            set { _dangnhaphople = value; }
        }
        public void Thucthi()
        {
            TruyVanDuLieuDangNhapNguoiDung dulieunguoidung = new
            TruyVanDuLieuDangNhapNguoiDung();
            dulieunguoidung.Nguoidung = this.Nguoidung;
            Ketqua = dulieunguoidung.Laydulieu();
            GridView grid = new GridView();
            grid.DataSource = Ketqua;
            grid.DataBind();
            if (grid.Rows.Count != 0)
            {
                Dangnhaphople = true;
                Nguoidung.Hoten = grid.Rows[0].Cells[0].Text;
                Nguoidung.Idnguoidung = int.Parse(grid.Rows[0].Cells[1].Text);
            }
            else
            {
                Dangnhaphople = false;
            }
        }
        public NguoiDung Nguoidung
        {
            get { return _nguoidung; }
            set { _nguoidung = value; }
        }
    }
}
