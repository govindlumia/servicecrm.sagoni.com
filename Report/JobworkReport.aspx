<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="JobworkReport.aspx.cs" Inherits="Report_JobworkReport" Culture ="en-GB" UICulture ="en-GB" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register TagPrefix="Ajaxified" Assembly="Ajaxified" Namespace="Ajaxified" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
  <script type="text/javascript" src="../Jscript/mtmv.js"></script>
  <link href ="../css/doplus_style.css" rel="stylesheet" type="text/css"/>
   
    <div class ="gridSearch" >
   <table width ="100%">
      
   <tr>
     <td style=" padding-left:-20px" >
      <h2>Job Work Report</h2>
     </td> 
      <td align ="right">
 <asp:Button ID="btnExcell" runat="server" Text ="Click Export as Excel" onclick="btnExcell_Click" 
               /></td> 
    
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

        <td align="left"style="width:20%;padding-top:5px; padding-bottom:5px" >  Repair Status:
<asp:DropDownList id="ddlRepairstatus" class="small" runat ="server"   AutoPostBack ="false" 
                Width="150px">
</asp:DropDownList> 
</td>  

                                        
 </tr>

                                         
                     
	        </table>
             <asp:Button  id="cmdSearch" runat =server  Text ="View" 
                            OnClientClick ="return displayLoadingImage();" Width="111px" 
                                                Font-Bold="True" onclick="cmdSearch_Click" 
          /> 
                           <asp:Image ImageUrl="~/images/rotation.gif"  runat="server"  
                                                id="imgLoading" style="Z-INDEX: 101; LEFT: 424px; VISIBILITY:hidden   ;  

POSITION: absolute; TOP: 240px; width: 60px;"/>
	               
	                                        <asp:Label ID="lblmsg" runat="server" ForeColor="Red" Visible="false"></asp:Label>
	        </asp:Panel> 

   </div>
   <div class="mGrid" cellspacing="0" rules="cols" border="1" id="gridCustomers" style="width:100%;border-collapse:collapse;">
                         <asp:GridView ID="grdLead" runat ="server" AutoGenerateColumns ="False"   GridLines ="None"  
                             Width ="100%" 

                                EmptyDataText ="No lead found for the criteria you selected." 
                           
                            
                           > 
                                
                         <Columns >
                       
                          
                          
                       
                          <asp:TemplateField HeaderText="Lead">
                                    <ItemTemplate>
                                       <asp:LinkButton ID="lnkLeadno" Text ='<%#Eval("requestId") %>' runat="server" CommandName ="Leaddetail" ToolTip ="Click to see Lead Detail" ForeColor =Black   />
                                    </ItemTemplate>
                                </asp:TemplateField>
                        
                                
                          
                             
                      
                              <asp:BoundField DataField ="Gadgettype" HeaderText ="Gadget Type"/>
                                <asp:BoundField DataField ="Device_status" HeaderText ="Status"/>
                                <asp:BoundField DataField ="Entry_status" HeaderText ="Entry Status"/>
                          <asp:BoundField DataField ="Issue" HeaderText ="Issue"/>
                                  <asp:BoundField DataField ="equipmentreturn_reason" HeaderText ="Status"/> 
                                    <asp:BoundField DataField ="repairreason_code" HeaderText ="Repairreason"/>                                
                         <asp:BoundField DataField ="Pickuptime" HeaderText ="Pickup Date"/>                   
                          <asp:BoundField DataField ="inTime" HeaderText ="InTime Date"/>
                           <asp:BoundField DataField ="outTime" HeaderText ="OutTime Date" />
                          <asp:BoundField DataField ="StoreRemarks" HeaderText ="StoreRemarks" />                   
                           <asp:BoundField DataField="Brand" HeaderText="Brand" />
                           
                                    <asp:BoundField DataField ="Model" HeaderText ="Model"/>
                            <asp:BoundField DataField ="IMIE_NO" HeaderText ="IMIE NO"/>
                             <asp:BoundField DataField ="Screen" HeaderText ="Screen"/>
                                <asp:BoundField DataField ="Battery_Serial_No" HeaderText ="Battery Serial No"/>
                       <asp:BoundField DataField ="Back_cover" HeaderText ="Back cover"/>
                              <%--  <asp:BoundField DataField ="Pickup_Engineer" HeaderText ="Pickup Engineer"/>
                                <asp:BoundField DataField ="chipEngineer" HeaderText ="chipEngineer"/>
                                 <asp:BoundField DataField ="software_engg" HeaderText ="Software_Engineer"/>
                                 <asp:BoundField DataField ="QualitycheckEngineer" HeaderText ="QualitycheckEngineer"/>
                          <asp:BoundField DataField ="DeliveryEngineer" HeaderText ="DeliveryEngineer"/>               --%>  
                           <asp:BoundField DataField="phone_rent_status" HeaderText="Phone In Rent" />
                           
                        <asp:BoundField DataField ="created_by" HeaderText ="Created By" />   
                                      
                          
                            
                           
                         
                        
                     
                           
                         </Columns>
                         </asp:GridView>
        		           
			           </div>
</asp:Content>

