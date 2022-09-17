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
public partial class Report_LeadReport : System.Web.UI.Page
{
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

            objReader = objsales.crmleadstatus_select(1);
            ddlLeadStatus.DataSource = objReader;
            ddlLeadStatus.DataTextField = "leadstatus_name";
            ddlLeadStatus.DataValueField = "leadstatus_id";
            ddlLeadStatus.DataBind();
            ddlLeadStatus.Items.Insert(0, "<--Select-->");
            ddlLeadStatus.Items[0].Value = "0";
            ddlLeadStatus.SelectedValue = "0";
            objReader.Close();

            objsales.Flag = "Default";
            ViewState["flag"] = "Default";
            objsales.lead_status = ddlLeadStatus.SelectedValue.ToString();
            objsales.from_date = Convert.ToDateTime(txtfromdate.Text);
            objsales.to_date = Convert.ToDateTime(txttodate.Text);
            grdLead.DataSource = objsales.CRMLead_selectforreport(objsales);
            grdLead.DataBind();


            

        }
    }
    protected void grdLead_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }
    protected void btnExcell_Click(object sender, EventArgs e)
    {
        Export_Excel();
    }
    protected void cmdSearch_Click(object sender, EventArgs e)
    {
        objsales.Flag = "Default";
        objsales.lead_status = ddlLeadStatus.SelectedValue.ToString();
        objsales.from_date = Convert.ToDateTime(txtfromdate.Text);
        objsales.to_date = Convert.ToDateTime(txttodate.Text);


        grdLead.DataSource = objsales.CRMLead_selectforreport(objsales);
        grdLead.DataBind();
    }

    private void Export_Excel()
    {
        try
        {
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment;filename=Lead_Report.csv");
            Response.Charset = "";
            Response.ContentType = "application/text";

            DataTable dt = new DataTable();

            objsales.Flag = "Default";
            objsales.lead_status = ddlLeadStatus.SelectedValue.ToString();
            objsales.from_date = Convert.ToDateTime(txtfromdate.Text);
            objsales.to_date = Convert.ToDateTime(txttodate.Text);
            dt = objsales.CRMLead_selectforreport(objsales);
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