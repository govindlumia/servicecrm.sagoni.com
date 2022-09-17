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

public partial class Refund_View_Repair_Refund : System.Web.UI.Page
{
    clsSales objsales = new clsSales();
    clsAccount objAccount = new clsAccount();
    clsSupport objsupport = new clsSupport();
    SqlDataReader objReader;
    decimal Totalamount = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
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
            grdLead.DataSource = objAccount.m_CRMRepaircustomer_Refund_select(objAccount);
            grdLead.EditIndex = -1;
            grdLead.DataBind();
        }
    }
    protected void grdLead_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

    }
    protected void grdLead_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "edit")
        {

            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            Label lblserialno = (Label)row.FindControl("lblserialno");


            Response.Redirect("Refund_Repair_Invoice.aspx?serial_no=" + lblserialno.Text);


        }
        if (e.CommandName == "print")
        {

            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            Label lblserialno = (Label)row.FindControl("lblserialno");
            Response.Redirect("~/Repair_Refund_Invoice.aspx?serial_no=" + lblserialno.Text);

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

    }
    protected void cmdSearch_Click(object sender, EventArgs e)
    {
        objAccount.Search = txtSearch.Text;
        objAccount.from_date = Convert.ToDateTime(txtfromdate.Text);
        objAccount.to_date = Convert.ToDateTime(txttodate.Text);
        objAccount.flag = "1";
        grdLead.DataSource = objAccount.m_CRMRepaircustomer_Refund_select(objAccount);
        grdLead.EditIndex = -1;
        grdLead.DataBind();
    }
}