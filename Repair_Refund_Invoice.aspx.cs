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
using System.IO;

public partial class Repair_Refund_Invoice : System.Web.UI.Page
{
    clsSales objsales = new clsSales();
    clsAccount objAccount = new clsAccount();
    clsSupport objsupport = new clsSupport();
    SqlDataReader objReader;
    clsRepair objRepair = new clsRepair();
    decimal Totalamount = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        lblDate1.Text = DateTime.UtcNow.ToShortDateString();
        if (Session["user_id"] == null || Session["user_name"] == null)
        {
            Response.Redirect("~/AdminLogin.aspx");
        }

        if (!IsPostBack)
        {
            if (Request.QueryString["serial_no"] != null)
            {


                objReader = objRepair.Print_Repair_Refund_invoice(Request.QueryString["serial_no"].ToString());
                if (objReader.Read())
                {
                    lblCompName1.Text = objReader["customerName"].ToString();
                    lblMobile1.Text = objReader["mobile_no"].ToString();
                    lblemail1.Text = objReader["address"].ToString();

                    lblDate1.Text = objReader["invoice_date"].ToString();
                    lblInvoiceNo1.Text = objReader["invoice_no"].ToString();
                    // lbltinno1.Text = objReader["NoOfNode"].ToString();
                    lblservicetype1.Text = objReader["NoOfNode"].ToString();
                    lblremarks1.Text = objReader["item"].ToString();
                    lblDescription1.Text = objReader["remarks"].ToString();
                    lblquotamt1.Text = objReader["Actual_amount"].ToString();
                    lblGrandTotal1.Text = objReader["Total_amount"].ToString();
                    lblservicetax1.Text = objReader["service_tax"].ToString();



                }
            }
            objReader.Close();
        }
    }
}