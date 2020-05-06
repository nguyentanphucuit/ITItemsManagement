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

public partial class SanPhamTheoDanhMuc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            HienThiSanPham();
        }

    }
    private void HienThiSanPham()
    {
        SanPham sanpham = new SanPham();
        sanpham.Iddanhmucsanpham = int.Parse(Request.QueryString["IdDanhMucSanPham"]);
        XuLyLayDuLieuSanPhamTheoDanhMuc xulylaysanpham = new XuLyLayDuLieuSanPhamTheoDanhMuc();
        xulylaysanpham.Sanpham = sanpham;
        try
        {
            xulylaysanpham.Thucthi();
        }
        catch
        {
            Response.Redirect("Trangloi.aspx");
        }
        dtlSanPhamDM.DataSource = xulylaysanpham.Ketqua;
        dtlSanPhamDM.DataBind();
    }
}
