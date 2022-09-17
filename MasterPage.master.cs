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

public partial class MasterPage : System.Web.UI.MasterPage
{
    maincode obj_main = new maincode();
    SqlDataReader objReader;
    protected void Page_Load(object sender, EventArgs e)
    {
       lblusername.Text = Session["name"].ToString();
       string des = Session["role"].ToString();
       if ((Session["role"].ToString() == "Inside sale" ||  Session["role"].ToString() == "TRC"))
       {
           
           hyplsaleperformance.Visible = false;
           hypldailytransction.Visible = false;
           hyplmydash.Visible = true;
           hyplmylead.Visible = true;

           Hypl_user.Visible = false;
           HyperLink29.Visible = false;
           HyperLink4.Visible = false;
           //HyperLink9.Visible = false;
           //HyperLink31.Visible = false;
           //HyperLink15.Visible = false;
           //  hypl_custo.Visible = false;
           hypl_dev.Visible = true;
           //HyperLink36.Visible = false;
           HyperLink5.Visible = false;
           HyperLink19.Visible = false;
           HyperLink8.Visible = false;
           HyperLink3.Visible = false;

       }
       if ((Session["role"].ToString() == "Account & Finance" || Session["role"].ToString() == "Management"))
       {
           Hypl_user.Visible = false;
           hyplsaleperformance.Visible = true;
           hypldailytransction.Visible = true;
           hyplmydash.Visible = false;
           hyplmylead.Visible = false;
       }
       if ( Session["role"].ToString() == "Admin")
       {
           
           hyplsaleperformance.Visible = true;
           hypldailytransction.Visible = true;
           hyplmydash.Visible = false;
           hyplmylead.Visible = false;
       }

       if (( Session["role"].ToString() == "Inside Support" ))
       {
           Hypl_user.Visible = false;

           //HyperLink9.Visible = false;

           //HyperLink31.Visible = false;

           //HyperLink15.Visible = false;
           //  hypl_custo.Visible = false;
           hypl_dev.Visible = true;

         //  HyperLink36.Visible = false;
         HyperLink5.Visible = true;
           HyperLink19.Visible = false;
           HyperLink8.Visible = false;
           HyperLink3.Visible = false;
          hyplsaleperformance.Visible = true;
           hypldailytransction.Visible = true;
           hyplmydash.Visible = true;
           hyplmylead.Visible = true;

       }
    
    }
   
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/home.aspx");
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
}
