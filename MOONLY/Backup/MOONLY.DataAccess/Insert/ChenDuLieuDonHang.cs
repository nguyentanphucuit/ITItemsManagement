using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using System.Web.UI.WebControls;

namespace MOONLY.DataAccess.Insert
{
  public  class ChenDuLieuDonHang
    {
        private DonHang _donhang;
        public DonHang Donhang
        {
            get { return _donhang; }
            set { _donhang = value; }
        }
        public SqlDataSource chenVaLaydulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.InsertCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.InsertCommand = "DonHang_Insert";
            sqldata.InsertParameters.Add("IdNguoiDung", Donhang.Idnguoidung.ToString());
            sqldata.InsertParameters.Add("IdGiaoDich", Donhang.Idgiaodich.ToString());
            sqldata.Insert();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "DonHang_Top1_Select ";
            return sqldata;
        }
    }
}
