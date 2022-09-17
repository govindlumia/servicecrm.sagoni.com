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
public partial class Report_service_invoice_report : System.Web.UI.Page
{
    clsAccount objAccount = new clsAccount();
    SqlDataReader objReader;
    clsSales objsales = new clsSales();
    clsUser objuser = new clsUser();
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

            objAccount.Flag = "Default";
            ViewState["flag"] = "Default";
            objAccount.from_date = Convert.ToDateTime(txtfromdate.Text);
            objAccount.to_date = Convert.ToDateTime(txttodate.Text);
            grdLead.DataSource = objAccount.CRMserviceReport(objAccount);
            grdLead.DataBind();




        }

    }

    protected void btnExcell_Click(object sender, EventArgs e)
    {
        Export_Excel();
    }
    protected void cmdSearch_Click(object sender, EventArgs e)
    {
        objAccount.Flag = "Default";
        objAccount.from_date = Convert.ToDateTime(txtfromdate.Text);
        objAccount.to_date = Convert.ToDateTime(txttodate.Text);


        grdLead.DataSource = objAccount.CRMserviceReport(objAccount);
        grdLead.DataBind();
    }
    private void Export_Excel()
    {
        try
        {
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment;filename=service_invoice_report.csv");
            Response.Charset = "";
            Response.ContentType = "application/text";

            DataTable dt = new DataTable();

            objAccount.Flag = "Default";
            //objsales.lead_status = ddlLeadStatus.SelectedValue.ToString();
            objAccount.from_date = Convert.ToDateTime(txtfromdate.Text);
            objAccount.to_date = Convert.ToDateTime(txttodate.Text);
            dt = objAccount.CRMRepaireReport(objAccount);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int k = 0; k < dt.Columns.Count; k++)
            {
                //add separator
                sb.Append(dt.Columns[k].ColumnName + ',');
            }
            //append new line
            sb.Append("\r\n");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int k = 0; k < dt.Columns.Count; k++)
                {
                    //add separator
                    sb.Append(dt.Rows[i][k].ToString().Replace(",", ";") + ',');
                }
                //append new line
                sb.Append("\r\n");
            }
            Response.Output.Write(sb.ToString());
            Response.Flush();
            Response.End();
        }
        catch (Exception ex)
        {
            lblmsg.Visible = true;
            lblmsg.Text = "Please Try Again !";

        }


    }
}