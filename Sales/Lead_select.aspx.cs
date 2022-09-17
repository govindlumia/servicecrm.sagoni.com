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
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net.Mail;

public partial class Sales_Lead_select : System.Web.UI.Page
{
    SqlDataReader objReader;
    clsSales objsales = new clsSales();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Session["user_id"] == null || Session["user_name"] == null)
        {
            Response.Redirect("~/AdminLogin.aspx");
        }
        
        if (!IsPostBack)
        {

            objReader = objsales.crmLeadSource_Select(1);
            ddlLeadSource.DataSource = objReader;
            ddlLeadSource.DataTextField = "leadsource_name";
            ddlLeadSource.DataValueField = "leadsource_id";
            ddlLeadSource.DataBind();
            ddlLeadSource.Items.Insert(0, "<--Select-->");
            ddlLeadSource.Items[0].Value = "0";
            ddlLeadSource.SelectedIndex = 0;
            objReader.Close();

            objReader = objsales.crmleadstatus_select(1);
            ddlLeadStatus.DataSource = objReader;
            ddlLeadStatus.DataTextField = "leadstatus_name";
            ddlLeadStatus.DataValueField = "leadstatus_id";
            ddlLeadStatus.DataBind();
            ddlLeadStatus.Items.Insert(0, "<--Select-->");
            ddlLeadStatus.Items[0].Value = "0";
            ddlLeadStatus.SelectedValue = "16";
            objReader.Close();



            objReader = objsales.CRMOffice_Select(1);
            ddlOffice.DataSource = objReader;
            ddlOffice.DataTextField = "office_name";
            ddlOffice.DataValueField = "office_id";
            ddlOffice.DataBind();
            ddlOffice.SelectedIndex = 0;
            objReader.Close();


            objsales.Flag = "Default";
            objsales.search_value = "";
            objsales.created_by = "0";
            objsales.lead_source = ddlLeadSource.SelectedValue.ToString();
            objsales.lead_status = ddlLeadStatus.SelectedValue.ToString();
            objsales.Office_id = ddlOffice.SelectedValue.ToString();


            grdLead.DataSource = objsales.CRMLead_select(objsales);
            grdLead.DataBind();


            string strTheTime = DateTime.UtcNow.ToString("HH");
            string strTheTime1 = DateTime.UtcNow.ToString("tt");

        }
    }

    protected void grdLead_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdLead.PageIndex = e.NewPageIndex;
        objsales.Flag = cboViewList.SelectedValue.ToString();
        objsales.search_value = txtSearch.Text;
        objsales.created_by = "0";
        objsales.lead_source = ddlLeadSource.SelectedValue.ToString();
        objsales.lead_status = ddlLeadStatus.SelectedValue.ToString();
        objsales.Office_id = ddlOffice.SelectedValue.ToString();


        grdLead.DataSource = objsales.CRMLead_select(objsales);
        grdLead.DataBind();
    }
    protected void grdLead_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "edit")
        {

            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            Label lblLeadNo = (Label)row.FindControl("lblLeadNo");
            Label lblStatus_id = (Label)row.FindControl("lblStatus_id");
            Response.Redirect("CreateLead.aspx?LeadId=" + lblLeadNo.Text + "&lead_status=" + lblStatus_id.Text);
            //Response.Redirect("CreateLead.aspx?LeadId=" + lblLeadNo.Text);
        }
    }
    protected void grdLead_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }
    protected void grdLead_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }
    protected void cmdSearch_Click(object sender, EventArgs e)
    {
        objsales.Flag = cboViewList.SelectedValue.ToString();
        objsales.search_value = txtSearch.Text;
        objsales.created_by = "0";
        objsales.lead_source = ddlLeadSource.SelectedValue.ToString();
        objsales.lead_status = ddlLeadStatus.SelectedValue.ToString();
        objsales.Office_id = ddlOffice.SelectedValue.ToString();


        grdLead.DataSource = objsales.CRMLead_select(objsales);
        grdLead.DataBind();
    }
}