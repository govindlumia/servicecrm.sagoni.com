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

/// <summary>
/// Summary description for ProductMgmt
/// </summary>
public class ProductMgmt
{
    string con_str = ConfigurationManager.ConnectionStrings["SlickTicket"].ConnectionString;
    SqlCommand objCommand;
    SqlConnection objConnection;
    SqlDataAdapter objDataAdapter;
    SqlDataReader dataReader;
    DataSet objDataSet;
    DataTable dt;
    DataTable objDataTable;
	public ProductMgmt()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _s_no;
    public string s_no
    {
        get
        {
            return _s_no;
        }
        set
        {
            _s_no = value;
        }
    }
    private string _Invoice_No;
    public string Invoice_No
    {
        get
        {
            return _Invoice_No;
        }
        set
        {
            _Invoice_No = value;
        }
    }
    private DateTime _Invoice_Date;
    public DateTime Invoice_Date
    {
        get
        {
            return _Invoice_Date;
        }
        set
        {
            _Invoice_Date = value;
        }
    }
    private string _first_name;
    public string first_name
    {
        get
        {
            return _first_name;
        }
        set
        {
            _first_name = value;
        }
    }
    private string _last_name;
    public string last_name
    {
        get
        {
            return _last_name;
        }
        set
        {
            _last_name = value;
        }
    }
    private string _mobile;
    public string mobile
    {
        get
        {
            return _mobile;
        }
        set
        {
            _mobile = value;
        }
    }
    private string _telephone;
    public string telephone
    {
        get
        {
            return _telephone;
        }
        set
        {
            _telephone = value;
        }
    }
    private string _email;
    public string email
    {
        get
        {
            return _email;
        }
        set
        {
            _email = value;
        }
    }
    private string _extra_charge;
    public string extra_charge
    {
        get
        {
            return _extra_charge;
        }
        set
        {
            _extra_charge = value;
        }
    }
    private string _extra_amount;
    public string extra_amount
    {
        get
        {
            return _extra_amount;
        }
        set
        {
            _extra_amount = value;
        }
    }
    private string _total_amount;
    public string total_amount
    {
        get
        {
            return _total_amount;
        }
        set
        {
            _total_amount = value;
        }
    }
    private string _amount_paid;
    public string amount_paid
    {
        get
        {
            return _amount_paid;
        }
        set
        {
            _amount_paid = value;
        }
    }
    private string _Description;
    public string Description
    {
        get
        {
            return _Description;
        }
        set
        {
            _Description = value;
        }
    }
    private string _rest_amount;
    public string rest_amount
    {
        get
        {
            return _rest_amount;
        }
        set
        {
            _rest_amount = value;
        }
    }
    private string _cst;
    public string cst
    {
        get
        {
            return _cst;
        }
        set
        {
            _cst = value;
        }
    }
    private string _vat;
    public string vat
    {
        get
        {
            return _vat;
        }
        set
        {
            _vat = value;
        }
    }
    private string _tax;
    public string tax
    {
        get
        {
            return _tax;
        }
        set
        {
            _tax = value;
        }
    }

    //==============================================================
    private string _search_value;
         public string search_value
    {
        get
        {
            return _search_value;
        }
        set
        {
            _search_value = value;
        }
    }
         private string _remarks;
    public string remarks
    {
        get
        {
            return _remarks;
        }
        set
        {
            _remarks = value;
        }
    }
     private string _created_by;
    public string created_by
    {
        get
        {
            return _created_by;
        }
        set
        {
            _created_by = value;
        }
    }
    private string _sno;
    public string sno
    {
        get
        {
            return _sno;
        }
        set
        {
            _sno = value;
        }
    }
     private string _product_code;
    public string product_code
    {
        get
        {
            return _product_code;
        }
        set
        {
            _product_code = value;
        }
    }
     private string _quantity;
    public string quantity
    {
        get
        {
            return _quantity;
        }
        set
        {
            _quantity = value;
        }
    }
     private string _brand_name;
    public string brand_name
    {
        get
        {
            return _brand_name;
        }
        set
        {
            _brand_name = value;
        }
    }
     private string _model;
    public string model
    {
        get
        {
            return _model;
        }
        set
        {
            _model = value;
        }
    }
     private string _product_type;
    public string product_type
    {
        get
        {
            return _product_type;
        }
        set
        {
            _product_type = value;
        }
    }
     private string _product_name;
    public string product_name
    {
        get
        {
            return _product_name;
        }
        set
        {
            _product_name = value;
        }
    }
     private string _description;
    public string description
    {
        get
        {
            return _description;
        }
        set
        {
            _description = value;
        }
    }
     private string _selling_price;
    public string selling_price
    {
        get
        {
            return _selling_price;
        }
        set
        {
            _selling_price = value;
        }
    }
     private string _purchase_price;
    public string purchase_price
    {
        get
        {
            return _purchase_price;
        }
        set
        {
            _purchase_price = value;
        }
    }
    private string _flag;
    public string flag
    {
        get
        {
            return _flag;
        }
        set
        {
            _flag = value;
        }
    }
    private string _address;
    public string address
    {
        get
        {
            return _address;
        }
        set
        {
            _address = value;
        }
    }
    private string _party_name;
    public string party_name
    {
        get
        {
            return _party_name;
        }
        set
        {
            _party_name = value;
        }
    }
 
    public DataTable Inventory_Product_Select(ProductMgmt pm)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Inventory_Product_Select";
            objCommand.Parameters.AddWithValue("@search_value", search_value);
            //objCommand.Parameters.AddWithValue("@from_date", from_date);
            //objCommand.Parameters.AddWithValue("@to_date", to_date);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }
    public DataTable Purchase_Product_Select(ProductMgmt pm)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Purchase_Product_Select";
            objCommand.Parameters.AddWithValue("@search_value", search_value);
            //objCommand.Parameters.AddWithValue("@from_date", from_date);
            //objCommand.Parameters.AddWithValue("@to_date", to_date);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }
    public string Inventory_Product_Insert(ProductMgmt pm)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "Inventory_Product_Insert";
            objCommand.Parameters.AddWithValue("@sno", sno);
            objCommand.Parameters.AddWithValue("@product_code", product_code);
            objCommand.Parameters.AddWithValue("@quantity", quantity);
            objCommand.Parameters.AddWithValue("@brand_name", brand_name);
            objCommand.Parameters.AddWithValue("@model", model);
            objCommand.Parameters.AddWithValue("@product_type", product_type);
            objCommand.Parameters.AddWithValue("@product_name", product_name);
            objCommand.Parameters.AddWithValue("@description", description);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
            objCommand.Parameters.AddWithValue("@remarks", remarks);
             objCommand.Parameters.AddWithValue("@selling_price", selling_price);
            objCommand.Parameters.AddWithValue("@purchase_price", purchase_price);
            objCommand.Parameters.AddWithValue("@flag", flag);

            dataReader = objCommand.ExecuteReader();
            string j = "0";
            if (dataReader.Read())
            {
                j = dataReader[0].ToString();
            }
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            dataReader.Close();
            return j;

        }
    }

    public string Purchase_Product_Insert(ProductMgmt pm)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "Purchase_Product_Insert";
            objCommand.Parameters.AddWithValue("@sno", sno);
            objCommand.Parameters.AddWithValue("@party_name", party_name);
            objCommand.Parameters.AddWithValue("@address", address);
            objCommand.Parameters.AddWithValue("@product_code", product_code);
            objCommand.Parameters.AddWithValue("@quantity", quantity);
            objCommand.Parameters.AddWithValue("@brand_name", brand_name);
            objCommand.Parameters.AddWithValue("@model", model);
            objCommand.Parameters.AddWithValue("@product_type", product_type);
            objCommand.Parameters.AddWithValue("@product_name", product_name);
            objCommand.Parameters.AddWithValue("@description", description);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
            objCommand.Parameters.AddWithValue("@remarks", remarks);
            objCommand.Parameters.AddWithValue("@selling_price", selling_price);
            objCommand.Parameters.AddWithValue("@purchase_price", purchase_price);
            objCommand.Parameters.AddWithValue("@flag", flag);

            dataReader = objCommand.ExecuteReader();
            string j = "0";
            if (dataReader.Read())
            {
                j = dataReader[0].ToString();
            }
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            dataReader.Close();
            return j;

        }
    }
    public SqlDataReader CheckExistingInventory(string product_code)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CheckExistingInventory";
        objCommand.Parameters.AddWithValue("@product_code", product_code);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public SqlDataReader CheckExistingProduct(string product_code)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CheckExistingProduct";
        objCommand.Parameters.AddWithValue("@product_code", product_code);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public SqlDataReader Inventory_Product_Update(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Inventory_Product_Update";
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader Purchase_Product_Update(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Purchase_Product_Update";
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public string Sale_Invoice_insert(ProductMgmt pm)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "Sale_Invoice_insert ";
            objCommand.Parameters.AddWithValue("@cst", cst);
            objCommand.Parameters.AddWithValue("@vat", vat);
            objCommand.Parameters.AddWithValue("@s_no", s_no);
            objCommand.Parameters.AddWithValue("@last_name", last_name);
            objCommand.Parameters.AddWithValue("@Invoice_Date", Invoice_Date);
            objCommand.Parameters.AddWithValue("@first_name", first_name);
            objCommand.Parameters.AddWithValue("@address", address);
            objCommand.Parameters.AddWithValue("@extra_charge", extra_charge);
            objCommand.Parameters.AddWithValue("@email", email);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
            //bank_name,branch,rtgs_code,account_no,,,
            //bank_name,branch_name,rtgs_code,account_no
            objCommand.Parameters.AddWithValue("@tax", tax);
            objCommand.Parameters.AddWithValue("@mobile", mobile);
            objCommand.Parameters.AddWithValue("@telephone", telephone);
            objCommand.Parameters.AddWithValue("@extra_amount", extra_amount);
            objCommand.Parameters.AddWithValue("@total_amount", total_amount);
            objCommand.Parameters.AddWithValue("@amount_paid", amount_paid);
            objCommand.Parameters.AddWithValue("@Description", Description);
            objCommand.Parameters.AddWithValue("@rest_amount", rest_amount);
            objCommand.Parameters.AddWithValue("@remarks", remarks);
            objCommand.Parameters.AddWithValue("@flag", flag);

            dataReader = objCommand.ExecuteReader();
            string j = "0";
            if (dataReader.Read())
            {
                j = dataReader[0].ToString();
            }
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            dataReader.Close();
            return j;

        }
    }
    public SqlDataReader Invoice_Product_Select(ProductMgmt pm)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Invoice_Product_Select";
        //objCommand.Parameters.AddWithValue("@from_date", from_date);
        //objCommand.Parameters.AddWithValue("@to_date", to_date);
        objCommand.Parameters.AddWithValue("@search_value", search_value);

        //  objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader Invoice_Delete(string s_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Invoice_Delete";
        objCommand.Parameters.AddWithValue("@s_no", s_no);

        //  objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader Invoice_Product_Delete(string s_id)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Invoice_Product_Delete";
        objCommand.Parameters.AddWithValue("@s_id", s_id);

        //  objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public SqlDataReader Invoice_Product_print(string s_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Invoice_Product_print";
        objCommand.Parameters.AddWithValue("@s_no", s_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //  objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader Invoice_select_print(string s_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Invoice_select_print";
        objCommand.Parameters.AddWithValue("@s_no", s_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //  objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader Sale_Invoice_total_price(string s_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Sale_Invoice_total_price";
        objCommand.Parameters.AddWithValue("@s_no", s_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //  objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public SqlDataReader Product_Stock()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Product_Stock";
        //objCommand.Parameters.AddWithValue("@Product_Code", Product_Code);
        //objCommand.Parameters.AddWithValue("@QUANTITY", QUANTITY);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
}