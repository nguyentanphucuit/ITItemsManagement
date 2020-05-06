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

public partial class DangNhap : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        textUsername.Focus();
    }
    protected void btnDangNhap_Click(object sender, ImageClickEventArgs e)
    {
        if (IsValid)
        {
            NguoiDung nguoidung = new NguoiDung();
            XuLyDangNhapNguoiDung xulydangnhap = new XuLyDangNhapNguoiDung();
            nguoidung.Tendangnhap = textUsername.Text;
            nguoidung.Matkhau = textMatKhau.Text;
            xulydangnhap.Nguoidung = nguoidung;
            xulydangnhap.Thucthi();
            try
            {

                labelMessage.Text = "Đăng nhập thành công!";
            }
            catch
            {
                Response.Redirect("TrangLoi.aspx");
            }
            if (xulydangnhap.Dangnhaphople)
            {
                base.NguoiDungHienTai = xulydangnhap.Nguoidung;
                Label lblWelcome = (Label)Master.FindControl("lblchao");
                lblWelcome.Text = "Xin chào, " + base.NguoiDungHienTai.Hoten;
                if (Request.Cookies["ReturnURL"] != null)
                {
                    Response.Redirect(Request.Cookies["ReturnURL"].Value);
                }
                else
                {
                    Response.Redirect("DonHangKhach.aspx");
                }
            }
            else
            {
                labelMessage.Text = "Đăng nhập không thành công!";
            }
        }
    }
}
