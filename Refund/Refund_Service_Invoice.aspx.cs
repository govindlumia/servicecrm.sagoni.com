using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class Refund_Refund_Service_Invoice : System.Web.UI.Page
{
    clsAccount objAccount = new clsAccount();
    clsSales objsales = new clsSales();
    clsUser objuser = new clsUser();
    clsRepair objRepair = new clsRepair();
    clsSupport objsupport = new clsSupport();
    SqlDataReader objReader;

    string Requestid, Active, clientid;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_id"] == null || Session["user_name"] == null)
        {
            Response.Redirect("~/AdminLogin.aspx");
        }
        if (!IsPostBack)
        {
            ViewState["flag"] = "I";
            objReader = objsales.crmservicetype_Select();
            ddServicetype.DataSource = objReader;
            ddServicetype.DataTextField = "servicetype_name";
            ddServicetype.DataValueField = "servicetype_id";
            ddServicetype.DataBind();
            ddServicetype.Items.Insert(0, "<--Select-->");
            ddServicetype.Items[0].Value = "0";
            ddServicetype.SelectedValue = "0";
            objReader.Close();

            if (Request.QueryString["serial_no"] != null)
            {


                objReader = objRepair.m_CRMcustomer_Refund_update_select(Request.QueryString["serial_no"].ToString(), 1);
                if (objReader.Read())
                {
                    //  Session["requestId"] = objReader["requestId"].ToString();


                    txtRequestid.Text = objReader["lead_no"].ToString();
                    lblclient_name.Text = objReader["customerName"].ToString();
                    lblmobileno.Text = objReader["mobile_no"].ToString();
                    lblAddress.Text = objReader["address"].ToString();
                    txtChequeNo.Text = objReader["chequeNo"].ToString();

                    txtunit.Text = objReader["NoOfNode"].ToString();
                    txttaxAmount.Text = objReader["tax"].ToString();
                    txtamount.Text = objReader["amount"].ToString();
                    txtitems.Text = objReader["item"].ToString();
                    //txtnec.Text = objReader["nextUpdate"].ToString();
                    txtremarks.Text = objReader["remarks"].ToString();
                    ddServicetype.SelectedValue = objReader["servicetype"].ToString();
                    // objRepair.jobwork_status = ddlJobwork.SelectedValue.ToString();
                    ViewState["flag"] = "U";
                }
            }
        }
    }
    protected void btnSave1_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {

            save();
        }
    }
    private void save()
    {

        objAccount.lead_no = txtRequestid.Text;
        objAccount.customerName = lblclient_name.Text;
        objAccount.mobile_no = lblmobileno.Text;
        objAccount.address = lblAddress.Text;
        if (rbCheque.Checked == true)
            objAccount.paymentMode = "Q";
        else if (rbCash.Checked == true)
            objAccount.paymentMode = "C";
        else if (rbonline.Checked == true)
            objAccount.paymentMode = "O";
        else if (PRadioTeller.Checked == true)
            objAccount.paymentMode = "T";
        else
            objAccount.paymentMode = "";

        objAccount.tax = txttaxAmount.Text;
        objAccount.chequeNo = txtChequeNo.Text;
        objAccount.NoOfNode = txtunit.Text;
        objAccount.item = txtitems.Text;
        objAccount.amount = txtamount.Text;

        objAccount.remarks = txtremarks.Text;

        objAccount.officeid = "1";
        objAccount.servicetype = ddServicetype.SelectedValue.ToString();

        objAccount.user = Session["user_id"].ToString();
        objAccount.created_by = Session["user_id"].ToString();
        objAccount.lead_created_by = Session["user_id"].ToString();


        if (ViewState["flag"].ToString() == "I")
        {
            objAccount.serial_no = "0";
            objAccount.Invoice_no = "0";
            objAccount.customerId = "0";
            objAccount.flag = "I";

            Requestid = objAccount.m_CRMcustomer_Refund_insert(objAccount);
        }
        if (ViewState["flag"].ToString() == "U")
        {


            objAccount.flag = "U";
            objAccount.Invoice_no = "0";
            objAccount.customerId = "0";
            objAccount.serial_no = Request.QueryString["serial_no"];

            Requestid = objAccount.m_CRMcustomer_Refund_insert(objAccount);

        }
        Response.Redirect("View_Service_Refund.aspx");

    }
    protected void txtRequestid_TextChanged(object sender, EventArgs e)
    {
        objReader = objsales.CheckExistingLead_m_CRMcustomer_Refund(txtRequestid.Text);
        if (objReader.Read())
        {
            lblMsg.Visible = true;
            lblMsg.Text = "Customer Already Generate Service Invoice";
            return;
        }
        objReader = objsales.Service_Refund(txtRequestid.Text, 1);
        if (objReader.Read())
        {
            txtunit.Text = objReader["amount"].ToString();
            ddServicetype.SelectedValue = objReader["servicetype"].ToString();
            txtitems.Text = objReader["item"].ToString();
            lblclient_name.Text = objReader["customerName"].ToString();
            txtitems.Text = objReader["item"].ToString();
            lblmobileno.Text = objReader["mobile_no"].ToString();
            lblAddress.Text = objReader["address"].ToString();
            ViewState["office"] = objReader["officeid"].ToString();
            // ViewState["clientid"] = objReader["client_id"].ToString();
        }
        objReader.Close();
        //objReader = objsales.m_CRMRepaircustomer_RefundTotal(txtRequestid.Text);
        //if (objReader.Read())
        //{
        //    txtunit.Text = objReader["amount"].ToString();
        //}
        //objReader.Close();
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {

            save();
        }
    }
    protected void btnClose_Click(object sender, EventArgs e)
    {
        Response.Redirect("Refund_Service_Invoice.aspx");
    }
    protected void btnCancel1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Refund_Service_Invoice.aspx");
    }
}