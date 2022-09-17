<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="AdminLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">

<link href="css/Style1.css" type="text/css" rel="Stylesheet" />

<head id="Head2" runat="server">
   <link rel="Shortcut Icon" href="images/icon.png" />
    <title>GadgetGold - HelpDesk</title>



   
</head>
<body style="/* background-image:url('images/bg.png'); background-repeat:repeat-x;*/ margin:0px 0px 0px 0px">
    <div id="loginform">
<div id="facebook"><%--<i class="fa fa-facebook"></i>--%>
<div id="connect"><img class="logo_img" src="images/gadget-gold-eservices.png" /></div></div>
<div id="mainlogin">
<!--<div id="or">or</div>-->
<h1>Log in with Gadgetgold HelpDesk</h1>
<form action="#" runat="server">
<%--<input type="text" placeholder="username or email" value="" required>
<input type="password" placeholder="password" value="" required>--%>

<asp:TextBox ID="txtcode" runat="server" placeholder="User Name"  BorderWidth="1px" BorderStyle="None" 
    BorderColor="Transparent"  CssClass="input"></asp:TextBox>

     <asp:RequiredFieldValidator ID="rfvempcode" runat="server" ControlToValidate="txtcode" ForeColor="Red"
   Display="Dynamic" ErrorMessage="Please Enter correct User Id" ValidationGroup="Eng"></asp:RequiredFieldValidator>


<asp:TextBox ID="txtPassword" runat="server" placeholder="Password" BorderWidth="1px" BorderStyle="None" BorderColor="Transparent"   CssClass="input" TextMode="Password"></asp:TextBox>

 <asp:RequiredFieldValidator ID="rfvEngPass" runat="server" ControlToValidate="txtPassword" ForeColor="Red"
   Display="Dynamic" ErrorMessage="Please Enter correct Password" ValidationGroup="Eng"></asp:RequiredFieldValidator>


<%--<button type="submit"><i class="fa fa-arrow-right"></i>Login</button>--%>
<%--<asp:ImageButton ID="ImageButton1" runat="server" onclick="ImageButton1_Click" 
            />--%>

   <br /> <asp:Label ID="lblmsg" runat="server"  Visible="false"  ForeColor="Red"> </asp:Label>
<asp:Button ID="Button1" runat="server" Text="LOG IN" CssClass="login1" 
    Height="38px" Width="85px" onclick="Button1_Click" />
</form>
<div id="note"><a href="https://www.sagoni.com" class="float_left" target="_blank">Need Help ?</a></div>
</div>
</div>
</body>
</html>