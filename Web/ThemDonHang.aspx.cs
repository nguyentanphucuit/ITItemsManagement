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
using MOONLY.Common;
using MOONLY.Operational;

public partial class ThemDonHang : BasePage
{
    private DonHang _donhang = new DonHang();
    private decimal _tongtien = 0; // để tính tổng cột thành tiền
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label lblWelcome = (Label)Master.FindControl("lblChao");
            lblWelcome.Text = "Xin chào, " + base.NguoiDungHienTai.Hoten;
            HienThiGioHang();
        }
    }
    //-----------------Hiển thị nội dung giỏ hàng giống trang GioHang.aspx-----------------
    private void HienThiGioHang()
    {
        MOONLY.Common.GioHang giohang = new MOONLY.Common.GioHang();
        giohang.Cartguid = TaoCartGUID.LayCartGUID();
        XuLyLayGioHang xulylaygiohang = new XuLyLayGioHang();
        xulylaygiohang.Giohang = giohang;
        try
        {
            xulylaygiohang.Thucthi();
            gridgiohang.DataSource = xulylaygiohang.Ketqua;
            gridgiohang.DataBind();
        }
        catch
        {
            Response.Redirect("Trangloi.aspx");
        }
    }
    //-------------------Tính tổng cộng của cột thành tiền trong Gridview-------------
    protected void gridgiohang_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            _tongtien += Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "ThanhTien"));
        }
        lblTotal.Text = _tongtien.ToString() + " VND";
    }
    //---------Tạo đơn hàng, dựa số liệu trên gridview giỏ hàng-------------------
    private void GuiDonHang()
    {
        XuLyThemDonHang themdonhang = new XuLyThemDonHang();
        themdonhang.Donhang = _donhang;

        try
        {
            themdonhang.Thucthi();
        }
        catch
        {
            Response.Redirect("Trangloi.aspx");
        }
        Response.Redirect("GioiThieuSanPham.aspx");
    }
    //---------------Sự kiện cho nút tiếp tục mua hàng----------------------------------
    protected void ImageButtonTieptucmuahang_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("GioiThieuSanPham.aspx");
    }
    //---------------Sự kiện cho nút tạo và gửi đơn hàng-----------------

    protected void ImageButtonTaovaguidonhang_Click(object sender, ImageClickEventArgs e)
    {
        MOONLY.Common.DonHang donhang = new MOONLY.Common.DonHang();
        SanPham[] prods = new SanPham[gridgiohang.Rows.Count];
        foreach (GridViewRow grow in gridgiohang.Rows)
        {
            if (grow.RowType == DataControlRowType.DataRow)
            {
                SanPham Spham = new SanPham();
                DataKey data = gridgiohang.DataKeys[grow.DataItemIndex];
                Spham.Idsanpham = int.Parse(data.Values["IdSanPham"].ToString());
                Label lblTenSanPham = (Label)grow.FindControl("lblTenSanPham");
                Spham.Ten = lblTenSanPham.Text;
                Label lblSoLuong = (Label)grow.FindControl("lblSoLuong");
                Spham.Soluong = int.Parse(lblSoLuong.Text);
                Label lblDonGia = (Label)grow.FindControl("lblDonGia");
                Spham.Giasanpham = Convert.ToInt32(lblDonGia.Text.Replace("VND", ""));
                prods.SetValue(Spham, grow.DataItemIndex);
            }
        }
        _donhang.Chitietdonhang.Sanpham = prods;
        _donhang.Idnguoidung = NguoiDungHienTai.Idnguoidung;
        //Giả lập tạo TransactionID
        _donhang.Idgiaodich = Guid.NewGuid().ToString();
        GuiDonHang();
    }
}
