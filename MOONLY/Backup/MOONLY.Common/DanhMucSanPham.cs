using System;
using System.Collections.Generic;
using System.Text;

namespace MOONLY.Common
{
   public class DanhMucSanPham
    {
        private int _iddanhmucsanpham;
        public int Iddanhmucsanpham
        {
            get { return _iddanhmucsanpham; }
            set { _iddanhmucsanpham = value; }
        }
        private string _tendanhmucsanpham;
        public string Tendanhmucsanpham
        {
            get { return _tendanhmucsanpham; }
            set { _tendanhmucsanpham = value; }
        }
        public DanhMucSanPham()
        {
        }
    }
}
