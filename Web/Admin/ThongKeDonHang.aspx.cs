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

public partial class Admin_ThongKeDonHang : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            HienTatCaDonHang();
        }
    }
    private void HienTatCaDonHang()
    {
        XuLyLayTatCaDonHang laytatcadonhang = new XuLyLayTatCaDonHang();
        try
        {
            laytatcadonhang.Thucthi();
        }
        catch
        {
            Response.Redirect("../Trangloi.aspx");
        }
        gridTatCaDonHang.DataSource = laytatcadonhang.Ketqua;
        gridTatCaDonHang.DataBind();
    }
}
