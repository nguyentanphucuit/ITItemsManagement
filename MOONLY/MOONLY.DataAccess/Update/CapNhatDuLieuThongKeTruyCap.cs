using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;

namespace MOONLY.DataAccess.Update
{
   public class CapNhatDuLieuThongKeTruyCap
    {
       public void Capnhatdulieu()
       {
           SqlDataSource sqldata = new SqlDataSource();
           KetNoi chuoiketnoi = new KetNoi();
           sqldata.ConnectionString = chuoiketnoi.ConnectionString();
           sqldata.UpdateCommandType = SqlDataSourceCommandType.StoredProcedure;
           sqldata.UpdateCommand = "NguoiTruyCap_Update";
           sqldata.Update();
       }
    }
}
