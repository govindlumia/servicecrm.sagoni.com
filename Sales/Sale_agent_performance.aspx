<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Sale_agent_performance.aspx.cs" Inherits="Sales_Sale_agent_performance" Culture="en-GB" UICulture="en-GB"%>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register TagPrefix="Ajaxified" Assembly="Ajaxified" Namespace="Ajaxified" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
  <script type="text/javascript" src="../Jscript/mtmv.js"></script>
  <link href ="../css/doplus_style.css" rel="stylesheet" type="text/css"/>
    <div class ="gridSearch" style="height:80px">

 <table style="width:100%">
 <tr>

<td  style="width:100%; padding-bottom:10px; padding-left:10px; padding-top:0px">
<label style=" font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:22px;padding-left:20px"> Agent Performance Snapshot </label>
  
</td>
</tr>
 <tr>
 <td  style=" padding-top:20px; padding-left:300px; width:1108px; color:Black">
 <table>
 <tr> 
 <td><b> Enter Date&nbsp; </b></td> 
 <td>
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:Label ID="lblfrom" runat="server" Text="From"  Font-Bold="true"></asp:Label>
                 
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
 <td>
  <asp:Label ID="lblto" runat="server" Text="To"  Font-Bold="true"></asp:Label>
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
 </td>
 <td>
                           <label style="padding-left:30px"><asp:Button ID="View_show" runat="server" Text="View" 
         onclick="VIEW_CLICK" Width="111px" /></label>  
 </td>
 </tr>
 </table>
 
 

                      
                           



                     
                     
                     
                     
                     
                     
                     
                       </td>

  
 
 <td style=" font-family:Times New Roman; font-size:medium; color:Maroon">
   <%-- <asp:Label ID="lblerror" runat="server" Text="Please Enter the Correct Date"></asp:Label>--%>
</td>
 </tr>
 </table>
 </div>


<div class="mGrid1">
 <div class="mGrid1" cellspacing="0" rules="cols"  border="1" id="Div3" style="width:100%;border-collapse:collapse; padding-left:2px; padding-top:0px">
                         <asp:GridView ID="grdvassigntech" runat ="server" 
                             AutoGenerateColumns ="False"   GridLines ="None"  
                             Width ="100%"
                             ShowFooter= "true"   
                                EmptyDataText ="No lead found for the criteria you selected." 
                             BorderColor="#CCCCCC" 
                             BorderStyle="None" onrowdatabound="grdvassigntech_RowDataBound" 
                             onrowcommand="grdvassigntech_RowCommand" onselectedindexchanged="grdvassigntech_SelectedIndexChanged" 
                             > 
                               <FooterStyle BackColor="#CCCC99" HorizontalAlign="left" Font-Bold ="true" />  
                         <Columns >
                           <asp:TemplateField  HeaderText ="View">
                                                <ItemTemplate>
               <asp:ImageButton ID="imgEdit" ImageUrl ="~/images/quotation-icon.jpg" runat="server" CommandName ="edit" ToolTip ="Click to edit" CausesValidation ="false"   /> 
                                                     
                                                   
                                                </ItemTemplate>
                          </asp:TemplateField>
                       
                           <asp:TemplateField HeaderText ="Name"  Visible="false">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblcreate" runat="server" Text ='<%#Eval("created_by") %>' />
                                                </ItemTemplate>
                          </asp:TemplateField>
                          
                          <asp:BoundField DataField ="createdby" HeaderText ="Agent Name"/>     
                         <asp:BoundField DataField ="totallead" HeaderText ="Total Lead"/>
                          <asp:BoundField DataField ="converted_lead" HeaderText ="Converted Lead"/>
                           <asp:BoundField DataField ="Conversion" HeaderText ="% of Conversion"/>

                          <asp:BoundField DataField ="converted_amount" HeaderText ="Converted Amount"/>
                          
                           
                         </Columns>
                         </asp:GridView>
        		           
			           
 </div></div>

</asp:Content>

