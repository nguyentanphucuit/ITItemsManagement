using System;
using System.Collections.Generic;
using System.Text;

namespace MOONLY.Common
{
   public class SanPham
    {
        private int _idsanpham;
        public int Idsanpham
        {
            get { return _idsanpham; }
            set { _idsanpham = value; }
        }
        private int _iddanhmucsanpham;
        public int Iddanhmucsanpham
        {
            get { return _iddanhmucsanpham; }
            set { _iddanhmucsanpham = value; }
        }
        private DanhMucSanPham _danhmucsanpham;
        public DanhMucSanPham Danhmucsanpham
        {
            get { return _danhmucsanpham; }
            set { _danhmucsanpham = value; }
        }
        private string _ten;
        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }
        private string _mota;
        public string Mota
        {
            get { return _mota; }
            set { _mota = value; }
        }
        private int _soluong;
        public int Soluong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }
        private int _idhinhsanpham;
        public int Idhinhsanpham
        {
            get { return _idhinhsanpham; }
            set { _idhinhsanpham = value; }
        }
        private byte[] _dulieuhinhsanpham;
        public byte[] Dulieuhinhsanpham
        {
            get { return _dulieuhinhsanpham; }
            set { _dulieuhinhsanpham = value; }
        }
        private decimal _giasanpham;
        public decimal Giasanpham
        {
            get { return _giasanpham; }
            set { _giasanpham = value; }
        }
        public SanPham()
        {
            _danhmucsanpham = new DanhMucSanPham();
        }
    }
}
