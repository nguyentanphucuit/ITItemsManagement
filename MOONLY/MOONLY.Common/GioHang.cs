using System;
using System.Collections.Generic;
using System.Text;

namespace MOONLY.Common
{
   public class GioHang
    {
        private int _idgiohang;
        private string _cartguid;
        private int _soluong;
        private int _idsanpham;
        private DateTime _ngaytaogiohang;
        public int Idgiohang
        {
            get { return _idgiohang; }
            set { _idgiohang = value; }
        }
        public string Cartguid
        {
            get { return _cartguid; }
            set { _cartguid = value; }
        }
        public int Soluong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }
        public int Idsanpham
        {
            get { return _idsanpham; }
            set { _idsanpham = value; }
        }
        public DateTime Ngaytaogiohang
        {
            get { return _ngaytaogiohang; }
            set { _ngaytaogiohang = value; }
        }
        public GioHang()
        {
        }
    }
}
