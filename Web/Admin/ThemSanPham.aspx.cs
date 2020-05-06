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

public partial class Admin_ThemSanPham : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtTenSanPham.Focus(); // txtTenSanPham là ID của TextBox
            HienThiDanhMucSanPham();
        }
    }
    private void HienThiDanhMucSanPham()
    {
        XuLyLayDanhMucSanPham xulydanhmucsanpham = new
        XuLyLayDanhMucSanPham();
        try
        {
            xulydanhmucsanpham.Thucthi();
        }
        catch
        {
            Response.Redirect("../Trangloi.aspx");
        }
        dropDanhMucSanPham.DataTextField = "TenDanhMucSanPham";
        // dropDanhMucSanPham là ID của điều khiển DropDownList
        dropDanhMucSanPham.DataValueField = "IDDanhMucSanPham";
        dropDanhMucSanPham.DataSource = xulydanhmucsanpham.Ketqua;
        dropDanhMucSanPham.DataBind();
    }
    protected void btnCapNhat_Click(object sender, EventArgs e)
    {
        if (IsValid)
        {
            XuLyThemSanPham themsanpham = new XuLyThemSanPham();
            MOONLY.Common.SanPham Spham = new MOONLY.Common.SanPham();
            Spham.Iddanhmucsanpham = int.Parse(dropDanhMucSanPham.SelectedItem.Value);
            Spham.Ten = txtTenSanPham.Text; // txtTenSanPham là ID của TextBox
            Spham.Mota = CKEditorControlMoTa.Text;//txtTenSanPham là ID của TextBox
            Spham.Dulieuhinhsanpham = fileuploadHinhSanPham.FileBytes;
            // fileuploadHinhSanPham là ID của điều khiển FileUpLoad
            Spham.Giasanpham = Convert.ToDecimal(txtGia.Text); // txtGia là ID của TextBox
            themsanpham.Sanpham = Spham;
            try
            {
                themsanpham.Thucthi();
            }
            catch
            {
                Response.Redirect("../Trangloi.aspx");
            }
            Response.Redirect("SanPham.aspx");
        }
    }
    protected void BtnBoQua_Click(object sender, EventArgs e)
    {
        Response.Redirect("SanPham.aspx");
    }
}
