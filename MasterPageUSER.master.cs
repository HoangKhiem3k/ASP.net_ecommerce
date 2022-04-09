using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;//ngắt kết nối (Disconnected)
using QUANLYBANHANG.App_Code;
public partial class MasterPageUSER : System.Web.UI.MasterPage
{

    PROCESSDATA xulydulieu;
   public DataTable tbLOAISACH;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        String path = Server.MapPath("App_Data\\dbQUANLYBANHANG.mdf");
        xulydulieu = new PROCESSDATA(path); 
        String SQL = "Select * from tbLOAISACH";

        tbLOAISACH = xulydulieu.getDataTable(SQL);

        this.Repeater1.DataSource = tbLOAISACH;
        this.Repeater1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}
