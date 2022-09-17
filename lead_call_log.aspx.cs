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

public partial class lead_call_log : System.Web.UI.Page
{
    clsRepair objRepair = new clsRepair();
    clsSales objsales = new clsSales();
    clsUser objuser = new clsUser();
    clsSupport objsupport = new clsSupport();
    SqlDataReader objReader;
    string lead_no, lead_status;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_id"] == null || Session["user_name"] == null)
        {
            Response.Redirect("~/AdminLogin.aspx");
        }
       
        if (!IsPostBack)
        {
            lbl_lead_no.Text = Session["lead_no"].ToString();
            lbllead_status.Text = Session["leadstatus"].ToString();
            lbllead_status.Visible = false;
            lead_no = lbl_lead_no.Text;
           
            grdCalllog.DataSource = objRepair.lead_calllog_select(lbl_lead_no.Text, 1);
            grdCalllog.DataBind();
        }

    }
    protected void btncalllogsave_Click(object sender, EventArgs e)
    {
        objRepair.created_by = Session["user_id"].ToString();
        objRepair.lead_status = lbllead_status.Text;
        lbllead_status.Visible = false;
        objRepair.lead_no = lbl_lead_no.Text;
        objRepair.description = txtDescription.Text;
        lead_no = objRepair.lead_calllog_insert(objRepair);
        grdCalllog.DataSource = objRepair.lead_calllog_select(lbl_lead_no.Text, 1);
        grdCalllog.DataBind();

    }
    protected void btncalllogcancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Sales/Lead_select.aspx");
    }
}