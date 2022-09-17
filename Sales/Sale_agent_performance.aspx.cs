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

public partial class Sales_Sale_agent_performance : System.Web.UI.Page
{
    clsSales objsales = new clsSales();
    clsUser objuser = new clsUser();
    clsSupport objsupport = new clsSupport();
    clsAccount objAccount = new clsAccount();
    SqlDataReader objReader;

    decimal Totalamount = 0;
    int Totallead = 0, Totalconvertedlead = 0;
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
            objAccount.to_date = Convert.ToDateTime(txttodate.Text);
            objAccount.from_date = Convert.ToDateTime(txtfromdate.Text);

            // objsales.created_by = Session["user_id"].ToString();

            grdvassigntech.DataSource = objsales.Sale_Agentperformance_snapshot(Convert.ToDateTime(txtfromdate.Text), Convert.ToDateTime(txttodate.Text), '1');
            grdvassigntech.DataBind();



        }

    }
    protected void grdvassigntech_SelectedIndexChanged(object sender, EventArgs e)
    {
        objAccount.from_date = Convert.ToDateTime(txtfromdate.Text);
        objAccount.to_date = Convert.ToDateTime(txttodate.Text);
        // objsales.created_by = Session["user_id"].ToString();
        objsales.created_by = Session["employee_id"].ToString();

        objAccount.flag = "1";
        grdvassigntech.DataSource = objsales.Sale_Agentperformance_snapshot(Convert.ToDateTime(txtfromdate.Text), Convert.ToDateTime(txttodate.Text), '1');
        grdvassigntech.DataBind();
    }
    protected void grdvassigntech_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            // ImageButton imgincentive = (ImageButton)e.Row.FindControl("imgincentive");

            Totallead = Totallead + Convert.ToInt32(e.Row.Cells[3].Text);
            Totalconvertedlead = Totalconvertedlead + Convert.ToInt32(e.Row.Cells[4].Text);
            Totalamount = Totalamount + Convert.ToDecimal(e.Row.Cells[6].Text);


        }
        if (e.Row.RowType == DataControlRowType.Footer)
        {

            e.Row.Cells[0].Text = "Total";
            e.Row.Cells[3].Text = Convert.ToString(Totallead);
            e.Row.Cells[4].Text = Convert.ToString(Totalconvertedlead);
            e.Row.Cells[6].Text = Convert.ToString(Totalamount);
        }
    }
    protected void grdvassigntech_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "edit")
        {

            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            Label lblcreate = (Label)row.FindControl("lblcreate");
            Session["employee_id"] = Convert.ToInt32(lblcreate.Text);
            //created_by=Session["user_id"]

            Response.Redirect("~/sales/my_lead_details.aspx?employee_id = " + lblcreate.Text);

        }

    }
    protected void VIEW_CLICK(object sender, EventArgs e)
    {
        objAccount.from_date = Convert.ToDateTime(txtfromdate.Text);
        objAccount.to_date = Convert.ToDateTime(txttodate.Text);
        // objsales.created_by = Session["user_id"].ToString();
        objsales.created_by = Session["employee_id"].ToString();

        objAccount.flag = "1";
        grdvassigntech.DataSource = objsales.Sale_Agentperformance_snapshot(Convert.ToDateTime(txtfromdate.Text), Convert.ToDateTime(txttodate.Text), '1');
        grdvassigntech.DataBind();
    }
}