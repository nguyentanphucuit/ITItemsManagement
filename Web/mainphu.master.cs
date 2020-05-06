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

public partial class mainphu : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click1(object sender, EventArgs e)
    {
        if (Request.Cookies["ReturnURL"] != null)
        {
            Response.Cookies["ReturnURL"].Expires = DateTime.Now.AddDays(-1);
        }
        Response.Redirect("DangNhap.aspx");
    }
}
