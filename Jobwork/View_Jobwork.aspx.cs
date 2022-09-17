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
public partial class Jobwork_View_Jobwork : System.Web.UI.Page
{
    clsSales objsales = new clsSales();
    clsUser objuser = new clsUser();
    clsRepair objRepair = new clsRepair();
    SqlDataReader objReader;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_id"] == null || Session["user_name"] == null)
        {
            Response.Redirect("~/AdminLogin.aspx");
        }
      
        if (!IsPostBack)
        {
            //txtfromdate.Text = DateTime.Today.ToShortDateString();
            //txttodate.Text = DateTime.Today.ToShortDateString();
            objReader = objRepair.CRMEquipmentStatus_select();
            ddlStatus.DataSource = objReader;
            ddlStatus.DataTextField = "equipmentStatus_name";
            ddlStatus.DataValueField = "equipmentStatus_id";
            ddlStatus.DataBind();
            ddlStatus.Items.Insert(0, "Select Status");
            ddlStatus.Items[0].Value = "0";
            ddlStatus.SelectedIndex = 0;
            objReader.Close();

            objReader = objsales.CRMOffice_Select(1);
            ddlOffice.DataSource = objReader;
            ddlOffice.DataTextField = "office_name";
            ddlOffice.DataValueField = "office_id";
            ddlOffice.DataBind();
            ddlOffice.SelectedIndex = 0;
            objReader.Close();

            objReader = objuser.crm_user_selectfordropdown("Admin");
            ddlchiplevel.DataSource = objReader;
            ddlchiplevel.DataTextField = "name";
            ddlchiplevel.DataValueField = "emp_id";
            ddlchiplevel.DataBind();
            ddlchiplevel.Items.Insert(0, "Select Executive");
            ddlchiplevel.Items[0].Value = "0";
            ddlchiplevel.SelectedIndex = 0;
            objReader.Close();


            objReader = objRepair.drop_down_Repairstatus_select(1);
            ddlRepairstatus.DataSource = objReader;
            ddlRepairstatus.DataTextField = "RepairStatus";
            ddlRepairstatus.DataValueField = "RepairStatus";
            ddlRepairstatus.DataBind();
            ddlRepairstatus.Items.Insert(0, "Select Repair Status");
            ddlRepairstatus.Items[0].Value = "0";
            ddlRepairstatus.SelectedIndex = 0;
            objReader.Close();

           

            objRepair.flag = "1";
            objRepair.requestId = txtSearch.Text;
            objRepair.jobwork_status = ddlStatus.SelectedValue.ToString();
            objRepair.RepairStatus = ddlRepairstatus.SelectedValue.ToString();

            objRepair.chipEngineer = ddlchiplevel.SelectedValue.ToString();
            objRepair.office_id = ddlOffice.SelectedValue.ToString();

            grdLead.DataSource = objRepair.crmequipment_select(objRepair);
            grdLead.DataBind();

        }

    }
    protected void grdLead_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdLead.PageIndex = e.NewPageIndex;
        if (txtSearch.Text == "")
        {
            objRepair.flag = "1";
        }
        else
        {
            objRepair.flag = "2";
        }
        objRepair.requestId = txtSearch.Text;
        objRepair.jobwork_status = ddlStatus.SelectedValue.ToString();
        objRepair.chipEngineer = ddlchiplevel.SelectedValue.ToString();
        objRepair.RepairStatus = ddlRepairstatus.SelectedValue.ToString();
        objRepair.office_id = ddlOffice.SelectedValue.ToString();
        grdLead.DataSource = objRepair.crmequipment_select(objRepair);
        grdLead.DataBind();
    }
    protected void grdLead_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "edit")
        {

            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            Label lblserialno = (Label)row.FindControl("lblserialno");
            Response.Redirect("insert_jobwork.aspx?Serialno=" + lblserialno.Text);

        }
        if (e.CommandName == "print")
        {

            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            Label lblserialno = (Label)row.FindControl("lblserialno");
            Response.Redirect("~/payment_service_invoice.aspx?serial_no=" + lblserialno.Text);

        }
    }
    protected void grdLead_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }
    protected void grdLead_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }
    protected void Update_Jobwork_Click(object sender, EventArgs e)
    {

    }

    protected void callreminder_Click(object sender, EventArgs e)
    {

    }
    protected void cmdSearch_Click(object sender, EventArgs e)
    {

    }
}