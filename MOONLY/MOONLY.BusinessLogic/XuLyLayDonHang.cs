using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using System.Web.UI.WebControls;
using MOONLY.DataAccess.Select;

namespace MOONLY.BusinessLogic
{
  public  class XuLyLayDonHang
    {
        private NguoiDung _nguoidung;
        public NguoiDung Nguoidung
        {
            get { return _nguoidung; }
            set { _nguoidung = value; }
        }
        private SqlDataSource _ketqua;
        public SqlDataSource Ketqua
        {
            get { return _ketqua; }
            set { _ketqua = value; }
        }
        public void Thucthi()
        {
            TruyVanDuLieuDonHang donhangchon = new TruyVanDuLieuDonHang();
            donhangchon.NguoiDung = this.Nguoidung;
            Ketqua = donhangchon.Laydulieu();
        }
    }
}
