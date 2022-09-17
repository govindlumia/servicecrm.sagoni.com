<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Product_Purchase.aspx.cs" Inherits="Inventory_Product_Purchase" Culture ="en-GB" UICulture ="en-GB"%>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register TagPrefix="Ajaxified" Assembly="Ajaxified" Namespace="Ajaxified" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script type="text/javascript">
        function camelcase(input, ctrl) {
            var s = input;

            var result = s.replace(/(?:^|\s)\w/g, function (match) {
                return match.toUpperCase();
            });

            document.getElementById(ctrl).value = result;

        }
   </script>
    <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
    <script type="text/javascript" src="../Jscript/mtmv.js"></script>
    <link href ="../css/doplus_style.css" rel="stylesheet" type="text/css"/>
<div class="wrap">
  <div class="detailedViewHeader">
  <p class="lvtHeaderText">Product Purchase Entry </p>
  <center>
<div class="dvtContentSpace" style="padding:0px 10px 0px 0px;width:99.7%;">
<table width="100%" cellpadding="0" cellspacing="0" class="big" >
  


   <tr>
   <td valign="middle" class="dvtCellLabel">Product Code : </td>
    <td valign="middle" class="cellInfo1" >
    <asp:TextBox ID="Txt_ProductCode" runat="server"  CssClass="textbox padding_left" 
            onBlur="camelcase(this.value, this.id)" ></asp:TextBox><br />
                   <asp:Label ID="lblmsg" runat="server" Visible="False" ForeColor="Red"></asp:Label>

<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" EnableClientScript="true" ControlToValidate="Txt_ProductCode" Display="Dynamic" ErrorMessage="Please Enter Code"></asp:RequiredFieldValidator>
            </td>
    <td valign="middle" class="dvtCellLabel">Brand Name : </td>
    <td valign="middle" class="cellInfo1" >
    <asp:TextBox ID="Txt_BrandName" runat="server"  CssClass="textbox padding_left" 
            onBlur="camelcase(this.value, this.id)" ></asp:TextBox><br />
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" EnableClientScript="true" ControlToValidate="Txt_Model" Display="Dynamic" ErrorMessage="Please Enter Brand"></asp:RequiredFieldValidator>
            </td>
</tr>
<tr>
 <td valign="middle" class="dvtCellLabel">Model :</td>
    <td valign="middle" class="cellInfo1">
<asp:TextBox ID="Txt_Model" runat="server" onkeyup="myFunction(this.id)" class="textbox"></asp:TextBox><br />
 <asp:RequiredFieldValidator ID="rfvLastName" runat="server" EnableClientScript="true" ControlToValidate="Txt_Model" Display="Dynamic" ErrorMessage="Please Enter Model"></asp:RequiredFieldValidator>           
    </td>
    <td valign="middle" class="dvtCellLabel">Product Type :</td>
    <td valign="middle" class="cellInfo1">
     <asp:DropDownList ID="ddlproducttype" runat="server" class="dropdown" style="width:110px" >
                                                                    <asp:ListItem Text="<--Select-->" Value="0" Selected="True"></asp:ListItem>
                                                                    <asp:ListItem Text="Mobile" Value="Mobile"></asp:ListItem>
                                                                    <asp:ListItem Text="SpareParts" Value="SpareParts"></asp:ListItem>
                                                                </asp:DropDownList>
    </td>
    </tr>
    <tr>
    <td valign="middle" class="dvtCellLabel">Spare Parts/Product Name :</td>
    <td valign="middle" class="cellInfo1">
     <asp:TextBox ID="Txt_ProductName" class="textbox" runat="server"></asp:TextBox></td>
     <td valign="middle" class="dvtCellLabel">Product Quantity :</td>
    <td valign="middle" class="cellInfo1">
      <asp:TextBox ID="Txt_qty" class="textbox" runat="server"></asp:TextBox><br />
        <asp:RegularExpressionValidator id="RegularExpressionValidator3" ControlToValidate="Txt_qty" ValidationExpression="\d+" Display="Static"
EnableClientScript="true" ErrorMessage="Please enter numbers only" runat="server"/>
  </td>
   </tr>
    <tr>
    <td valign="middle" class="dvtCellLabel">Product Description :</td>
    <td valign="middle" class="cellInfo1">
      <asp:TextBox ID="Txt_Description" class="textbox" runat="server"></asp:TextBox>
  </td>
    <td valign="middle" class="dvtCellLabel">Selling Price :</td>
    <td valign="middle" class="cellInfo1">
   <asp:TextBox ID="Txt_SellingPrice" runat="server" onkeyup="myFunction(this.id)" class="textbox"></asp:TextBox><br />
   <asp:RegularExpressionValidator id="RegularExpressionValidator1" ControlToValidate="Txt_SellingPrice" ValidationExpression="\d+" Display="Static"
EnableClientScript="true" ErrorMessage="Please enter numbers only" runat="server"/>
    </td>
    </tr>
      <tr>
    <td valign="middle" class="dvtCellLabel">Purchase Price :</td>
    <td valign="middle" class="cellInfo1">
       <asp:TextBox ID="Txt_PurchasePrice" runat="server" onkeyup="myFunction(this.id)" class="textbox"></asp:TextBox><br />
          <asp:RegularExpressionValidator id="RegularExpressionValidator2" ControlToValidate="Txt_PurchasePrice" ValidationExpression="\d+" Display="Static"
EnableClientScript="true" ErrorMessage="Please enter numbers only" runat="server"/>
 </td>
    <td valign="middle" class="dvtCellLabel">Party Name :</td>
    <td valign="middle" class="cellInfo1">
       <asp:TextBox ID="Txt_Partyname" runat="server" onkeyup="myFunction(this.id)" class="textbox"></asp:TextBox></td>
       </tr>
       <tr>
       <td valign="middle" class="dvtCellLabel">Address :</td>
    <td valign="middle" class="cellInfo1">
   <asp:TextBox ID="Txt_Address" runat="server" onkeyup="myFunction(this.id)" TextMode="MultiLine" Height="60px" class="textbox"></asp:TextBox><br />
    </td>
    <td valign="middle" class="dvtCellLabel">Remarks :</td>
    <td valign="middle" class="cellInfo1">
   <asp:TextBox ID="Txt_Remarks" runat="server" onkeyup="myFunction(this.id)" TextMode="MultiLine" Height="60px" class="textbox"></asp:TextBox><br />
    </td>
    </tr>
 </table>

  <table width="100%" cellpadding="0" cellspacing="0" class="big" >
<tr>
   <td valign="middle"  colspan="4" style="padding-bottom:0px; text-align:center; background-color:#DDDCDD; height:55px">

            <asp:ImageButton ID="ImageButton1" runat="server" 
           ImageUrl="~/images/submitbutton.png" onclick="ImageButton1_Click"  />&nbsp;&nbsp;
   <asp:ImageButton ID="reset" runat="server" ImageUrl="~/images/reset.png" 
           CausesValidation="False" />
   </td>
    
   </tr>
 </table>
</div>
</center>
  </div>
</asp:Content>
