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
using System.Net.Mail;

public partial class Expense_Expance_Entry : System.Web.UI.Page
{
    maincode obj_main = new maincode();
    clsSales objsales = new clsSales();
    SqlDataReader objReader;
    string value;
    protected void Page_Load(object sender, EventArgs e)
    {
        //lblusername.Text = Session["name"].ToString();
       // string des = Session["designation"].ToString();

        if (Session["user_id"] == null || Session["user_name"] == null)
        {
            Response.Redirect("~/AdminLogin.aspx");
        }
        if (!IsPostBack)
        {
            txtdate.Text = DateTime.UtcNow.ToShortDateString();



            objReader = objsales.Expense_select(1);
            ddlexpancetype.DataSource = objReader;
            ddlexpancetype.DataTextField = "Expense_name";
            ddlexpancetype.DataValueField = "Expense_name";
            ddlexpancetype.DataBind();
            ddlexpancetype.Items.Insert(0, "<--Select-->");
            ddlexpancetype.Items[0].Value = "0";
            ddlexpancetype.SelectedValue = "0";
            objReader.Close();

            ViewState["flag"] = "I";
            if (Request.QueryString["s_no"] != null)
            {
                objReader = obj_main.Expense_Entry_update_view(Request.QueryString["s_no"].ToString());
                if (objReader.Read())
                {
                    txtdues.Text = objReader["due_amount"].ToString();  
                    txtgivenamt.Text = objReader["collected_amount"].ToString();                 
                    txtdate.Text = objReader["Expence_date"].ToString();
                    txt_receivername.Text = objReader["Receiver_Name"].ToString();
                    txt_purpose.Text = objReader["Purpose"].ToString();
                    txt_remarks.Text = objReader["Remarks"].ToString();
                    txt_amt.Text = objReader["amount"].ToString();
                    txtbankname.Text = objReader["bank_and_branch"].ToString();
                    Txtchequeno.Text = objReader["cheque_no"].ToString();
                    ddlexpancetype.SelectedValue = objReader["Expense_type"].ToString();

                }
                ViewState["flag"] = "U";
            }

        }
    }
    protected void submit_Click1(object sender, ImageClickEventArgs e)
    {
        obj_main.amount = txt_amt.Text;
        obj_main.collected_amount = txtgivenamt.Text;
        obj_main.due_amount = txtdues.Text;

        obj_main.Expence_date = Convert.ToDateTime(txtdate.Text);
        obj_main.Receiver_Name = txt_receivername.Text;
        obj_main.Expense_type = ddlexpancetype.SelectedValue.ToString();
        obj_main.Purpose = txt_purpose.Text;
        obj_main.Remarks = txt_remarks.Text;
        obj_main.bank_and_branch = txtbankname.Text;
        obj_main.cheque_no = Txtchequeno.Text;

        obj_main.created_by = Session["user_id"].ToString();

        if (radcash.Checked == true)
        {
            obj_main.mode_of_payment = "cash";

        }
        else if (radCheque.Checked == true)

            obj_main.mode_of_payment = "cheque";

        else
            obj_main.mode_of_payment = "";


        if (ViewState["flag"].ToString() == "I")
        {
            obj_main.flag = "I";
            obj_main.sno = "0";

            value = obj_main.Expense_Entry_Insert(obj_main);
        }

        else if (ViewState["flag"].ToString() == "U")
        {
            obj_main.flag = "U";
            obj_main.sno = Request.QueryString["s_no"].ToString();
            value = obj_main.Expense_Entry_Insert(obj_main);
        }

        Response.Redirect("~/Expense/view_expance_details.aspx");

    }


    protected void reset_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/Expense/Expance_Entry.aspx");
    }


    protected void radcash_CheckedChanged(object sender, EventArgs e)
    {
        Txtchequeno.Enabled = false;
        txtbankname.Enabled = false;
        txt_amt.Enabled = true;

    }

    protected void radCheque_CheckedChanged1(object sender, EventArgs e)
    {
        Txtchequeno.Enabled = true;
        txtbankname.Enabled = true;
        txt_amt.Enabled = true;
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (Session["designation"].ToString() == "13")
        {
            Session.Abandon();
            Response.Redirect("~/Admin_Login.aspx");

        }
        else
        {
            Session.Abandon();
            Response.Redirect("~/Admin_Login.aspx");
        }
    }
   
    protected void LinkButton1_Click1(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("~/AdminLogin.aspx");
    }
    protected void txtsearch_TextChanged1(object sender, EventArgs e)
    {
        obj_main.search_value = txtsearch.Text.ToString();
        Response.Redirect("~/search_value.aspx?search_value=" + txtsearch.Text);

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/home.aspx");
    }
}