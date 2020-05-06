using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.DataAccess.Select;
using System.Web.UI.WebControls;

namespace MOONLY.BusinessLogic
{
    public class XuLyLayTimSanPham
    {
        private SqlDataSource _ketqua;
        public SqlDataSource Ketqua
        {
            get { return _ketqua; }
            set { _ketqua = value; }
        }
        private string _tieuchuantim;
        public string Tieuchuantim
        {
            get { return _tieuchuantim; }
            set { _tieuchuantim = value; }
        }
        public void thucthi()
        {
            TruyVanDuLieuTimSanPham timsanpham = new TruyVanDuLieuTimSanPham();
            Ketqua = timsanpham.Laydulieu(Tieuchuantim);

        }
    }
}