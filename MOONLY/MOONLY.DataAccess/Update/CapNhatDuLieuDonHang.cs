using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;
using MOONLY.Common;

namespace MOONLY.DataAccess.Update
{
  public  class CapNhatDuLieuDonHang
    {
        private DonHang _donhang;
        public DonHang Donhang
        {
            get { return _donhang; }
            set { _donhang = value; }
        }
        public void capnhatdulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.UpdateCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.UpdateCommand = "DonHang_Update";
            sqldata.UpdateParameters.Add("IDDonHang",Donhang.Iddonhang.ToString());
            sqldata.UpdateParameters.Add("IDTinhTrangDonHang",Donhang.Idtinhtrangdonhang.ToString());
            sqldata.UpdateParameters.Add("NgayXuLyDonHang",Donhang.Ngayxulydonhang.ToShortDateString());
            sqldata.UpdateParameters.Add("TrackingNumber",Donhang.Trackingnumber.ToString());
            sqldata.Update();
        }
    }
}
