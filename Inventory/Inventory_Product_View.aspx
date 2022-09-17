<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Inventory_Product_View.aspx.cs" Inherits="Inventory_Purchase_Product_View" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
<script type="text/javascript" src="../Jscript/mtmv.js"></script>
<link href ="../css/doplus_style.css" rel="stylesheet" type="text/css"/>
 
<br /><br />  
<div class="detailedViewHeader">
<p class="lvtHeaderText"> View Inventory Details </p>
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
             Width="100px" Height="25px" style="border-radius:4px" 
         onclick="View_Click"    />    
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
                                 <asp:BoundField DataField ="product_code" HeaderText ="Product Code"/>
                                 <asp:BoundField DataField ="product_name" HeaderText ="Product Name"/>
                                 <asp:BoundField DataField ="product_type" HeaderText ="Product Type"/>
                                 <asp:BoundField DataField ="brand_name" HeaderText ="Brand Name" />
                                 <asp:BoundField DataField ="model" HeaderText ="Model"/>
                                 <asp:BoundField DataField ="quantity" HeaderText ="Qty"/>
                                 <asp:BoundField DataField ="selling_price" HeaderText ="Sale Price"/>
                                 <asp:BoundField DataField ="purchase_price" HeaderText ="Purchase Price"/>    
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

