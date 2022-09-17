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

public partial class Jobwork_insert_jobwork : System.Web.UI.Page
{
    clsRepair objRepair = new clsRepair();
    clsSales objsales = new clsSales();
    clsAccount objAccount = new clsAccount();
    clsUser objuser = new clsUser();
    clsSupport objsupport = new clsSupport();
    SqlDataReader objReader;
    string Requestid, lead_status, Active;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_id"] == null || Session["user_name"] == null)
        {
            Response.Redirect("~/AdminLogin.aspx");
        }
        
        if (!IsPostBack)
        {
            //AutoCompleteExtender1.ContextKey =Session["company"].ToString();
            txtPick.Text = DateTime.UtcNow.ToShortDateString();
            txtIntime.Text = DateTime.UtcNow.ToShortDateString();
            txtOut.Text = DateTime.UtcNow.ToShortDateString();
            txtReturn.Text = DateTime.UtcNow.ToShortDateString();
            txtexpdate.Text = DateTime.UtcNow.ToShortDateString();
        

            objReader = objsales.CRMOffice_Select(1);
            ddlOffice.DataSource = objReader;
            ddlOffice.DataTextField = "office_name";
            ddlOffice.DataValueField = "office_id";
            ddlOffice.DataBind();
            ddlOffice.SelectedIndex = 0;
            objReader.Close();

            objReader = objRepair.drop_down_Repairstatus_select(1);
            ddlRepairstatus.DataSource = objReader;
            ddlRepairstatus.DataTextField = "RepairStatus";
            ddlRepairstatus.DataValueField = "RepairStatus";
            ddlRepairstatus.DataBind();
            ddlRepairstatus.Items.Insert(0, "Select Repair Status");
            ddlRepairstatus.Items[0].Value = "0";
            ddlRepairstatus.SelectedIndex = 0;
            objReader.Close();


            objReader = objRepair.drop_down_Repairreason_select(1);
            ddlRepairreason.DataSource = objReader;
            ddlRepairreason.DataTextField = "Repairreason";
            ddlRepairreason.DataValueField = "repairreason_code";
            ddlRepairreason.DataBind();
            ddlRepairreason.Items.Insert(0, "Select Repair Reason");
            ddlRepairreason.Items[0].Value = "0";
            ddlRepairreason.SelectedIndex = 0;
            objReader.Close();

            //objReader = objRepair.drop_down_Repairreason_select(1);
            //ddlRepairreason.DataSource = objReader;
            //ddlRepairreason.DataTextField = "Repairreason";
            //ddlRepairreason.DataValueField = "repairreason_code";
            //ddlRepairreason.DataBind();
            //ddlRepairreason.SelectedIndex = 0;
            //objReader.Close();

            objReader = objuser.crm_user_selectfordropdown("Admin");
            ddlpickupex.DataSource = objReader;
            ddlpickupex.DataTextField = "name";
            ddlpickupex.DataValueField = "emp_id";
            ddlpickupex.DataBind();
            ddlpickupex.Items.Insert(0, "Select Executive");
            ddlpickupex.Items[0].Value = "0";
            ddlpickupex.SelectedIndex = 0;
            objReader.Close();
            ///////////////////////////Confuse//////////////////////////////////////
            objReader = objuser.crm_user_selectfordropdown("Admin");
            ddlChipLevel.DataSource = objReader;
            ddlChipLevel.DataTextField = "name";
            ddlChipLevel.DataValueField = "emp_id";
            ddlChipLevel.DataBind();
            ddlChipLevel.Items.Insert(0, "Select Executive");
            ddlChipLevel.Items[0].Value = "0";
            ddlChipLevel.SelectedIndex = 0;
            objReader.Close();

            objReader = objuser.crm_user_selectfordropdown("Admin");
            ddlQuality.DataSource = objReader;
            ddlQuality.DataTextField = "name";
            ddlQuality.DataValueField = "emp_id";
            ddlQuality.DataBind();
            ddlQuality.Items.Insert(0, "Select Executive");
            ddlQuality.Items[0].Value = "0";
            ddlQuality.SelectedIndex = 0;
            objReader.Close();

            objReader = objuser.crm_user_selectfordropdown("Admin");
            ddlDeliveryex.DataSource = objReader;
            ddlDeliveryex.DataTextField = "name";
            ddlDeliveryex.DataValueField = "emp_id";
            ddlDeliveryex.DataBind();
            ddlDeliveryex.Items.Insert(0, "Select Executive");
            ddlDeliveryex.Items[0].Value = "0";
            ddlDeliveryex.SelectedIndex = 0;
            objReader.Close();

            objReader = objRepair.CRMGadgettype_select();
            ddlType.DataSource = objReader;
            ddlType.DataTextField = "Gadgettype_name";
            ddlType.DataValueField = "Gadgettype_id";
            ddlType.DataBind();
            ddlType.Items.Insert(0, "Select Gadget Type");
            ddlType.Items[0].Value = "0";
            ddlType.SelectedIndex = 0;
            objReader.Close();


            objReader = objRepair.crm_phone_rent_select(1);
            ddlrentphone.DataSource = objReader;
            ddlrentphone.DataTextField = "phone_rent_status";
            ddlrentphone.DataValueField = "phone_rent_status";
            ddlrentphone.DataBind();
            ddlrentphone.Items.Insert(0, "Select Condition");
            ddlrentphone.Items[0].Value = "0";
            ddlrentphone.SelectedIndex = 0;
            objReader.Close();

            objReader = objuser.crm_user_selectfordropdown("Admin");
            ddl_software.DataSource = objReader;
            ddl_software.DataTextField = "name";
            ddl_software.DataValueField = "emp_id";
            ddl_software.DataBind();
            ddl_software.Items.Insert(0, "Select Software Engineer");
            ddl_software.Items[0].Value = "0";
            ddl_software.SelectedIndex = 0;
            objReader.Close();



            objReader = objRepair.Entry_status__drop_down_select(1);
            ddlReturn.DataSource = objReader;
            ddlReturn.DataTextField = "Entry_status";
            ddlReturn.DataValueField = "Entry_status";
            ddlReturn.DataBind();
            //ddlReturn.Items.Insert(0, "Select Software Engineer");
            //ddlReturn.Items[0].Value = "0";
            ddlReturn.SelectedIndex = 0;
            objReader.Close();

            objReader = objRepair.CRMEquipmentStatus_select();
            ddlJobwork.DataSource = objReader;
            ddlJobwork.DataTextField = "equipmentStatus_name";
            ddlJobwork.DataValueField = "equipmentStatus_id";
            ddlJobwork.DataBind();
            ddlJobwork.Items.Insert(0, "Select Status");
            ddlJobwork.Items[0].Value = "0";
            ddlJobwork.SelectedIndex = 0;
            objReader.Close();




            ViewState["flag"] = "I";

            if (Request.QueryString["Serialno"] != null)
            {


                objReader = objRepair.crmequipment_update(Request.QueryString["Serialno"].ToString(), 1);
                if (objReader.Read())
                {
                       Session["requestId"] = objReader["requestId"].ToString();


                       lblServ_revn.Text = objReader["ExpectedRevenue"].ToString();
                        lblservicetype.Text = objReader["servicetype"].ToString();
                        txtLeadno.Text = objReader["requestId"].ToString();
                        ddlType.SelectedValue = objReader["Gadgettype"].ToString();
                       // lblServ_revn.Text = objReader["amount"].ToString();
                        txtDesc.Text = objReader["Issue"].ToString();
                        txtSolution.Text = objReader["solution"].ToString();
                        ddlRepairstatus.SelectedValue = objReader["RepairStatus"].ToString();
                        //txtEmail.Text = objReader["Device_status"].ToString();
                        //txtFax.Text = objReader["equipmentreturn_reason"].ToString();
                        ddlRepairreason.SelectedValue = objReader["repairreason_code"].ToString();
                        txtPick.Text = objReader["Pickuptime"].ToString();
                        txtIntime.Text = objReader["inTime"].ToString();
                        txtexpdate.Text = objReader["expectdate"].ToString();
                        lblexpdeldate.Text = objReader["expectdate"].ToString();
                        //txtnec.Text = objReader["nextUpdate"].ToString();
                        txtOut.Text = objReader["outTime"].ToString();
                        txtReturn.Text = objReader["return_date"].ToString();
                        txtStoreRemarks.Text = objReader["StoreRemarks"].ToString();
                        txtBrand.Text = objReader["Brand"].ToString();
                        txtModel.Text = objReader["Model"].ToString();
                        txtpattarn_lock.Text = objReader["pattern_lock"].ToString();
                        txtImieno.Text = objReader["IMIE_NO"].ToString();
                        txtScreen.Text = objReader["Screen"].ToString();
                        txtBatterySerailNo.Text = objReader["Battery_Serial_No"].ToString();
                        txtCamera.Text = objReader["Camera"].ToString();
                        txtKeypad.Text = objReader["Keypad"].ToString();
                        lblcustadd.Text = objReader["street"].ToString();
                        txtCharger.Text = objReader["Adopter_Charger"].ToString();
                        txtbody.Text = objReader["Front_BackBody"].ToString();
                        txtBackcover.Text = objReader["Back_cover"].ToString();
                        txtDatacard.Text = objReader["datacard"].ToString();
                        txtDatcable.Text = objReader["Datacable"].ToString();
                        txtOther.Text = objReader["Other"].ToString();
                        ddlpickupex.SelectedValue = objReader["Pickup_Engineer"].ToString();
                        ddlChipLevel.SelectedValue = objReader["chipEngineer"].ToString();
                        ddlQuality.SelectedValue = objReader["softwareinstall_eng"].ToString();
                        ddlQuality.SelectedValue = objReader["QualitycheckEngineer"].ToString();
                        ddlDeliveryex.SelectedValue = objReader["DeliveryEngineer"].ToString();

                        ddlRepairreason.SelectedValue = objReader["repairreason_code"].ToString();
                    
                        ddlrentphone.SelectedValue = objReader["phone_rent_status"].ToString();

                        ddlReturn.SelectedValue = objReader["Entry_status"].ToString();
                        ddlJobwork.SelectedValue = objReader["jobwork_status"].ToString();

                        if (ddlJobwork.SelectedValue.ToString() == "12")
                        {
                            lblexpdeldate.Text = "Device Already Delivered";
                            txtexpdate.Text = objReader["expectdate"].ToString();

                        }
                        else
                        {
                           // lblexpdeldate.Visible = true;
                            lblexpdeldate.Text = objReader["expectdate"].ToString();
                            txtexpdate.Text = objReader["expectdate"].ToString();
        
                        }

                        if (ddlReturn.SelectedValue.ToString() == "Return")
                        {
                            ddlReturn.Enabled = false;

                        }

                        else
                        {
                            lblMsg.Visible = false;
                            btnSave.Enabled = true;
                            btnSave1.Enabled = true;
                        }
                        ddl_software.SelectedValue = objReader["software_engg"].ToString();
                        objRepair.jobwork_status = ddlJobwork.SelectedValue.ToString();

                        //txtSmartPhone.Text = objReader["created_on"].ToString();
                        //ddlReason.SelectedValue = objReader["created_by"].ToString();
                        ddlOffice.SelectedValue = objReader["office_id"].ToString();
                        //ddlTitle.SelectedValue = objReader["ApprovalOption"].ToString();
                        //txtFollowuptime.Text = objReader["costapproval"].ToString();
                        lblcustomername.Text = objReader["customerName"].ToString();
                        lblContactnumber.Text = objReader["mobile_no"].ToString();
                        //lbl= objReader["professional_email"].ToString();
                        //lblcustadd.Text = objReader["street"].ToString();
                       ddlJobwork.SelectedValue = objReader["jobwork_status"].ToString();
                    if (ddlJobwork.SelectedValue.ToString() == "12")
                    {
                        lblMsg.Visible = true;
                        lblMsg.Text = "Please Change Entry Status for Update";
                        ddlJobwork.Enabled = false;
                        btnSave.Enabled = false;
                        btnSave1.Enabled = false;

                         if (ddlReturn.SelectedValue.ToString() == "Return")
                        {
                            lblMsg.Visible = false;
                           // lblMsg.Text = "Please Change Entry Status for Update";
                            ddlJobwork.Enabled = true;
                            btnSave.Enabled = true;
                            btnSave1.Enabled = true;
                            ddlReturn.Enabled = false;

                        }
                        
                    }

                        ViewState["flag"] = "U";
                    }
                }
            }
        

            objRepair.jobwork_status = ddlJobwork.SelectedValue.ToString();
            grdCalllog.DataSource = objRepair.equipment_calllog_select(txtLeadno.Text, 1);
            grdCalllog.DataBind();

    }


    protected void btnSave1_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            save();
            //Response.Redirect("Ticket_select.aspx");
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            save();
            //Response.Redirect("Ticket_select.aspx");
        }
    }
    public void save()
    {

        objRepair.requestId = txtLeadno.Text;
        objRepair.Gadgettype = ddlType.SelectedValue.ToString();
        objRepair.jobwork_status = ddlJobwork.SelectedValue.ToString();
        objRepair.Issue = txtDesc.Text;
        objRepair.solution = txtSolution.Text;
        objRepair.RepairStatus = ddlRepairstatus.SelectedValue.ToString();
        objRepair.Device_status = "0";
        objRepair.equipmentreturn_reason = "";
        objRepair.repairreason_code = "0";

        objRepair.Pickuptime = Convert.ToDateTime(txtPick.Text);
        objRepair.inTime = Convert.ToDateTime(txtIntime.Text);
        objRepair.expectdate = Convert.ToDateTime(txtexpdate.Text);
        objRepair.nextUpdate = Convert.ToDateTime(txtOut.Text);
        objRepair.outTime = Convert.ToDateTime(txtOut.Text);
        objRepair.return_date = Convert.ToDateTime(txtReturn.Text);
        objRepair.StoreRemarks = txtStoreRemarks.Text;
        objRepair.Brand = txtBrand.Text;
        objRepair.Model = txtModel.Text;
        objRepair.IMIE_NO = txtImieno.Text;
        objRepair.Screen = txtScreen.Text;
        objRepair.Battery_Serial_No = txtBatterySerailNo.Text;
        objRepair.Camera = txtCamera.Text;
        objRepair.Keypad = txtKeypad.Text;
        objRepair.Adopter_Charger = txtCharger.Text;
        objRepair.Front_BackBody = txtbody.Text;
        objRepair.Back_cover = txtBackcover.Text;
        objRepair.datacard = txtDatacard.Text;
        objRepair.Datacable = txtDatcable.Text;
        objRepair.Other = txtOther.Text;
        objRepair.pattern_lock = txtpattarn_lock.Text;
        objRepair.Pickup_Engineer = ddlpickupex.SelectedValue.ToString();
        objRepair.chipEngineer = ddlChipLevel.SelectedValue.ToString();
        objRepair.softwareinstall_eng = "0";
        objRepair.QualitycheckEngineer = ddlQuality.SelectedValue.ToString();
        objRepair.DeliveryEngineer = ddlDeliveryex.SelectedValue.ToString();
        objRepair.created_by = Session["user_id"].ToString();
        objRepair.office_id = ddlOffice.SelectedValue.ToString();
        objRepair.phone_rent_status = ddlrentphone.SelectedValue.ToString();
        objRepair.software_engg = ddl_software.SelectedValue.ToString();
        objRepair.Entry_status = ddlReturn.SelectedValue.ToString();
        objRepair.repairreason_code = ddlRepairreason.SelectedValue.ToString();


        objRepair.ApprovalOption = "y";
        objRepair.costapproval = "1";
        objRepair.approval_by = "1";
        objRepair.approval_date = Convert.ToDateTime(txtOut.Text);
        if (ViewState["flag"].ToString() == "I")
        {
            objReader = objRepair.CheckExisting_RequestId_jobworktable(txtLeadno.Text);
            if (objReader.Read())
            {
                lblMsg.Visible = true;
                lblMsg.Text = "Record are already inserted for this requestid";
                return;
            }

            objReader.Close();
            objRepair.flag = "I";
            objRepair.serial_no = "0";
            Requestid = objRepair.crmequipment_Insert(objRepair);

        }

        else if (ViewState["flag"].ToString() == "U")
        {
            objRepair.flag = "U";
            objRepair.serial_no = Request.QueryString["Serialno"].ToString();
            Requestid = objRepair.crmequipment_Insert(objRepair);
        }

        if (Requestid == "NO")
        {
            lblMsg.Visible = true;
            lblMsg.Text = "Record are already inserted for this requestid";
            return;
        }
        else
        {
            lblMsg.Visible = false;
            lblMsg.Text = "";
            Response.Redirect("View_Jobwork.aspx");
        }
    }
    protected void btnlogSave_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["Serialno"] != null)
        {
            objRepair.jobwork_status = ddlJobwork.SelectedValue.ToString();
            //ddlJobwork.SelectedValue = objReader["jobwork_status"].ToString();

            Requestid = objRepair.equipment_calllog_insert(txtLeadno.Text, txtCallLog.Text, Session["user_id"].ToString());

        }
        grdCalllog.DataSource = objRepair.equipment_calllog_select(txtLeadno.Text, 1);
        grdCalllog.DataBind();
    }
    protected void btnCancle_Click(object sender, EventArgs e)
    {
        txtCallLog.Text = "";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Jobwork/insert_jobwork.aspx");
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("jobwork_select.aspx");
    }
    protected void txtLeadno_TextChanged(object sender, EventArgs e)
    {
        objReader = objRepair.CheckExisting_RequestId_jobworktable(txtLeadno.Text);
        if (objReader.Read())
        {
            lblMsg.Visible = true;
            lblMsg.Text = "Record are already inserted for this requestid";
            return;
        }

        objReader = objsales.leaddetail_selectforticket(txtLeadno.Text, 1);
        if (objReader.Read())
        {
            ////status = objReader["status"].ToString();
            //if (objReader["lead_status"].ToString() == "2")
            //{
            //    lblMsg.Visible = false;
            //    lblMsg.Text = "";
            //}
            //else
            //{
            //    lblMsg.Visible = true;
            //    lblMsg.Text = "Lead is not in Prospect please convert it into Prospect";
            //    return;
            //}
            lblservicetype.Text = objReader["servicetype"].ToString();
            lblServ_revn.Text = objReader["ExpectedRevenue"].ToString();
            lblcustomername.Text = objReader["customername"].ToString();
            lblContactnumber.Text = objReader["mobile"].ToString();
            lblcustadd.Text = objReader["address"].ToString();
            ddlOffice.SelectedValue = objReader["Office_id"].ToString();
        }
        objReader.Close();
    

    }
}