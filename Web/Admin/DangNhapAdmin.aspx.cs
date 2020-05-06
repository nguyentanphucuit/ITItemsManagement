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

public partial class Admin_DangNhapAdmin1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        textUsername.Focus();
    }
    protected void btnDangNhap_Click(object sender, EventArgs e)
    {
        if (IsValid)
        {
            NguoiDung nguoidung = new NguoiDung();
            XuLyDangNhapAdmin xulydangnhapadmin = new XuLyDangNhapAdmin();
            nguoidung.Tendangnhap = textUsername.Text;
            nguoidung.Matkhau = textMatKhau.Text;
            xulydangnhapadmin.Nguoidung = nguoidung;
            try
            {
                xulydangnhapadmin.Thucthi();
                if (xulydangnhapadmin.IsAuthenticated)
                {
                    FormsAuthentication.RedirectFromLoginPage(textUsername.Text, false);
                }
                else
                {
                    labelMessage.Text = "Đăng nhập không thành công!";
                }
            }
            catch
            {
                Response.Redirect("../Trangloi.aspx");
            }
        }
    }
}
