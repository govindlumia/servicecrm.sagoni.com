<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="repaire_invoice_callog.aspx.cs" Inherits="repaire_invoice_callog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div>
<table style="width:100%;background-color:#DDDDDD; border-bottom-color:White; border-bottom-style:solid; border-bottom-width:1px">
 <tr>

<td  style="width:100%; padding-bottom:30px; padding-left:20px; height:0px; padding-top:10px">
<label style=" font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:20px;padding-left:20px">
Repair Invoice Call Logs </label>
   <asp:Label ID="lbl_lead_no" runat="server" Text=""></asp:Label>
</td>
</tr>
 </table>
 <table width="100%">
      <tr>
     <td >
      <asp:GridView ID="grdCalllog" runat="server" 
             AllowSorting="True" AutoGenerateColumns="False"  class="grid" 
             EmptyDataText ="No Record found for the criteria you selected." 
                       
             >
          <Columns>
          <asp:TemplateField HeaderText="Serial No.">
 <ItemTemplate>
 <%#Container.DataItemIndex+1 %>
 </ItemTemplate>
 </asp:TemplateField>
           <asp:BoundField DataField="serial_no" Visible="false" HeaderText="Serial_No" />  
              <asp:BoundField DataField="lead_no" HeaderText="Lead No" /> 
                <asp:BoundField DataField="amount" HeaderText="Total Amt" /> 
               <asp:BoundField DataField="amount_paid" HeaderText="Amt Paid" /> 
                <asp:BoundField DataField="rest_amount" HeaderText="Rest Amt" /> 
                <asp:BoundField DataField="created_by" HeaderText="Created By" />
                <asp:BoundField DataField="invoice_date" HeaderText="Invoice Date" />  
              <asp:BoundField DataField="created_on" HeaderText="Modify Date" />
          
          </Columns>
            </asp:GridView>
            </td>
           </tr></table>
</div>
</asp:Content>

