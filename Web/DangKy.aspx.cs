using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using MOONLY.Common;
using MOONLY.BusinessLogic;

public partial class DangKy : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        textHoTen.Focus();
    }

    protected void btnDangKy_Click(object sender, ImageClickEventArgs e)
    {
        NguoiDung nguoidung = new NguoiDung();
        XuLyThemNguoiDung themnguoidung = new XuLyThemNguoiDung();
        if (IsValid)
        {
            nguoidung.Idkieunguoidung = (int)Enums.KieuNguoiDung.CUSTOMER;
            nguoidung.Hoten = textHoTen.Text;
            nguoidung.Tendangnhap = textTenDangNhap.Text;
            nguoidung.Diachi = textQuanHuyen.Text;
            nguoidung.Madienthoai = textMaDienThoai.Text;
            nguoidung.Matkhau = textMatKhau.Text;
            nguoidung.Email = textEmail.Text;
            nguoidung.Sodienthoai = textSoDienThoai.Text;
            nguoidung.Sofax = textFax.Text;
            themnguoidung.Nguoidung = nguoidung;
            try
            {
                themnguoidung.Thucthi();
            }
            catch
            {
                Response.Redirect("TrangLoi.aspx");
            }
            NguoiDungHienTai = themnguoidung.Nguoidung;
            Response.Redirect("DangNhap.aspx");
        }
    }
}
