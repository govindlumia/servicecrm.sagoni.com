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
using System.Data.SqlClient;
using System.Xml.Linq;

public partial class Sales_CreateLead : System.Web.UI.Page
{
    clsSales objsales = new clsSales();
    clsUser objuser = new clsUser();
    SqlDataReader objReader, objReader1, objReader2;
    string lead_no, officeid, state, allocate_to, leadstatus;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_id"] == null || Session["user_name"] == null)
        {
            Response.Redirect("~/AdminLogin.aspx");
        }

        if (!IsPostBack)
        {
            txtExpRevenue.Text = "0.0";
            txtExpecteddate.Text = DateTime.UtcNow.ToShortDateString();
            txtfolowupdate.Text = DateTime.UtcNow.ToShortDateString();

            
            objReader = objuser.crm_user_selectfordropdown("PickUp Executive");
            ddlpickupexe.DataSource = objReader;
            ddlpickupexe.DataTextField = "name";
            ddlpickupexe.DataValueField = "emp_id";
            ddlpickupexe.DataBind();
            ddlpickupexe.Items.Insert(0, "Select Executive");
            ddlpickupexe.Items[0].Value = "0";
            ddlpickupexe.SelectedIndex = 0;
            objReader.Close();

            objReader = objsales.crmservicetype_Select();
            ddServicetype.DataSource = objReader;
            ddServicetype.DataTextField = "servicetype_name";
            ddServicetype.DataValueField = "servicetype_id";
            ddServicetype.DataBind();
            ddServicetype.Items.Insert(0, "<--Select-->");
            ddServicetype.Items[0].Value = "0";
            ddServicetype.SelectedValue = "0";
            objReader.Close();

            objReader = objsales.crmLeadSource_Select(1);
            ddlLeadSource.DataSource = objReader;
            ddlLeadSource.DataTextField = "leadsource_name";
            ddlLeadSource.DataValueField = "leadsource_id";
            ddlLeadSource.DataBind();
            ddlLeadSource.Items.Insert(0, "<--Select-->");
            ddlLeadSource.Items[0].Value = "0";
            ddlLeadSource.SelectedValue = "0";
            objReader.Close();

            objReader = objsales.crmleadstatus_select(1);
            ddlLeadStatus.DataSource = objReader;
            ddlLeadStatus.DataTextField = "leadstatus_name";
            ddlLeadStatus.DataValueField = "leadstatus_id";
            ddlLeadStatus.DataBind();
            ddlLeadStatus.Items.Insert(0, "<--Select-->");
            ddlLeadStatus.Items[0].Value = "0";
            ddlLeadStatus.SelectedValue = "0";
            objReader.Close();


            objReader = objsales.crmstate_select(1);
            ddlState.DataSource = objReader;
            ddlState.DataTextField = "state_name";
            ddlState.DataValueField = "state_id";
            ddlState.DataBind();
            ddlState.Items.Insert(0, "<--Select-->");
            ddlState.Items[0].Value = "0";
            ddlState.SelectedIndex = 0;
            objReader.Close();

            objReader = objsales.CRMCity_Select(1);
            ddlCity.DataSource = objReader;
            ddlCity.DataTextField = "city_name";
            ddlCity.DataValueField = "city_id";
            ddlCity.DataBind();
            ddlCity.Items.Insert(0, "<--Select City-->");
            ddlCity.Items[0].Value = "0";
            ddlCity.SelectedIndex = 0;
            objReader.Close();

            objReader = objsales.crmLead_cancelReason(0);
            ddlReason.DataSource = objReader;
            ddlReason.DataTextField = "Cancel_reasonname";
            ddlReason.DataValueField = "Cancel_reasonname";
            ddlReason.DataBind();
            ddlReason.Items.Insert(0, "<--Select-->");
            ddlReason.Items[0].Value = "0";
            ddlReason.SelectedIndex = 0;
            objReader.Close();

            ViewState["flag"] = "I";

            if (Request.QueryString["LeadId"] != null)
            {
                Session["lead_no"] = Request.QueryString["LeadId"].ToString();
            }

            if (Request.QueryString["lead_status"] != null)
            {
                Session["leadstatus"] = Request.QueryString["lead_status"].ToString();
            }

            if (Request.QueryString["leadallocate"] != null)
            {
                txtFirstName.Text = Request.QueryString["name"].ToString();
                txtMobile.Text = Request.QueryString["mobile"].ToString();
                txtEmail.Text = Request.QueryString["email"].ToString();
                ddlLeadSource.SelectedValue = Request.QueryString["leadsource"].ToString();
                officeid = Request.QueryString["officeid"].ToString();
            }
            
            //**********************************************************************************************************************
          

            if (Request.QueryString["LeadId"] != null)
            {
                objReader = objsales.CRMLeadSelect_for_update(Request.QueryString["LeadId"].ToString());
                if (objReader.Read())
                {

                    if (Session["role"].ToString() == "Admin")
                    {
                        Panel1.Visible = true;
                        lblLead_no.Text = objReader["lead_no"].ToString();
                        ddlCity.SelectedValue = objReader["state"].ToString();
                        ddlCity.SelectedValue = objReader["city"].ToString();
                        txtCompany.Text = objReader["company"].ToString();
                        txtDescription.Text = objReader["description"].ToString();
                        txtEmail.Text = objReader["email"].ToString();
                        txtFirstName.Text = objReader["first_name"].ToString();
                        txtLastName.Text = objReader["last_name"].ToString();
                        txtMobile.Text = objReader["mobile"].ToString();
                        txtPhone.Text = objReader["phone"].ToString();
                        txtpin.Text = objReader["postal_code"].ToString();
                        ddlReason.SelectedValue = objReader["cancel_reason"].ToString();
                        ddServicetype.SelectedValue = objReader["servicetype"].ToString();
                        ddlState.SelectedValue = objReader["state"].ToString();
                        txthouseno.Text = objReader["street"].ToString();
                        txtExpRevenue.Text = objReader["ExpectedRevenue"].ToString();
                        string leadSource = objReader["lead_source"].ToString();
                        ddlLeadSource.SelectedValue = leadSource;
                        ddlLeadStatus.SelectedValue = objReader["lead_status"].ToString();
                        ddlTitle.SelectedValue = objReader["title"].ToString();
                        txtfolowupdate.Text = objReader["Followup_date"].ToString();
                        txtExpecteddate.Text = objReader["expecteddate"].ToString();
                        ddlLeadStatus.SelectedValue = objReader["lead_status"].ToString();
                        string leadStatus = objReader["lead_status"].ToString();

                        ddlpickupexe.SelectedValue = objReader["Pickup"].ToString();

                        if (leadStatus == "6" || leadStatus == "7")
                        {
                            ddlReason.Visible = true;
                            //rfvReason.Visible = true;
                        }

                        if (leadStatus == "2" || leadStatus == "3")
                        {
                            pickup.Visible = true;

                        }
                        else
                        {
                            pickup.Visible = false;
                        }

                    }
                    else
                    {

                        lblLead_no.Text = objReader["lead_no"].ToString();
                        Panel1.Visible = true;
                        ddlCity.SelectedValue = objReader["city"].ToString();
                        txtCompany.Text = objReader["company"].ToString();
                        txtDescription.Text = objReader["description"].ToString();
                        txtEmail.Text = objReader["email"].ToString();
                        txtFirstName.Text = objReader["first_name"].ToString();
                        txtLastName.Text = objReader["last_name"].ToString();
                        txtMobile.Text = objReader["mobile"].ToString();
                        txtPhone.Text = objReader["phone"].ToString();
                        txtpin.Text = objReader["postal_code"].ToString();

                        ddlState.SelectedValue = objReader["state"].ToString();
                        txthouseno.Text = objReader["street"].ToString();
                        txtExpRevenue.Text = objReader["ExpectedRevenue"].ToString();
                        string leadSource = objReader["lead_source"].ToString();
                        ddlLeadSource.SelectedValue = leadSource;
                        ddlLeadStatus.SelectedValue = objReader["lead_status"].ToString();
                        ddlTitle.SelectedValue = objReader["title"].ToString();
                        txtfolowupdate.Text = objReader["Followup_date"].ToString();
                        txtExpecteddate.Text = objReader["expecteddate"].ToString();
                        ddlLeadStatus.SelectedValue = objReader["lead_status"].ToString();
                        string leadStatus = objReader["lead_status"].ToString();
                        ddServicetype.SelectedValue = objReader["servicetype"].ToString();
                        ddlpickupexe.SelectedValue = objReader["Pickup"].ToString();
                        if (leadStatus == "2" || leadStatus == "3")
                        {
                            pickup.Visible = true;

                        }
                        else
                        {
                            pickup.Visible = false;
                        }
                    }
                }
                ViewState["flag"] = "U";
                ImageButton1.Visible = true;
                ImageButton5.Visible = false;
            }
        }
    }


    protected void btn_calllog_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["LeadId"] != null)
        {
            Session["lead_no"] = Request.QueryString["LeadId"].ToString();
            // Session["lead_Status"] = Request.QueryString["leadStatus"].ToString();
            Session["leadstatus"] = Request.QueryString["lead_status"].ToString();
            lead_no = Request.QueryString["LeadId"].ToString();
            leadstatus = Request.QueryString["lead_status"].ToString();

            Response.Redirect("~/lead_call_log.aspx?LeadId=" + lead_no + "&lead_status=" + leadstatus);
        }
        else
        {
            Response.Redirect("~/Sales/CreateLead.aspx");
        }

    }

    protected void reset_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/Sales/CreateLead.aspx");
    }
  
    protected void ddlLeadStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlLeadStatus.SelectedValue == "4" || ddlLeadStatus.SelectedValue == "5")
    {
        Panel1.Visible = true;
           
    }
    else
    {
        Panel1.Visible = false;
    }

    if (ddlLeadStatus.SelectedValue == "2" || ddlLeadStatus.SelectedValue == "3")
        {
            pickup.Visible = true;

        }
        else
        {
            pickup.Visible = false;
        }

    if (ddlLeadStatus.SelectedValue == "6" || ddlLeadStatus.SelectedValue == "7")
    {
        ddlReason.Visible=true;
    }
    else
    {
        ddlReason.Visible=false;
    }

    }
    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        objsales.first_name = txtFirstName.Text;
        objsales.last_name = txtLastName.Text;
        objsales.phone = txtPhone.Text;
        objsales.mobile = txtMobile.Text;
        objsales.professional_email = txtEmail.Text;
        objsales.personal_email = txtEmail.Text;
        objsales.title = ddlTitle.SelectedValue.ToString();
        objsales.company = txtCompany.Text;
        objsales.street = txthouseno.Text;
        objsales.city = ddlCity.SelectedValue.ToString();
        objsales.state = ddlState.SelectedValue.ToString();
        objsales.servicetype = ddServicetype.SelectedValue.ToString();
        objsales.postal_code = txtpin.Text;
        objsales.country = "India";
        objsales.Office_id = "1";
        objsales.lead_source = ddlLeadSource.SelectedValue.ToString();
        objsales.lead_status = ddlLeadStatus.SelectedValue.ToString();
        objsales.description = txtDescription.Text;
        objsales.ExpectedRevenue = txtExpRevenue.Text;
        objsales.created_by = Session["user_id"].ToString();
        objsales.expecteddate = Convert.ToDateTime(txtExpecteddate.Text);
        objsales.Followup_date = Convert.ToDateTime(txtfolowupdate.Text);
        objsales.servicetype = ddServicetype.SelectedValue.ToString();
        objsales.cancel_reason = ddlReason.SelectedValue.ToString();
        objsales.assign_emp = ddlpickupexe.SelectedValue.ToString();
        //ddlpickupexe.SelectedValue = objReader["Pickup"].ToString();
        if (ViewState["flag"].ToString() == "I")
        {
            objReader = objsales.CheckExistingLead(txtMobile.Text);
            if (objReader.Read())
            {
                lblmsg.Visible = true;
                lblmsg.Text = "Customer already registered";
                return;
            }
            objReader.Close();
            objsales.lead_no = "0";
            objsales.Flag = "I";
            lead_no = objsales.crmlead_Insert(objsales);
        }
        if (ViewState["flag"].ToString() == "U")
        {
            objsales.lead_no = Request.QueryString["LeadId"].ToString();
            objsales.Flag = "U";
            lead_no = objsales.crmlead_Insert(objsales);
            // ViewState["leadno1"] = lead_no;
        }
        Response.Redirect("Lead_select.aspx");
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        objsales.first_name = txtFirstName.Text;
        objsales.last_name = txtLastName.Text;
        objsales.phone = txtPhone.Text;
        objsales.mobile = txtMobile.Text;
        objsales.professional_email = txtEmail.Text;
        objsales.personal_email = txtEmail.Text;
        objsales.title = ddlTitle.SelectedValue.ToString();
        objsales.company = txtCompany.Text;
        objsales.street = txthouseno.Text;
        objsales.city = ddlCity.SelectedValue.ToString();
        objsales.state = ddlState.SelectedValue.ToString();
        objsales.servicetype = ddServicetype.SelectedValue.ToString();
        objsales.postal_code = txtpin.Text;
        objsales.country = "India";
        objsales.Office_id = "1";
        objsales.lead_source = ddlLeadSource.SelectedValue.ToString();
        objsales.lead_status = ddlLeadStatus.SelectedValue.ToString();
        objsales.description = txtDescription.Text;
        objsales.ExpectedRevenue = txtExpRevenue.Text;
        objsales.created_by = Session["user_id"].ToString();
        objsales.expecteddate = Convert.ToDateTime(txtExpecteddate.Text);
        objsales.Followup_date = Convert.ToDateTime(txtfolowupdate.Text);
        objsales.servicetype = ddServicetype.SelectedValue.ToString();
        objsales.cancel_reason = ddlReason.SelectedValue.ToString();
        objsales.assign_emp = ddlpickupexe.SelectedValue.ToString();
        if (ViewState["flag"].ToString() == "I")
        {
            objReader = objsales.CheckExistingLead(txtMobile.Text);
            if (objReader.Read())
            {
                lblmsg.Visible = true;
                lblmsg.Text = "Customer already registered";
                return;
            }
            objReader.Close();
            objsales.lead_no = "0";
            objsales.Flag = "I";
            lead_no = objsales.crmlead_Insert(objsales);
        }
        if (ViewState["flag"].ToString() == "U")
        {
            objsales.lead_no = Request.QueryString["LeadId"].ToString();
            objsales.Flag = "U";
            lead_no = objsales.crmlead_Insert(objsales);
            // ViewState["leadno1"] = lead_no;
        }
        Response.Redirect("Lead_select.aspx");
    }
}
        
