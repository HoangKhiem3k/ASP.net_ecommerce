using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using QUANLYBANHANG.App_Code;
public partial class pageCHITIETSANPHAM : System.Web.UI.Page{
  
    DataTable tbSACH;
    PROCESSDATA xulydulieu;
    protected void Page_Load(object sender, EventArgs e) {
      
        String path = Server.MapPath("App_Data\\dbQUANLYBANHANG.mdf");
        xulydulieu = new PROCESSDATA(path); 
            String SQL = null;
            if (Request.QueryString.Get("IDSP") != null)
                SQL = "Select * from tbSACH WHERE MaSach=" + Request.QueryString.Get("IDSP");
            tbSACH = xulydulieu.getDataTable(SQL); 
         
            this.Repeater2.DataSource = tbSACH;
            this.Repeater2.DataBind();
            
            
            
    }
    
}