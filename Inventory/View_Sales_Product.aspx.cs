using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Net.Mail;

public partial class Inventory_View_Sales_Product : System.Web.UI.Page
{
    ProductMgmt pm = new ProductMgmt();
    SqlDataReader objReader;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_id"] == null || Session["user_name"] == null)
        {

            Response.Redirect("~/AdminLogin.aspx");
        }
        if (!IsPostBack)
        {
            pm.search_value = Txt_Search.Text;
            GridView1.DataSource = pm.Invoice_Product_Select(pm);
            GridView1.DataBind();
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        pm.search_value = Txt_Search.Text;
        GridView1.DataSource = pm.Invoice_Product_Select(pm);
        GridView1.DataBind();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "PRINT")
        {

            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            Label lblserialno = (Label)row.FindControl("lblserialno");
            Response.Redirect("~/print_Sales_Product.aspx?seno=" + lblserialno.Text);

        }
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
        //GridViewRow row = (GridViewRow)(((ImageButton)e.Keys).NamingContainer);
        Label lblserialno = (Label)row.FindControl("lblserialno");
        Response.Redirect("~/DeleteInvoice.aspx?seno=" + lblserialno.Text);
    }
    protected void View_Click(object sender, EventArgs e)
    {
        pm.search_value = Txt_Search.Text;
        GridView1.DataSource = pm.Invoice_Product_Select(pm);
        GridView1.DataBind();
    }
}