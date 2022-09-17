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

public partial class changePassword : System.Web.UI.Page
{
    SqlDataReader objReader;
    clsUser objuser = new clsUser();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_id"] == null || Session["user_name"] == null)
        {
            Response.Redirect("~/AdminLogin.aspx");
        }
        if (!IsPostBack)
        {
            Session["update"] = Server.UrlEncode(System.DateTime.Now.ToString());
        }

    }
    private void Page_PreRender(object sender, EventArgs e)
    {
        ViewState["update"] = Session["update"];
    }
    protected void btnSubmitt_Click(object sender, EventArgs e)
    {
        if (Session["update"].ToString() == ViewState["update"].ToString())
        {
            if (Page.IsValid)
            {
                objReader = objuser.crm_user_selectforlogin(Session["emp_code"].ToString(), txtCuurentPass.Text);
               // objReader = objuser.Change_password(, Session["user_id"].ToString());
                if (objReader.Read())
                {
                    Session["update"] = Server.UrlEncode(System.DateTime.UtcNow.ToString());
                    objReader = objuser.Change_password(txtNewPass.Text, Session["user_id"].ToString());
                    lblMsg.Visible = true;
                    lblMsg.Text = "Password changed successfully";
                    txtNewPass.Text = "";
                    txtCuurentPass.Text = "";
                    txtConfPass.Text = "";

                }
                else
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "Current password does not match";
                }
            }
        }
    }
}
