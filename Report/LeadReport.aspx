<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LeadReport.aspx.cs" Inherits="Report_LeadReport" Culture ="en-GB" UICulture ="en-GB" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register TagPrefix="Ajaxified" Assembly="Ajaxified" Namespace="Ajaxified" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%-- <link rel="stylesheet" type="text/css"  href="../themes/softed/style.css">--%>
  <%--  <link rel="stylesheet" href="../css/MenuMatic.css" type="text/css" media="screen" charset="utf-8" />--%>
 <script type ="text/javascript" >
     function displayLoadingImage() {
         var imgLoading = document.getElementById("<%=imgLoading.ClientID%>");

         imgLoading.style.visibility = "visible";

     }
 </script>
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
    
  
   <div class ="gridSearch" >
   <table width ="100%">
      
   <tr>
     <td style=" padding-left:20px" >
      <h2>Lead Report</h2>
     </td> 
      <td align ="right">
 <asp:Button ID="btnExcell" runat="server" Text ="Click Export as Excel" 
              onclick="btnExcell_Click" /></td> 
    
   </tr> 
    </table>
   <asp:Panel ID="pnlsearch" runat="server" DefaultButton="cmdSearch">
   <table cellpadding="0" cellspacing="0" width="100%" style ="color:Black; padding-left:10px ">
     <tr>
                  <td align="right"  width="35%">
                        From Date
                        <asp:TextBox ID="txtfromdate" runat="server"></asp:TextBox>
                        <asp:Image runat="Server" ID="Image1" ImageUrl="~/images/cal.gif" />
                        <asp:RequiredFieldValidator ID="rfv_fromdate" runat="server" SetFocusOnError="true"
                            ControlToValidate="txtfromdate" Display="Dynamic" ErrorMessage="Enter From Date"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="cmv_fromdate" ControlToValidate="txtfromdate" Operator="DataTypeCheck"
                            Type="Date" ErrorMessage="Enter Valid Date" Display="Dynamic" runat="server"
                            SetFocusOnError="true"></asp:CompareValidator>
                        <ajaxtoolkit:CalendarExtender ID="calendarextender1" runat="server" TargetControlID="txtfromdate"
                            Format="dd/MM/yyyy" PopupButtonID="image1" />
                       </td>
                       <td  width="20%"> &nbsp;To Date &nbsp;
                        <asp:TextBox ID="txttodate" runat="server"></asp:TextBox>
                        <asp:Image runat="Server" ID="Image2" ImageUrl="~/images/cal.gif" />
                        <asp:RequiredFieldValidator ID="rfv_todate" runat="server" ControlToValidate="txttodate"
                            Display="Dynamic" ErrorMessage="Enter" SetFocusOnError="true"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="cmv_todate" ControlToValidate="txttodate" Operator="DataTypeCheck"
                            Type="Date" ErrorMessage="Valid" Display="Dynamic" runat="server"
                            SetFocusOnError="true"></asp:CompareValidator>
                        <asp:CompareValidator ID="cmv_todate2" ControlToValidate="txttodate" ControlToCompare="txtfromdate"
                            Type="Date" Operator="GreaterThanEqual" Display="Dynamic" ErrorMessage="from date"
                            runat="server" SetFocusOnError="true"></asp:CompareValidator>
                        <ajaxtoolkit:CalendarExtender ID="calendarextender2" runat="server" TargetControlID="txttodate"
                            Format="dd/MM/yyyy" PopupButtonID="image2" />
                    </td>
                    <td style="width:15%;padding-top:5px; padding-bottom:5px" align="left"  ></td>
                </tr>
		        <tr>

        <td align="left"style="width:20%;padding-top:5px; padding-bottom:5px" >  Lead Status:
<asp:DropDownList id="ddlLeadStatus" class="small" runat ="server"   AutoPostBack ="false" 
                Width="150px">
</asp:DropDownList> 
</td>  

                                        
 </tr>

                                         
                     
	        </table>
             <asp:Button  id="cmdSearch" runat =server  Text ="View" 
                            OnClientClick ="return displayLoadingImage();" Width="111px" 
                                                Font-Bold="True" 
         onclick="cmdSearch_Click"  /> 
                           <asp:Image ImageUrl="~/images/rotation.gif"  runat="server"  
                                                id="imgLoading" style="Z-INDEX: 101; LEFT: 424px; VISIBILITY:hidden   ;  

POSITION: absolute; TOP: 240px; width: 60px;"/>
	               
	                                        <asp:Label ID="lblmsg" runat="server" ForeColor="Red" Visible="false"></asp:Label>
	        </asp:Panel> 

   </div> 
   
	           <div class="mGrid1" cellspacing="0" rules="cols" border="1" id="gridCustomers" style="width:100%;border-collapse:collapse;">
                         <asp:GridView ID="grdLead" runat ="server" AutoGenerateColumns ="False"   GridLines ="None"  
                             Width ="100%" 

                                EmptyDataText ="No lead found for the criteria you selected." 
                             onrowcommand="grdLead_RowCommand" 
                            
                           > 
                                
                         <Columns >
                       
                          
                          
                       
                          <asp:TemplateField HeaderText="Lead No.">
                                    <ItemTemplate>
                                       <asp:LinkButton ID="lnkLeadno" Text ='<%#Eval("lead_no") %>' runat="server" CommandName ="Leaddetail" ToolTip ="Click to see Lead Detail" ForeColor =Black   />
                                    </ItemTemplate>
                                </asp:TemplateField>
                         <asp:TemplateField HeaderText ="Lead No."  Visible="false">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblLeadNo" runat="server" Text ='<%#Eval("lead_no") %>' />
                                                </ItemTemplate>
                          </asp:TemplateField>
                                 <asp:TemplateField HeaderText ="Name"  Visible="true">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblname" runat="server" Text ='<%#Eval("first_name") %>' />
                                                </ItemTemplate>
                          </asp:TemplateField>
                          
                              <%--<asp:BoundField DataField ="first_name" HeaderText ="First Name"/>--%>
                                <asp:BoundField DataField ="last_name" HeaderText ="Last Name"/>
                          <asp:BoundField DataField ="company" HeaderText ="Company"/>
                         <asp:TemplateField Visible="true" HeaderText ="Mobile">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblMobile" runat="server" Text ='<%#Eval("mobile") %>' />
                                                </ItemTemplate>
                          </asp:TemplateField>
                         
                         <%--<asp:TemplateField Visible="true" HeaderText ="Email">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblEmail" runat="server" Text ='<%#Eval("personal_email") %>' />
                                                </ItemTemplate>
                          </asp:TemplateField>--%>
                           <%--<asp:BoundField DataField ="description" HeaderText ="Description"/>--%>
                          
                         <asp:BoundField DataField="lead_source" HeaderText="Lead Source" />
                          <asp:TemplateField Visible="true" HeaderText ="Status">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblStatus" runat="server" Text ='<%#Eval("lead_status") %>' />
                                                </ItemTemplate>
                          </asp:TemplateField>
                          <asp:BoundField DataField ="cancel_reason" HeaderText ="Cancel Reason"/>
                           <asp:BoundField DataField="ExpectedRevenue" HeaderText="ExpRevenue" />
                           <asp:BoundField DataField ="created_by" HeaderText ="Created By" />
                           
                             
                           
                           <asp:TemplateField  Visible =false >
                                                <ItemTemplate>
                                                    <asp:Label   ID="lblCustomerType"  runat=server   Text ='<%#Eval("customer_Type") %>' /> 
                                                     
                                                </ItemTemplate>
                          </asp:TemplateField>
                        
                      
                      <%--  <asp:BoundField DataField="Followup_Date" HeaderText="Followup_Date" />--%>
                        <asp:BoundField DataField="expecteddate" HeaderText="Exp Service Date" />                            
                            <%-- <asp:BoundField DataField="promocode" HeaderText="Promo Code" />--%>
                        <%-- <asp:BoundField DataField="businesstype" HeaderText="Business Type" />
                         <asp:BoundField DataField="Probabilty_ages" HeaderText="Probabilty_Lead" />--%>
                           <%--<asp:BoundField DataField="office_name" HeaderText="Office Name" />--%>
                            
                           
                         </Columns>
                         </asp:GridView>
        		           
			           </div>

</asp:Content>

