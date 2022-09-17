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
using System.Net.Mail;
using System.Data;

public class maincode
{
    string con_str = ConfigurationManager.ConnectionStrings["SlickTicket"].ConnectionString;
    SqlCommand objCommand;
    SqlConnection objConnection;
    SqlDataAdapter objDataAdapter;
    SqlDataReader dataReader;
    DataSet objDataSet;

    public maincode()
    {
        
    }

    private string _Expense_type;
         public string Expense_type
    {
        get
        {
            return _Expense_type;
        }
        set
        {
            _Expense_type = value;
        }
    }

    private string _t_leave;
    public string t_leave
    {
        get
        {
            return _t_leave;
        }
        set
        {
            _t_leave = value;
        }
    }


       private string _t_absent;
       public string t_absent
    {
        get
        {
            return _t_absent;
        }
        set
        {
            _t_absent = value;
        }
    }
    private string _t_pesent;
            public string t_pesent
    {
        get
        {
            return _t_pesent;
        }
        set
        {
            _t_pesent = value;
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
           private string _unitsell;
         public string unitsell
    {
        get
        {
            return _unitsell;
        }
        set
        {
            _unitsell = value;
        }
    }
        private string _enq_sta;
         public string enq_sta
    {
        get
        {
            return _enq_sta;
        }
        set
        {
            _enq_sta = value;
        }
    }
 
    private string _specialize;
         public string specialize
    {
        get
        {
            return _specialize;
        }
        set
        {
            _specialize = value;
        }
    }
    private string _location;
        public string location
    {
        get
        {
            return _location;
        }
        set
        {
            _location = value;
        }
    }
    private string _payment_type;
            public string payment_type
    {
        get
        {
            return _payment_type;
        }
        set
        {
            _payment_type = value;
        }
    }
    private string _area;
         public string area
    {
        get
        {
            return _area;
        }
        set
        {
            _area = value;
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
    
    private string _discussiontype;
        public string discussiontype
    {
        get
        {
            return _discussiontype;
        }
        set
        {
            _discussiontype = value;
        }
    }
    private string _discountitem;
         public string discountitem
    {
        get
        {
            return _discountitem;
        }
        set
        {
            _discountitem = value;
        }
    }
    private string _b_name;
       public string b_name
    {
        get
        {
            return _b_name;
        }
        set
        {
            _b_name = value;
        }
    }
    private string _tin;
    public string tin
    {
        get
        {
            return _tin;
        }
        set
        {
            _tin = value;
        }
    }

    private string _servicetaxno;
    public string servicetaxno
    {
        get
        {
            return _servicetaxno;
        }
        set
        {
            _servicetaxno = value;
        }
    }

    private string _invoice_no;
    public string invoice_no
    {
        get
        {
            return _invoice_no;
        }
        set
        {
            _invoice_no = value;
        }
    }
    private string _Quotation_No;
    public string Quotation_No
    {
        get
        {
            return _Quotation_No;
        }
        set
        {
            _Quotation_No = value;
        }
    }
    private string _dp_name;
      public string dp_name
    {
        get
        {
            return _dp_name;
        }
        set
        {
            _dp_name = value;
        }
    }
    private string _DoFeel;
    public string DoFeel
    {
        get
        {
            return _DoFeel;
        }
        set
        {
            _DoFeel = value;
        }
    }
 private string _prblm_face;
    public string prblm_face
    {
        get
        {
            return _prblm_face;
        }
        set
        {
            _prblm_face = value;
        }
    }



    private string _imprv;
    public string imprv
    {
        get
        {
            return _imprv;
        }
        set
        {
            _imprv = value;
        }
    }
    private string _working_details;
    public string working_details
    {
        get
        {
            return _working_details;
        }
        set
        {
            _working_details = value;
        }
    }
    private string _discount;
     public string discount
    {
        get
        {
            return _discount;
        }
        set
        {
            _discount = value;
        }
    }
    private string _reg_emailID;
    public string reg_emailID
    {
        get
        {
            return _reg_emailID;
        }
        set
        {
            _reg_emailID = value;
        }
    }

    private string _sp_name;
         public string sp_name
    {
        get
        {
            return _sp_name;
        }
        set
        {
            _sp_name = value;
        }
    }
    private string _renewalamount;
     public string renewalamount
    {
        get
        {
            return _renewalamount;
        }
        set
        {
            _renewalamount = value;
        }
    }
    
    private string _swtware;
    public string swtware
    {
        get
        {
            return _swtware;
        }
        set
        {
            _swtware = value;
        }
    }


  
  //    ,  ,  ,  , 



    private string _branch;
    public string branch
    {
        get
        {
            return _branch;
        }
        set
        {
            _branch = value;
        }
    }



    private string _bank;
    public string bank
    {
        get
        {
            return _bank;
        }
        set
        {
            _bank = value;
        }
    }
    private string _other_password;
    public string other_password
    {
        get
        {
            return _other_password;
        }
        set
        {
            _other_password = value;
        }
    }

    private string _other_regEmail;
    public string other_regEmail
    {
        get
        {
            return _other_regEmail;
        }
        set
        {
            _other_regEmail = value;
        }
    }

    private string _other_name;
    public string other_name
    {
        get
        {
            return _other_name;
        }
        set
        {
            _other_name = value;
        }
    }
    private string _leave_reson;
          public string leave_reson
    {
        get
        {
            return _leave_reson;
        }
        set
        {
            _leave_reson = value;
        }
    }

    // ,,,,,,,,
    private string _total_fee;
    public string total_fee
    {
        get
        {
            return _total_fee;
        }
        set
        {
            _total_fee = value;
        }
    }

   
    private string _remark;
        public string remark
    {
        get
        {
            return _remark;
        }
        set
        {
            _remark = value;
        }
    }
    private string _other_contact;
        public string other_contact
    {
        get
        {
            return _other_contact;
        }
        set
        {
            _other_contact = value;
        }
    }

        private DateTime _start_date;
        public DateTime start_date
    {
        get
        {
            return _start_date;
        }
        set
        {
            _start_date = value;
        }
    }
    private string _other_cer;
    public string other_cer
    {
        get
        {
            return _other_cer;
        }
        set
        {
            _other_cer = value;
        }
    }

    private string _gad_cer;
    public string gad_cer
    {
        get
        {
            return _gad_cer;
        }
        set
        {
            _gad_cer = value;
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


          private string _pen_card;
          public string pen_card
    {
        get
        {
            return _pen_card;
        }
        set
        {
            _pen_card = value;
        }
    }
 
        
    private DateTime _Expence_date;
    public DateTime Expence_date
    {
        get
        {
            return _Expence_date;
        }
        set
        {
            _Expence_date = value;
        }
    }

    private DateTime _p_Relieving_date;
    public DateTime p_Relieving_date
    {
        get
        {
            return _p_Relieving_date;
        }
        set
        {
            _p_Relieving_date = value;
        }
    }



    private DateTime _p_joining_date;
    public DateTime p_joining_date
    {
        get
        {
            return _p_joining_date;
        }
        set
        {
            _p_joining_date = value;
        }
    }



    private string _p_job_profile;
    public string p_job_profile
    {
        get
        {
            return _p_job_profile;
        }
        set
        {
            _p_job_profile = value;
        }
    }



    private string _p_company_name;
    public string p_company_name
    {
        get
        {
            return _p_company_name;
        }
        set
        {
            _p_company_name = value;
        }
    }
    private string _designation;
    public string designation
    {
        get
        {
            return _designation;
        }
        set
        {
            _designation = value;
        }
    }
    private string _salary;
    public string salary
    {
        get
        {
            return _salary;
        }
        set
        {
            _salary = value;
        }
    }

    private string _gender;
    public string gender
    {
        get
        {
            return _gender;
        }
        set
        {
            _gender = value;
        }
    }

    private DateTime _dob;
    public DateTime dob
    {
        get
        {
            return _dob;
        }
        set
        {
            _dob = value;
        }
    }

    private string _Father_name;
    public string Father_name
    {
        get
        {
            return _Father_name;
        }
        set
        {
            _Father_name = value;
        }
    }
    private string _emp_name;
    public string emp_name
    {
        get
        {
            return _emp_name;
        }
        set
        {
            _emp_name = value;
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
    private string _feedback;
    public string feedback
    {
        get
        {
            return _feedback;
        }
        set
        {
            _feedback = value;
        }
    }
    private string _contact_person;
    public string contact_person
    {
        get
        {
            return _contact_person;
        }
        set
        {
            _contact_person = value;
        }
    }
    private string _cancel_reason;
    public string cancel_reason
    {
        get
        {
            return _cancel_reason;
        }
        set
        {
            _cancel_reason = value;
        }
    }
    private string _no_of_plots;
    public string no_of_plots
    {
        get
        {
            return _no_of_plots;
        }
        set
        {
            _no_of_plots = value;
        }
    }
    private DateTime _join_date;
    public DateTime join_date
    {
        get
        {
            return _join_date;
        }
        set
        {
            _join_date = value;
        }
    }
    private string _collected_amount;
    public string collected_amount
    {
        get
        {
            return _collected_amount;
        }
        set
        {
            _collected_amount = value;
        }
    }
    private string _regd_email;
    public string regd_email
    {
        get
        {
            return _regd_email;
        }
        set
        {
            _regd_email = value;
        }
    }
    private string _due_amount;
    public string due_amount
    {
        get
        {
            return _due_amount;
        }
        set
        {
            _due_amount = value;
        }
    }


    private string _customer_name;
    public string customer_name
    {
        get
        {
            return _customer_name;
        }
        set
        {
            _customer_name = value;
        }
    }
    private string _modified_by;
    public string modified_by
    {
        get
        {
            return _modified_by;
        }
        set
        {
            _modified_by = value;
        }
    }
    private string _service_desc;
    public string service_desc
    {
        get
        {
            return _service_desc;
        }
        set
        {
            _service_desc = value;
        }
    }

    private string _no_of_mails;
    public string no_of_mails
    {
        get
        {
            return _no_of_mails;
        }
        set
        {
            _no_of_mails = value;
        }
    }

    private string _no_of_pages;
    public string no_of_pages
    {
        get
        {
            return _no_of_pages;
        }
        set
        {
            _no_of_pages = value;
        }
    }

    private string _service_amount;
    public string service_amount
    {
        get
        {
            return _service_amount;
        }
        set
        {
            _service_amount = value;
        }
    }

    private string _email_id;
    public string email_id
    {
        get
        {
            return _email_id;
        }
        set
        {
            _email_id = value;
        }
    }
    private string _cast;
    public string cast
    {
        get
        {
            return _cast;
        }
        set
        {
            _cast = value;
        }
    }
     private string _relegion;
     public string relegion
     {
         get
         {
             return _relegion;
         }
         set
         {
             _relegion = value;
         }
     }
    private string _invoice_id;
    public string invoice_id
    {
        get
        {
            return _invoice_id;
        }
        set
        {
            _invoice_id = value;
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
   
    private string _Invoice_no;
    public string Invoice_no
    {
        get
        {
            return _Invoice_no;
        }
        set
        {
            _Invoice_no = value;
        }
    }

    private string _emi_Invoice_no;
    public string emi_Invoice_no
    {
        get
        {
            return _emi_Invoice_no;
        }
        set
        {
            _emi_Invoice_no = value;
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
   private DateTime _due_date;
   public DateTime due_date
   {
       get
       {
           return _due_date;
       }
       set
       {
           _due_date = value;
       }
   }
   private DateTime _nxt_remind_date;
   public DateTime nxt_remind_date
   {
       get
       {
           return _nxt_remind_date;
       }
       set
       {
           _nxt_remind_date = value;
       }
   }

   private string _project;
   public string project
   {
       get
       {
           return _project;
       }
       set
       {
           _project = value;
       }
   }
  
   private string _purchaser_name;
   public string purchaser_name
   {
       get
       {
           return _purchaser_name;
       }
       set
       {
           _purchaser_name = value;
       }
   }

  
   private string _CustomerId;
         public string CustomerId
   {
       get
       {
           return _CustomerId;
       }
       set
       {
           _CustomerId = value;
       }
   }
   private string _Feedback;
   public string Feedback
   {
       get
       {
           return _Feedback;
       }
       set
       {
           _Feedback = value;
       }
   }

     private string _discount_amount;
   public string discount_amount
   {
       get
       {
           return _discount_amount;
       }
       set
       {
           _discount_amount = value;
       }
   }
   private string _business_catogary;
   public string business_catogary
   {
       get
       {
           return _business_catogary;
       }
       set
       {
           _business_catogary = value;
       }
   }

   private string _feedback_id;
   public string feedback_id
   {
       get
       {
           return _feedback_id;
       }
       set
       {
           _feedback_id = value;
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


    private string _call_log;
    public string call_log
    {
        get
        {
            return _call_log;
        }
        set
        {
            _call_log = value;
        }
    }


    private string _mode_pay;
    public string mode_pay
    {
        get
        {
            return _mode_pay;
        }
        set
        {
            _mode_pay = value;
        }
    }

    private string _Branch_Name;
    public string Branch_Name
    {
        get
        {
            return _Branch_Name;
        }
        set
        {
            _Branch_Name = value;
        }
    }

    private string _agent_name;
    public string agent_name
    {
        get
        {
            return _agent_name;
        }
        set
        {
            _agent_name = value;
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
    private string _mobile_no;
    public string mobile_no
    {
        get
        {
            return _mobile_no;
        }
        set
        {
            _mobile_no = value;
        }
    }

    private DateTime _doj;
    public DateTime doj
    {
        get
        {
            return _doj;
        }
        set
        {
            _doj = value;
        }
    }

    private string _commision;
    public string commision
    {
        get
        {
            return _commision;
        }
        set
        {
            _commision = value;
        }
    }

    private string _project_id;
    public string project_id
    {
        get
        {
            return _project_id;
        }
        set
        {
            _project_id = value;
        }
    }


    private string _project_name;
    public string project_name
    {
        get
        {
            return _project_name;
        }
        set
        {
            _project_name = value;
        }
    }

    private string _project_location;
    public string project_location
    {
        get
        {
            return _project_location;
        }
        set
        {
            _project_location = value;
        }
    }


    private string _no_of_plot;
    public string no_of_plot
    {
        get
        {
            return _no_of_plot;
        }
        set
        {
            _no_of_plot = value;
        }
    }
   

    private string _Company;
    public string Company
    {
        get
        {
            return _Company;
        }
        set
        {
            _Company = value;
        }
    }

    private string _project_status;
    public string project_status
    {
        get
        {
            return _project_status;
        }
        set
        {
            _project_status = value;
        }
    }

    private string _contactno;
       public string contactno
    {
        get
        {
            return _contactno;
        }
        set
        {
            _contactno = value;
        }
    }
      private string _logged_by;
    public string logged_by
    {
        get
        {
            return _logged_by;
        }
        set
        {
            _logged_by = value;
        }
    }

     private string _Issue_name;
    public string Issue_name
    {
        get
        {
            return _Issue_name;
        }
        set
        {
            _Issue_name = value;
        }
    }
    private string _agent_status;
    public string agent_status
    {
        get
        {
            return _agent_status;
        }
        set
        {
            _agent_status = value;
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


    private string _chequeno;
    public string chequeno
    {
        get
        {
            return _chequeno;
        }
        set
        {
            _chequeno = value;
        }
    }
    private string _bank_branch;
    public string bank_branch
    {
        get
        {
            return _bank_branch;
        }
        set
        {
            _bank_branch = value;
        }
    }
 

    private DateTime _sale_date;
    public DateTime sale_date
    {
        get
        {
            return _sale_date;
        }
        set
        {
            _sale_date = value;
        }
    }


    private string _mode_of_payment;
    public string mode_of_payment
    {
        get
        {
            return _mode_of_payment;
        }
        set
        {
            _mode_of_payment = value;
        }
    }




    private string _Purpose;
    public string Purpose
    {
        get
        {
            return _Purpose;
        }
        set
        {
            _Purpose = value;
        }
    }
    private string _Receiver_Name;
    public string Receiver_Name
    {
        get
        {
            return _Receiver_Name;
        }
        set
        {
            _Receiver_Name = value;
        }
    }
    private string _cheque_no;
    public string cheque_no
    {
        get
        {
            return _cheque_no;
        }
        set
        {
            _cheque_no = value;
        }
    }


    private string _bank_and_branch;
    public string bank_and_branch
    {
        get
        {
            return _bank_and_branch;
        }
        set
        {
            _bank_and_branch = value;
        }
    }


    private string _registrant_name;
    public string registrant_name
    {
        get
        {
            return _registrant_name;
        }
        set
        {
            _registrant_name = value;
        }
    }

    private DateTime _assign_date;
    public DateTime assign_date
    {
        get
        {
            return _assign_date;
        }
        set
        {
            _assign_date = value;
        }
    }

    private string _father_name;
    public string father_name
    {
        get
        {
            return _father_name;
        }
        set
        {
            _father_name = value;
        }
    }
    private string _emp_id;
     public string emp_id
    {
        get
        {
            return _emp_id;
        }
        set
        {
            _emp_id = value;
        }
    }

     private string _amount;
     public string amount
     {
         get
         {
             return _amount;
         }
         set
         {
             _amount = value;
         }
     }


         private string _m_salary;
         public string m_salary
         {
             get
             {
                 return _m_salary;
             }
             set
             {
                 _m_salary = value;
             }
         }

         private string _permenet_address;
         public string permenet_address
         {
             get
             {
                 return _permenet_address;
             }
             set
             {
                 _permenet_address = value;
             }
         }





         private string _present_address;
         public string present_address
         {
             get
             {
                 return _present_address;
             }
             set
             {
                 _present_address = value;
             }
         }



         private string _parent_profession;
         public string parent_profession
         {
             get
             {
                 return _parent_profession;
             }
             set
             {
                 _parent_profession = value;
             }
         }



         private string _local_guardian;
         public string local_guardian
         {
             get
             {
                 return _local_guardian;
             }
             set
             {
                 _local_guardian = value;
             }
         }



         private string _mother_name;
         public string mother_name
         {
             get
             {
                 return _mother_name;
             }
             set
             {
                 _mother_name = value;
             }
         }





         private string _pob;
         public string pob
         {
             get
             {
                 return _pob;
             }
             set
             {
                 _pob = value;
             }
         }

         private string _reason_for_leave;
         public string reason_for_leave
         {
             get
             {
                 return _reason_for_leave;
             }
             set
             {
                 _reason_for_leave = value;
             }
         }



         private string _t_salary;
         public string t_salary
         {
             get
             {
                 return _t_salary;
             }
             set
             {
                 _t_salary = value;
             }
         }


         private string _mode_of_pay;
         public string mode_of_pay
         {
             get
             {
                 return _mode_of_pay;
             }
             set
             {
                 _mode_of_pay = value;
             }
         }


         private string _Bank_Branch;
         public string Bank_Branch
         {
             get
             {
                 return _Bank_Branch;
             }
             set
             {
                 _Bank_Branch = value;
             }
         }

         private string _Lead_no;
         public string Lead_no
         {
             get
             {
                 return _Lead_no;
             }
             set
             {
                 _Lead_no = value;
             }
         }
         private string _Remarks;
         public string Remarks
         {
             get
             {
                 return _Remarks;
             }
             set
             {
                 _Remarks = value;
             }
         }

         private string _Product_Cost;
         public string Product_Cost
         {
             get
             {
                 return _Product_Cost;
             }
             set
             {
                 _Product_Cost = value;
             }
         }

         private string _Product_Name;
         public string Product_Name
         {
             get
             {
                 return _Product_Name;
             }
             set
             {
                 _Product_Name = value;
             }
         }
      

         private string _Absent;
         public string Absent
         {
             get
             {
                 return _Absent;
             }
             set
             {
                 _Absent = value;
             }
         }


         private string _Leave;
         public string Leave
         {
             get
             {
                 return _Leave;
             }
             set
             {
                 _Leave = value;
             }
         }

         private string _L_Without_Pay;
         public string L_Without_Pay
         {
             get
             {
                 return _L_Without_Pay;
             }
             set
             {
                 _L_Without_Pay = value;
             }
         }

         private string _T_Working_Day;
         public string T_Working_Day
         {
             get
             {
                 return _T_Working_Day;
             }
             set
             {
                 _T_Working_Day = value;
             }
         }


    private string _cheque;
    public string cheque
    {
        get
        {
            return _cheque;
        }
        set
        {
            _cheque = value;
        }
    }

    private string _cash;
    public string cash
    {
        get
        {
            return _cash;
        }
        set
        {
            _cash = value;
        }
    }

    private string _domain_name;
    public string domain_name
    {
        get
        {
            return _domain_name;
        }
        set
        {
            _domain_name = value;
        }
    }




    private string _issue_desc;
    public string issue_desc
    {
        get
        {
            return _issue_desc;
        }
        set
        {
            _issue_desc = value;
        }
    }


    private string _issue;
    public string issue
    {
        get
        {
            return _issue;
        }
        set
        {
            _issue = value;
        }
    }


    private string _issue_type;
    public string issue_type
    {
        get
        {
            return _issue_type;
        }
        set
        {
            _issue_type = value;
        }
    }


    private DateTime _Schedule_date;
    public DateTime Schedule_date
    {
        get
        {
            return _Schedule_date;
        }
        set
        {
            _Schedule_date = value;
        }
    }

    private string _customer_id;
    public string customer_id
    {
        get
        {
            return _customer_id;
        }
        set
        {
            _customer_id = value;
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


    private string _country;
    public string country
    {
        get
        {
            return _country;
        }
        set
        {
            _country = value;
        }
    }

    private string _pincode;
    public string pincode
    {
        get
        {
            return _pincode;
        }
        set
        {
            _pincode = value;
        }
    }

    private string _city;
    public string city
    {
        get
        {
            return _city;
        }
        set
        {
            _city = value;
        }
    }

    private string _state;
    public string state
    {
        get
        {
            return _state;
        }
        set
        {
            _state = value;
        }
    }

    private string _company_name;
    public string company_name
    {
        get
        {
            return _company_name;
        }
        set
        {
            _company_name = value;
        }
    }



    private string _txt_Mr;
    public string txt_Mr
    {
        get
        {
            return _txt_Mr;
        }
        set
        {
            _txt_Mr = value;
        }
    }

    private string _Schedule_Time;
    public string Schedule_Time
    {
        get
        {
            return _Schedule_Time;
        }
        set
        {
            _Schedule_Time = value;
        }
    }

    private string _service_type;
    public string service_type
    {
        get
        {
            return _service_type;
        }
        set
        {
            _service_type = value;
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

  

           private string _name;
           public string name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

     private string _requirement;
     public string requirement
    {
        get
        {
            return _requirement;
        }
        set
        {
            _requirement = value;
        }
    }

   
     private string _amt;
     public string amt
     {
         get
         {
             return _amt;
         }
         set
         {
             _amt = value;
         }
     }


     private string _agreement_peroid;
     public string agreement_peroid
     {
         get
         {
             return _agreement_peroid;
         }
         set
         {
             _agreement_peroid = value;
         }
     }


    public string m_crm_temp_employee_insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "m_crm_temp_employee_insert";
            objCommand.Parameters.AddWithValue("@sno", sno);
            objCommand.Parameters.AddWithValue("@address", address);
            objCommand.Parameters.AddWithValue("@join_date", join_date);
            objCommand.Parameters.AddWithValue("@emp_name", emp_name);
            objCommand.Parameters.AddWithValue("@Father_name", Father_name);
            objCommand.Parameters.AddWithValue("@mobile", mobile);
            objCommand.Parameters.AddWithValue("@gender", gender);
            objCommand.Parameters.AddWithValue("@salary", salary);
            objCommand.Parameters.AddWithValue("@designation", designation);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
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

    public DataTable Expense_Entry_Select(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Expense_Entry_Select";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
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

    public SqlDataReader monthly_Attendance_Report(DateTime from_date, DateTime to_date, string flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "monthly_Attendance_Report";
        objCommand.Parameters.AddWithValue("@from_date", from_date);
        objCommand.Parameters.AddWithValue("@to_date", to_date);
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
      //  objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public SqlDataReader m_crm_temp_employee_select_print(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_crm_temp_employee_select_print";
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }

    public string Branch_deactive(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "Branch_deactive";
            objCommand.Parameters.AddWithValue("@emp_id", emp_id);
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

    public SqlDataReader m_crmemployee_select_print(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_crmemployee_select_print";
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
  
    public string Expense_Entry_Insert(maincode obj_main)
         {
             using (SqlConnection objConnection = new SqlConnection(con_str))
             {
                
                 SqlCommand objCommand;
                 objCommand = objConnection.CreateCommand();
                 objConnection.Open();
                 objCommand.CommandType = CommandType.StoredProcedure;
                 objCommand.CommandTimeout = 0;
                 objCommand.CommandText = "Expense_Entry_Insert";
                 objCommand.Parameters.AddWithValue("@sno", sno);
                 objCommand.Parameters.AddWithValue("@Expence_date", Expence_date);
                 objCommand.Parameters.AddWithValue("@Receiver_Name", Receiver_Name);
                 objCommand.Parameters.AddWithValue("@Purpose", Purpose);
                 objCommand.Parameters.AddWithValue("@Remarks", Remarks);
                 objCommand.Parameters.AddWithValue("@created_by", created_by);
                 objCommand.Parameters.AddWithValue("@bank_and_branch", bank_and_branch);
                 objCommand.Parameters.AddWithValue("@amount", amount);
                 objCommand.Parameters.AddWithValue("@cheque_no", cheque_no);
                 objCommand.Parameters.AddWithValue("@mode_of_payment", mode_of_payment);
                 objCommand.Parameters.AddWithValue("@Expense_type", Expense_type);
                 objCommand.Parameters.AddWithValue("@collected_amount", collected_amount);
                 objCommand.Parameters.AddWithValue("@due_amount", due_amount);
                 
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

    public SqlDataReader m_crmemployee_update_view(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_crmemployee_update_view";
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public SqlDataReader Expense_Entry_update_view(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Expense_Entry_update_view";
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
      public SqlDataReader m_crm_tempemployee_update_view(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_crm_tempemployee_update_view";
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader m_crm_customer_update_view(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_crm_customer_update_view";
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader crm_user_Detail_update(string emp_id)
         {
             objConnection = new SqlConnection(con_str);
             objConnection.ConnectionString = con_str;
             objConnection.Open();
             objCommand = new SqlCommand();
             objCommand.CommandType = CommandType.StoredProcedure;
             objCommand.CommandTimeout = 0;
             objCommand.CommandText = "crm_user_Detail_update";
             objCommand.Parameters.AddWithValue("@emp_id", emp_id);

            // objCommand.Parameters.AddWithValue("@flag", flag);
             objCommand.Connection = objConnection;
             dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
             objCommand.Dispose();
             objCommand = null;
             objConnection = null;
             return dataReader;
         }
    public SqlDataReader Expense_Entry_UPDATE(string sno)
         {
             objConnection = new SqlConnection(con_str);
             objConnection.ConnectionString = con_str;
             objConnection.Open();
             objCommand = new SqlCommand();
             objCommand.CommandType = CommandType.StoredProcedure;
             objCommand.CommandTimeout = 0;
             objCommand.CommandText = "Expense_Entry_UPDATE";
             objCommand.Parameters.AddWithValue("@sno", sno);

            // objCommand.Parameters.AddWithValue("@flag", flag);
             objCommand.Connection = objConnection;
             dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
             objCommand.Dispose();
             objCommand = null;
             objConnection = null;
             return dataReader;
         }

    public DataTable m_crm_temp_employee_select(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "m_crm_temp_employee_select";
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

    public SqlDataReader employee_details(string EMP_ID)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "employee_details";
        objCommand.Parameters.AddWithValue("@EMP_ID", EMP_ID);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public DataTable m_crmemployee_select(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "m_crmemployee_select";
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

   
    public DataTable crm_user_Detail_Report(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "crm_user_Detail_Report";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
           // objCommand.Parameters.AddWithValue("@agent_name", agent_name);
            objCommand.Parameters.AddWithValue("@Branch_Name", Branch_Name);
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
   
    public DataTable Expense_Entry_SELECT_delete(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Expense_Entry_SELECT_delete";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
           // objCommand.Parameters.AddWithValue("@agent_name", agent_name);
            objCommand.Parameters.AddWithValue("@Branch_Name", Branch_Name);
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
    public DataTable Expense_Entry_SELECT_view(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Expense_Entry_SELECT_view";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
           // objCommand.Parameters.AddWithValue("@agent_name", agent_name);
            objCommand.Parameters.AddWithValue("@Branch_Name", Branch_Name);
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

    public string Expense_Entry_Delete(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "Expense_Entry_Delete";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
            // objCommand.Parameters.AddWithValue("@agent_name", agent_name);
            objCommand.Parameters.AddWithValue("@Branch_Name", Branch_Name);
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

    public DataTable Expense_Entry_SELECT(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Expense_Entry_SELECT";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
           // objCommand.Parameters.AddWithValue("@agent_name", agent_name);
            //objCommand.Parameters.AddWithValue("@Branch_Name", Branch_Name);
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
   

    public SqlDataReader select_company()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "select_company";
       
        //  objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }


    public SqlDataReader role_select()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "role_select";
        // objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }


}