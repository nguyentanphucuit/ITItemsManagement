using System;
using System.Collections.Generic;
using System.Text;

namespace MOONLY.Common
{
   public class KieuNguoiDung
    {
        private int _idkieunguoidung;
        public int Idkieunguoidung
        {
            get { return _idkieunguoidung; }
            set { _idkieunguoidung = value; }
        }
        private string _tennguoidung;
        public string Tennguoidung
        {
            get { return _tennguoidung; }
            set { _tennguoidung = value; }
        }
        public KieuNguoiDung()
        {
        }
    }
}
