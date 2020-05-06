using System;
using System.Collections.Generic;
using System.Text;

namespace MOONLY.Common
{
   public class DonHang
    {
        private int _iddonhang;
        public int Iddonhang
        {
            get { return _iddonhang; }
            set { _iddonhang = value; }
        }
        private int _idnguoidung;
        public int Idnguoidung
        {
            get { return _idnguoidung; }
            set { _idnguoidung = value; }
        }
        private DateTime _ngaytaodonhang;
        public DateTime Ngaytaodonhang
        {
            get { return _ngaytaodonhang; }
            set { _ngaytaodonhang = value; }
        }
        private DateTime _ngayxulydonhang;
        public DateTime Ngayxulydonhang
        {
            get { return _ngayxulydonhang; }
            set { _ngayxulydonhang = value; }
        }
        private int _idtinhtrangdonhang;
        public int Idtinhtrangdonhang
        {
            get { return _idtinhtrangdonhang; }
            set { _idtinhtrangdonhang = value; }
        }
        private string _trackingnumber;
        public string Trackingnumber
        {
            get { return _trackingnumber; }
            set { _trackingnumber = value; }
        }
        private NguoiDung _nguoidung;
        public NguoiDung Nguoidung
        {
            get { return _nguoidung; }
            set { _nguoidung = value; }
        }
        private ChiTietDonHang _chitietdonhang;
        public ChiTietDonHang Chitietdonhang
        {
            get { return _chitietdonhang; }
            set { _chitietdonhang = value; }
        }
        private string _idgiaodich;
        public string Idgiaodich
        {
            get { return _idgiaodich; }
            set { _idgiaodich = value; }
        }
        public DonHang()
        {
            _chitietdonhang = new ChiTietDonHang();
            _nguoidung = new NguoiDung();
        }
    }
}
