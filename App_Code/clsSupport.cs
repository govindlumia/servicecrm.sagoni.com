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
using System.Configuration;
using System.Data;

/// <summary>
/// Summary description for clsSupport
/// </summary>
public class clsSupport
{
    string con_str = ConfigurationManager.ConnectionStrings["SlickTicket"].ConnectionString;
    SqlCommand objCommand;
    SqlConnection objConnection;
    SqlDataAdapter objDataAdapter;
    SqlDataReader dataReader;
    DataSet objDataSet;
	public clsSupport()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _requestId;
    public string RequestId
    {
        get
        {
            return _requestId;
        }
        set
        {
            _requestId = value;
        }
    }
    private string _ticket_type;
    public string ticket_type
    {
        get
        {
            return _ticket_type;
        }
        set
        {
            _ticket_type = value;
        }
    }
    private string _support_type;
    public string support_type
    {
        get
        {
            return _support_type;
        }
        set
        {
            _support_type = value;
        }
    }
    private string _parts;
    public string parts
    {
        get
        {
            return _parts;
        }
        set
        {
            _parts = value;
        }
    }
    private string _modify_by;
    public string modify_by
    {
        get
        {
            return _modify_by;
        }
        set
        {
            _modify_by = value;
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
    private string _status;
    public string status
    {
        get
        {
            return _status;
        }
        set
        {
            _status = value;
        }
    }
    private string _assignTo;
    public string assignTo
    {
        get
        {
            return _assignTo;
        }
        set
        {
            _assignTo = value;
        }
    }
    private DateTime _expecteddate;
    public DateTime expecteddate
    {
        get
        {
            return _expecteddate;
        }
        set
        {
            _expecteddate = value;
        }
    }
    private DateTime _from_date;
    public DateTime from_date
    {
        get
        {
            return _from_date;
        }
        set
        {
            _from_date = value;
        }
    }
    private DateTime _to_date;
    public DateTime to_date
    {
        get
        {
            return _to_date;
        }
        set
        {
            _to_date = value;
        }
    }
    private string _expectedtime;
    public string expectedtime
    {
        get
        {
            return _expectedtime;
        }
        set
        {
            _expectedtime = value;
        }
    }
    private string _office_id;
    public string office_id
    {
        get
        {
            return _office_id;
        }
        set
        {
            _office_id = value;
        }
    }
    private string _Flag;
    public string Flag
    {
        get
        {
            return _Flag;
        }
        set
        {
            _Flag = value;
        }
    }
    private string _lead_no;
    public string lead_no
    {
        get
        {
            return _lead_no;
        }
        set
        {
            _lead_no = value;
        }
    }
    private string _search;
    public string search
    {
        get
        {
            return _search;
        }
        set
        {
            _search = value;
        }
    }
    private string _assignto;
    public string assignto
    {
        get
        {
            return _assignto;
        }
        set
        {
            _assignto = value;
        }
    }
    private string _servicetype;
    public string servicetype
    {
        get
        {
            return _servicetype;
        }
        set
        {
            _servicetype = value;
        }
    }
    private string _total_delivery;
    public string total_delivery
    {
        get
        {
            return _total_delivery;
        }
        set
        {
            _total_delivery = value;
        }
    }
    private string _l_name;
    public string l_name 
    {
        get
        {
            return _l_name;
        }
        set
        {
            _l_name = value;
        }
    }
    private string _l_id;
    public string l_id
    {
        get
        {
            return _l_id;
        }
        set
        {
            _l_id = value;
        }
    }
    private string _Pickup_Engineer;
    public string Pickup_Engineer
    {
        get
        {
            return _Pickup_Engineer;
        }
        set
        {
            _Pickup_Engineer = value;
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
     private DateTime _created_on;
     public DateTime created_on
     {
         get
         {
             return _created_on;
         }
         set
         {
             _created_on = value;
         }
     }
    public string crm_servicerequest_insert(clsSupport objRequest)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "crm_servicerequest_insert";
            objCommand.Parameters.AddWithValue("@requestId", objRequest.RequestId);
            objCommand.Parameters.AddWithValue("@Leadno", objRequest.lead_no);
            objCommand.Parameters.AddWithValue("@ticket_type", objRequest.ticket_type);
            objCommand.Parameters.AddWithValue("@support_type", objRequest.support_type);
            objCommand.Parameters.AddWithValue("@parts", objRequest.parts);
            objCommand.Parameters.AddWithValue("@created_by", objRequest.created_by);
            objCommand.Parameters.AddWithValue("@description", objRequest.description);
            objCommand.Parameters.AddWithValue("@status", objRequest.status);
            objCommand.Parameters.AddWithValue("@assignTo", objRequest.assignTo);
            objCommand.Parameters.AddWithValue("@expecteddate", objRequest.expecteddate);
            objCommand.Parameters.AddWithValue("@expectedtime", objRequest.expectedtime);            
            objCommand.Parameters.AddWithValue("@office_id", objRequest.office_id);
            objCommand.Parameters.AddWithValue("@servicetype", objRequest.servicetype);
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
    public string crm_servicerequest_update(clsSupport objRequest)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "crm_servicerequest_update";
            objCommand.Parameters.AddWithValue("@requestId", objRequest.RequestId);            
            objCommand.Parameters.AddWithValue("@ticket_type", objRequest.ticket_type);
            objCommand.Parameters.AddWithValue("@support_type", objRequest.support_type);
            objCommand.Parameters.AddWithValue("@parts", objRequest.parts);
            objCommand.Parameters.AddWithValue("@modify_by", objRequest.modify_by);
            objCommand.Parameters.AddWithValue("@description", objRequest.description);
            objCommand.Parameters.AddWithValue("@status", objRequest.status);
            objCommand.Parameters.AddWithValue("@assignTo", objRequest.assignTo);
            objCommand.Parameters.AddWithValue("@expecteddate", objRequest.expecteddate);
            objCommand.Parameters.AddWithValue("@expectedtime", objRequest.expectedtime);
            objCommand.Parameters.AddWithValue("@office_id", objRequest.office_id);
            objCommand.Parameters.AddWithValue("@servicetype", servicetype);
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

    public SqlDataReader crmrequestselect_forupdate(string RequestId, string office_id, int Flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crmrequestselect_forupdate";
        objCommand.Parameters.AddWithValue("@requestId", RequestId);
        objCommand.Parameters.AddWithValue("@office_id ", office_id);
        objCommand.Parameters.AddWithValue("@Flag ", Flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader crmticketstatus_Select()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crmticketstatus_Select";        
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public SqlDataReader dropdown_CRMtickettype_select()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "dropdown_CRMtickettype_select";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public SqlDataReader dropdown_crmlocation_select()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "dropdown_crmlocation_select";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public DataTable CRMRequestSelect(clsSupport objRequest)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {


            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "CRMRequestSelect";
            objCommand.Parameters.AddWithValue("@search", objRequest.search);
            objCommand.Parameters.AddWithValue("@status", objRequest.status);
            objCommand.Parameters.AddWithValue("@assignto", objRequest.assignto);
            objCommand.Parameters.AddWithValue("@office_id", objRequest.office_id);
            objCommand.Parameters.AddWithValue("@from_date", objRequest.from_date);
            objCommand.Parameters.AddWithValue("@to_date", objRequest.to_date);
            objCommand.Parameters.AddWithValue("@parts", objRequest.parts);
           // objCommand.Parameters.AddWithValue("@ticket_type", objRequest.ticket_type);
            objCommand.Parameters.AddWithValue("@Flag", objRequest.Flag);
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

    public DataTable CRM_Service_Return_Select(clsSupport objRequest)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "CRM_Service_Return_Select";
            //objCommand.Parameters.AddWithValue("@search", objRequest.search);
            objCommand.Parameters.AddWithValue("@from_date", objRequest.from_date);
            objCommand.Parameters.AddWithValue("@Flag", objRequest.Flag);
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

    public DataTable crm_assign_location_select(clsSupport objRequest)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "crm_assign_location_select";
            objCommand.Parameters.AddWithValue("@created_on", objRequest.created_on);
            //objCommand.Parameters.AddWithValue("@Flag", objRequest.Flag);
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
    public string crm_assign_location_insert(clsSupport objRequest)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "crm_assign_location_insert";
           // objCommand.Parameters.AddWithValue("@s_no", objRequest.s_no);
            objCommand.Parameters.AddWithValue("@Pickup_Engineer", objRequest.Pickup_Engineer);
            objCommand.Parameters.AddWithValue("@l_id", objRequest.l_id);
            objCommand.Parameters.AddWithValue("@total_delivery", objRequest.total_delivery);
            objCommand.Parameters.AddWithValue("@remarks", objRequest.remarks);
            objCommand.Parameters.AddWithValue("@created_by", objRequest.created_by);
            //objCommand.Parameters.AddWithValue("@created_on", objRequest.created_on);
           
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
    public DataTable CRMRequestSelect_report(clsSupport objRequest)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "CRMRequestSelect_report";
            objCommand.Parameters.AddWithValue("@search", objRequest.search);
            objCommand.Parameters.AddWithValue("@status", objRequest.status);
            objCommand.Parameters.AddWithValue("@assignto", objRequest.assignto);
            objCommand.Parameters.AddWithValue("@office_id", objRequest.office_id);
            objCommand.Parameters.AddWithValue("@from_date", objRequest.from_date);
            objCommand.Parameters.AddWithValue("@to_date", objRequest.to_date);
            objCommand.Parameters.AddWithValue("@parts", objRequest.parts);
            objCommand.Parameters.AddWithValue("@ticket_type", objRequest.ticket_type);
            objCommand.Parameters.AddWithValue("@Flag", objRequest.Flag);
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
}
