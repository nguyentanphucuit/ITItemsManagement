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
using MOONLY.Operational;

public partial class ThemGioHang : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        XuLyThemGioHang xulygiohang = new XuLyThemGioHang();
        MOONLY.Common.GioHang giohang = new MOONLY.Common.GioHang();
        giohang.Idsanpham = int.Parse(Request.QueryString["IDsanpham"]);
        giohang.Cartguid = CartGUID;
        giohang.Soluong = 1;
        xulygiohang.Giohang = giohang;
        
        try
           {
        xulygiohang.Thucthi();
        }
        catch
        {
        Response.Redirect("Trangloi.aspx");
        }
        Response.Redirect("GioHang.aspx");
        }
        private string CartGUID
        {
        get { return TaoCartGUID.LayCartGUID(); }
    }
    }
