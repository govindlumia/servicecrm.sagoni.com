using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Inventory_Purchase_Product_View : System.Web.UI.Page
{
    ProductMgmt pm = new ProductMgmt();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_id"] == null || Session["user_name"] == null)
        {
            Response.Redirect("~/AdminLogin.aspx");
        }
        if (!IsPostBack)
        {
            pm.search_value = Txt_Search.Text;
            GridView1.DataSource = pm.Inventory_Product_Select(pm);
            GridView1.DataBind();
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "edit")
        {

            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            Label lblserialno = (Label)row.FindControl("lblserialno");
            Response.Redirect("~/Inventory/Inventory_Product.aspx?serial_no=" + lblserialno.Text);

        }
    }
    protected void View_Click(object sender, EventArgs e)
    {
        pm.search_value = Txt_Search.Text;
        GridView1.DataSource = pm.Inventory_Product_Select(pm);
        GridView1.DataBind();
    }
}