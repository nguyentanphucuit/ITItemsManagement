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

public partial class ChiTietSanPham : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Hienchitietsanpham();
        }
    }
    private void Hienchitietsanpham()
    {
        SanPham Spham = new SanPham();
        Spham.Idsanpham = int.Parse(Request.QueryString["IdSanPham"]);
        XuLyLaySanPhamByID laySanPham = new XuLyLaySanPhamByID();
        laySanPham.Sanpham = Spham;
        try
        {
            laySanPham.Thucthi();
        }
        catch
        {
            Response.Redirect("Trangloi.aspx");
        }
        dtlChiTietSanPham.DataSource = laySanPham.Ketqua;
        // dtlChiTietSanPham là ID của DataList
        dtlChiTietSanPham.DataBind();

    }
}
