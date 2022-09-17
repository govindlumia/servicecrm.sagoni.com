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
using System.Net.NetworkInformation;

public partial class generate_branch : System.Web.UI.Page
{
    clsSales objsales = new clsSales();
    clsUser objuser = new clsUser();
    maincode obj_main = new maincode();
    string value;
    
    SqlDataReader objReader, objReader1, objReader2;
    string password, empcode, ip_address,data;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_id"] == null || Session["user_name"] == null)
        {
            Response.Redirect("~/AdminLogin.aspx");
        }

        if (!IsPostBack)
        {

            objReader = obj_main.role_select();
            Ddlbranchname.DataSource = objReader;
            Ddlbranchname.DataTextField = "role";
            Ddlbranchname.DataValueField = "role";
            Ddlbranchname.DataBind();
            Ddlbranchname.Items.Insert(0, "Select Designation");
            Ddlbranchname.Items[0].Value = "0";
            Ddlbranchname.SelectedValue = "0";
            objReader.Close();

            
            ViewState["flag"] = "I";

            if (Request.QueryString["empid"] != null)
            {

                objReader = obj_main.crm_user_Detail_update(Request.QueryString["empid"].ToString());
                if (objReader.Read())
                {

                    Txtbranchname.Text = objReader["emp_name"].ToString();
                    txtBranchuser.Text = objReader["emp_code"].ToString();
                    txtadd.Text = objReader["address"].ToString();
                    Txtauthmob.Text = objReader["mobile_no"].ToString();
                    Txt_Email.Text = objReader["email"].ToString();
                    Txtpasscode.Text = objReader["password"].ToString();
                    Ddlbranchname.SelectedValue = objReader["role"].ToString();
                }
                ViewState["flag"] = "U";
            }
        }
    }
    protected void submit_Click(object sender, ImageClickEventArgs e)
    {
        objuser.emp_name = Txtbranchname.Text;
        objuser.role = Ddlbranchname.SelectedValue.ToString();
        objuser.Branch_Name = Txtbranchname.Text;
        objuser.email = Txt_Email.Text;
        objuser.emp_code = txtBranchuser.Text;
        objuser.mobile_no = Txtauthmob.Text;
        objuser.address = txtadd.Text;
        objuser.password = Txtpasscode.Text;
       // objuser.flag = "I";
        objuser.active = "Y";
        objuser.created_by = Session["user_id"].ToString();


        lblmsg.Visible = false;
        if (ViewState["flag"].ToString() == "I")
        {
            objReader = objuser.crm_user_login_check(txtBranchuser.Text);
            if (objReader.Read())
            {
                if (objReader["emp_code"].ToString() != txtBranchuser.Text)
                {
                    lblmsg.Visible = false;
                    lblmsg.Text = "";


                }
                else
                {

                    lblmsg.Visible = true;
                    lblmsg.Text = " User Name Already Exist Please try For Another Branch User Name";
                    return;

                }
            }
            objuser.flag = "I";
            objuser.emp_id = "0";
           

            data = objuser.crm_user_insert(objuser);
        }
        else if (ViewState["flag"].ToString() == "U")
        {
            objuser.flag = "U";
           // objuser.emp_id = "0";
           // objuser.active = "Inactive";
            objuser.emp_id = Request.QueryString["empid"].ToString();
            data = objuser.crm_user_insert(objuser);

        }

        Response.Redirect("~/Branch/Show_Branch_Login_Details.aspx");



    }

    protected void reset_Click(object sender, ImageClickEventArgs e)
    {
         Txtbranchname.Text="";

         Txtbranchname.Text = "";
         Txt_Email.Text = "";
         txtBranchuser.Text = "";
         Txtauthmob.Text = "";
         txtadd.Text = "";
         Txtpasscode.Text = "";

    }
}