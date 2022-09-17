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
using System.IO;

public partial class lead_allocation : System.Web.UI.Page
{
    SqlDataReader objReader;
    clsSales objSales = new clsSales();
    DataTable dt;
    string otherUser, strissue, fromdate, enddate, allocate_to, auto_allocatedto;
    string assign;
    int ExpectedRevenue;

    protected void Page_Load(object sender, EventArgs e)
    {

        Response.AppendHeader("Refresh", "40");

        if (Session["user_id"] == null || Session["user_name"] == null)
        {
            Response.Redirect("~/AdminLogin.aspx");
        }
       
        if (!this.IsPostBack)
        {

            fromdate = DateTime.UtcNow.ToString();
            enddate = DateTime.UtcNow.ToString();
           
            objSales.from_date = Convert.ToDateTime(fromdate);
            objSales.to_date = Convert.ToDateTime(enddate);
            objSales.Office_id = "1";
            objSales.created_by = "0";
            objSales.lead_source = "0";
            objSales.Flag = "1";
            grdLead.DataSource = objSales.Lead_allocation_agent_view(objSales);
            grdLead.DataBind();
            
        }
    }
  
   
    protected void grdLead_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "edit")
        {

            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            Label lblLeadNo = (Label)row.FindControl("lblLeadNo");
            Label lead_status = (Label)row.FindControl("lead_status");
            Label lblmobile = (Label)row.FindControl("lblmobile");
            Label lblemail = (Label)row.FindControl("lblemail");
            Label customername = (Label)row.FindControl("customername");
            Label lead_name = (Label)row.FindControl("lead_name");
            Label officeid = (Label)row.FindControl("officeid");

            //if (lead_status.Text == "Allocated")
            //    // Response.Redirect("Sales/NewLead.aspx?leadallocate=" + lblLeadNo.Text);
            //    Response.Redirect("Sales/NewLead.aspx?leadallocate=" + lblLeadNo.Text + "&mobile=" + lblmobile.Text + "&email=" + lblemail.Text + "&name=" + customername.Text + "&leadsource=" + lead_name.Text + "&officeid=" + officeid.Text);


            //else 
            if (lead_status.Text == "Not-Allocated")
            {
                allocate_to = objSales.leadallocationstatus_update(lblLeadNo.Text, "Allocated", Session["user_id"].ToString(), "1");
                //Response.Redirect("Sales/NewLead.aspx?leadallocate=" + lblLeadNo.Text);
                Response.Redirect("Sales/CreateLead.aspx?leadallocate=" + lblLeadNo.Text + "&mobile=" + lblmobile.Text + "&email=" + lblemail.Text + "&name=" + customername.Text + "&leadsource=" + lead_name.Text + "&officeid=1");

            }
        }
    }
    protected void grdLead_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }
}