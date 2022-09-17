<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Expance_Entry.aspx.cs" Inherits="Expense_Expance_Entry"Culture="en-GB" UICulture="en-GB"%>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register TagPrefix="Ajaxified" Assembly="Ajaxified" Namespace="Ajaxified" %>



<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1"  runat="server">
  
    <link href ="../css/crm_style.css" rel="stylesheet" type="text/css"/>
   
   <%-- <script type="text/javascript" src="Jscript/Menu.js"></script>--%>

    <%--<link href="http://fonts.googleapis.com/css?family=Armata" rel='stylesheet' type='text/css'>--%>
    
    <title>::GADGETGOLD - HELPDESK:: </title>  

   <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
   <script type="text/javascript" src="../Jscript/mtmv.js"></script>
   <link href ="../css/doplus_style.css" rel="stylesheet" type="text/css"/>

   <script language="javascript" type="text/javascript">
         function Add() {
             var ab, cd, ef, gh;
             ab = parseFloat(document.getElementById("txt_amt").value);
             if (isNaN(ab) == true) {
                 ab = 0;
             }
             cd = parseFloat(document.getElementById("txtgivenamt").value);
             if (isNaN(cd) == true) {
                 cd = 0;
             }
             var mNm = (parseFloat(ab)) - (parseFloat(cd));
             var xxd = mNm.toFixed(2);
             document.getElementById("txtdues").value = xxd;


         }
      </script>
   <script type="text/javascript" language="javascript">
       window.onload = blinkOn;

       function blinkOn() {
           document.getElementById("blink").style.color = "Black"
           setTimeout("blinkOff()", 300)
       }

       function blinkOff() {
           document.getElementById("blink").style.color = "Red"
           setTimeout("blinkOn()", 300)
       }



</script>
   <style type="text/css">
   /* Begin Navigation Bar Styling */
   #nav {
      width: 95%;
      float: left;
      margin: 0 0 3em 0;
      padding: 0;
      list-style: none;
      background-color: #f2f2f2;
      border-bottom: 1px solid #ccc; 
      border-top: 1px solid #ccc;
      height:30px;
     
      }
   #nav li {
      float: left;
       height:30px;
       }
   #nav li a {
      display: block;
      padding: 5px 15px;
      text-decoration: none;
      font-weight: bold;
      color: #069;
      border-right: 1px solid #ccc;
      height:15px;
        }
        
   #nav li a:hover {
      color: #c00;
      background-color: #fff;
       height:15px; 
       }
   /* End navigation bar styling. */
   
   /* This is just styling for this specific page. */
 
</style>
</head>
<body style="background-image:url('images/body_bg.jpg'); margin:0px 0px 0px 0px">
    <form id="form1" runat="server">
      <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true" ScriptMode="Release">
 
        </asp:ScriptManager>
<div id="wrapper">

<div style=" width:100%; background-image: url('http://www.spjgadget.in/images/crop.png'); background-repeat: repeat; height:81px;">
      <table style=" background-image: url('http://www.spjgadget.in/images/crop.png'); background-repeat: repeat; width:100%">
      <tr>
      <td valign="middle" style="width:30%; text-align:left">

      <asp:ImageButton ID="ImageButton1" runat ="server" ImageAlign ="Middle" 
              Width="70%" Height="76px" ImageUrl= "~/images/gadget_logo.png"  
              style="text-align:center" CausesValidation="False" 
              onclick="ImageButton1_Click" /> 
   
     <%-- <asp:ImageButton ID="ImgCompany" runat ="server" ImageAlign ="Middle" Width="350px" Height="38px" ImageUrl= "images/mkji_logo.png" />  
   --%>
      </td>
     
     <td valign="middle">
     <table width="100%">

     <tr>
     <td valign="middle" colspan="2" style="text-align:right; padding-right:43px">
      <a style="font-size:14px; color:#FFF; font-weight:bold; text-decoration:none">Welcome</a>&nbsp;&nbsp;
      <asp:Label ID="lblusername" runat="server" Text="" Font-Bold="true" ForeColor="#FFF"  style="color:#D8D8D8"></asp:Label>
     </td>
     </tr>

     <tr>
     <td valign="middle" colspan="2" style="text-align:right">
     <asp:HyperLink ForeColor ="#FFFFFF" NavigateUrl ="changePassword.aspx"  ID="HyperLink2" Text ="Change Password" runat ="server" Font-Bold="true" Font-Size="13px" ></asp:HyperLink> <span style="color:#FFF;"> &nbsp;| </span>
	    <asp:LinkButton  ID="LinkButton1" CausesValidation="false" runat="server" 
             ForeColor="#FFFFFF" Font-Bold="true" Font-Size="13px" 
             onclick="LinkButton1_Click1" > LOG OUT </asp:LinkButton>
        <span style="color:#FFF;"> | </span>
     </td>
     </tr>

     <tr>

     <td valign="middle" colspan="2" style=" text-align:right; padding-right:23px">
      <asp:TextBox ID="txtsearch" runat="server" CssClass="search_textbox" Placeholder="Search"
           AutoPostBack="True" ontextchanged="txtsearch_TextChanged1"></asp:TextBox>
     </td>
    
     </tr>
     </table>
     </td>
  
      </tr>
   
  </table>  
 </div>
 <center>

 <div style="background-color:#000; height:30px; width:100%"></div>

 <table width="100%" cellpadding="0" cellspacing="0" style=" height:30px; ">
    
    <tr>
    <td valign="top"  style="width:12%; background-image: url('http://www.spjgadget.in/images/crop.png'); background-repeat: repeat;">
    <ul id="menu-v" style=" ">
     <li><asp:HyperLink ID="HyperLink24" runat="server" NavigateUrl="~/home.aspx"  >HOME</asp:HyperLink></li>

    <li><asp:HyperLink ID="Hypl_user" runat="server" NavigateUrl="~/home.aspx" CssClass="arrow" >CREATE LOGIN</asp:HyperLink>
   
      <ul class="sub">
         
      <li><asp:HyperLink ID="HyperLink25" runat="server" NavigateUrl="~/Branch/generate_branch.aspx">Create User</asp:HyperLink></li>
      <li><asp:HyperLink ID="HyperLink26" runat="server" NavigateUrl="~/Branch/Show_Branch_Login_Details.aspx">View User Details</asp:HyperLink></li>
      
      </ul>
        
    </li>
    <li><asp:HyperLink ID="HyperLink23" runat="server" NavigateUrl="~/lead_allocation.aspx">LEAD ALLOCATION</asp:HyperLink></li>
    <li><asp:HyperLink ID="HyperLink22" runat="server" NavigateUrl="~/Sales/Daily_sale_Transaction.aspx">DASH BOARD</asp:HyperLink></li>
      
    <li><asp:HyperLink ID="hypl_sale" runat="server" NavigateUrl="~/home.aspx" CssClass="arrow" >LEAD</asp:HyperLink>
   
        <ul class="sub">
         <li><asp:HyperLink ID="HyperLink16" runat="server" NavigateUrl="~/Sales/CreateLead.aspx">Create Lead</asp:HyperLink></li>
         <li><asp:HyperLink ID="HyperLink17" runat="server" NavigateUrl="~/Sales/Lead_select.aspx">Lead View</asp:HyperLink></li>
        </ul>
    </li>
    <li><asp:HyperLink ID="HyperLink29" runat="server" NavigateUrl="~/home.aspx" CssClass="arrow" >SERVICE INVOICE</asp:HyperLink>
        <ul class="sub">
        <li><asp:HyperLink ID="HyperLink30" runat="server" NavigateUrl="~/Invoice/CreateInvoice.aspx">Create Service Invoice</asp:HyperLink></li>
        <li><asp:HyperLink ID="HyperLink32" runat="server" NavigateUrl="~/Invoice/View_Invoice.aspx">View Service Invoice</asp:HyperLink></li>
       </ul>
    
    </li>
     <li><asp:HyperLink ID="HyperLink18" runat="server" NavigateUrl="~/home.aspx" CssClass="arrow" >JOBWORK</asp:HyperLink>
   
        <ul class="sub">
         <li><asp:HyperLink ID="HyperLink20" runat="server" NavigateUrl="~/Jobwork/insert_jobwork.aspx">Create JobWork</asp:HyperLink></li>
         <li><asp:HyperLink ID="HyperLink21" runat="server" NavigateUrl="~/Jobwork/View_Jobwork.aspx">View JobWork</asp:HyperLink></li>
        </ul>
    </li>
      <li><asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/home.aspx" CssClass="arrow" >REPAIR INVOICE</asp:HyperLink>
        <ul class="sub">
        <li><asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/Invoice/Repair_invoice_insert.aspx">Create Repair Invoice</asp:HyperLink></li>
        <li><asp:HyperLink ID="HyperLink34" runat="server" NavigateUrl="~/Invoice/View_Repair.aspx">View Repair Invoice</asp:HyperLink></li>
       </ul>
    
    </li>
     
     
    
     <li><asp:HyperLink ID="HyperLink9" runat="server" NavigateUrl="~/home.aspx" CssClass="arrow" > EXPENSE </asp:HyperLink>

      <ul class="sub">
      <li><asp:HyperLink ID="HyperLink10" runat="server" NavigateUrl="~/Expense/Expance_Entry.aspx">Expense Entry</asp:HyperLink></li>
      <li><asp:HyperLink ID="HyperLink12" runat="server" NavigateUrl="~/Expense/view_expance_details.aspx">View Expense Details</asp:HyperLink></li>
      </ul>
     </li>

     <li><asp:HyperLink ID="HyperLink31" runat="server" NavigateUrl="~/home.aspx" CssClass="arrow" > PURCHASE </asp:HyperLink>

      <ul class="sub">
      <li><asp:HyperLink ID="HyperLink33" runat="server" NavigateUrl="~/Inventory/Product_Purchase.aspx">Purchase Entry</asp:HyperLink></li>
      <li><asp:HyperLink ID="HyperLink35" runat="server" NavigateUrl="~/Inventory/Product_Purchase_View.aspx">View Product</asp:HyperLink></li>
      </ul>
     </li>
      <li><asp:HyperLink ID="HyperLink15" runat="server" NavigateUrl="~/home.aspx" CssClass="arrow" > INVENTORY </asp:HyperLink>

      <ul class="sub">
      <li><asp:HyperLink ID="HyperLink27" runat="server" NavigateUrl="~/Inventory/Inventory_Product.aspx">Product Entry</asp:HyperLink></li>
      <li><asp:HyperLink ID="HyperLink28" runat="server" NavigateUrl="~/Inventory/Inventory_Product_View.aspx">View Product</asp:HyperLink></li>
      </ul>
     </li>
     <li><asp:HyperLink ID="HyperLink36" runat="server" NavigateUrl="~/home.aspx" CssClass="arrow" > PRODUCT SALES </asp:HyperLink>

      <ul class="sub">
      <li><asp:HyperLink ID="HyperLink37" runat="server" NavigateUrl="~/Inventory/SalesProduct.aspx">Sales Entry</asp:HyperLink></li>
      <li><asp:HyperLink ID="HyperLink38" runat="server" NavigateUrl="~/Inventory/View_Sales_Product.aspx">View Sales</asp:HyperLink></li>
      </ul>
     </li>
     <li><asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/home.aspx" CssClass="arrow" >REFUNDS</asp:HyperLink>
   
     <ul class="sub">
     <li><asp:HyperLink ID="HyperLink13" runat="server" NavigateUrl="~/Refund/Refund_Service_Invoice.aspx">Service Invoice Refund</asp:HyperLink></li>
     <li><asp:HyperLink ID="HyperLink14" runat="server" NavigateUrl="~/Refund/View_Service_Refund.aspx">View Service Refund</asp:HyperLink></li>
   
     <li><asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/Refund/Refund_Repair_Invoice.aspx">Repair Invoice Refund</asp:HyperLink></li>
       <li><asp:HyperLink ID="HyperLink11" runat="server" NavigateUrl="~/Refund/View_Repair_Refund.aspx">View Repair Refund </asp:HyperLink></li>
      </ul>
     </li> 
     <li><asp:HyperLink ID="hypl_dev" runat="server" NavigateUrl="~/home.aspx" CssClass="arrow" >REPORTS</asp:HyperLink>
   
     <ul class="sub">
     <li><asp:HyperLink ID="hypldomain" runat="server" NavigateUrl="~/Report/LeadReport.aspx">Lead Report</asp:HyperLink></li>
       <li><asp:HyperLink ID="HyperLink70" runat="server" NavigateUrl="~/Report/service_invoice_report.aspx">Service Invoice Report</asp:HyperLink></li>
      <li><asp:HyperLink ID="HyperLink19" runat="server" NavigateUrl="~/Report/Repair_Report.aspx">Repair Invoice Report</asp:HyperLink></li>
     <li><asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/Report/JobworkReport.aspx">Job Work Report</asp:HyperLink></li>
     </ul>
     </li> 
     
        
    
     <li><asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/home.aspx">HELP</asp:HyperLink></li>
</ul>
        
   
    </td>
    <td valign="top" style="width:100%;">
    <center>

    
    <div id="content">
           <div class="detailedViewHeader">
<p class="lvtHeaderText"> Add Expense Details </p>
</div>
    

 <center>
 
<div class="dvtContentSpace" style="padding:10px 10px 10px 10px">
<table border="0" cellspacing="0" cellpadding="0" width="100%" class="big">
  
  <tr>
   <td colspan="4" style="background-color:#DDDCDD; height:30px; padding-left:10px; font-size:13px">
   Expense Details 
   </td>
   </tr>

    <tr>
    <td valign="middle" class="dvtCellLabeltop">Paid BY( Name) : </td>
    <td valign="middle"  class="cellInfo" style="width:350px">
    <asp:TextBox ID="txt_receivername" runat="server" CssClass="textbox"></asp:TextBox>
   </td>
     <td valign="middle" class="dvtCellLabel">Date:</td>
   <td valign="middle"  class="cellInfo1">
   <asp:TextBox ID="txtdate" runat="server" CssClass="date_textbox"></asp:TextBox>
                        
   <ajaxtoolkit:calendarextender ID="calendarextender1" runat="server" Format="dd/MM/yyyy" PopupButtonID="Image1" TargetControlID="txtdate" />                                 
 </td>
   </tr>

   <tr>
   <td valign="middle" class="dvtCellLabel" >Purpose :</td>
   <td valign="middle" class="cellInfo1">
    <asp:TextBox ID="txt_purpose" runat="server" CssClass="textbox"  TextMode="MultiLine" Height="50px"></asp:TextBox>
       </td>
   <td valign="middle" class="dvtCellLabel"> Remarks :</td>
   <td valign="middle" class="cellInfo1"><asp:TextBox ID="txt_remarks" runat="server" 
           CssClass="textbox" TextMode="MultiLine" Height="50px"></asp:TextBox></td>
  
   </tr>
    <tr>
          <td valign="middle" class="dvtCellLabel"> Expense Type :</td>
         <td valign="middle" class="cellInfo1">
   <asp:DropDownList ID="ddlexpancetype" runat="server"  class="dropdown" ></asp:DropDownList>
             </td>
         <td valign="middle" class="cellInfo1" colspan="2"></td>
        </tr>
   <tr>
<td colspan="4" class="detailedViewHeader" >
<b>Payment Details</b>
</td>
</tr>
     
    <tr>
   <td valign="middle" class="dvtCellLabel">Total Amount  <b style="padding-left:50px"> : </b></td>
   <td valign="middle"  class="cellInfo1"><asp:TextBox ID="txt_amt" runat="server"  class="textbox" onKeyUp="javascript:Add();"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txt_amt"  Font-Size="10px"
 ErrorMessage="Numeric & Decimal Values (Like 0.00) are allowed" ValidationExpression="^\d+(\.\d+)?$"></asp:RegularExpressionValidator>
  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_amt" ErrorMessage="Enter"></asp:RequiredFieldValidator>

   </td>
   <td valign="middle" class="dvtCellLabel">Given Amount<b style="padding-left:35px"> : </b></td>
   <td valign="middle" class="cellInfo1"><asp:TextBox ID="txtgivenamt" runat="server" class="textbox" onKeyUp="javascript:Add();"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator21" runat="server" ControlToValidate="txtgivenamt"  Font-Size="10px"
 ErrorMessage="Numeric & Decimal Values (Like 0.00) are allowed" ValidationExpression="^\d+(\.\d+)?$"></asp:RegularExpressionValidator>
  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtgivenamt" ErrorMessage="Enter"></asp:RequiredFieldValidator>


   </td>
   </tr>
    <tr>
   
   <td valign="middle" class="dvtCellLabel">Dues Amount :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
   <td valign="middle" class="cellInfo1"> 
   <asp:TextBox ID="txtdues" runat="server"  class="textbox"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtdues"  Font-Size="10px"
 ErrorMessage="Numeric & Decimal Values (Like 0.00) are allowed" ValidationExpression="^\d+(\.\d+)?$"></asp:RegularExpressionValidator>
  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtdues" ErrorMessage="Enter"></asp:RequiredFieldValidator>

   </td>
   <td valign="middle" class="dvtCellLabel">Mode Of Payment :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
   <td valign="middle" class="cellInfo1">
    <asp:RadioButton runat="server" ID="radcash" Text="Cash" 
           GroupName="Mode Of Payment" AutoPostBack="True" oncheckedchanged="radcash_CheckedChanged" 
            /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton runat="server" ID="radCheque" Text="Cheque" 
           GroupName="Mode Of Payment" AutoPostBack="True" oncheckedchanged="radCheque_CheckedChanged1" 
            /></td>
   </tr>
    <tr>
   <td valign="middle" class="dvtCellLabel">Cheque No. <b style="padding-left:50px"> : </b></td>
   <td valign="middle"  class="cellInfo1"><asp:TextBox ID="Txtchequeno" runat="server"  class="textbox"></asp:TextBox></td>
   <td valign="middle" class="dvtCellLabel">Bank & Branch<b style="padding-left:35px"> : </b></td>
   <td valign="middle" class="cellInfo1"><asp:TextBox ID="txtbankname" runat="server" class="textbox"></asp:TextBox></td>
   </tr>



 




   
    <tr>
   <td valign="middle" colspan="4" style="padding-bottom:10px; padding-top:10px; text-align:center; background-color:#DDDCDD">
   <asp:ImageButton ID="submit" runat="server" ImageUrl="~/images/submitButton.png" 
           onclick="submit_Click1"/>
   &nbsp;&nbsp;
   <asp:ImageButton ID="reset" runat="server" ImageUrl="~/images/cancel.png" 
           onclick="reset_Click" CausesValidation="False"/>
   
   </td>

   </tr>
   
   </table>
</div>
</center>
        </div>
</center>
    </td>
    </tr>

    </table>



 
 </center>


   
   </div>

        <!--endcontent-->
  
    <!--endwrapper-->
    <center>
    <div id="footerwrapper">
	<div style="width:100%; background-color:#333333; height:50px">
    <table  width="960px">
    <tr>
    <td valign="middle" style="text-align:left">
    <p style="margin-top:15px">
    <a href="#" style="color:white; font-family:Calibri; font-size:12px; text-decoration:none;"><b>© 2015 
        SPJ GADGET TECHNOLOGY All rights reserved</b></a><br />
    </p>
    </td>
    <td valign="middle" style="text-align:right">
    <p style="margin-top:15px">
    <a href="http://www.sagoni.com/" style="color:white; font-family:Calibri; font-size:12px; text-decoration:none;"><b>Powered By SAGONI INDIA PRIVATE LIMITED</b></a><br />
    </p>
    </td>
    </tr>
    </table>
    </div>
</div>
    </center>
  
    </form>
</body>
</html>
