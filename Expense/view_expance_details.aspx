<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="view_expance_details.aspx.cs" Inherits="Expense_view_expance_details" Culture ="en-GB" UICulture ="en-GB"%>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register TagPrefix="Ajaxified" Assembly="Ajaxified" Namespace="Ajaxified" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
<script type="text/javascript" src="../Jscript/mtmv.js"></script>
<link href ="../css/doplus_style.css" rel="stylesheet" type="text/css"/>
 
<br /><br />  
<div class="detailedViewHeader">
<p class="lvtHeaderText"> View Expense Details </p>
</div>

 <center>
 
<div class="dvtContentSpace" style="padding:10px 10px 10px 10px">

<table width="100%" cellpadding="0" cellspacing="0" class="big">
  
   <tr>
   <td valign="middle" class="dvtCellLabeltop">FROM : </td>
   <td valign="middle" class="cellInfo" style="width:350px">
    <asp:TextBox ID="txtfromdate" runat="server" CssClass="date_textbox"></asp:TextBox>
           <asp:RequiredFieldValidator ID="rfv_fromdate" runat="server" SetFocusOnError="true"
                            ControlToValidate="txtfromdate" Display="Dynamic" ErrorMessage="Enter From Date"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="cmv_fromdate" ControlToValidate="txtfromdate" Operator="DataTypeCheck"
                            Type="Date" ErrorMessage="Enter Valid Date" Display="Dynamic" runat="server"
                            SetFocusOnError="true"></asp:CompareValidator>
                        <ajaxtoolkit:CalendarExtender ID="calendarextender3" runat="server" TargetControlID="txtfromdate"
                            Format="dd/MM/yyyy" PopupButtonID="txtfromdate" />

   </td>
   <td valign="middle" class="dvtCellLabeltop" style="width:150px; padding-left:10px">TO :</td>
   <td valign="middle" class="cellInfo">
    <asp:TextBox ID="txttodate" runat="server" CssClass="date_textbox"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfv_todate" runat="server" ControlToValidate="txttodate"
                            Display="Dynamic" ErrorMessage="Enter To Date" SetFocusOnError="true"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="cmv_todate" ControlToValidate="txttodate" Operator="DataTypeCheck"
                            Type="Date" ErrorMessage="Enter Valid Date" Display="Dynamic" runat="server"
                            SetFocusOnError="true"></asp:CompareValidator>
                        <asp:CompareValidator ID="cmv_todate2" ControlToValidate="txttodate" ControlToCompare="txtfromdate"
                            Type="Date" Operator="GreaterThanEqual" Display="Dynamic" ErrorMessage="This Date cannot be less than from date"
                            runat="server" SetFocusOnError="true"></asp:CompareValidator>
                        <ajaxtoolkit:calendarextender ID="calendarextender2" runat="server" TargetControlID="txttodate"
                            Format="dd/MM/yyyy" PopupButtonID="txttodate" />

                                
 </td>
 </tr>
 <tr>
 <td colspan="4" align="center" class="dvtCellLabel">
  <asp:Button ID="View" runat="server" Font-Bold="true" 
                           ForeColor="Black" Font-Size="10pt" Text="View" 
             Width="100px" onclick="View_Click"  Height="25px" style="border-radius:4px; margin-right:500px"    />
 
 
 </td>
 </tr>


 <tr>
 <td colspan="4" style="padding-top:20px">
  <table width="100%" cellpadding="0" cellspacing="0" class="big" >
   
   <tr>
 <td valign="middle" class="dvtCellLabeltop">
 
 <div class="mGrid1"    id="Div1" style="width:100%;border-collapse:collapse; padding-top:0px"">
    <asp:GridView ID="GridView1" runat ="server" AutoGenerateColumns ="False"   GridLines ="None"  
         AllowPaging ="false" Width="100%" EmptyDataText ="No lead found for the criteria you selected."  CssClass="mGrid"
            PagerStyle-CssClass="pgr" onrowcommand="GridView1_RowCommand" PageSize="15" > 
                                
                         <Columns >
                         <asp:TemplateField  HeaderText ="Action">
                                                <ItemTemplate>
               <asp:ImageButton ID="imgEdit" ImageUrl ="~/images/edit.png" runat="server" CommandName ="edit" ToolTip ="Click to edit" CausesValidation ="false"   /> 
                                                     
                                                   
                                                </ItemTemplate>
                          </asp:TemplateField>
                          
                      
                           <asp:TemplateField HeaderText="sno" Visible= "false">
                                    <ItemTemplate>
                                     <asp:Label ID="lblserialno" runat="server" Text ='<%#Eval("sno") %>' />
                                      
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:BoundField DataField ="Receiver_Name" HeaderText ="Name"/>
                                 <asp:BoundField DataField ="Purpose" HeaderText ="Purpose"/>
                                 <asp:BoundField DataField ="Remarks" HeaderText ="Remarks" ItemStyle-Width="15%"/>
                                 <asp:BoundField DataField ="amount" HeaderText ="Total Amt"/>
                              <asp:BoundField DataField ="collected_amount" HeaderText ="Given Amt"/>
                              <asp:BoundField DataField ="due_amount" HeaderText ="Dues Amt"/>
                                 <asp:BoundField DataField ="mode_of_payment" HeaderText ="Pay Mode"/>
                                 <asp:BoundField DataField ="Expence_date" HeaderText =" Expence Date"/>    
                                 <asp:BoundField DataField ="created_on" HeaderText =" Date"/>     
                                          
                                
                         </Columns>
                            


                         </asp:GridView>
        		           
			           </div>

 </td>
  
 </tr>

  </table>
   </td>
   </tr>

</table>
</div>


   
 </center>

</asp:Content>


