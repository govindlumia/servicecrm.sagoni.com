<%@ Page Title="::GADGETGOLD TECHNOLOGY - HELPDESK::" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="generate_branch.aspx.cs" Inherits="generate_branch" %>

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
    <link rel="stylesheet" type="text/css" href="../css/menu_style.css" /><script type="text/javascript" src="../Jscript/mtmv.js"></script><link href ="../css/doplus_style.css" rel="stylesheet" type="text/css"/>

  <div class="detailedViewHeader">
  <p class="lvtHeaderText">Create User Login </p>
  </div>
    
<center>
<div class="dvtContentSpace" style="padding:10px 10px 10px 0px;width:99.7%;">
<table width="100%" cellpadding="0" cellspacing="0" class="big" >
  
   <tr>
   <td colspan="4" style="background-color:#DDDCDD; height:30px; padding-left:10px; font-size:13px">
   User Details 
    <asp:Label ID="lblmsg" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
 </td>
   </tr>

   <tr>
    <td valign="middle" class="dvtCellLabel">Employee Name :</td>
    <td valign="middle" class="cellInfo"><asp:TextBox ID="Txtbranchname" runat="server" CssClass="textbox" onBlur="camelcase(this.value, this.id)"></asp:TextBox></td>
   
   <td valign="middle" class="dvtCellLabel">Address: </td>
   <td valign="middle" class="cellInfo" >
   <asp:TextBox ID="txtadd" runat="server" CssClass="textbox" onBlur="camelcase(this.value, this.id)"></asp:TextBox>
     </td>
   </tr>

   <tr>
    <td valign="middle" class="dvtCellLabel">Email :</td>
    <td valign="middle" class="cellInfo1">
    <asp:TextBox ID="Txt_Email" runat="server"  CssClass="textbox" onBlur="camelcase(this.value, this.id)"></asp:TextBox></td>
   
 <td valign="middle" class="dvtCellLabel">Mobile No. :</td>
    <td valign="middle" class="cellInfo1">
<asp:TextBox ID="Txtauthmob" runat="server" CssClass="textbox" MaxLength="10"></asp:TextBox>
<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Txtauthmob"
    ErrorMessage="Please enter a 10 digit number(without std. code)" ValidationExpression="^[0-9]{10}"></asp:RegularExpressionValidator>
                
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                             ControlToValidate="Txtauthmob" Display="Dynamic" ErrorMessage="Enter value"></asp:RequiredFieldValidator>
                    
    </td>
   </tr>
     
   
    <tr>
    <td valign="middle" class="dvtCellLabel">User Name :</td>
    <td valign="middle" class="cellInfo1"><asp:TextBox ID="txtBranchuser" runat="server" CssClass="textbox"></asp:TextBox></td>
   
    <td valign="middle" class="dvtCellLabel">Password :</td>
    <td valign="middle" class="cellInfo1"><asp:TextBox ID="Txtpasscode" runat="server" CssClass="textbox"></asp:TextBox></td>
   </tr>
    <tr>
    <td valign="middle" class="dvtCellLabel">Designation :</td>
    <td valign="middle" class="cellInfo1">
    <asp:DropDownList ID="Ddlbranchname" runat="server" Width="220px" BorderWidth="1px" BorderStyle="Solid" BorderColor="#dddddd" CssClass="dropdown"></asp:DropDownList>
    </td>
     <td valign="middle" class="dvtCellLabel"></td>
    <td valign="middle" class="cellInfo1">
    </td>
   </table>

  <table width="100%" cellpadding="0" cellspacing="0" class="big" >
   

   <tr>
   <td valign="middle"  colspan="4" style="padding-bottom:0px; text-align:center; background-color:#DDDCDD; height:55px">
   <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/submitbutton.png" onclick="submit_Click"/>&nbsp;&nbsp;
   <asp:ImageButton ID="reset" runat="server" ImageUrl="~/images/reset.png" 
           OnClick="reset_Click" CausesValidation="False"/>
   </td>
   </tr>

  

   </table>


   

</div>
</center>
</asp:Content>

