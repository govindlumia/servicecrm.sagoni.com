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

public partial class repaire_invoice_callog : System.Web.UI.Page
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
            lead_no = lbl_lead_no.Text;

            grdCalllog.DataSource = objRepair.repaire_calllog_calllog_select(lbl_lead_no.Text);
            grdCalllog.DataBind();
        }
    }
}