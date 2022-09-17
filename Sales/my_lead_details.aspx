<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="my_lead_details.aspx.cs" Inherits="Sales_my_lead_details"  Culture="en-GB" UICulture="en-GB"%>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register TagPrefix="Ajaxified" Assembly="Ajaxified" Namespace="Ajaxified" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link rel="stylesheet" type="text/css"  href="../themes/softed/style.css">
  <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
  <script type="text/javascript" src="../Jscript/mtmv.js"></script>
  <link href ="../css/doplus_style.css" rel="stylesheet" type="text/css"/>
<script type ="text/ecmascript" >
    var _Page = '0';
    var _StartsWith = 'All';

    var _SearchText = '';

    function NavigateToLetter(ltr) {

        _Page = 0;
        _StartsWith = ltr;

        DoNavigate();

        //        alert(url);
        //        return;
    }
    function DoNavigate() {
        var url = 'leadReport.aspx'

        url = url + '?firstname=' + _StartsWith;

        location.href = url;
    }


    

</script>
    
  
   <div class ="gridSearch" style="height:80px; padding-bottom:10px">
<table style="width:100%">
 <tr>

<td  style=" padding-bottom:20px; padding-left:0px; height:0px; padding-top:0px">
<label style=" font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:18px;padding-left:20px; padding-right:0px">
MY Performance </label>  
 </td>  
</tr>
  <tr>
  <td align="right" style="color:Black" >
                      
                       From&nbsp;
                        <asp:TextBox ID="txtfromdate" runat="server"></asp:TextBox>
                        <asp:Image runat="Server" ID="Image1" ImageUrl="~/images/cal.gif" />
                        <asp:RequiredFieldValidator ID="rfv_fromdate" runat="server" SetFocusOnError="true"
                            ControlToValidate="txtfromdate" Display="Dynamic" ErrorMessage="Enter From Date"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="cmv_fromdate" ControlToValidate="txtfromdate" Operator="DataTypeCheck"
                            Type="Date" ErrorMessage="Enter Valid Date" Display="Dynamic" runat="server"
                            SetFocusOnError="true"></asp:CompareValidator>
                        <ajaxtoolkit:CalendarExtender ID="calendarextender1" runat="server" TargetControlID="txtfromdate"
                            Format="dd/MM/yyyy" PopupButtonID="image1" />
                       </td><td  style="color:Black"> To &nbsp;
                        <asp:TextBox ID="txttodate" runat="server"></asp:TextBox>
                        <asp:Image runat="Server" ID="Image2" ImageUrl="~/images/cal.gif" />
                        <asp:RequiredFieldValidator ID="rfv_todate" runat="server" ControlToValidate="txttodate"
                            Display="Dynamic" ErrorMessage="Enter To Date" SetFocusOnError="true"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="cmv_todate" ControlToValidate="txttodate" Operator="DataTypeCheck"
                            Type="Date" ErrorMessage="Enter Valid Date" Display="Dynamic" runat="server"
                            SetFocusOnError="true"></asp:CompareValidator>
                        <asp:CompareValidator ID="cmv_todate2" ControlToValidate="txttodate" ControlToCompare="txtfromdate"
                            Type="Date" Operator="GreaterThanEqual" Display="Dynamic" ErrorMessage="This Date cannot be less than from date"
                            runat="server" SetFocusOnError="true"></asp:CompareValidator>
                        <ajaxtoolkit:CalendarExtender ID="calendarextender2" runat="server" TargetControlID="txttodate"
                            Format="dd/MM/yyyy" PopupButtonID="image2" />
                  
     <asp:Button ID="lead_detail" runat="server" Text="View"  ForeColor="black"
        Width="111px" onclick="lead_detail_Click"  />
                  </td>          

 </tr>

  <tr>   <td style="padding-left:350px"><asp:Label ID="lblmsg" runat="server" Text="" ForeColor="Red"></asp:Label>
  </td>
  </tr>
 
 </table>

</div> 



   <%--<div class ="grid" style="padding-bottom:10px; padding-top:10px;background-color:#DDDDDD" >
 <table width="100%" style=" padding-bottom:0px">
 <tr>
 <td align="center" ><label  style="font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:14px">Total Lead</label></td>
 <td align="center" ><label   style="font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:14px "> Qualified</label></td>
 <td align="center" ><label style="font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:14px">Prospect</label></td>
<td align="center" ><label  style="font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:14px">Assign Tech</label></td>
<td align="center" ><label  style="font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:14px ">Schedule</label></td>
 <td align="center" ><label   style="font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:14px ">Follow Up</label></td>
<td align="center" ><label   style="font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:14px ">Lost</label></td>
<td align="center" ><label   style="font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:14px ">Junk</label></td>
 </tr>
 <tr>
  <td align="center" ><label   style="font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:14px "> <asp:Label ID="lbltlead" runat="server"></asp:Label></label></td>
 <td align="center" ><label   style="font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:14px"> <asp:Label ID="lblqual" runat="server"></asp:Label></label></td>
 <td align="center" ><label  style="font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:14px "> <asp:Label ID="lblpros" runat="server"></asp:Label></label></td>
<td align="center" ><label   style="font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:14px "> <asp:Label ID="lblassign" runat="server"></asp:Label></label></td>
 <td align="center" ><label   style="font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:14px "> <asp:Label ID="lblschedule" runat="server"></asp:Label></label></td>
<td align="center" ><label   style="font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:14px "> <asp:Label ID="lblfol" runat="server"></asp:Label></label></td>
<td align="center" ><label   style="font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:14px "> <asp:Label ID="lbllost" runat="server"></asp:Label></label></td>
<td align="center" ><label   style="font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:14px "> <asp:Label ID="lbljunk" runat="server"></asp:Label></label></td>
 </tr>

</table>
</div>--%>
   <div class ="grid" >
 <table width="100%" style=" padding-bottom:0px;font-weight:bold;">
<tr>
<td align="left"  style="font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:16px;padding-left:2px ">
<b> Lead Summary</b>
</td>
<td align="center" style="font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:16px;padding-left:2px "  >
<b> Count</b>
</td>


<td align="center" style="font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:16px;padding-left:2px ">
<b> Amount</b></td>
<td align="center"style="font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:16px;padding-left:2px ">
<b>Conversion</b></td>
</tr>
<tr>
<td align="left"style=" border-style:solid; width: 593px;" >
 Total Leads
</td>
<td  align="center"  >
    <asp:Label ID="lbltlead" runat="server"></asp:Label>
</td>
<td></td>
<td></td>
</tr>
<tr>
<td align="left"style=" border-style:solid; width: 593px;" >
 Schedule
</td>
<td  align="center"  >
    <asp:Label ID="lblschedule" runat="server"></asp:Label>
</td>
<td></td>
<td></td>
</tr>
<tr>
<td align="left"style=" border-style:solid; width: 593px; color:Maroon" >
 Follow Up
</td>
<td  align="center" style="color:Maroon" >
    <asp:Label ID="lblfol" runat="server"></asp:Label>
</td>
<td></td>
<td></td>
</tr>

<tr>
<td align="left"style=" border-style:solid; width: 593px;" >
 Lost
</td>
<td  align="center"  >
    <asp:Label ID="lbllost" runat="server"></asp:Label>
</td>
<td></td>
<td></td>
</tr>
<tr>
<td align="left"style=" border-style:solid; width: 593px;" >
 Junk
</td>
<td  align="center"  >
    <asp:Label ID="lbljunk" runat="server"></asp:Label>
</td>
<td></td>
<td></td>
</tr>
<tr>
<td   align="left" style=" border-style:solid; width: 593px;" >
 Assign-Tech
</td>
<td   align="center"   >
    <asp:Label ID="lblassign" runat="server" ></asp:Label>
</td>

<td   align="center"  >
    <asp:Label ID="lblassignamount" runat="server" ></asp:Label>
</td>
<td   align="center"  style=" border-style:solid" >
    <%--<asp:Label ID="lblassignconversion" runat="server" ></asp:Label>--%>
</td>
</tr>
<tr>
<td align="left" style=" border-style:solid; width: 593px;"  >
Prospect [ Money to be collected ]
</td>
<td   align="center"  >
 <asp:Label ID="lblpros" runat="server"></asp:Label>
    </td>
    
    <td   align="center" style=" border-style:solid"  >
     <asp:Label ID="lblprosamount" runat="server"></asp:Label>
    </td>
     <td   align="center" style=" border-style:solid"  >
     <asp:Label ID="lblprosconversion" runat="server"></asp:Label>
    </td>
    </tr>
    <tr>
<td   align="left" style=" width: 593px" >
 Qualified
    [ Money Collected ]
</td>
<td   align="center"   >
 <asp:Label ID="lblqual" runat="server"></asp:Label>
</td>

<td   align="center"  >
 <asp:Label ID="lblquliamount" runat="server"></asp:Label>
</td>
<td   align="center"  >
 <asp:Label ID="lblquliconversion" runat="server"></asp:Label>
</td>
</tr>



</table>
</div>
<div class ="grid" style="padding-bottom:10px; padding-top:10px;background-color:#DDDDDD; height:30px" >
     
 <table  width="100%" style=" background-color:#DDDDDD;  height:60px "  >
   
        <tr>
            <td  rowspan= "2" style="width: 1080px" >
            <label style=" font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:12pt;padding-left:10px" >Follow Up Lead List</label>
        
            </td>
            
        </tr>
      
        </table>             
        </div>	      
  
              
               <div class="mGrid" cellspacing="0" rules="cols" border="1" id="gridCustomers" style="width:100%;border-collapse:collapse;">
                         <asp:GridView ID="grdLead" runat ="server" AutoGenerateColumns ="False"   GridLines ="None"  
                             Width ="100%" 

                                EmptyDataText ="No lead found for the criteria you selected." onrowcommand="grdLead_RowCommand" 
                           
                           > 
                                
                         <Columns >
                         <asp:TemplateField  HeaderText ="Action">
                                                <ItemTemplate>
               <asp:ImageButton ID="imgEdit" ImageUrl ="~/images/quotation-icon.jpg" runat="server" CommandName ="edit" ToolTip ="Click to edit" CausesValidation =false   /> 
                                                     
                                                   
                                                </ItemTemplate>
                          </asp:TemplateField>
 
                         <asp:TemplateField HeaderText ="Lead No."  Visible="true">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblLeadNo" runat="server" Text ='<%#Eval("lead_no") %>' />
                                                </ItemTemplate>
                          </asp:TemplateField>
                      <asp:TemplateField HeaderText ="leadstatus"  Visible="false">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblleadStatus" runat="server" Text ='<%#Eval("lead_status") %>' />
                                                </ItemTemplate>
                          </asp:TemplateField>

                              <asp:BoundField DataField ="first_name" HeaderText ="First Name"/>
                              <asp:BoundField DataField ="last_name" HeaderText ="Last Name"/>
                              <asp:BoundField DataField ="mobile" HeaderText ="Mobile"/>
                              <asp:BoundField DataField ="personal_email" HeaderText ="Email"/>
                              <asp:BoundField DataField ="description" HeaderText ="Description"/>
                              <asp:BoundField DataField="leadsource_name" HeaderText="Lead source" />
                              
                              <asp:BoundField DataField ="leadstatus_name" HeaderText ="Status"/>
                              <asp:BoundField DataField="ExpectedRevenue" HeaderText="ExpRevenue" />
                              <asp:BoundField DataField ="created_on" HeaderText ="created Date" />
                              <asp:BoundField DataField ="created_by" HeaderText ="Created By" />
                           
                         </Columns>
                         </asp:GridView>
        		           
			           </div>

</asp:Content>

