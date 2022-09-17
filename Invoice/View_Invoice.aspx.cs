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

public partial class Invoice_View_Invoice : System.Web.UI.Page
{
    clsSales objsales = new clsSales();
    clsAccount objAccount = new clsAccount();
    clsSupport objsupport = new clsSupport();
    SqlDataReader objReader;
    decimal Totalamount = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["update"] = Server.UrlEncode(System.DateTime.Now.ToString());

        if (Session["user_id"] == null || Session["user_name"] == null)
        {
            Response.Redirect("~/AdminLogin.aspx");
        }
        
        if (!IsPostBack)
        {
         txtfromdate.Text = DateTime.UtcNow.ToShortDateString();
            txttodate.Text = DateTime.UtcNow.ToShortDateString();



            objAccount.Search = txtSearch.Text;
            objAccount.from_date = Convert.ToDateTime(txtfromdate.Text);
            objAccount.to_date = Convert.ToDateTime(txttodate.Text);
            //objAccount.RequestId = txtSearch.Text;
            ////objAccount.paymentstatus = ddlpayment.SelectedValue.ToString();
            objAccount.flag = "1";
            grdLead.DataSource = objAccount.m_CRMcustomer_select(objAccount);
            grdLead.EditIndex = -1;
            grdLead.DataBind();
        }
    }
    protected void grdLead_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        //objclient.client_id = ddlclient.SelectedValue.ToString();
        //objclient.from_date = Convert.ToDateTime(txtfromdate.Text);
        //objclient.to_date = Convert.ToDateTime(txttodate.Text);
        //objclient.RequestId = txtSearch.Text;
        //objclient.paymentstatus = ddlpayment.SelectedValue.ToString();
        //objclient.flag = "1";
        //grdLead.DataSource = objclient.client_CRMcustomerplandetail_select(objclient);
        //grdLead.EditIndex = -1;
        //grdLead.DataBind();
    }
    protected void grdLead_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "edit")
        {

            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            Label lblserialno = (Label)row.FindControl("lblserialno");
            Label lblticketid = (Label)row.FindControl("lblticketid");

            Response.Redirect("~/Invoice/CreateInvoice.aspx?serial_no=" + lblserialno.Text + "&LeadId=" + lblticketid.Text);
            

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
        if (e.Row.RowType == DataControlRowType.DataRow)
        {

            Totalamount = Totalamount + Convert.ToDecimal(e.Row.Cells[8].Text);

        }
        if (e.Row.RowType == DataControlRowType.Footer)
        {

            e.Row.Cells[0].Text = "Total";
            e.Row.Cells[8].Text = Convert.ToString(Totalamount);


        }
    }
    protected void grdLead_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //objclient.client_id = ddlclient.SelectedValue.ToString();
        //objclient.from_date = Convert.ToDateTime(txtfromdate.Text);
        //objclient.to_date = Convert.ToDateTime(txttodate.Text);
        //objclient.RequestId = txtSearch.Text;
        //objclient.paymentstatus = ddlpayment.SelectedValue.ToString();
        //objclient.flag = "1";
        //grdLead.DataSource = objclient.client_CRMcustomerplandetail_select(objclient);
        //grdLead.EditIndex = -1;
        //grdLead.DataBind();
    }
    protected void cmdSearch_Click(object sender, EventArgs e)
    {
        objAccount.Search = txtSearch.Text;
        objAccount.from_date = Convert.ToDateTime(txtfromdate.Text);
        objAccount.to_date = Convert.ToDateTime(txttodate.Text);
        objAccount.flag = "1";
        grdLead.DataSource = objAccount.m_CRMcustomer_select(objAccount);
        grdLead.EditIndex = -1;
        grdLead.DataBind();
    }
    protected void txtfromdate_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txttodate_TextChanged(object sender, EventArgs e)
    {

    }
}