<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CreateLead.aspx.cs" Inherits="Sales_CreateLead"  Culture ="en-GB" UICulture ="en-GB"%>
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
  <p class="lvtHeaderText">Create Lead </p>
  </div>
    
<center>
<div class="dvtContentSpace" style="padding:0px 10px 0px 0px;width:99.7%;">
<table width="100%" cellpadding="0" cellspacing="0" class="big" >
  
   <tr>
   <td colspan="4" style="padding: 2px 5px 2px 5px ">
  <div align="center">
 <asp:Button ID="btn_calllog" runat="server" Text="Call Log" ForeColor="#000000" 
 Width="148px" Font-Bold="True" CausesValidation="False" onclick="btn_calllog_Click"  />
 <asp:Label ID="lblCreatedBy" runat="server" Visible="true"></asp:Label><br />
<asp:Label ID="lblmsg" runat="server" Visible="true" ForeColor="Red"></asp:Label>
</div>
 </td>
 </tr>
<tr>
 <td class="detailedViewHeader" colspan="4" align="right">
<b>Lead No : -</b>&nbsp;&nbsp;&nbsp;&nbsp;  <asp:Label ID="lblLead_no" runat="server" Text= "Auto Genrate on Save"  ></asp:Label> 
</td>
</tr>
   <tr>
    <td valign="middle" class="dvtCellLabel">First Name : </td>
    <td valign="middle" class="cellInfo1" >
     <asp:DropDownList ID="ddlTitle" runat="server" class="dropdown" style="width:60px" >
                                                                   <%-- <asp:ListItem Text="<--Select-->" Value="0" Selected="True"></asp:ListItem>--%>
                                                                    <asp:ListItem Text="Mr." Value="Mr."></asp:ListItem>
                                                                    <asp:ListItem Text="Mrs." Value="Mrs."></asp:ListItem>
                                                                    <asp:ListItem Text="Miss." Value="Ms."></asp:ListItem>
                                                                    <asp:ListItem Text="Dr." Value="Dr."></asp:ListItem>
                                                                </asp:DropDownList>
    <asp:TextBox ID="txtFirstName" runat="server"  CssClass="textbox padding_left" 
            onBlur="camelcase(this.value, this.id)" ></asp:TextBox><br />
             <asp:RequiredFieldValidator ID="rfvLastName" runat="server" EnableClientScript="true"
                             ControlToValidate="txtFirstName" Display="Dynamic" ErrorMessage="Please Enter First Name"></asp:RequiredFieldValidator></td>
   
 <td valign="middle" class="dvtCellLabel">Last Name :</td>
    <td valign="middle" class="cellInfo1">
<asp:TextBox ID="txtLastName" runat="server" onkeyup="myFunction(this.id)" class="textbox"></asp:TextBox>
                                                            <br />
                                                            
                                                                

                    
    </td>
   </tr>
     
   
    <tr>
    <td valign="middle" class="dvtCellLabel">Mobile :</td>
    <td valign="middle" class="cellInfo1">
    <asp:TextBox ID="txtMobile" class="textbox" runat="server" MaxLength="10"></asp:TextBox><br />
    <asp:RegularExpressionValidator id="RegularExpressionValidator2" 
                   ControlToValidate="txtMobile"
                   ValidationExpression="\d+"
                   Display="Static"
                   EnableClientScript="true"
                   ErrorMessage="Please Enter Valid Number Only"
                   runat="server"/>
                                                              <%--  <ajaxtoolkit:textboxwatermarkextender id="TBWtxtMobile" runat="server" targetcontrolid="txtMobile"
                                                                    watermarktext="10 Digits" /><br />--%>
                                                            <%--    <asp:Label ID="lblMobile" Text="mobile no/Phone no." Visible="true" runat="server"
                                                                    ForeColor="Red"></asp:Label>--%>
                                                                <%--<asp:RequiredFieldValidator ID="rfvMobile" runat =server ControlToValidate ="txtMobile"  ErrorMessage ="Enter Mobile" Display =Dynamic></asp:RequiredFieldValidator>--%>
                                                                <%--<asp:RegularExpressionValidator ID="reMobile" runat="server" ControlToValidate="txtMobile"
                                                                    ErrorMessage="10 digit number" ValidationExpression="^[0-9]{10}"></asp:RegularExpressionValidator>--%>
    </td>
   
    <td valign="middle" class="dvtCellLabel">Phone :</td>
    <td valign="middle" class="cellInfo1">
     <asp:TextBox ID="txtPhone" class="textbox" runat="server"></asp:TextBox><br />
    </td>
   </tr>
    <tr>
    <td valign="middle" class="dvtCellLabel">Email :</td>
    <td valign="middle" class="cellInfo1">
      <asp:TextBox ID="txtEmail" class="textbox" runat="server"></asp:TextBox>
                                                                <ajaxtoolkit:textboxwatermarkextender id="TBWtxtEmail" runat="server" targetcontrolid="txtEmail"
                                                                    watermarktext="Email"  />
                                                                <br />
 <asp:RegularExpressionValidator ID="regEmail" runat="server" ErrorMessage="Valid Email"
Visible="true" ControlToValidate="txtEmail" Display="Dynamic" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                                           
    </td>
    <td valign="middle" class="dvtCellLabel">Company/Organization :</td>
    <td valign="middle" class="cellInfo1">
   <asp:TextBox ID="txtCompany" runat="server" onkeyup="myFunction(this.id)" class="textbox"></asp:TextBox>
   
    </td>
    </tr>
      <tr>
    <td valign="middle" class="dvtCellLabel">Lead Source :</td>
    <td valign="middle" class="cellInfo1">
     <asp:DropDownList ID="ddlLeadSource" class="dropdown" runat="server" ></asp:DropDownList><br />
<asp:RequiredFieldValidator ID="rfvLeadSource" runat="server" ErrorMessage="Select lead source"
 ControlToValidate="ddlLeadSource" Display="Dynamic" InitialValue="0"></asp:RequiredFieldValidator>
 </td>
    <td valign="middle" class="dvtCellLabel">Expected Revenue :</td>
    <td valign="middle" class="cellInfo1">
   <asp:TextBox ID="txtExpRevenue" runat="server" onkeyup="myFunction(this.id)" class="textbox"></asp:TextBox><br />
 <%--<asp:RangeValidator ID="rvExpRevenue" runat="server" ErrorMessage=""
Visible="true" ControlToValidate="txtExpRevenue" Display="Dynamic" MinimumValue="0"
 MaximumValue="999999" Type="Integer"></asp:RangeValidator>--%>
 <asp:RegularExpressionValidator id="RegularExpressionValidator1"
                   ControlToValidate="txtExpRevenue"
                   ValidationExpression="\d+"
                   Display="Static"
                   EnableClientScript="true"
                   ErrorMessage="Please enter numbers only"
                   runat="server"/>
 <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtExpRevenue"
Display="Dynamic" ErrorMessage="Amount" Visible="true"></asp:RequiredFieldValidator>
    </td>
    </tr>
 <tr>
    <td valign="middle" class="dvtCellLabel">Lead Status :</td>
<td valign="middle" class="cellInfo1">
<asp:DropDownList ID="ddlLeadStatus" class="dropdown" runat="server"  
        AutoPostBack="true" onselectedindexchanged="ddlLeadStatus_SelectedIndexChanged">
</asp:DropDownList><br />
<asp:DropDownList ID="ddlReason" class="dropdown" runat="server"  AutoPostBack="false" Visible="false">
</asp:DropDownList>
</td>

 <td valign="middle" class="dvtCellLabel">FollowUp Date :</td>
    <td valign="middle" class="cellInfo1">
     <asp:Panel ID="Panel1" runat="server" Visible="true">
     <asp:TextBox ID="txtfolowupdate" runat="server" class="textbox" ></asp:TextBox>
     <ajaxtoolkit:CalendarExtender ID="calendarextender1" runat="server" Format="dd/MM/yyyy" PopupButtonID="txtfolowupdate" TargetControlID="txtfolowupdate" />
    <asp:TextBox ID="txtExpecteddate" runat="server" class="textbox" Height="1px" Width="1px"  Visible="false"></asp:TextBox>
   <ajaxtoolkit:CalendarExtender ID="calendarextender3" runat="server" Format="dd/MM/yyyy" PopupButtonID="txtExpecteddate" TargetControlID="txtExpecteddate" />
   </asp:Panel>
        </td>
   
   
  
    </tr>
      
    <tr>
    <td valign="middle" class="dvtCellLabel">Description :</td>
    <td valign="middle" class="cellInfo1">
    <asp:TextBox class="textbox" TextMode="MultiLine" Height="60px" ID="txtDescription"
                                                                    runat="server"></asp:TextBox> </td>
   
    <td valign="middle" class="dvtCellLabel"><font color="red"></font>Addres<br />
                                                                                                                              
                                                                Near By Location / Land Mark :</td>
    <td valign="middle" class="cellInfo1">
    <asp:TextBox class="textbox" style="height:60px" runat="server" ID="txthouseno" TextMode="MultiLine"></asp:TextBox>                                                                  
 </td>
   </tr>
   <tr>
    
    <td valign="middle" class="dvtCellLabel">State :</td>
    <td valign="middle" class="cellInfo1">
<asp:DropDownList ID="ddlState" class="dropdown" runat="server"></asp:DropDownList>
 </td>   
 <td valign="middle" class="dvtCellLabel">City :</td>
<td valign="middle" class="cellInfo1">
<asp:DropDownList ID="ddlCity" class="dropdown" runat="server"> </asp:DropDownList>

</td>
   </tr>
   <tr>
    <td valign="middle" class="dvtCellLabel">Pin Code :</td>
    <td valign="middle" class="cellInfo1">
     <asp:TextBox ID="txtpin" runat="server" MaxLength="6" class="textbox"></asp:TextBox>
        </td>
    <td valign="middle" class="dvtCellLabel">Service Type :</td>
    <td valign="middle" class="cellInfo1">
     <asp:DropDownList ID="ddServicetype" class="dropdown" runat="server"></asp:DropDownList><br />

        </td>
  </tr>
   <asp:Panel ID="pickup" runat="server" Visible="false">
  <tr>
   
   
    <td valign="middle" class="dvtCellLabel">Pickup Executive :</td>
    <td valign="middle" class="cellInfo1">
     <asp:DropDownList ID="ddlpickupexe" class="dropdown" runat="server"></asp:DropDownList>

        </td>
         <td valign="middle" class="dvtCellLabel"></td>
    <td valign="middle" class="cellInfo1">
    

        </td>
  </tr>
  </asp:Panel>
 </table>

  <table width="100%" cellpadding="0" cellspacing="0" class="big" >
<tr>
   <td valign="middle"  colspan="4" style="padding-bottom:0px; text-align:center; background-color:#DDDCDD; height:55px">
   <asp:ImageButton ID="ImageButton5" runat="server" 
           ImageUrl="~/images/submitbutton.png" onclick="ImageButton5_Click"  />&nbsp;&nbsp;

            <asp:ImageButton ID="ImageButton1" runat="server" 
           ImageUrl="~/images/submitbutton.png"  Visible="false" 
           CausesValidation="False" onclick="ImageButton1_Click"  />&nbsp;&nbsp;
   <asp:ImageButton ID="reset" runat="server" ImageUrl="~/images/reset.png" 
           onclick="reset_Click" CausesValidation="False" />
   </td>
    
   </tr>
 </table>
</div>
</center>
</div>
</asp:Content>

