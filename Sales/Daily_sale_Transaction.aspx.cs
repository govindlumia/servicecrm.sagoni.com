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

public partial class Sales_Daily_sale_Transaction : System.Web.UI.Page
{
    clsSales objsales = new clsSales();
    clsUser objuser = new clsUser();
    clsSupport objsupport = new clsSupport();
    clsAccount objAccount = new clsAccount();
    SqlDataReader objReader;

    decimal amtqual = 0, amtassign = 0, amtpros = 0;
    double countqual = 0, countassign = 0, countpros = 0, totallead = 0
       , counttotallead = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_id"] == null || Session["user_name"] == null)
        {
            Response.Redirect("~/AdminLogin.aspx");
        }
        

        if (!IsPostBack)
        {
            txtfromdate.Text = DateTime.UtcNow.ToShortDateString();
            objAccount.from_date = Convert.ToDateTime(txtfromdate.Text);

            grdvassigntech.DataSource = objsales.daily_sale_transaction(Convert.ToDateTime(txtfromdate.Text), '3');
            grdvassigntech.DataBind();

            gredpros.DataSource = objsales.daily_sale_transaction(Convert.ToDateTime(txtfromdate.Text), '2');
            gredpros.DataBind();
            grdqulify.DataSource = objsales.daily_sale_transaction(Convert.ToDateTime(txtfromdate.Text), '1');
            grdqulify.DataBind();


           

            objReader = objsales.daily_sale_transaction(Convert.ToDateTime(txtfromdate.Text), '4');
            if (objReader.Read())
            {

                lbltlead.Text = objReader["totallead"].ToString();

                counttotallead = Convert.ToDouble(objReader["totallead"]);
            }
            
            if (lbltlead.Text == "0")
            {
                lbltlead.Text = "0";
                lblproscount.Text = "0";
                lblqulicount.Text = "0";
                lblassign.Text = "0";
                lblassignamount.Text = "0";
                lblquliamount.Text = "0";
                lblprosamount.Text = "0";
                lblQualamt.Text = "0";
                lblQualcnt.Text = "0";
               
                lblquliconversion.Text = "0" + '%';
                lblprosconversion.Text = "0" + '%';
                lblquliconversion.Text = "0" + '%';
               
            }
            else
            {


                lblassign.Text = countassign.ToString();
                lblassignamount.Text = amtassign.ToString();

                lblquliamount.Text = amtqual.ToString();
                lblqulicount.Text = countqual.ToString();


                lblproscount.Text = countpros.ToString();
                lblprosamount.Text = amtpros.ToString();

                lblassign1.Text = countassign.ToString();
                lblassignamount1.Text = amtassign.ToString();

                lblQualamt.Text = amtqual.ToString();
                lblQualcnt.Text = countqual.ToString();

                lblPrsamt.Text = amtpros.ToString();
                lblPrsCnt.Text = countpros.ToString();




                lblassignconversion.Text = Math.Round((((countassign / counttotallead) * 100)), 2).ToString() + '%';

                lblprosconversion.Text = Math.Round((((countpros / counttotallead) * 100)), 2).ToString() + '%';


                lblquliconversion.Text = Math.Round((((countqual / counttotallead) * 100)), 2).ToString() + '%';

            }

        }


    }
    
    protected void grdqulify_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {

            amtqual = amtqual + Convert.ToDecimal(e.Row.Cells[3].Text);
            lblQualcnt.Text = countqual.ToString();
            countqual++;
            objAccount.flag = "1";

            lblqulicount.Text = countqual.ToString();
            lblQualamt.Text = amtqual.ToString();
            lblquliamount.Text = amtqual.ToString();
        }

    }
    protected void gredpros_RowDataBound(object sender, GridViewRowEventArgs e)
    {

        if (e.Row.RowType == DataControlRowType.DataRow)
        {

            amtpros = amtpros + Convert.ToDecimal(e.Row.Cells[3].Text);
            lblPrsamt.Text = amtpros.ToString();
            countpros++;
            objAccount.flag = "2";
            lblPrsCnt.Text = countpros.ToString();

            lblproscount.Text = countpros.ToString();
            lblprosamount.Text = amtpros.ToString();

        }

    }

    protected void VIEW_CLICK(object sender, EventArgs e)
    {


        if (DateTime.UtcNow > Convert.ToDateTime(txtfromdate.Text))
        {


            Pnlassign.Visible = true;
            Pnlpros.Visible = true;
            pnlquli.Visible = true;

            grdvassigntech.DataSource = objsales.daily_sale_transaction(Convert.ToDateTime(txtfromdate.Text), '3');
            grdvassigntech.DataBind();
            int assigncount = grdvassigntech.Rows.Count;

            if (assigncount == 0)
            {

                lblassign1.Text = "0";
                lblassignamount1.Text = "0";

            }

            gredpros.DataSource = objsales.daily_sale_transaction(Convert.ToDateTime(txtfromdate.Text), '2');
            gredpros.DataBind();
            int proscount = gredpros.Rows.Count;
            if (proscount == 0)
            {
                lblPrsCnt.Text = "0";
                lblPrsamt.Text = "0";

            }
            grdqulify.DataSource = objsales.daily_sale_transaction(Convert.ToDateTime(txtfromdate.Text), '1');
            grdqulify.DataBind();
            int qualcount = grdqulify.Rows.Count;
            if (qualcount == 0)
            {
                lblQualamt.Text = "0";
                lblQualcnt.Text = "0";
            }

            objReader = objsales.daily_sale_transaction(Convert.ToDateTime(txtfromdate.Text), '4');
            if (objReader.Read())
            {

                lbltlead.Text = objReader["totallead"].ToString();

                counttotallead = Convert.ToDouble(objReader["totallead"]);


            }

            
            lblassign.Text = countassign.ToString();
            lblassignamount.Text = amtassign.ToString();

            lblquliamount.Text = amtqual.ToString();
            lblqulicount.Text = countqual.ToString();

            lblproscount.Text = countpros.ToString();
            lblprosamount.Text = amtpros.ToString();

            lblassign1.Text = countassign.ToString();
            lblassignamount1.Text = amtassign.ToString();

            lblQualamt.Text = amtqual.ToString();
            lblQualcnt.Text = countqual.ToString();

            lblPrsamt.Text = amtpros.ToString();
            lblPrsCnt.Text = countpros.ToString();

            lblassignconversion.Text = Math.Round((((countassign / counttotallead) * 100)), 2).ToString() + '%';
            lblprosconversion.Text = Math.Round((((countpros / counttotallead) * 100)), 2).ToString() + '%';
            lblquliconversion.Text = Math.Round((((countqual / counttotallead) * 100)), 2).ToString() + '%';
        }

        else
        {
            Pnlassign.Visible = false;
            Pnlpros.Visible = false;
            pnlquli.Visible = false;
            lbltlead.Text = "0";
            lblproscount.Text = "0";
            lblqulicount.Text = "0";
            lblassign.Text = "0";
            lblassignamount.Text = "0";
            lblquliamount.Text = "0";
            lblprosamount.Text = "0";
            lblassignamount.Text = "0";
            lblassignamount1.Text = "0";
            lblPrsamt.Text = "0";
            lblPrsCnt.Text = "0";
            lblQualamt.Text = "0";
            lblQualcnt.Text = "0";
            lblprosconversion.Text = "0" + '%';
            lblquliconversion.Text = "0" + '%';
            lblassignconversion.Text = "0" + '%';
            lblassign1.Text = "0";
           

        }
    }
    protected void lblLeadNo_Click(object sender, EventArgs e)
    {

        GridViewRow row = (GridViewRow)((LinkButton)sender).NamingContainer;
        //string lead_no = row.Cells[0].Text;
        //string customername = row.Cells[1].Text;
        //string mobile = row.Cells[2].Text;
        //string amount = row.Cells[3].Text;
        //string created_by = row.Cells[4].Text;
        //string Status_id = row.Cells[5].Text;
        LinkButton lblLeadNo = (LinkButton)row.FindControl("lblLeadNo");
        Label lblStatus_id = (Label)row.FindControl("lblStatus_id");
        Response.Redirect("CreateLead.aspx?LeadId=" + lblLeadNo.Text + "&lead_status=" + lblStatus_id.Text);
    }
    protected void lblLeadNo_Click1(object sender, EventArgs e)
    {
        GridViewRow row = (GridViewRow)((LinkButton)sender).NamingContainer;
        //string lead_no = row.Cells[0].Text;
        //string customername = row.Cells[1].Text;
        //string mobile = row.Cells[2].Text;
        //string amount = row.Cells[3].Text;
        //string created_by = row.Cells[4].Text;
        //string Status_id = row.Cells[5].Text;

        LinkButton lblLeadNo = (LinkButton)row.FindControl("lblLeadNo");
        Label lblStatus_id = (Label)row.FindControl("lblStatus_id");
        Response.Redirect("CreateLead.aspx?LeadId=" + lblLeadNo.Text + "&lead_status=" + lblStatus_id.Text);
    }
    protected void grdvassigntech_RowDataBound1(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {

            amtassign = amtassign + Convert.ToDecimal(e.Row.Cells[3].Text);
            lblassignamount1.Text = amtassign.ToString();
            countassign++;
            objAccount.flag = "3";
            lblassign1.Text = countassign.ToString();
            lblassign.Text = countassign.ToString();
            lblassignamount.Text = amtassign.ToString();
        }
    }
}