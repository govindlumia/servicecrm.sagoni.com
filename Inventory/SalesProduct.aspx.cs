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
using System.Collections.Specialized;
using System.Text;
using System.Data.SqlClient;


public partial class Sales_SalesProduct : System.Web.UI.Page
{
    ProductMgmt pm = new ProductMgmt();
    string value;
    SqlDataReader objReader, objReader1, objReader2;
    protected void Page_Load(object sender, EventArgs e)
    {
        lbldate.Text = DateTime.UtcNow.ToShortDateString();
         if (Session["user_id"] == null || Session["user_name"] == null)
        {
            Response.Redirect("~/AdminLogin.aspx");
        }
         if (!IsPostBack)
         {
             FirstGridViewRow();
             Txt_Extracharge.Text = "0.0";
             Txt_TotalAmount.Text = "0.0";
             Txt_CST.Text = "0.0";
             Txt_AmountPaid.Text = "0.0";
             Txt_RestAmount.Text = "0.0";
             Txt_TAX.Text = "0.0";
             Txt_VAT.Text = "0.0";
         }
    }
    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        AddNewRow();
    }
    private void FirstGridViewRow()
    {
        DataTable dt = new DataTable();
        DataRow dr = null;
        dt.Columns.Add(new DataColumn("RowNumber", typeof(string)));
        dt.Columns.Add(new DataColumn("Col1", typeof(string)));
        dt.Columns.Add(new DataColumn("Col2", typeof(string)));
        dt.Columns.Add(new DataColumn("Col3", typeof(string)));
        dt.Columns.Add(new DataColumn("Col4", typeof(string)));
        dt.Columns.Add(new DataColumn("Col5", typeof(string)));
        dt.Columns.Add(new DataColumn("Col6", typeof(string)));
        //dt.Columns.Add(new DataColumn("Col7", typeof(string)));
        dr = dt.NewRow();
        dr["RowNumber"] = 1;
        dr["Col1"] = string.Empty;
        dr["Col2"] = string.Empty;
        dr["Col3"] = string.Empty;
        dr["Col4"] = string.Empty;
        dr["Col5"] = string.Empty;
        dr["Col6"] = string.Empty;
        //dr["Col7"] = string.Empty;
        dt.Rows.Add(dr);

        ViewState["CurrentTable"] = dt;


        Gridview1.DataSource = dt;
        Gridview1.DataBind();


        //TextBox txn = (TextBox)Gridview1.Rows[0].Cells[1].FindControl("Txt_ProductCode");
        //txn.Focus();
        //Button btnAdd = (Button)Gridview1.FooterRow.Cells[5].FindControl("ButtonAdd");
        //Page.Form.DefaultFocus = btnAdd.ClientID;

    }
    private void SetPreviousData()
    {
        int rowIndex = 0;
        if (ViewState["CurrentTable"] != null)
        {
            DataTable dt = (DataTable)ViewState["CurrentTable"];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    TextBox box1 = (TextBox)Gridview1.Rows[rowIndex].Cells[1].FindControl("Txt_ProductCode");
                    TextBox box2 = (TextBox)Gridview1.Rows[rowIndex].Cells[2].FindControl("Txt_ProductName");
                    TextBox box3 = (TextBox)Gridview1.Rows[rowIndex].Cells[3].FindControl("Txt_SellingPrice");
                    TextBox box4 = (TextBox)Gridview1.Rows[rowIndex].Cells[4].FindControl("Txt_Quantity");
                    TextBox box5 = (TextBox)Gridview1.Rows[rowIndex].Cells[5].FindControl("Txt_Discount");
                    // TextBox box6 = (TextBox)Gridview1.Rows[rowIndex].Cells[6].FindControl("Txt_Discount");
                    Label box6 = (Label)Gridview1.Rows[rowIndex].Cells[6].FindControl("LblTotal");
                    // drCurrentRow["RowNumber"] = i + 1;

                    Gridview1.Rows[i].Cells[0].Text = Convert.ToString(i + 1);
                    box1.Text = dt.Rows[i]["Col1"].ToString();
                    box2.Text = dt.Rows[i]["Col2"].ToString();
                    box3.Text = dt.Rows[i]["Col3"].ToString();
                    box4.Text = dt.Rows[i]["Col4"].ToString();
                    box5.Text = dt.Rows[i]["Col5"].ToString();
                    box6.Text = dt.Rows[i]["Col6"].ToString();
                    //box7.Text = dt.Rows[i]["Col7"].ToString();
                    rowIndex++;
                }
            }
        }
    }
    private void AddNewRow()
    {
        int rowIndex = 0;

        if (ViewState["CurrentTable"] != null)
        {
            DataTable dtCurrentTable = (DataTable)ViewState["CurrentTable"];
            DataRow drCurrentRow = null;
            if (dtCurrentTable.Rows.Count > 0)
            {
                for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                {
                    TextBox box1 = (TextBox)Gridview1.Rows[rowIndex].Cells[1].FindControl("Txt_ProductCode");
                    TextBox box2 = (TextBox)Gridview1.Rows[rowIndex].Cells[2].FindControl("Txt_ProductName");
                    TextBox box3 = (TextBox)Gridview1.Rows[rowIndex].Cells[3].FindControl("Txt_SellingPrice");
                    TextBox box4 = (TextBox)Gridview1.Rows[rowIndex].Cells[4].FindControl("Txt_Quantity");
                    TextBox box5 = (TextBox)Gridview1.Rows[rowIndex].Cells[5].FindControl("Txt_Discount");
                    //TextBox box6 = (TextBox)Gridview1.Rows[rowIndex].Cells[6].FindControl("Txt_Discount");
                    Label box6 = (Label)Gridview1.Rows[rowIndex].Cells[6].FindControl("LblTotal");
                    drCurrentRow = dtCurrentTable.NewRow();
                    drCurrentRow["RowNumber"] = i + 1;

                    dtCurrentTable.Rows[i - 1]["Col1"] = box1.Text;
                    dtCurrentTable.Rows[i - 1]["Col2"] = box2.Text;
                    dtCurrentTable.Rows[i - 1]["Col3"] = box3.Text;
                    dtCurrentTable.Rows[i - 1]["Col4"] = box4.Text;
                    dtCurrentTable.Rows[i - 1]["Col5"] = box5.Text;
                    dtCurrentTable.Rows[i - 1]["Col6"] = box6.Text;
                    //dtCurrentTable.Rows[i - 1]["Col7"] = box7.Text;
                    rowIndex++;
                }
                dtCurrentTable.Rows.Add(drCurrentRow);
                ViewState["CurrentTable"] = dtCurrentTable;

                Gridview1.DataSource = dtCurrentTable;
                Gridview1.DataBind();

                //TextBox txn = (TextBox)Gridview1.Rows[rowIndex].Cells[1].FindControl("Txt_ProductCode");
                //txn.Focus();
                // txn.Focus;
            }
        }
        else
        {
            Response.Write("ViewState is null");
        }
        SetPreviousData();
    }

    private string GetConnectionString()
    {
        //"DBConnection" is the name of the Connection String
        //that was set up from the web.config file
        return System.Configuration.ConfigurationManager.ConnectionStrings["SlickTicket"].ConnectionString;
    }


    private void SetRowData()
    {
        int rowIndex = 0;

        if (ViewState["CurrentTable"] != null)
        {
            DataTable dtCurrentTable = (DataTable)ViewState["CurrentTable"];
            DataRow drCurrentRow = null;
            if (dtCurrentTable.Rows.Count > 0)
            {
                for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                {
                    TextBox box1 = (TextBox)Gridview1.Rows[rowIndex].Cells[1].FindControl("Txt_ProductCode");
                    TextBox box2 = (TextBox)Gridview1.Rows[rowIndex].Cells[2].FindControl("Txt_ProductName");
                    TextBox box3 = (TextBox)Gridview1.Rows[rowIndex].Cells[3].FindControl("Txt_SellingPrice");
                    TextBox box4 = (TextBox)Gridview1.Rows[rowIndex].Cells[4].FindControl("Txt_Quantity");
                    TextBox box5 = (TextBox)Gridview1.Rows[rowIndex].Cells[5].FindControl("Txt_Discount");
                    //TextBox box6 = (TextBox)Gridview1.Rows[rowIndex].Cells[6].FindControl("Txt_Discount");
                    Label box6 = (Label)Gridview1.Rows[rowIndex].Cells[6].FindControl("LblTotal");
                    drCurrentRow = dtCurrentTable.NewRow();
                    drCurrentRow["RowNumber"] = i + 1;
                    dtCurrentTable.Rows[i - 1]["Col1"] = box1.Text;
                    dtCurrentTable.Rows[i - 1]["Col2"] = box2.Text;
                    dtCurrentTable.Rows[i - 1]["Col3"] = box3.Text;
                    dtCurrentTable.Rows[i - 1]["Col4"] = box4.Text;
                    dtCurrentTable.Rows[i - 1]["Col5"] = box5.Text;
                    dtCurrentTable.Rows[i - 1]["Col6"] = box6.Text;
                    //dtCurrentTable.Rows[i - 1]["Col7"] = box7.Text;
                    rowIndex++;
                }

                ViewState["CurrentTable"] = dtCurrentTable;
                //grvStudentDetails.DataSource = dtCurrentTable;
                //grvStudentDetails.DataBind();
            }
        }
        else
        {
            Response.Write("ViewState is null");
        }
        //SetPreviousData();
    }
    private void InsertRecords(StringCollection sc)
    {
        SqlConnection conn = new SqlConnection(GetConnectionString());
        StringBuilder sb = new StringBuilder(string.Empty);
        string[] splitItems = null;
        foreach (string item in sc)
        {

            const string sqlStatement = "INSERT INTO Invoice_Product (Product_Code,Product_Name,Selling_Price,Quantity,Discount) VALUES";

            if (item.Contains(","))
            {
                splitItems = item.Split(",".ToCharArray());
                sb.AppendFormat("{0}('{1}','{2}','{3}','{4}',{5}); ", sqlStatement, splitItems[0], splitItems[1], splitItems[2], splitItems[3], splitItems[4]);

            }

        }

        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

            //  Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Script", "alert('Records Successfuly Saved!');", true);

        }
        catch (System.Data.SqlClient.SqlException ex)
        {
            string msg = "Insert Error:";
            msg += ex.Message;
            throw new Exception(msg);
        }


        finally
        {
            conn.Close();
        }
    }
    private void Temp_Record(StringCollection sc)
    {
        SqlConnection conn = new SqlConnection(GetConnectionString());
        StringBuilder sb = new StringBuilder(string.Empty);
        string[] splitItems = null;
        foreach (string item in sc)
        {

            const string sqlStatement = "INSERT INTO Temp_Product (Product_Code,Product_Name,Selling_Price,Quantity,Discount) VALUES";

            if (item.Contains(","))
            {
                splitItems = item.Split(",".ToCharArray());
                sb.AppendFormat("{0}('{1}','{2}','{3}','{4}',{5}); ", sqlStatement, splitItems[0], splitItems[1], splitItems[2], splitItems[3], splitItems[4]);

            }

        }

        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

            //  Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Script", "alert('Records Successfuly Saved!');", true);

        }
        catch (System.Data.SqlClient.SqlException ex)
        {
            string msg = "Insert Error:";
            msg += ex.Message;
            throw new Exception(msg);
        }


        finally
        {
            conn.Close();
        }
    }
    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        int rowIndex = 0;
        StringCollection sc = new StringCollection();
        if (ViewState["CurrentTable"] != null)
        {
            DataTable dtCurrentTable = (DataTable)ViewState["CurrentTable"];
            DataRow drCurrentRow = null;
            if (dtCurrentTable.Rows.Count > 0)
            {
                for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                {
                    //extract the TextBox values
                    TextBox box1 = (TextBox)Gridview1.Rows[rowIndex].Cells[1].FindControl("Txt_ProductCode");
                    TextBox box2 = (TextBox)Gridview1.Rows[rowIndex].Cells[2].FindControl("Txt_ProductName");
                    TextBox box3 = (TextBox)Gridview1.Rows[rowIndex].Cells[3].FindControl("Txt_SellingPrice");
                    TextBox box4 = (TextBox)Gridview1.Rows[rowIndex].Cells[4].FindControl("Txt_Quantity");
                    TextBox box5 = (TextBox)Gridview1.Rows[rowIndex].Cells[5].FindControl("Txt_Discount");
                    //TextBox box6 = (TextBox)Gridview1.Rows[rowIndex].Cells[6].FindControl("Txt_Discount");
                    //get the values here

                    //Response.Write(box1.Text + "<BR/>");
                    //Response.Write(box2.Text + "<BR/>");
                    //Response.Write(box3.Text);

                    sc.Add(box1.Text + "," + box2.Text + "," + box3.Text + "," + box4.Text + "," + box5.Text);
                    rowIndex++;

                }
                InsertRecords(sc);
                Temp_Record(sc);
            }
        }
        pm.Invoice_Date =Convert.ToDateTime( lbldate.Text);
        pm.first_name = Txt_FirstName.Text;
        pm.last_name = Txt_LastName.Text;
        pm.address = Txt_Address.Text;
        pm.mobile = Txt_Mob.Text;
        pm.telephone = Txt_Telephone.Text;
        pm.email = Txt_Email.Text;
        pm.extra_charge = DD_ExtraCharge.SelectedItem.Text;
        pm.extra_amount = Txt_Extracharge.Text;
        pm.total_amount = Txt_TotalAmount.Text;
        pm.amount_paid = Txt_AmountPaid.Text;
        pm.Description = txtDescription.Text;
        pm.rest_amount = Txt_RestAmount.Text;
        pm.remarks = Txt_Remarks.Text;
        pm.cst = Txt_CST.Text;
        pm.vat = Txt_VAT.Text;
        pm.tax = Txt_TAX.Text;
        pm.created_by = Session["user_id"].ToString();
        pm.flag = "I";
        pm.s_no = "0";
        value = pm.Sale_Invoice_insert(pm);
        pm.Product_Stock();
        SqlConnection conn = new SqlConnection(GetConnectionString());
        conn.Open();
        string q = "DELETE FROM Temp_Product";
        SqlCommand cmd = new SqlCommand(q, conn);
        cmd.ExecuteNonQuery();
        conn.Close();
        Response.Redirect("~/Inventory/View_Sales_Product.aspx");
    }
    protected void grvStudentDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        SetRowData();
        if (ViewState["CurrentTable"] != null)
        {
            DataTable dt = (DataTable)ViewState["CurrentTable"];
            DataRow drCurrentRow = null;
            int rowIndex = Convert.ToInt32(e.RowIndex);
            if (dt.Rows.Count > 1)
            {
                dt.Rows.Remove(dt.Rows[rowIndex]);
                drCurrentRow = dt.NewRow();
                ViewState["CurrentTable"] = dt;
                Gridview1.DataSource = dt;
                Gridview1.DataBind();

                for (int i = 0; i < Gridview1.Rows.Count - 1; i++)
                {
                    Gridview1.Rows[i].Cells[0].Text = Convert.ToString(i + 1);
                }
                SetPreviousData();
            }
        }
    }
    public void Total()
    {
        decimal a, b, c;
        int rowIndex = 0;

        if (ViewState["CurrentTable"] != null)
        {
            DataTable dtCurrentTable = (DataTable)ViewState["CurrentTable"];
            DataRow drCurrentRow = null;
            if (dtCurrentTable.Rows.Count > 0)
            {
                for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                {
                    TextBox box1 = (TextBox)Gridview1.Rows[rowIndex].Cells[1].FindControl("Txt_ProductCode");
                    TextBox box2 = (TextBox)Gridview1.Rows[rowIndex].Cells[2].FindControl("Txt_ProductName");
                    TextBox box3 = (TextBox)Gridview1.Rows[rowIndex].Cells[3].FindControl("Txt_SellingPrice");
                    TextBox box4 = (TextBox)Gridview1.Rows[rowIndex].Cells[4].FindControl("Txt_Quantity");
                    TextBox box5 = (TextBox)Gridview1.Rows[rowIndex].Cells[5].FindControl("Txt_Discount");
                    //TextBox box6 = (TextBox)Gridview1.Rows[rowIndex].Cells[6].FindControl("Txt_Discount");
                    Label box6 = (Label)Gridview1.Rows[rowIndex].Cells[6].FindControl("LblTotal");

                    drCurrentRow = dtCurrentTable.NewRow();
                    drCurrentRow["RowNumber"] = i + 1;

                    dtCurrentTable.Rows[i - 1]["Col1"] = box1.Text;
                    dtCurrentTable.Rows[i - 1]["Col2"] = box2.Text;
                    dtCurrentTable.Rows[i - 1]["Col3"] = box3.Text;
                    dtCurrentTable.Rows[i - 1]["Col4"] = box4.Text;
                    dtCurrentTable.Rows[i - 1]["Col5"] = box5.Text;
                    dtCurrentTable.Rows[i - 1]["Col6"] = box6.Text;
                    //dtCurrentTable.Rows[i - 1]["Col7"] = box7.Text;
                    rowIndex++;
                    //a = Convert.ToDecimal(.Text);
                    //b = Convert.ToDecimal(.Text);
                    decimal j = Math.Round((Decimal.Parse(box3.Text) * Decimal.Parse(box4.Text) * Decimal.Parse(box5.Text) / 100), 2);
                    box6.Text = Math.Round((Decimal.Parse(box3.Text) * Decimal.Parse(box4.Text)) - j, 2).ToString();


                }
            }
        }

    }
    protected void Submit_Btn1_Click(object sender, EventArgs e)
    {
        Total();
    }
    protected void Gridview1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void reset_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/Inventory/SalesProduct.aspx");
    }
}