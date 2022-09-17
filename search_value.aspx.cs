using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class search_value : System.Web.UI.Page
{
    clsRepair objRepair = new clsRepair();

     

protected void Page_Load(object sender, EventArgs e)
    {  if (Session["user_id"] == null || Session["user_name"] == null)
        {
            Response.Redirect("~/AdminLogin.aspx");
        }
    if (Request.QueryString["search_value"] != null)
    {

        Session["search_value"] = Request.QueryString["search_value"].ToString();
        string search_value = Request.QueryString["search_value"].ToString();

        grdlead.DataSource = objRepair.search_report_select(Request.QueryString["search_value"].ToString(), "Lead");
        grdlead.DataBind();

        grdrequestid.DataSource = objRepair.search_report_select(Request.QueryString["search_value"].ToString(), "Jobwork");
        grdrequestid.DataBind();

        grdcustomer.DataSource = objRepair.search_report_select(Request.QueryString["search_value"].ToString(), "Customer");
        grdcustomer.DataBind();

        grdrepair.DataSource = objRepair.search_report_select(Request.QueryString["search_value"].ToString(), "repair_invoice");
        grdrepair.DataBind();



    }
    }
protected void lblLeadNo_Click(object sender, EventArgs e)
{
    GridViewRow row = (GridViewRow)((LinkButton)sender).NamingContainer;
    //string lead_no = row.Cells[0].Text;
    //string customername = row.Cells[1].Text;
    //string mobile = row.Cells[2].Text;
    //string amount = row.Cells[3].Text;
    //string created_by = row.Cells[4].Text;
    //string Status_id = row.Cells[5].Text;
    LinkButton lblLeadNo = (LinkButton)row.FindControl("lblLeadNo");
    Label lblStatus_id = (Label)row.FindControl("lblStatus_id");
    Response.Redirect("~/Sales/CreateLead.aspx?LeadId=" + lblLeadNo.Text + "&lead_status=" + lblStatus_id.Text);

}
}