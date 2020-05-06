using System;
using System.Collections.Generic;
using System.Text;
using MOONLY.Common;
using MOONLY.DataAccess.Update;

namespace MOONLY.BusinessLogic
{
   public class XuLyCapNhatGioHang
    {
        private GioHang _giohang;
        public GioHang Giohang
        {
            get { return _giohang; }
            set { _giohang = value; }
        }
        public void Thucthi()
        {
            CapNhatDuLieuGioHang dulieugiohang = new CapNhatDuLieuGioHang();
            dulieugiohang.Giohang = this.Giohang;
            dulieugiohang.capnhatdulieu();
        }
    }
}
