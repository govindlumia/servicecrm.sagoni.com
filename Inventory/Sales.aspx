<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Sales.aspx.cs" Inherits="Inventory_Sales" Culture="en-GB" UICulture="en-GB" %>
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
  <p class="lvtHeaderText">Product Inventory </p>
  <center>
<div class="dvtContentSpace" style="padding:0px 10px 0px 0px;width:99.7%;">
<table width="100%" cellpadding="0" cellspacing="0" class="big" >
  


   <tr>
   <td valign="middle" class="dvtCellLabel">Customer First Name : </td>
    <td valign="middle" class="cellInfo1" >
    <asp:TextBox ID="Txt_FirstName" runat="server"  CssClass="textbox padding_left" 
            onBlur="camelcase(this.value, this.id)" ></asp:TextBox><br />
                 <%--  <asp:Label ID="lblmsg" runat="server" Visible="False" ForeColor="Red"></asp:Label>--%>

<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" EnableClientScript="true" ControlToValidate="Txt_FirstName" Display="Dynamic" ErrorMessage="Please Enter Name"></asp:RequiredFieldValidator>
            </td>
    <td valign="middle" class="dvtCellLabel">Customer Last Name : </td>
    <td valign="middle" class="cellInfo1" >
    <asp:TextBox ID="Txt_LastName" runat="server"  CssClass="textbox padding_left" 
            onBlur="camelcase(this.value, this.id)" ></asp:TextBox>
<%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" EnableClientScript="true" ControlToValidate="Txt_LastName" Display="Dynamic" ErrorMessage="Please Enter Brand"></asp:RequiredFieldValidator>
--%>            </td>
</tr>
<tr>
 <td valign="middle" class="dvtCellLabel">Address : </td>
    <td valign="middle" class="cellInfo1" >
    <asp:TextBox ID="Txt_Address" runat="server" TextMode="MultiLine" Height="60px"  CssClass="textbox padding_left" 
            onBlur="camelcase(this.value, this.id)" ></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" EnableClientScript="true" ControlToValidate="Txt_Address" Display="Dynamic" ErrorMessage="Please Enter Address"></asp:RequiredFieldValidator>
</td>
 <td valign="middle" class="dvtCellLabel">Mobile No : </td>
    <td valign="middle" class="cellInfo1" >
    <asp:TextBox ID="Txt_Mob" runat="server" MaxLength="10"  CssClass="textbox padding_left" 
            onBlur="camelcase(this.value, this.id)" ></asp:TextBox>
            </td>
</tr>
<tr>
<td valign="middle" class="dvtCellLabel">Email : </td>
    <td valign="middle" class="cellInfo1" >
    <asp:TextBox ID="Txt_Email" runat="server"   CssClass="textbox padding_left" 
            onBlur="camelcase(this.value, this.id)" ></asp:TextBox>
            </td>
</tr>
</asp:Content>

