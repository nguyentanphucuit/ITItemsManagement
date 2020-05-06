using System;
using System.Collections.Generic;
using System.Text;

namespace MOONLY.Common
{
    public class ChiTietDonHang
    {
        private int _idchitietdonhang;
        public int Idchitietdonhang
        {
            get { return _idchitietdonhang; }
            set { _idchitietdonhang = value; }
        }
        private int _iddonhang;
        public int Iddonhang
        {
            get { return _iddonhang; }
            set { _iddonhang = value; }
        }
        private int _idsanpham;
        public int Idsanpham
        {
            get { return _idsanpham; }
            set { _idsanpham = value; }
        }
        private int _soluong;
        public int Soluong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }
        private SanPham[] _sanpham;
        public SanPham[] Sanpham
        {
            get { return _sanpham; }
            set { _sanpham = value; }
        }
        public ChiTietDonHang()
        {
        }
    }
}
