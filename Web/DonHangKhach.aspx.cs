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
using MOONLY.BusinessLogic;

public partial class DonHangKhach : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label lblWelcome = (Label)Master.FindControl("lblchao");
            lblWelcome.Text = "Xin chào, " + base.NguoiDungHienTai.Hoten;
            HienThiDonHang();
        }
    }
    private void HienThiDonHang()
    {
        XuLyLayDonHang laydonhang = new XuLyLayDonHang();
        laydonhang.Nguoidung = NguoiDungHienTai;

        try
        {
            laydonhang.Thucthi();
        }
        catch
        {
            Response.Redirect("Trangloi.aspx");
        }
        gridviewOrders.DataSource = laydonhang.Ketqua;
        gridviewOrders.DataBind();
    }
    protected void ImageButtontrove_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("GioiThieuSanPham.aspx");

    }
}
