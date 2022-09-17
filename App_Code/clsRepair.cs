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
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// Summary description for clsRepair
/// </summary>
public class clsRepair
{
	public clsRepair()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    string con_str = ConfigurationManager.ConnectionStrings["SlickTicket"].ConnectionString;
    SqlCommand objCommand;
    SqlConnection objConnection;
    SqlDataAdapter objDataAdapter;
    SqlDataReader dataReader;
    DataSet objDataSet;
    DataTable objDataTable;
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
    private string _Pserial_no;
    public string Pserial_no
    {
        get
        {
            return _Pserial_no;
        }
        set
        {
            _Pserial_no = value;
        }
    }

    private string _leadstatus;
    public string leadstatus
    {
        get
        {
            return _leadstatus;
        }
        set
        {
            _leadstatus = value;
        }
    }

    private string _Brand_ID;
    public string Brand_ID
    {
        get
        {
            return _Brand_ID;
        }
        set
        {
            _Brand_ID = value;
        }
    }

    private string _Brand_Name;
    public string Brand_Name
    {
        get
        {
            return _Brand_Name;
        }
        set
        {
            _Brand_Name = value;
        }
    }


    private string _Model_ID;
    public string Model_ID
    {
        get
        {
            return _Model_ID;
        }
        set
        {
            _Model_ID = value;
        }
    }

    private string _Model_Name;
    public string Model_Name
    {
        get
        {
            return _Model_Name;
        }
        set
        {
            _Model_Name = value;
        }
    }


    private string _spare_Part_ID;
    public string spare_Part_ID
    {
        get
        {
            return _spare_Part_ID;
        }
        set
        {
            _spare_Part_ID = value;
        }
    }

    private string _spare_Partname;
    public string spare_Partname
    {
        get
        {
            return _spare_Partname;
        }
        set
        {
            _spare_Partname = value;
        }
    }

    private string _spare_Partcolor;
    public string spare_Partcolor
    {
        get
        {
            return _spare_Partcolor;
        }
        set
        {
            _spare_Partcolor = value;
        }
    }

    private string _Part_Cost;
    public string Part_Cost
    {
        get
        {
            return _Part_Cost;
        }
        set
        {
            _Part_Cost = value;
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
    private string _requestId;
    public string requestId
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
    private string _Gadgettype;
    public string Gadgettype
    {
        get
        {
            return _Gadgettype;
        }
        set
        {
            _Gadgettype = value;
        }
    }
    private string _jobwork_status;
    public string jobwork_status
    {
        get
        {
            return _jobwork_status;
        }
        set
        {
            _jobwork_status = value;
        }
    }
    private string _software_engg;
    public string software_engg
    {
        get
        {
            return _software_engg;
        }
        set
        {
            _software_engg = value;
        }
    }
    private string _Issue;
    public string Issue
    {
        get
        {
            return _Issue;
        }
        set
        {
            _Issue = value;
        }
    }
    private string _solution;
    public string solution
    {
        get
        {
            return _solution;
        }
        set
        {
            _solution = value;
        }
    }
    private string _RepairStatus;
    public string RepairStatus
    {
        get
        {
            return _RepairStatus;
        }
        set
        {
            _RepairStatus = value;
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

    private string _Device_status;
    public string Device_status
    {
        get
        {
            return _Device_status;
        }
        set
        {
            _Device_status = value;
        }
    }
    private string _equipmentreturn_reason;
    public string equipmentreturn_reason
    {
        get
        {
            return _equipmentreturn_reason;
        }
        set
        {
            _equipmentreturn_reason = value;
        }
    }
    private string _repairreason_code;
    public string repairreason_code
    {
        get
        {
            return _repairreason_code;
        }
        set
        {
            _repairreason_code = value;
        }
    }
    private DateTime _Pickuptime;
    public DateTime Pickuptime
    {
        get
        {
            return _Pickuptime;
        }
        set
        {
            _Pickuptime = value;
        }
    }
    private DateTime _inTime;
    public DateTime inTime
    {
        get
        {
            return _inTime;
        }
        set
        {
            _inTime = value;
        }
    }

    private DateTime _expectdate;
    public DateTime expectdate
    {
        get
        {
            return _expectdate;
        }
        set
        {
            _expectdate = value;
        }
    }


    private DateTime _nextUpdate;
    public DateTime nextUpdate
    {
        get
        {
            return _nextUpdate;
        }
        set
        {
            _nextUpdate = value;
        }
    }
    private DateTime _outTime;
    public DateTime outTime
    {
        get
        {
            return _outTime;
        }
        set
        {
            _outTime = value;
        }
    }
    private DateTime _return_date;
    public DateTime return_date
    {
        get
        {
            return _return_date;
        }
        set
        {
            _return_date = value;
        }
    }
    private string _StoreRemarks;
    public string StoreRemarks
    {
        get
        {
            return _StoreRemarks;
        }
        set
        {
            _StoreRemarks = value;
        }
    }

    private string _Brand;
    public string Brand
    {
        get
        {
            return _Brand;
        }
        set
        {
            _Brand = value;
        }
    }
    private string _model;
    public string Model
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
    private string _IMIE_NO;
    public string IMIE_NO
    {
        get
        {
            return _IMIE_NO;
        }
        set
        {
            _IMIE_NO = value;
        }
    }
    private string _Screen;
    public string Screen
    {
        get
        {
            return _Screen;
        }
        set
        {
            _Screen = value;
        }
    }
    private string _Battery_Serial_No;
    public string Battery_Serial_No
    {
        get
        {
            return _Battery_Serial_No;
        }
        set
        {
            _Battery_Serial_No = value;
        }
    }
    private string _Camera;
    public string Camera
    {
        get
        {
            return _Camera;
        }
        set
        {
            _Camera = value;
        }
    }
 
    private string _Keypad;
    public string Keypad
    {
        get
        {
            return _Keypad;
        }
        set
        {
            _Keypad = value;
        }
    }
    private string _Adopter_Charger;
    public string Adopter_Charger
    {
        get
        {
            return _Adopter_Charger;
        }
        set
        {
            _Adopter_Charger = value;
        }
    }
    private string _Front_BackBody;
    public string Front_BackBody
    {
        get
        {
            return _Front_BackBody;
        }
        set
        {
            _Front_BackBody = value;
        }
    }
    private string _Back_cover;
    public string Back_cover
    {
        get
        {
            return _Back_cover;
        }
        set
        {
            _Back_cover = value;
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
    private DateTime _modify_on;
    public DateTime modify_on
    {
        get
        {
            return _modify_on;
        }
        set
        {
            _modify_on = value;
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
    private string _datacard;
    public string datacard
    {
        get
        {
            return _datacard;
        }
        set
        {
            _datacard = value;
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
    private string _Datacable;
    public string Datacable
    {
        get
        {
            return _Datacable;
        }
        set
        {
            _Datacable = value;
        }
    }
    private string _Other;
    public string Other
    {
        get
        {
            return _Other;
        }
        set
        {
            _Other = value;
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
    private string _chipEngineer;
    public string chipEngineer
    {
        get
        {
            return _chipEngineer;
        }
        set
        {
            _chipEngineer = value;
        }
    }
    private string _softwareinstall_eng;
    public string softwareinstall_eng
    {
        get
        {
            return _softwareinstall_eng;
        }
        set
        {
            _softwareinstall_eng = value;
        }
    }
    private string _QualitycheckEngineer;
    public string QualitycheckEngineer
    {
        get
        {
            return _QualitycheckEngineer;
        }
        set
        {
            _QualitycheckEngineer = value;
        }
    }
    private string _DeliveryEngineer;
    public string DeliveryEngineer
    {
        get
        {
            return _DeliveryEngineer;
        }
        set
        {
            _DeliveryEngineer = value;
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
    private string _ApprovalOption;
    public string ApprovalOption
    {
        get
        {
            return _ApprovalOption;
        }
        set
        {
            _ApprovalOption = value;
        }
    }
    private string _costapproval;
    public string costapproval
    {
        get
        {
            return _costapproval;
        }
        set
        {
            _costapproval = value;
        }
    }
    private string _approval_by;
    public string approval_by
    {
        get
        {
            return _approval_by;
        }
        set
        {
            _approval_by = value;
        }
    }
    private DateTime _approval_date;
    public DateTime approval_date
    {
        get
        {
            return _approval_date;
        }
        set
        {
            _approval_date = value;
        }
    }
    private string _serial_no;
    public string serial_no
    {
        get
        {
            return _serial_no;
        }
        set
        {
            _serial_no = value;
        }
    }
    private string _lead_status;
      public string lead_status
    {
        get
        {
            return _lead_status;
        }
        set
        {
            _lead_status = value;
        }
    }
    

    private string _phone_rent_status;
    public string phone_rent_status
    {
        get
        {
            return _phone_rent_status;
        }
        set
        {
            _phone_rent_status = value;
        }
    }
    private string _callbacktime;
    public string callbacktime
    {
        get
        {
            return _callbacktime;
        }
        set
        {
            _callbacktime = value;
        }
    }

    private DateTime _callbackdate;
    public DateTime callbackdate
    {
        get
        {
            return _callbackdate;
        }
        set
        {
            _callbackdate = value;
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
    private string _Remark;
    public string Remark
    {
        get
        {
            return _Remark;
        }
        set
        {
            _Remark = value;
        }
    }

     private string _relatedto_name;
    public string relatedto_name
    {
        get
        {
            return _relatedto_name;
        }
        set
        {
            _relatedto_name = value;
        }
    }
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
    private string _Entry_status;
    public string Entry_status
    {
        get
        {
            return _Entry_status;
        }
        set
        {
            _Entry_status = value;
        }
    }
    private string _pattern_lock;
    public string pattern_lock
    {
        get
        {
            return _pattern_lock;
        }
        set
        {
            _pattern_lock = value;
        }
    }


    
   
    public string crmequipment_Insert(clsRepair objRepair)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "crmequipment_Insert";
            objCommand.Parameters.AddWithValue("@serialno", objRepair.serial_no);
            objCommand.Parameters.AddWithValue("@requestId", objRepair.requestId );
            objCommand.Parameters.AddWithValue("@Gadgettype", objRepair.Gadgettype);
            objCommand.Parameters.AddWithValue("@jobwork_status", objRepair.jobwork_status);
            objCommand.Parameters.AddWithValue("@Issue", objRepair.Issue);
            objCommand.Parameters.AddWithValue("@solution", objRepair.solution);
            objCommand.Parameters.AddWithValue("@RepairStatus", objRepair.RepairStatus);
            objCommand.Parameters.AddWithValue("@Device_status", objRepair.Device_status);
            objCommand.Parameters.AddWithValue("@equipmentreturn_reason", objRepair.equipmentreturn_reason);
            objCommand.Parameters.AddWithValue("@repairreason_code", objRepair.repairreason_code);
            objCommand.Parameters.AddWithValue("@Pickuptime", objRepair.Pickuptime);
            objCommand.Parameters.AddWithValue("@inTime", objRepair.inTime);
            objCommand.Parameters.AddWithValue("@expectdate", objRepair.expectdate);
            objCommand.Parameters.AddWithValue("@nextUpdate", objRepair.nextUpdate);
            objCommand.Parameters.AddWithValue("@outTime", objRepair.outTime);
            objCommand.Parameters.AddWithValue("@return_date", objRepair.return_date);
            objCommand.Parameters.AddWithValue("@StoreRemarks", objRepair.StoreRemarks);
            objCommand.Parameters.AddWithValue("@Brand", objRepair.Brand);           
            objCommand.Parameters.AddWithValue("@Model", objRepair.Model);
            objCommand.Parameters.AddWithValue("@IMIE_NO", objRepair.IMIE_NO);
            objCommand.Parameters.AddWithValue("@Screen", objRepair.Screen);
            objCommand.Parameters.AddWithValue("@Battery_Serial_No", objRepair.Battery_Serial_No);
            objCommand.Parameters.AddWithValue("@Camera", objRepair.Camera);
            objCommand.Parameters.AddWithValue("@Keypad", objRepair.Keypad);
            objCommand.Parameters.AddWithValue("@Adopter_Charger", objRepair.Adopter_Charger);
            objCommand.Parameters.AddWithValue("@Front_BackBody", objRepair.Front_BackBody);
            objCommand.Parameters.AddWithValue("@Back_cover", objRepair.Back_cover);
            objCommand.Parameters.AddWithValue("@datacard", objRepair.datacard);
            objCommand.Parameters.AddWithValue("@Datacable", objRepair.Datacable);
            objCommand.Parameters.AddWithValue("@Other", objRepair.Other);
            objCommand.Parameters.AddWithValue("@Pickup_Engineer", objRepair.Pickup_Engineer);
            objCommand.Parameters.AddWithValue("@chipEngineer", objRepair.chipEngineer);
            objCommand.Parameters.AddWithValue("@softwareinstall_eng", objRepair.softwareinstall_eng);
            objCommand.Parameters.AddWithValue("@QualitycheckEngineer", objRepair.QualitycheckEngineer);
            objCommand.Parameters.AddWithValue("@DeliveryEngineer", objRepair.DeliveryEngineer);          
            objCommand.Parameters.AddWithValue("@created_by", objRepair.created_by);
            objCommand.Parameters.AddWithValue("@office_id", objRepair.office_id);
            objCommand.Parameters.AddWithValue("@ApprovalOption", objRepair.ApprovalOption);
            objCommand.Parameters.AddWithValue("@costapproval", objRepair.costapproval);
            objCommand.Parameters.AddWithValue("@approval_by", objRepair.approval_by);
            objCommand.Parameters.AddWithValue("@approval_date", objRepair.approval_date);
            objCommand.Parameters.AddWithValue("@phone_rent_status", objRepair.phone_rent_status);
            objCommand.Parameters.AddWithValue("@software_engg", objRepair.software_engg);
            objCommand.Parameters.AddWithValue("@Entry_status", objRepair.Entry_status);
            objCommand.Parameters.AddWithValue("@pattern_lock", objRepair.pattern_lock);
            objCommand.Parameters.AddWithValue("@flag", flag);
            dataReader = objCommand.ExecuteReader();
            //int i=objCommand.ExecuteNonQuery();
            string j = "0";
            //if(i>0)
            //{
            //    j = "inserted";
            //}
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
    public SqlDataReader crmcustomer_update_select(string serial_no, int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crmcustomer_update_select";
        objCommand.Parameters.AddWithValue("@serial_no", serial_no);

        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }


    public SqlDataReader m_CRMcustomer_Refund_update_select(string serial_no, int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_CRMcustomer_Refund_update_select";
        objCommand.Parameters.AddWithValue("@serial_no", serial_no);

        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader m_CRMRepaircustomer_update_select(string serial_no, int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_CRMRepaircustomer_update_select";
        objCommand.Parameters.AddWithValue("@serial_no", serial_no);

        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public SqlDataReader m_CRMRepaircustomer_Refund_update_select(string serial_no, int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_CRMRepaircustomer_Refund_update_select";
        objCommand.Parameters.AddWithValue("@serial_no", serial_no);

        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }




    public SqlDataReader crmequipment_update(string serial_no, int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crmequipment_update";
        objCommand.Parameters.AddWithValue("@serial_no", serial_no);
     
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader Print_Client_Service_invoice(string serial_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Print_Client_Service_invoice";
        objCommand.Parameters.AddWithValue("@serial_no", serial_no);

        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }



    public SqlDataReader Print_m_CRMcustomer_Refund_invoice(string serial_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Print_m_CRMcustomer_Refund_invoice";
        objCommand.Parameters.AddWithValue("@serial_no", serial_no);

        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }

    public DataTable CRMJobWorkforreport(clsRepair objRepair)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {


            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "CRMJobWorkforreport";
            objCommand.Parameters.AddWithValue("@Flag", objRepair.Flag);
            //objCommand.Parameters.AddWithValue("@search_value", objSales.search_value);
            // objCommand.Parameters.AddWithValue("@created_by", objSales.created_by);
            objCommand.Parameters.AddWithValue("@RepairStatus", objRepair.RepairStatus);
            objCommand.Parameters.AddWithValue("@from_date", objRepair.from_date);
            objCommand.Parameters.AddWithValue("@to_date", objRepair.to_date);
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

    public SqlDataReader Print_Repair_Refund_invoice(string serial_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Print_Repair_Refund_invoice";
        objCommand.Parameters.AddWithValue("@serial_no", serial_no);

        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }





    public SqlDataReader Print_Repair_invoice(string serial_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Print_Repair_invoice";
        objCommand.Parameters.AddWithValue("@serial_no", serial_no);

        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public SqlDataReader CheckExisting_RequestId_jobworktable(string requestId)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CheckExisting_RequestId_jobworktable";
        objCommand.Parameters.AddWithValue("@requestId", requestId);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public SqlDataReader crmserviceinvoice_update(string requestid, int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crmserviceinvoice_update";
        objCommand.Parameters.AddWithValue("@requestid", requestid);
        
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public SqlDataReader search_report_select(string search_value, string Flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "search_report_select";
        objCommand.Parameters.AddWithValue("@search_value", search_value);
        objCommand.Parameters.AddWithValue("@Flag", Flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public DataTable crmequipment_select(clsRepair objRepair)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "crmequipment_select";
            objCommand.Parameters.AddWithValue("@flag", objRepair.flag);
            objCommand.Parameters.AddWithValue("@requestId", objRepair.requestId);
            objCommand.Parameters.AddWithValue("@jobwork_status", objRepair.jobwork_status);
            objCommand.Parameters.AddWithValue("@chipEngineer", objRepair.chipEngineer);
            objCommand.Parameters.AddWithValue("@RepairStatus", objRepair.RepairStatus); 
            objCommand.Parameters.AddWithValue("@office_id", objRepair.office_id);
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

    public DataTable Expected_delivery_equipment_report(clsRepair objRepair)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Expected_delivery_equipment_report";
            objCommand.Parameters.AddWithValue("@flag", objRepair.flag);
            objCommand.Parameters.AddWithValue("@requestId", objRepair.requestId);
            objCommand.Parameters.AddWithValue("@from_date", objRepair.from_date);
            objCommand.Parameters.AddWithValue("@to_date", objRepair.to_date);
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
public string Update_CRMEquipment_jobwork_status(clsRepair objRepair)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Update_CRMEquipment_jobwork_status";
        objCommand.Parameters.AddWithValue("@requestId", objRepair.requestId);
        objCommand.Parameters.AddWithValue("@DeliveryEngineer", objRepair.DeliveryEngineer);
        objCommand.Parameters.AddWithValue("@chipEngineer", objRepair.chipEngineer);
        objCommand.Parameters.AddWithValue("@description", objRepair.description);
        objCommand.Parameters.AddWithValue("@jobwork_status", objRepair.jobwork_status);
        objCommand.Parameters.AddWithValue("@outimedate", objRepair.outTime);
        objCommand.Parameters.AddWithValue("@created_by", objRepair.created_by);
        
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        string j = "0";
        //if(i>0)
        //{
        //    j = "inserted";
        //}
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


    public DataTable crmequipment_selectforreport(clsRepair objRepair)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "crmequipment_selectforreport";
            objCommand.Parameters.AddWithValue("@flag", objRepair.flag);
            objCommand.Parameters.AddWithValue("@requestId", objRepair.requestId);
            objCommand.Parameters.AddWithValue("@jobwork_status", objRepair.jobwork_status);
            objCommand.Parameters.AddWithValue("@office_id", objRepair.office_id);
            objCommand.Parameters.AddWithValue("@from_date", objRepair.from_date);
            objCommand.Parameters.AddWithValue("@to_date", objRepair.to_date);
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
    public SqlDataReader CRMEquipmentStatus_select()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CRMEquipmentStatus_select";     
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }


    public SqlDataReader crm_phone_rent_select(int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crm_phone_rent_select";
        objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
   
    public SqlDataReader CRMGadgettype_select()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CRMGadgettype_select";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public DataTable crmequipment_select_outward(clsRepair objRepair)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "crmequipment_select_outward ";
            objCommand.Parameters.AddWithValue("@flag", objRepair.flag);
            objCommand.Parameters.AddWithValue("@requestId", objRepair.requestId);
            objCommand.Parameters.AddWithValue("@jobwork_status", objRepair.jobwork_status);
            objCommand.Parameters.AddWithValue("@office_id", objRepair.office_id);
            objCommand.Parameters.AddWithValue("@from_date", objRepair.from_date);
            objCommand.Parameters.AddWithValue("@to_date", objRepair.to_date);
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
    public DataTable crmequipment_select_inward(clsRepair objRepair)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "crmequipment_select_Report ";
            objCommand.Parameters.AddWithValue("@flag", objRepair.flag);
            objCommand.Parameters.AddWithValue("@requestId", objRepair.requestId);
            objCommand.Parameters.AddWithValue("@jobwork_status", objRepair.jobwork_status);
            objCommand.Parameters.AddWithValue("@office_id", objRepair.office_id);
            objCommand.Parameters.AddWithValue("@from_date", objRepair.from_date);
            objCommand.Parameters.AddWithValue("@to_date", objRepair.to_date);
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
  
    public string equipment_calllog_insert(string requestid,string description, string created_by)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "equipment_calllog_insert";
        objCommand.Parameters.AddWithValue("@requestid", requestid);
        objCommand.Parameters.AddWithValue("@description", description);
        objCommand.Parameters.AddWithValue("@jobwork_status", jobwork_status);
        objCommand.Parameters.AddWithValue("@created_by", created_by);
        
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        string j = "0";
        //if(i>0)
        //{
        //    j = "inserted";
        //}
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
    public string lead_calllog_insert(clsRepair objRepair)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "lead_calllog_insert";
        objCommand.Parameters.AddWithValue("@lead_no", lead_no);
        objCommand.Parameters.AddWithValue("@lead_status", lead_status);
        objCommand.Parameters.AddWithValue("@description ", description);
       // objCommand.Parameters.AddWithValue("@relatedto_name ", relatedto_name);
        objCommand.Parameters.AddWithValue("@created_by", created_by);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        string j = "0";
        //if(i>0)
        //{
        //    j = "inserted";
        //}
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

    public SqlDataReader SME_Repair_invoice_Report(string requestid)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "SME_Repair_invoice_Report";
        objCommand.Parameters.AddWithValue("@requestId", requestId);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader CrmDelivery_Print_out_report(string requestid)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CrmDelivery_Print_out_report";
        objCommand.Parameters.AddWithValue("@requestId", requestId);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader equipment_calllog_select(string requestid, int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "equipment_calllog_select";
        objCommand.Parameters.AddWithValue("@requestId", requestid);
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }


    public SqlDataReader repaire_calllog_calllog_select(string lead_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "repaire_calllog_calllog_select";
        objCommand.Parameters.AddWithValue("@lead_no", lead_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader invoice_calllog_calllog_select(string lead_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "invoice_calllog_calllog_select";
        objCommand.Parameters.AddWithValue("@lead_no", lead_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader lead_calllog_select(string lead_no, int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "lead_calllog_select";
        objCommand.Parameters.AddWithValue("@lead_no", lead_no);
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public DataTable crmequipment_Trc_select(clsRepair objRepair)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "crmequipment_Trc_select";
            objCommand.Parameters.AddWithValue("@flag", objRepair.flag);
            objCommand.Parameters.AddWithValue("@requestId", objRepair.requestId);
            objCommand.Parameters.AddWithValue("@jobwork_status", objRepair.jobwork_status);
            objCommand.Parameters.AddWithValue("@Entry_status", objRepair.Entry_status);
            objCommand.Parameters.AddWithValue("@from_date", objRepair.from_date);
            objCommand.Parameters.AddWithValue("@to_date", objRepair.to_date);
            objCommand.Parameters.AddWithValue("@office_id", objRepair.office_id);
            objCommand.Parameters.AddWithValue("@RepairStatus", objRepair.RepairStatus);
            objCommand.Parameters.AddWithValue("@repairreason_code", objRepair.repairreason_code);
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
      public SqlDataReader jobwork_helpdesk_details_select(DateTime from_date,  string flag)
     {
         objConnection = new SqlConnection(con_str);
         objConnection.ConnectionString = con_str;
         objConnection.Open();
         objCommand = new SqlCommand();
         objCommand.CommandType = CommandType.StoredProcedure;
         objCommand.CommandTimeout = 0;
         objCommand.CommandText = "jobwork_helpdesk_details_select";
         objCommand.Parameters.AddWithValue("@from_date", from_date);
         objCommand.Parameters.AddWithValue("@flag", flag);

         objCommand.Connection = objConnection;
         dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
         objCommand.Dispose();
         objCommand = null;
         objConnection = null;
         return dataReader;
     }

      public SqlDataReader Callback_reminder_view(DateTime callbackdate, int flag)
      {
          objConnection = new SqlConnection(con_str);
          objConnection.ConnectionString = con_str;
          objConnection.Open();
          objCommand = new SqlCommand();
          objCommand.CommandType = CommandType.StoredProcedure;
          objCommand.CommandTimeout = 0;
          objCommand.CommandText = "Callback_reminder_view";
          objCommand.Parameters.AddWithValue("@callbackdate",callbackdate);
          objCommand.Parameters.AddWithValue("@flag", flag);
          objCommand.Connection = objConnection;
          dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
          objCommand.Dispose();
          objCommand = null;
          objConnection = null;

          return dataReader;
      }

      public SqlDataReader Callback_reminder_search(string requestId, int flag)
      {
          objConnection = new SqlConnection(con_str);
          objConnection.ConnectionString = con_str;
          objConnection.Open();
          objCommand = new SqlCommand();
          objCommand.CommandType = CommandType.StoredProcedure;
          objCommand.CommandTimeout = 0;
          objCommand.CommandText = "Callback_reminder_search";
          objCommand.Parameters.AddWithValue("@requestId",requestId);
          objCommand.Parameters.AddWithValue("@flag", flag);
          objCommand.Connection = objConnection;
          dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
          objCommand.Dispose();
          objCommand = null;
          objConnection = null;

          return dataReader;
      }
      public string Callback_reminder_insert(clsRepair objRepair)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "Callback_reminder_insert";

            objCommand.Parameters.AddWithValue("@requestId",requestId);
            objCommand.Parameters.AddWithValue("@Remark", Remark);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
            //objCommand.Parameters.AddWithValue("@created_on", created_on);
           // objCommand.Parameters.AddWithValue("@modify_by", modify_by);
            //objCommand.Parameters.AddWithValue("@modify_on", modify_on);
           objCommand.Parameters.AddWithValue("@callbackdate",callbackdate);
           objCommand.Parameters.AddWithValue("@callbacktime", callbacktime);
           objCommand.Parameters.AddWithValue("@flag", flag);
            dataReader = objCommand.ExecuteReader();
            //int i=objCommand.ExecuteNonQuery();
            string j = "0";
            //if(i>0)
            //{
            //    j = "inserted";
            //}
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
      //public DataTable Callback_reminder_select(DateTime callbackdate, int flag)
      //{
      //    objConnection = new SqlConnection(con_str);
      //    objConnection.ConnectionString = con_str;
      //    objConnection.Open();
      //    objCommand = new SqlCommand();
      //    objCommand.CommandType = CommandType.StoredProcedure;
      //    objCommand.CommandTimeout = 0;
      //    objCommand.CommandText = "Callback_reminder_select";
      //    objCommand.Parameters.AddWithValue("@callbackdate",callbackdate);
      //    objCommand.Parameters.AddWithValue("@flag", flag);
      //    objCommand.Connection = objConnection;
      //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
      //    objCommand.Dispose();
      //    objCommand = null;
      //    objConnection = null;

      //    return dataReader;
      //}

      public DataTable Callback_reminder_select(DateTime callbackdate, int flag)
      {
          using (SqlConnection objConnection = new SqlConnection(con_str))
          {
              SqlCommand objCommand;
              objCommand = objConnection.CreateCommand();
              objCommand.CommandType = CommandType.StoredProcedure;
              objCommand.CommandText = "Callback_reminder_select";
              objCommand.Parameters.AddWithValue("@callbackdate", callbackdate);
              objCommand.Parameters.AddWithValue("@flag", flag);
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

      public SqlDataReader Callback_reminder_update(string requestId, int flag)
      {
          objConnection = new SqlConnection(con_str);
          objConnection.ConnectionString = con_str;
          objConnection.Open();
          objCommand = new SqlCommand();
          objCommand.CommandType = CommandType.StoredProcedure;
          objCommand.CommandTimeout = 0;
          objCommand.CommandText = "Callback_reminder_update";
          objCommand.Parameters.AddWithValue("@requestId", requestId);
          objCommand.Parameters.AddWithValue("@flag", flag);
          objCommand.Connection = objConnection;
          dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
          objCommand.Dispose();
          objCommand = null;
          objConnection = null;

          return dataReader;
      }
      public SqlDataReader crm_software_engg_drop_down_select(int flag)
      {
          objConnection = new SqlConnection(con_str);
          objConnection.ConnectionString = con_str;
          objConnection.Open();
          objCommand = new SqlCommand();
          objCommand.CommandType = CommandType.StoredProcedure;
          objCommand.CommandTimeout = 0;
          objCommand.CommandText = "crm_software_engg_drop_down_select";
          objCommand.Parameters.AddWithValue("@Flag", flag);
          objCommand.Connection = objConnection;
          dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
          objCommand.Dispose();
          //objConnection.Close();
          objCommand = null;
          objConnection = null;
          return dataReader;

      }
      public SqlDataReader drop_down_Repairreason_select(int flag)
      {
          objConnection = new SqlConnection(con_str);
          objConnection.ConnectionString = con_str;
          objConnection.Open();
          objCommand = new SqlCommand();
          objCommand.CommandType = CommandType.StoredProcedure;
          objCommand.CommandTimeout = 0;
          objCommand.CommandText = "drop_down_Repairreason_select";
          objCommand.Parameters.AddWithValue("@Flag", flag);
          objCommand.Connection = objConnection;
          dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
          objCommand.Dispose();
          //objConnection.Close();
          objCommand = null;
          objConnection = null;
          return dataReader;

      }
      public SqlDataReader Entry_status__drop_down_select(int flag)
      {
          objConnection = new SqlConnection(con_str);
          objConnection.ConnectionString = con_str;
          objConnection.Open();
          objCommand = new SqlCommand();
          objCommand.CommandType = CommandType.StoredProcedure;
          objCommand.CommandTimeout = 0;
          objCommand.CommandText = "Entry_status__drop_down_select";
          objCommand.Parameters.AddWithValue("@Flag", flag);
          objCommand.Connection = objConnection;
          dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
          objCommand.Dispose();
           objCommand = null;
          objConnection = null;
          return dataReader;

      }
      public SqlDataReader jobwork_update_select(string requestid)
      {

          objConnection = new SqlConnection(con_str);
          objConnection.ConnectionString = con_str;
          objConnection.Open();
          objCommand = new SqlCommand();
          objCommand.CommandType = CommandType.StoredProcedure;
          objCommand.CommandTimeout = 0;
          objCommand.CommandText = "jobwork_update_select";
          objCommand.Parameters.AddWithValue("@requestid ", requestid);
          objCommand.Connection = objConnection;
          dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
          objCommand.Dispose();
          objCommand = null;
          objConnection = null;
          return dataReader;

      }

      public SqlDataReader drop_down_Repairstatus_select(int flag)
      {
          objConnection = new SqlConnection(con_str);
          objConnection.ConnectionString = con_str;
          objConnection.Open();
          objCommand = new SqlCommand();
          objCommand.CommandType = CommandType.StoredProcedure;
          objCommand.CommandTimeout = 0;
          objCommand.CommandText = "drop_down_Repairstatus_select";
          objCommand.Parameters.AddWithValue("@Flag", flag);
          objCommand.Connection = objConnection;
          dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
          objCommand.Dispose();
           objCommand = null;
          objConnection = null;
          return dataReader;

      }
      public SqlDataReader crm_Product_Information_select(string Brand_ID ,string Model_ID,int flag )
      {
          objConnection = new SqlConnection(con_str);
          objConnection.ConnectionString = con_str;
          objConnection.Open();
          objCommand = new SqlCommand();
          objCommand.CommandType = CommandType.StoredProcedure;
          objCommand.CommandTimeout = 0;
          objCommand.CommandText = "crm_Product_Information_select";
          objCommand.Parameters.AddWithValue("@Brand_ID", Brand_ID);
          objCommand.Parameters.AddWithValue("@Model_ID", Model_ID);
          //objCommand.Parameters.AddWithValue("@spare_Part_ID", spare_Part_ID);
          objCommand.Parameters.AddWithValue("@flag", flag);
          objCommand.Connection = objConnection;
          dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
          objCommand.Dispose();
           objCommand = null;
          objConnection = null;
          return dataReader;

      }
      public SqlDataReader crm_Product_Brand_dropdown_select(string Brand_ID)
      {
          objConnection = new SqlConnection(con_str);
          objConnection.ConnectionString = con_str;
          objConnection.Open();
          objCommand = new SqlCommand();
          objCommand.CommandType = CommandType.StoredProcedure;
          objCommand.CommandTimeout = 0;
          objCommand.CommandText = "crm_Product_Brand_dropdown_select";
          objCommand.Parameters.AddWithValue("@Brand_ID", Brand_ID);
          objCommand.Connection = objConnection;
          dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
          objCommand.Dispose();
          objCommand = null;
          objConnection = null;
          return dataReader;

      }
      public SqlDataReader crm_Product_Model_dropdown_select(string Brand_ID)
      {
          objConnection = new SqlConnection(con_str);
          objConnection.ConnectionString = con_str;
          objConnection.Open();
          objCommand = new SqlCommand();
          objCommand.CommandType = CommandType.StoredProcedure;
          objCommand.CommandTimeout = 0;
          objCommand.CommandText = "crm_Product_Model_dropdown_select";
          objCommand.Parameters.AddWithValue("@Brand_ID", Brand_ID);
         // objCommand.Parameters.AddWithValue("@Brand_ID", Brand_ID);
          objCommand.Connection = objConnection;
          dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
          objCommand.Dispose();
          objCommand = null;
          objConnection = null;
          return dataReader;

      }
      public SqlDataReader CRMEquipment_Returnticket_insert(clsRepair objRepair)
      {

          objConnection = new SqlConnection(con_str);
          objConnection.ConnectionString = con_str;
          objConnection.Open();
          objCommand = new SqlCommand();
          objCommand.CommandType = CommandType.StoredProcedure;
          objCommand.CommandTimeout = 0;
          objCommand.CommandText = "CRMEquipment_Returnticket_insert";
          objCommand.Parameters.AddWithValue("@requestId", requestId);
          objCommand.Parameters.AddWithValue("@Issue", Issue);
          objCommand.Parameters.AddWithValue("@created_by", created_by);
          objCommand.Connection = objConnection;
          dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
          objCommand.Dispose();
          objCommand = null;
          objConnection = null;
          return dataReader;

      }
      public SqlDataReader crm_Product_sparepart_dropdown_select( int flag)
      {
          objConnection = new SqlConnection(con_str);
          objConnection.ConnectionString = con_str;
          objConnection.Open();
          objCommand = new SqlCommand();
          objCommand.CommandType = CommandType.StoredProcedure;
          objCommand.CommandTimeout = 0;
          objCommand.CommandText = "crm_Product_sparepart_dropdown_select";
          objCommand.Parameters.AddWithValue("@flag", flag);
          objCommand.Connection = objConnection;
          dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
          objCommand.Dispose();
          objCommand = null;
          objConnection = null;
          return dataReader;

      }
}

