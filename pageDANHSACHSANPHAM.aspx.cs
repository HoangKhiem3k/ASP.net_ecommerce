using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using QUANLYBANHANG.App_Code; 
public partial class pageDANHSACHSANPHAM : System.Web.UI.Page
{
    PROCESSDATA xulydulieu;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        String path = Server.MapPath("App_Data\\dbQUANLYBANHANG.mdf");

        xulydulieu = new PROCESSDATA(path); 

        String SQL = "select * from tbSACH";

        if (Request.QueryString.Get("IDDM") != null)
            SQL += " where MaLoai=" + Request.QueryString.Get("IDDM");

        this.DataList1.DataSource = xulydulieu.getDataTable(SQL) ;
        this.DataList1.DataBind();
        this.DataList1.RepeatColumns = 3;
       
    }
}