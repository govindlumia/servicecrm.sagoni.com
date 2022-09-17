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

public partial class Invoice_Repair_invoice_insert : System.Web.UI.Page
{
    clsAccount objAccount = new clsAccount();
    clsSales objsales = new clsSales();
    clsUser objuser = new clsUser();
    clsRepair objRepair = new clsRepair();
    clsSupport objsupport = new clsSupport();
    SqlDataReader objReader;
    string Requestid, Active, clientid,lead_no;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_id"] == null || Session["user_name"] == null)
        {
            Response.Redirect("~/AdminLogin.aspx");
        }
        if (!IsPostBack)
        {
            txtinvoicedate.Text = DateTime.UtcNow.ToShortDateString();
            ViewState["flag"] = "I";
            objReader = objsales.crmwarrantytype_select();
            ddServicetype.DataSource = objReader;
            ddServicetype.DataTextField = "warrantytype_name";
            ddServicetype.DataValueField = "warrantytype_id";
            ddServicetype.DataBind();
            ddServicetype.Items.Insert(0, "<--Select-->");
            ddServicetype.Items[0].Value = "0";
            ddServicetype.SelectedValue = "0";
            objReader.Close();
            if (Request.QueryString["LeadId"] != null)
            {
                Session["lead_no"] = Request.QueryString["LeadId"].ToString();
            }
            if (Request.QueryString["serial_no"] != null)
            {


                objReader = objRepair.m_CRMRepaircustomer_update_select(Request.QueryString["serial_no"].ToString(), 1);
                if (objReader.Read())
                {
                    //  Session["requestId"] = objReader["requestId"].ToString();


                    txtRequestid.Text = objReader["lead_no"].ToString();
                    lblclient_name.Text = objReader["customerName"].ToString();
                    lblmobileno.Text = objReader["mobile_no"].ToString();
                    lblAddress.Text = objReader["address"].ToString();
                    txtChequeNo.Text = objReader["chequeNo"].ToString();


                    txtinvoicedate.Text = objReader["invoice_date"].ToString();
                    Txt_RestAmount.Text = objReader["rest_amount"].ToString();
                    Txt_Amountpaid.Text = objReader["amount_paid"].ToString();

                    txtunit.Text = objReader["NoOfNode"].ToString();
                    txttaxAmount.Text = objReader["tax"].ToString();
                    txtamount.Text = objReader["amount"].ToString();
                    txtitems.Text = objReader["item"].ToString();
                    //txtnec.Text = objReader["nextUpdate"].ToString();
                    txtremarks.Text = objReader["remarks"].ToString();
                    ddServicetype.SelectedValue = objReader["crmwarrantytype"].ToString();
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
        objAccount.rest_amount = Txt_RestAmount.Text;
        objAccount.amount_paid = Txt_Amountpaid.Text;
        objAccount.remarks = txtremarks.Text;
        objAccount.invoice_date = Convert.ToDateTime(txtinvoicedate.Text);
        objAccount.officeid = "1";
        objAccount.crmwarrantytype = ddServicetype.SelectedValue.ToString();

        objAccount.user = Session["user_id"].ToString();
        objAccount.created_by = Session["user_id"].ToString();
        objAccount.lead_created_by = Session["user_id"].ToString();


        if (ViewState["flag"].ToString() == "I")
        {
            objAccount.serial_no = "0";
            objAccount.Invoice_no = "0";
            objAccount.customerId = "0";
            objAccount.flag = "I";

            Requestid = objAccount.m_CRMRepaircustomer_insert(objAccount);
        }
        if (ViewState["flag"].ToString() == "U")
        {


            objAccount.flag = "U";
            objAccount.Invoice_no = "0";
            objAccount.customerId = "0";
            objAccount.serial_no = Request.QueryString["serial_no"];

            Requestid = objAccount.m_CRMRepaircustomer_insert(objAccount);

        }
        Response.Redirect("View_Repair.aspx"); 

    }
    protected void txtRequestid_TextChanged(object sender, EventArgs e)
    {
        objReader = objsales.CheckExistingLead_m_CRMRepaircustomer(txtRequestid.Text);
        if (objReader.Read())
        {
            lblerror.Visible = true;
            lblerror.Text = "Customer already registered";
            return;
        }
        objReader.Close();
        objReader = objsales.leaddetail_selectforticket(txtRequestid.Text, 1);
        if (objReader.Read())
        {
           // ddServicetype.SelectedValue = objReader["crmwarrantytype"].ToString();

            lblclient_name.Text = objReader["customername"].ToString();
            //txtRequestid.Text = objReader["RequestId"].ToString();
            lblmobileno.Text = objReader["mobile"].ToString();
            lblAddress.Text = objReader["address"].ToString();
            ViewState["office"] = objReader["Office_id"].ToString();
            // ViewState["clientid"] = objReader["client_id"].ToString();
        }
        objReader.Close();
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {

            save();
        }
    }
    protected void btnCancel1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Invoice/Repair_invoice_insert.aspx");
    }

    protected void Txt_Amountpaid_TextChanged(object sender, EventArgs e)
    {
        double total = Convert.ToDouble(txtamount.Text);
        double paid = Convert.ToDouble(Txt_Amountpaid.Text);
        double Rest = total - paid;
        Txt_RestAmount.Text = Rest.ToString();
    }
    protected void btn_calllog_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["LeadId"] != null)
        {
            Session["lead_no"] = Request.QueryString["LeadId"].ToString();
            lead_no = Request.QueryString["LeadId"].ToString();
            Response.Redirect("~/repaire_invoice_callog.aspx?LeadId=" + lead_no);
        }
        else
        {
            Response.Redirect("~/Invoice/Repair_invoice_insert.aspx");
        }
    }
}