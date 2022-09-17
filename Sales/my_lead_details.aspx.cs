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

public partial class Sales_my_lead_details : System.Web.UI.Page
{
    clsSales objsales = new clsSales();
    clsUser objuser = new clsUser();
    clsSupport objsupport = new clsSupport();
    clsAccount objAccount = new clsAccount();
    SqlDataReader objReader;

    decimal amtqual = 0, amtassign = 0, amtpros = 0;
    double countqual = 0, countassign = 0, countpros = 0, totallead = 0
       , counttotallead = 0;
    string lead_no, officeid, state, allocate_to, leadstatus;
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
            objsales.from_date = Convert.ToDateTime(txtfromdate.Text);
            objsales.to_date = Convert.ToDateTime(txttodate.Text);
            objsales.created_by = Session["employee_id"].ToString();
            objsales.Flag = "1";
            grdLead.DataSource = objsales.Mylead_followup_detail_select(objsales);
            grdLead.DataBind();

            objReader = objsales.Mylead_detail_select(Convert.ToDateTime(txtfromdate.Text), Convert.ToDateTime(txttodate.Text), Session["employee_id"].ToString(), 1);
            if (objReader.Read())
            {
                lbltlead.Text = objReader["totallead"].ToString();
                counttotallead = Convert.ToInt32(lbltlead.Text);

            }
            objReader = objsales.Mylead_detail_select(Convert.ToDateTime(txtfromdate.Text), Convert.ToDateTime(txttodate.Text), Session["employee_id"].ToString(), 2);
            if (objReader.Read())
            {
                lblqual.Text = objReader["qlead"].ToString();
                countqual = Convert.ToInt32(lblqual.Text);
                lblquliamount.Text = objReader["amount"].ToString();
                amtqual = Convert.ToDecimal(lblquliamount.Text);
                lblquliconversion.Text = Math.Round((((countqual / counttotallead) * 100)), 2).ToString() + '%';

            }
            objReader = objsales.Mylead_detail_select(Convert.ToDateTime(txtfromdate.Text), Convert.ToDateTime(txttodate.Text), Session["employee_id"].ToString(), 3);
            if (objReader.Read())
            {
                lblpros.Text = objReader["plead"].ToString();
                countpros = Convert.ToInt32(lblpros.Text);
                lblprosamount.Text = objReader["pros_amount"].ToString();
                amtpros = Convert.ToDecimal(lblprosamount.Text);
                lblprosconversion.Text = Math.Round((((countpros / counttotallead) * 100)), 2).ToString() + '%';

            }
            objReader = objsales.Mylead_detail_select(Convert.ToDateTime(txtfromdate.Text), Convert.ToDateTime(txttodate.Text), Session["employee_id"].ToString(), 4);
            if (objReader.Read())
            {
                lblassign.Text = objReader["alead"].ToString();
                lblassignamount.Text = objReader["assign_amount"].ToString();


            }
            objReader = objsales.Mylead_detail_select(Convert.ToDateTime(txtfromdate.Text), Convert.ToDateTime(txttodate.Text), Session["employee_id"].ToString(), 5);
            if (objReader.Read())
            {
                lblschedule.Text = objReader["slead"].ToString();

            }
            objReader = objsales.Mylead_detail_select(Convert.ToDateTime(txtfromdate.Text), Convert.ToDateTime(txttodate.Text), Session["employee_id"].ToString(), 6);
            if (objReader.Read())
            {
                lblfol.Text = objReader["flead"].ToString();

            }
            objReader = objsales.Mylead_detail_select(Convert.ToDateTime(txtfromdate.Text), Convert.ToDateTime(txttodate.Text), Session["employee_id"].ToString(), 7);
            if (objReader.Read())
            {
                lbllost.Text = objReader["llead"].ToString();

            }
            objReader = objsales.Mylead_detail_select(Convert.ToDateTime(txtfromdate.Text), Convert.ToDateTime(txttodate.Text), Session["employee_id"].ToString(), 8);
            if (objReader.Read())
            {

                lbljunk.Text = objReader["jlead"].ToString();

            }
        }
    }

          protected void grdLead_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "edit")
        {
           
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            Label lblLeadNo = (Label)row.FindControl("lblLeadNo");
            Label lblleadStatus = (Label)row.FindControl("lblleadStatus");

            Response.Redirect("~/sales/CreateLead.aspx?LeadId=" + lblLeadNo.Text + "&lead_status=" + lblleadStatus.Text);

        }
    }

    protected void lead_detail_Click(object sender, EventArgs e)
    {
        objsales.from_date = Convert.ToDateTime(txtfromdate.Text);
        objsales.to_date = Convert.ToDateTime(txttodate.Text);
        objsales.created_by = Session["employee_id"].ToString();
        objsales.Flag = "1";
        grdLead.DataSource = objsales.Mylead_followup_detail_select(objsales);
        grdLead.DataBind();

        objReader = objsales.Mylead_detail_select(Convert.ToDateTime(txtfromdate.Text), Convert.ToDateTime(txttodate.Text), Session["employee_id"].ToString(), 1);
        if (objReader.Read())
        {
            lbltlead.Text = objReader["totallead"].ToString();
            counttotallead = Convert.ToInt32(lbltlead.Text);


        }
        objReader = objsales.Mylead_detail_select(Convert.ToDateTime(txtfromdate.Text), Convert.ToDateTime(txttodate.Text), Session["employee_id"].ToString(), 2);
        if (objReader.Read())
        {
            lblqual.Text = objReader["qlead"].ToString();
            countqual = Convert.ToInt32(lblqual.Text);
            lblquliamount.Text = objReader["amount"].ToString();
            amtqual = Convert.ToDecimal(lblquliamount.Text);
            lblquliconversion.Text = Math.Round((((countqual / counttotallead) * 100)), 2).ToString() + '%';

        }
        objReader = objsales.Mylead_detail_select(Convert.ToDateTime(txtfromdate.Text), Convert.ToDateTime(txttodate.Text), Session["employee_id"].ToString(), 3);
        if (objReader.Read())
        {
            lblpros.Text = objReader["plead"].ToString();
            countpros = Convert.ToInt32(lblpros.Text);
            lblprosamount.Text = objReader["pros_amount"].ToString();
            amtpros = Convert.ToDecimal(lblprosamount.Text);
            lblprosconversion.Text = Math.Round((((countpros / counttotallead) * 100)), 2).ToString() + '%';

        }
        objReader = objsales.Mylead_detail_select(Convert.ToDateTime(txtfromdate.Text), Convert.ToDateTime(txttodate.Text), Session["employee_id"].ToString(), 4);
        if (objReader.Read())
        {
            lblassign.Text = objReader["alead"].ToString();
            lblassignamount.Text = objReader["assign_amount"].ToString();

        }
        objReader = objsales.Mylead_detail_select(Convert.ToDateTime(txtfromdate.Text), Convert.ToDateTime(txttodate.Text), Session["employee_id"].ToString(), 5);
        if (objReader.Read())
        {
            lblschedule.Text = objReader["slead"].ToString();

        }
        objReader = objsales.Mylead_detail_select(Convert.ToDateTime(txtfromdate.Text), Convert.ToDateTime(txttodate.Text), Session["employee_id"].ToString(), 6);
        if (objReader.Read())
        {
            lblfol.Text = objReader["flead"].ToString();

        }
        objReader = objsales.Mylead_detail_select(Convert.ToDateTime(txtfromdate.Text), Convert.ToDateTime(txttodate.Text), Session["employee_id"].ToString(), 7);
        if (objReader.Read())
        {
            lbllost.Text = objReader["llead"].ToString();

        }
        objReader = objsales.Mylead_detail_select(Convert.ToDateTime(txtfromdate.Text), Convert.ToDateTime(txttodate.Text), Session["employee_id"].ToString(), 8);
        if (objReader.Read())
        {

            lbljunk.Text = objReader["jlead"].ToString();

        }

        
    }
}