using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using MOONLY.DataAccess.Insert;

namespace MOONLY.BusinessLogic
{
   public class XuLyThemGioHang
    {
        private GioHang _giohang;
        public GioHang Giohang
        {
            get { return _giohang; }
            set { _giohang = value; }
        }
        public void Thucthi()
        {
            ChenDuLieuGioHang dulieugiohang = new ChenDuLieuGioHang();
            dulieugiohang.Giohang = this.Giohang;
            dulieugiohang.chendulieugiohang();
        }
    }
}
