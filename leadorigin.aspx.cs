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
using System.Data;
using System.Data.SqlClient;
using System.IO;

public partial class leadorigin : System.Web.UI.Page
{
    clsSales objsales = new clsSales();
    //clsCustomer objCustomer = new clsCustomer();
    SqlDataReader objReader, objReader1, objReader2;
    //mail objmail = new mail();
    DataTable dt;
    string name, leadsource, mobile,leadtype, email, office, address, city, lead_no,category="", description = "", orgin, SMS_datetime = "", allocate_to = "", company = "", mobile_no;
   
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!IsPostBack)
        {
            if (Request.QueryString["leadtype"] != null)
            {
                if (Request.QueryString["leadtype"] == null)
                {
                    leadtype = "";

                }
                else
                {
                    leadtype = Request.QueryString["leadtype"].ToString();
                }
            if (Request.QueryString["name"] == null)
            {
                name = "";
            }
            else
            {
                name = Request.QueryString["name"].ToString();
            }


            if (Request.QueryString["leadsource"] == null)
            {
                 leadsource = "1";
            }
            else
            {
                leadsource = Request.QueryString["leadsource"].ToString();
            }

            // ********************** Customer Mobile  ***********************

            if (Request.QueryString["mobile"] == null)
            {
                mobile = "";
            }
            else
            {
                mobile = Request.QueryString["mobile"].ToString();
            }
            // ********************** Customer Email  ***********************

            if (Request.QueryString["email"] == null)
            {
                email = "";
            }
            else
            {
                email = Request.QueryString["email"].ToString();
            }

            // ********************** Customer city  ***********************

            if (Request.QueryString["city"] == null)
            {
                city = "";

            }
            else
            {
                city = Request.QueryString["city"].ToString();
            }


            if (Request.QueryString["category"] == null)
            {
                category = "";

            }
            else
            {
                category = Request.QueryString["category"].ToString();
            }

            if (Request.QueryString["description"] == null)
            {
                description = "";

            }
            else
            {
                description = Request.QueryString["description"].ToString();
            }
           orgin = "Just Dial onetime Leads";
             
            }
            if (city == "Delhi NCR" || city == "Delhi" || city == "DEL" || city == "Delhi/NCR")
            {
                office = "1";

            }
    
            Save();
        }
    }
    private void Save()
    {

        //if (Session["update"].ToString() == ViewState["update"].ToString())
        //{
        try
        {
            Session["update"] = Server.UrlEncode(System.DateTime.UtcNow.ToString());


            objsales.first_name = name;
            objsales.last_name = " ";
            objsales.company = company;
            objsales.lead_source = leadsource;
            objsales.mobile_no = mobile;
           objsales.lead_type = leadtype;
            objsales.personal_email = email;
            objsales.Office_id = "1";
            objsales.description = description;
            objsales.created_by = "109";
            objsales.lead_no = "0";
            objsales.origin = orgin;
            objsales.category = category;
            //objsales.SMS_datetime = SMS_datetime;
           // objReader = objsales.Lead_allocation_duplicacy_check(Convert.ToDateTime(DateTime.Today.ToString()), Convert.ToDateTime(DateTime.Today.ToString()), "1", mobile, 1);
            //if (objReader.Read())
            //{
                allocate_to = "0";
            //}
            //else
            //{
                allocate_to = objsales.lead_allocationto_agent_insert(objsales);
           // }
            //objsales.Street = allocate_to;
            //lead_no = objsales.leadorgin_insert(objsales);



        }

        catch (Exception myException)
        {

            //blmsg.Text = "Request failed." + myException.Message;
        }

        if (Request.QueryString["leadtype"] != null)
        {
            lblmsg.Text = "Received";
        }
        else
        {
            lblmsg.Text = "Not Received";
           // Response.Redirect("Leadorigin_response.aspx");
        }

    }
}