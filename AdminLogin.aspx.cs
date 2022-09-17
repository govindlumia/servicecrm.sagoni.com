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

public partial class AdminLogin : System.Web.UI.Page
{
    clsUser objuser = new clsUser();
    SqlDataReader objReader, objReader1, objReader2;
    string password, empcode, ip_address;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
  protected void Button1_Click(object sender, EventArgs e)
    {
        //System.Threading.Thread.Slee(500);
        string ip_address = HttpContext.Current.Request.UserHostAddress;
        objReader = objuser.crm_user_selectforlogin(txtcode.Text, txtPassword.Text);

        if (objReader.Read())
        {
            Session["role"] = objReader["role"].ToString();
            Session["designation"] = objReader["role"].ToString();
            // string des = Session["designation"].ToString();
            if (Session["role"].ToString() == "QRT Sales")
            {

                //{
                //   if (Session["role"].ToString() == "SuperAdmin" || Session["role"].ToString() == "ITAdmin")
                // {
                rfvEngPass.Validate();
                rfvempcode.Validate();
                if (rfvempcode.IsValid && rfvEngPass.IsValid)
                {

                    password = txtPassword.Text.Trim();
                    empcode = txtcode.Text.Trim();
                    string mac_address = "";
                    objuser.crmuserLogin_insert(objReader["emp_id"].ToString(), txtcode.Text, ip_address, "0", 'I');
                    objReader = objuser.crm_user_selectforlogin(txtcode.Text, txtPassword.Text);
                    //objReader = objEmp.HR_userSelect(txtUserName.Text, txtPassword.Text);
                    if (objReader.Read())
                    {

                        Session["employee_id"] = objReader["emp_id"].ToString();
                        Session["user_id"] = objReader["emp_id"].ToString();
                        Session["emp_id"] = objReader["emp_id"].ToString();
                        Session["emp_code"] = objReader["emp_code"].ToString();
                        Session["user_name"] = objReader["emp_name"].ToString();
                        Session["read"] = objReader["rd"].ToString();
                        Session["write"] = objReader["write"].ToString();
                        Session["designation"] = objReader["designation"].ToString();
                        //Session["companyName"] = objReader["company"].ToString();
                        // Session["image"] = objReader["image"].ToString();
                        Session["name"] = objReader["username"].ToString();
                        Session["role"] = objReader["role"].ToString();
                        // Session["subdesignation"] = objReader["subdesignation"].ToString();
                        // Session["subdesignation_name"] = objReader["subdesignation_name"].ToString();
                        Session["office_id"] = objReader["office_id"].ToString();
                        Session["Supervisorid"] = objReader["Supervisorid"].ToString();
                        Response.Redirect("~/home.aspx");
                    }

                }
            }
            if (Session["role"].ToString() == "Account & Finance" || Session["role"].ToString() == "Management")
            {

                //{
                //   if (Session["role"].ToString() == "SuperAdmin" || Session["role"].ToString() == "ITAdmin")
                // {
                rfvEngPass.Validate();
                rfvempcode.Validate();
                if (rfvempcode.IsValid && rfvEngPass.IsValid)
                {

                    password = txtPassword.Text.Trim();
                    empcode = txtcode.Text.Trim();
                    string mac_address = "";
                    objuser.crmuserLogin_insert(objReader["emp_id"].ToString(), txtcode.Text, ip_address, "0", 'I');
                    objReader = objuser.crm_user_selectforlogin(txtcode.Text, txtPassword.Text);
                    //objReader = objEmp.HR_userSelect(txtUserName.Text, txtPassword.Text);
                    if (objReader.Read())
                    {

                        Session["employee_id"] = objReader["emp_id"].ToString();
                        Session["user_id"] = objReader["emp_id"].ToString();
                        Session["emp_id"] = objReader["emp_id"].ToString();
                        Session["emp_code"] = objReader["emp_code"].ToString();
                        Session["user_name"] = objReader["emp_name"].ToString();
                        Session["designation"] = objReader["role"].ToString();
                        Session["name"] = objReader["username"].ToString();
                        Session["role"] = objReader["role"].ToString();
                        Response.Redirect("~/home.aspx");
                    }

                }
            }
            if (Session["role"].ToString() == "Inside sale" || Session["role"].ToString() == "Inside Support" || Session["role"].ToString() == "TRC")
            {

                //{
                //   if (Session["role"].ToString() == "SuperAdmin" || Session["role"].ToString() == "ITAdmin")
                // {
                rfvEngPass.Validate();
                rfvempcode.Validate();
                if (rfvempcode.IsValid && rfvEngPass.IsValid)
                {

                    password = txtPassword.Text.Trim();
                    empcode = txtcode.Text.Trim();
                    string mac_address = "";
                    objuser.crmuserLogin_insert(objReader["emp_id"].ToString(), txtcode.Text, ip_address, "0", 'I');
                    objReader = objuser.crm_user_selectforlogin(txtcode.Text, txtPassword.Text);
                    //objReader = objEmp.HR_userSelect(txtUserName.Text, txtPassword.Text);
                    if (objReader.Read())
                    {

                        Session["employee_id"] = objReader["emp_id"].ToString();
                        Session["user_id"] = objReader["emp_id"].ToString();
                        Session["emp_id"] = objReader["emp_id"].ToString();
                        Session["emp_code"] = objReader["emp_code"].ToString();
                        Session["user_name"] = objReader["emp_name"].ToString();
                        //Session["read"] = objReader["rd"].ToString();
                        //Session["write"] = objReader["write"].ToString();
                        Session["designation"] = objReader["role"].ToString();
                        //Session["companyName"] = objReader["company"].ToString();
                        // Session["image"] = objReader["image"].ToString();
                        Session["name"] = objReader["username"].ToString();
                        Session["role"] = objReader["role"].ToString();
                        //  Session["subdesignation"] = objReader["subdesignation"].ToString();
                        //   Session["subdesignation_name"] = objReader["subdesignation_name"].ToString();
                        //Session["office_id"] = objReader["office_id"].ToString();
                        //Session["Supervisorid"] = objReader["Supervisorid"].ToString();
                        Response.Redirect("~/home.aspx");
                    }

                }
            }
            if (Session["role"].ToString() == "Development")
            {

                //{
                //   if (Session["role"].ToString() == "SuperAdmin" || Session["role"].ToString() == "ITAdmin")
                // {
                rfvEngPass.Validate();
                rfvempcode.Validate();
                if (rfvempcode.IsValid && rfvEngPass.IsValid)
                {

                    password = txtPassword.Text.Trim();
                    empcode = txtcode.Text.Trim();
                    string mac_address = "";
                    objuser.crmuserLogin_insert(objReader["emp_id"].ToString(), txtcode.Text, ip_address, "0", 'I');
                    objReader = objuser.crm_user_selectforlogin(txtcode.Text, txtPassword.Text);
                    //objReader = objEmp.HR_userSelect(txtUserName.Text, txtPassword.Text);
                    if (objReader.Read())
                    {

                        Session["employee_id"] = objReader["emp_id"].ToString();
                        Session["user_id"] = objReader["emp_id"].ToString();
                        Session["emp_id"] = objReader["emp_id"].ToString();
                        Session["emp_code"] = objReader["emp_code"].ToString();
                        Session["user_name"] = objReader["emp_name"].ToString();
                        Session["read"] = objReader["rd"].ToString();
                        Session["write"] = objReader["write"].ToString();
                        Session["designation"] = objReader["designation"].ToString();
                        //Session["companyName"] = objReader["company"].ToString();
                        // Session["image"] = objReader["image"].ToString();
                        Session["name"] = objReader["username"].ToString();
                        Session["role"] = objReader["role"].ToString();
                        //  Session["subdesignation"] = objReader["subdesignation"].ToString();
                        // Session["subdesignation_name"] = objReader["subdesignation_name"].ToString();
                        Session["office_id"] = objReader["office_id"].ToString();
                        Session["Supervisorid"] = objReader["Supervisorid"].ToString();
                        Response.Redirect("~/home.aspx");
                    }

                }
            } if (Session["role"].ToString() == "Admin" || Session["role"].ToString() == "IT Department")
            {

                //{
                //   if (Session["role"].ToString() == "SuperAdmin" || Session["role"].ToString() == "ITAdmin")
                // {
                rfvEngPass.Validate();
                rfvempcode.Validate();
                if (rfvempcode.IsValid && rfvEngPass.IsValid)
                {

                    password = txtPassword.Text.Trim();
                    empcode = txtcode.Text.Trim();
                    string mac_address = "";
                    objuser.crmuserLogin_insert(objReader["emp_id"].ToString(), txtcode.Text, ip_address, "0", 'I');
                    objReader = objuser.crm_user_selectforlogin(txtcode.Text, txtPassword.Text);
                    //objReader = objEmp.HR_userSelect(txtUserName.Text, txtPassword.Text);
                    if (objReader.Read())
                    {

                        Session["employee_id"] = objReader["emp_id"].ToString();
                        Session["user_id"] = objReader["emp_id"].ToString();
                        Session["emp_id"] = objReader["emp_id"].ToString();
                        Session["emp_code"] = objReader["emp_code"].ToString();
                        Session["user_name"] = objReader["emp_name"].ToString();
                        //Session["read"] = objReader["rd"].ToString();
                        //Session["write"] = objReader["write"].ToString();
                        Session["designation"] = objReader["role"].ToString();
                        //Session["companyName"] = objReader["company"].ToString();
                        // Session["image"] = objReader["image"].ToString();
                        Session["name"] = objReader["username"].ToString();
                        Session["role"] = objReader["role"].ToString();
                        //  Session["subdesignation"] = objReader["subdesignation"].ToString();
                        //   Session["subdesignation_name"] = objReader["subdesignation_name"].ToString();
                        //Session["office_id"] = objReader["office_id"].ToString();
                        //Session["Supervisorid"] = objReader["Supervisorid"].ToString();
                        Response.Redirect("~/home.aspx");
                    }

                }
            }
            else
            {
                objReader = objuser.crm_iptable_select(ip_address);
                if (objReader.Read())
                {

                    rfvEngPass.Validate();
                    rfvempcode.Validate();


                    if (rfvempcode.IsValid && rfvEngPass.IsValid)
                    {

                        password = txtPassword.Text.Trim();
                        empcode = txtcode.Text.Trim();


                        string mac_address = "";


                        objuser.crmuserLogin_insert(objReader["emp_id"].ToString(), txtcode.Text, ip_address, "0", 'I');
                        objReader = objuser.crm_user_selectforlogin(txtcode.Text, txtPassword.Text);
                        //objReader = objEmp.HR_userSelect(txtUserName.Text, txtPassword.Text);
                        if (objReader.Read())
                        {

                            Session["user_id"] = objReader["emp_id"].ToString();
                            Session["emp_code"] = objReader["emp_code"].ToString();
                            Session["user_name"] = objReader["emp_name"].ToString();
                            //Session["read"] = objReader["rd"].ToString();
                            //Session["write"] = objReader["write"].ToString();
                            Session["designation"] = objReader["role"].ToString();
                            //Session["companyName"] = objReader["company"].ToString();
                            // Session["image"] = objReader["image"].ToString();
                            Session["name"] = objReader["username"].ToString();
                            Session["role"] = objReader["role"].ToString();
                            // Session["subdesignation"] = objReader["subdesignation"].ToString();
                            //  Session["subdesignation_name"] = objReader["subdesignation_name"].ToString();
                            //Session["office_id"] = objReader["office_id"].ToString();
                            //Session["Supervisorid"] = objReader["Supervisorid"].ToString();
                            Response.Redirect("home.aspx");
                        }

                    }
                }
                else
                {

                    lblmsg.Visible = true;
                    lblmsg.Text = "Please Enter Correct User Name and Password";
                    Session.Abandon();
                    return;
                }
            }

        }




                //else
        //{

                //    lblmsg.Visible = true;
        //    lblmsg.Text = "Please Enter Correct User Name and Password";
        //    Session.Abandon();
        //    return;
        //}

           // }

        else
        {

            lblmsg.Visible = true;
            lblmsg.Text = "Please Enter Correct User Name and Password";
            Session.Abandon();
            return;
        }
    }
}