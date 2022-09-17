using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Inventory_Product_Purchase : System.Web.UI.Page
{
    ProductMgmt pm = new ProductMgmt();
    string value;
    SqlDataReader objReader, objReader1, objReader2;
    string password, empcode, ip_address, data;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_id"] == null || Session["user_name"] == null)
        {
            Response.Redirect("~/AdminLogin.aspx");
           
        }
        if (!IsPostBack)
        {
            ViewState["flag"] = "I";

            if (Request.QueryString["serial_no"] != null)
            {

                objReader = pm.Purchase_Product_Update(Request.QueryString["serial_no"].ToString());


                if (objReader.Read())
                {
                    Txt_Partyname.Text = objReader["party_name"].ToString();
                    Txt_Address.Text = objReader["address"].ToString();
                    Txt_Model.Text = objReader["model"].ToString();
                    Txt_BrandName.Text = objReader["brand_name"].ToString();
                    Txt_ProductCode.Text = objReader["product_code"].ToString();
                    Txt_ProductName.Text = objReader["product_name"].ToString();
                    Txt_PurchasePrice.Text = objReader["purchase_price"].ToString();
                    Txt_SellingPrice.Text = objReader["selling_price"].ToString();
                    Txt_qty.Text = objReader["quantity"].ToString();
                    Txt_Description.Text = objReader["description"].ToString();
                    ddlproducttype.SelectedValue = objReader["product_type"].ToString();
                    Txt_Remarks.Text = objReader["Remarks"].ToString();
                }
                ImageButton1.CausesValidation = false;
                ViewState["flag"] = "U";
            }
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        pm.brand_name = Txt_BrandName.Text;
        pm.description = Txt_Description.Text;
        pm.model = Txt_Model.Text;
        pm.product_code = Txt_ProductCode.Text;
        pm.product_name = Txt_ProductName.Text;
        pm.product_type = ddlproducttype.SelectedValue.ToString();
        pm.purchase_price = Txt_PurchasePrice.Text;
        pm.quantity = Txt_qty.Text;
        pm.description = Txt_Description.Text;
        pm.selling_price = Txt_SellingPrice.Text;
        pm.remarks = Txt_Remarks.Text;
        pm.address = Txt_Address.Text;
        pm.party_name = Txt_Partyname.Text;
        pm.created_by = Session["user_id"].ToString();
        if (ViewState["flag"].ToString() == "I")
        {
            objReader = pm.CheckExistingProduct(Txt_ProductCode.Text);
            if (objReader.Read())
            {
                lblmsg.Visible = true;
                lblmsg.Text = "Product Code already registered";
                return;
            }
            objReader.Close();
            pm.flag = "I";
            pm.sno = "0";
            value = pm.Purchase_Product_Insert(pm);
        }
        else if (ViewState["flag"].ToString() == "U")
        {
            pm.created_by = Session["user_id"].ToString();
            pm.flag = "U";

            pm.sno = Request.QueryString["serial_no"].ToString();

            value = pm.Purchase_Product_Insert(pm);
        }
        Response.Redirect("~/Inventory/Product_Purchase_View.aspx");
    }
}