<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="View_Sales_Product.aspx.cs" Inherits="Inventory_View_Sales_Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
<script type="text/javascript" src="../Jscript/mtmv.js"></script>
<link href ="../css/doplus_style.css" rel="stylesheet" type="text/css"/>
 
<br /><br />  
<div class="detailedViewHeader">
<p class="lvtHeaderText"> View Sales Details </p>
</div>

 <center>
 
<div class="dvtContentSpace" style="padding:10px 10px 10px 10px">

<table width="100%" cellpadding="0" cellspacing="0" class="big">
  
   <tr>
   <td valign="middle" class="dvtCellLabeltop">Search : </td>
   <td valign="middle" class="cellInfo" style="width:350px">
    <asp:TextBox ID="Txt_Search" runat="server" CssClass="textbox"></asp:TextBox>
      <asp:Button ID="View" runat="server" Font-Bold="true" 
                           ForeColor="Black" Font-Size="10pt" Text="View" 
             Width="100px" Height="25px" style="border-radius:4px" onclick="View_Click" 
           />    
   </td>
  
 </tr>
<%-- <tr>
 <td valign="middle" class="dvtCellLabeltop">&nbsp;</td>
 <td valign="middle" class="dvtCellLabeltop" >
  
 
 
 </td>
 </tr>--%>


 <tr>
 <td colspan="4" style="padding-top:20px">
  <table width="100%" cellpadding="0" cellspacing="0" class="big" >
   
   <tr>
 <td valign="middle" class="dvtCellLabeltop">
 
 <div class="mGrid1"    id="Div1" style="width:100%;border-collapse:collapse; padding-top:0px"">
<asp:GridView ID="GridView1" runat ="server" AutoGenerateColumns ="False"   GridLines ="None" AllowPaging ="false" Width="100%" 
EmptyDataText ="No lead found for the criteria you selected."  CssClass="mGrid" PagerStyle-CssClass="pgr" onrowcommand="GridView1_RowCommand" 
PageSize="15"  onrowdeleting="GridView1_RowDeleting" onpageindexchanging="GridView1_PageIndexChanging" > 
                                
                         <Columns >
                           <asp:TemplateField  HeaderText ="PRINT" >
                                                <ItemTemplate>
            <asp:ImageButton ID="imgInvoice" ImageUrl ="~/images/quotation-icon.jpg" runat="server" CommandName ="PRINT" ToolTip ="Click to Print" CausesValidation ="false"   /> 
                                                     
                                                </ItemTemplate>

  </asp:TemplateField>
                          
                       <asp:TemplateField HeaderText="sno" Visible= "false">
                                    <ItemTemplate>
                                     <asp:Label ID="lblserialno" runat="server" Text ='<%#Eval("s_no") %>' />
                                      
                                    </ItemTemplate>
                                </asp:TemplateField>
                           
                                 <asp:BoundField DataField ="Invoice_No" HeaderText ="Invoice No"/>
                                 <asp:BoundField DataField ="Purchaser_Name" HeaderText ="Purchaser Name"/>
                                 <asp:BoundField DataField ="address" HeaderText ="Address"/>
                                 <asp:BoundField DataField ="mobile" HeaderText ="Mobile" />
                                 <asp:BoundField DataField ="email" HeaderText ="Email"/>
                                 <asp:BoundField DataField ="total_amount" HeaderText ="Total Amount"/>
                                 <asp:BoundField DataField ="amount_paid" HeaderText ="Amount Paid"/>
                                 <asp:BoundField DataField ="rest_amount" HeaderText ="Rest Amount"/>    
                                 <asp:BoundField DataField ="created_on" HeaderText =" Date"/>     
                                             <asp:TemplateField  HeaderText ="Delete" >
                                                <ItemTemplate>
                           <asp:ImageButton ID="imgInvoic" ImageUrl ="~/images/deletedata.png" runat="server" CommandName ="Delete" ToolTip ="Click to Delete" CausesValidation ="false"   /> 
                                                                   
                                                </ItemTemplate>

  </asp:TemplateField>        
                                
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

