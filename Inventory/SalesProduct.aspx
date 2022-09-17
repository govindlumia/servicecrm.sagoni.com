<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SalesProduct.aspx.cs" Inherits="Sales_SalesProduct" Culture ="en-GB" UICulture ="en-GB"%>
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
  <p class="lvtHeaderText">Sales </p>
  <center>
<div class="dvtContentSpace" style="padding:0px 10px 0px 0px;width:99.7%;">
<table width="100%" cellpadding="0" cellspacing="0" class="big" >
  


   <tr>
    <td valign="middle" class="dvtCellLabel">Cutomer First Name  : </td>
    <td valign="middle" class="cellInfo1" >
    <asp:TextBox ID="Txt_FirstName" runat="server"  CssClass="textbox padding_left" 
            onBlur="camelcase(this.value, this.id)" ></asp:TextBox><br />
  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" EnableClientScript="true" ControlToValidate="Txt_FirstName" Display="Dynamic" ErrorMessage="Please Enter Name"></asp:RequiredFieldValidator>
          
            </td>
   
 <td valign="middle" class="dvtCellLabel">Cutomer Last Name :</td>
    <td valign="middle" class="cellInfo1">
<asp:TextBox ID="Txt_LastName" runat="server" onkeyup="myFunction(this.id)" class="textbox"></asp:TextBox>
  </td>
   </tr>
   <tr>
    <td valign="middle" class="dvtCellLabel">Address :</td>
     <td valign="middle" class="cellInfo1" >
    <asp:TextBox ID="Txt_Address" runat="server" TextMode="MultiLine" Height="60px"  CssClass="textbox padding_left" 
            onBlur="camelcase(this.value, this.id)" ></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" EnableClientScript="true" ControlToValidate="Txt_Address" Display="Dynamic" ErrorMessage="Please Enter Address"></asp:RequiredFieldValidator>
 </td>
   
    <td valign="middle" class="dvtCellLabel">Mobile No : </td>
    <td valign="middle" class="cellInfo1" >
    <asp:TextBox ID="Txt_Mob" runat="server" MaxLength="10"  CssClass="textbox padding_left" 
            onBlur="camelcase(this.value, this.id)" ></asp:TextBox><br />
<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" EnableClientScript="true" ControlToValidate="Txt_Mob" Display="Dynamic" ErrorMessage="Mobile Number Required"></asp:RequiredFieldValidator>
<br /><asp:RegularExpressionValidator id="RegularExpressionValidator2" ControlToValidate="Txt_Mob" ValidationExpression="\d+" Display="Static"
EnableClientScript="true" ErrorMessage="Please enter numbers only" runat="server"/>
    </td>
   </tr>
    <tr>
    <td valign="middle" class="dvtCellLabel">Telephone No :</td>
    <td valign="middle" class="cellInfo1">
      <asp:TextBox ID="Txt_Telephone" class="textbox" runat="server"></asp:TextBox><br />
<asp:RegularExpressionValidator id="RegularExpressionValidator1" ControlToValidate="Txt_Telephone" ValidationExpression="\d+" Display="Static"
EnableClientScript="true" ErrorMessage="Please enter numbers only" runat="server"/>                                                         
    </td>
    <td valign="middle" class="dvtCellLabel">Email :</td>
    <td valign="middle" class="cellInfo1">
   <asp:TextBox ID="Txt_Email" runat="server" onkeyup="myFunction(this.id)" class="textbox"></asp:TextBox><br />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" 
            ControlToValidate="Txt_Email" runat="server" ErrorMessage="Enter Valid Email" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    </td>
    </tr>
      <tr>
    <td valign="middle" class="dvtCellLabel">Extra Charge :</td>
    <td valign="middle" class="cellInfo1">
     <asp:DropDownList ID="DD_ExtraCharge" runat="server" CssClass="form-control" Style="height:30px;margin-left:20px">
   <asp:ListItem>Extra Charge</asp:ListItem>
   <asp:ListItem>Delivery Charge</asp:ListItem>
   <asp:ListItem>Freight Charge</asp:ListItem>
   <asp:ListItem>Postage And Handling</asp:ListItem>
   <asp:ListItem>Shipping And Handling</asp:ListItem>
   <asp:ListItem>Transport And Handling</asp:ListItem>
   </asp:DropDownList>
 </td>
    <td valign="middle" class="dvtCellLabel">Extra Charge Amount :</td>
    <td valign="middle" class="cellInfo1">
   <asp:TextBox ID="Txt_Extracharge" runat="server" onkeyup="myFunction(this.id)" class="textbox"></asp:TextBox><br />
<asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="Txt_Extracharge"
 ErrorMessage="Numeric & Decimal Values (Like 0.00) are allowed" ValidationExpression="^\d+(\.\d+)?$"></asp:RegularExpressionValidator><br />
<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
ControlToValidate="Txt_Extracharge" Display="Dynamic" ErrorMessage="Enter Extra Charge "></asp:RequiredFieldValidator>

    </td>
    </tr>
 <tr>
    <td valign="middle" class="dvtCellLabel">Total Amount :</td>
<td valign="middle" class="cellInfo1">
   <asp:TextBox ID="Txt_TotalAmount" runat="server" onkeyup="myFunction(this.id)" class="textbox"></asp:TextBox><br />
 <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="Txt_TotalAmount"
 ErrorMessage="Numeric & Decimal Values (Like 0.00) are allowed" ValidationExpression="^\d+(\.\d+)?$"></asp:RegularExpressionValidator><br />
 <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
 ControlToValidate="Txt_TotalAmount" Display="Dynamic" ErrorMessage="Enter Total Amount "></asp:RequiredFieldValidator>
</td>

 <td valign="middle" class="dvtCellLabel">Amount Paid :</td>
    <td valign="middle" class="cellInfo1">
   <asp:TextBox ID="Txt_AmountPaid" runat="server" onKeyUp="javascript:Add();"
           class="textbox"></asp:TextBox><br />
  <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" ControlToValidate="Txt_AmountPaid"
 ErrorMessage="Numeric & Decimal Values (Like 0.00) are allowed" ValidationExpression="^\d+(\.\d+)?$"></asp:RegularExpressionValidator><br />
 <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
 ControlToValidate="Txt_AmountPaid" Display="Dynamic" ErrorMessage="Enter Paid Amount"></asp:RequiredFieldValidator>
        </td>
   
   
  
    </tr>
      
    <tr>
    <td valign="middle" class="dvtCellLabel">Description :</td>
    <td valign="middle" class="cellInfo1">
    <asp:TextBox class="textbox" TextMode="MultiLine" Height="60px" ID="txtDescription"
                                                                    runat="server"></asp:TextBox> </td>
   
    <td valign="middle" class="dvtCellLabel"><font color="red"></font>Rest Amount :</td>
    <td valign="middle" class="cellInfo1">
   <asp:TextBox ID="Txt_RestAmount"  runat="server" 
           class="textbox"></asp:TextBox><br />
           <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" ControlToValidate="Txt_RestAmount"
 ErrorMessage="Numeric & Decimal Values (Like 0.00) are allowed" ValidationExpression="^\d+(\.\d+)?$"></asp:RegularExpressionValidator><br />
 <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
 ControlToValidate="Txt_RestAmount" Display="Dynamic" ErrorMessage="Enter Rest Amount"></asp:RequiredFieldValidator>                                                                  
 </td>
   </tr>
   <tr>
    
    <td valign="middle" class="dvtCellLabel">Remarks :</td>
    <td valign="middle" class="cellInfo1">
    <asp:TextBox ID="Txt_Remarks"  runat="server" 
           class="textbox"></asp:TextBox>
 </td>   
 <td valign="middle" class="dvtCellLabel">CST (%) :</td>
<td valign="middle" class="cellInfo1">
 <asp:TextBox ID="Txt_CST"  runat="server" 
           class="textbox"></asp:TextBox><br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="Txt_CST"
 ErrorMessage="Numeric & Decimal Values (Like 0.00) are allowed" ValidationExpression="^\d+(\.\d+)?$"></asp:RegularExpressionValidator><br />

 <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
ControlToValidate="Txt_CST" Display="Dynamic" ErrorMessage="Enter CST Amount "></asp:RequiredFieldValidator>
</td>
   </tr>
   <tr>
    <td valign="middle" class="dvtCellLabel">VAT (%) :</td>
    <td valign="middle" class="cellInfo1">
     <asp:TextBox ID="Txt_VAT" runat="server" class="textbox"></asp:TextBox><br />
      <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="Txt_VAT"
 ErrorMessage="Numeric & Decimal Values (Like 0.00) are allowed" ValidationExpression="^\d+(\.\d+)?$"></asp:RegularExpressionValidator><br />
  <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
ControlToValidate="Txt_VAT" Display="Dynamic" ErrorMessage="Enter VAT Amount"></asp:RequiredFieldValidator>
        </td>
    <td valign="middle" class="dvtCellLabel">TAX (%) :</td>
    <td valign="middle" class="cellInfo1">
     <asp:TextBox ID="Txt_TAX" runat="server" class="textbox"></asp:TextBox><br />
      <asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server" ControlToValidate="Txt_TAX"
 ErrorMessage="Numeric & Decimal Values (Like 0.00) are allowed" ValidationExpression="^\d+(\.\d+)?$"></asp:RegularExpressionValidator><br />

 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
ControlToValidate="Txt_TAX" Display="Dynamic" ErrorMessage="Enter TAX "></asp:RequiredFieldValidator>
        </td>
  </tr>
  <tr>
   <asp:gridview ID="Gridview1" runat="server" ShowFooter="true" 
            AutoGenerateColumns="false" OnRowDeleting="grvStudentDetails_RowDeleting" 
           HeaderStyle-BackColor="#CECECE" HeaderStyle-BorderWidth="0.5px"
           Width="100%" style="margin-top:50px" 
          onselectedindexchanged="Gridview1_SelectedIndexChanged" >
            <Columns>
            <asp:BoundField DataField="RowNumber" HeaderText="S.no" ItemStyle-Width="15px" />
           <asp:TemplateField HeaderText="Code" ItemStyle-Width="80px" >
                <ItemTemplate>
                    <asp:TextBox ID="Txt_ProductCode" runat="server" Width="80px"  Placeholder="Code"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
                     <asp:TemplateField HeaderText="Particular" ItemStyle-Width="390px" >
                <ItemTemplate>
                    <asp:TextBox ID="Txt_ProductName" runat="server" Width="385px" Placeholder=" Particular" Height="60px" TextMode="MultiLine"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="Qnty" ItemStyle-Width="95px">
                <ItemTemplate>
                    <asp:TextBox ID="Txt_Quantity" runat="server" Width="93px" Placeholder="Qnty" style="margin-top:14px"></asp:TextBox>
                    <span>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" Font-Size="8px" ControlToValidate="Txt_Quantity"
 ErrorMessage="Enter Numeric Value" ValidationExpression="^\d+(\.\d+)?$"></asp:RegularExpressionValidator>
<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
ControlToValidate="Txt_Quantity" Display="Dynamic" ErrorMessage="Enter Numeric Value" Font-Size="8px"></asp:RequiredFieldValidator> 
</span>  
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Amt" ItemStyle-Width="95px">
                <ItemTemplate>
                    <asp:TextBox ID="Txt_SellingPrice" runat="server" Width="93px" Placeholder=" Amt"  style="margin-top:14px; margin-left:1px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" 
        runat="server" ControlToValidate="Txt_SellingPrice"
 ErrorMessage="Enter Numeric Value" ValidationExpression="^\d+(\.\d+)?$" 
        Font-Size="8px"></asp:RegularExpressionValidator>
 <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
ControlToValidate="Txt_SellingPrice" Display="Dynamic" ErrorMessage="Enter Numeric Value" Font-Size="8px"></asp:RequiredFieldValidator>
                </ItemTemplate>
            </asp:TemplateField>
           
              <asp:TemplateField HeaderText="Discount(%)" ItemStyle-Width="20px">
                <ItemTemplate>
                    <asp:TextBox ID="Txt_Discount" runat="server" Width="100%"  style="margin-top:12px;" Text="0"></asp:TextBox>
                 <span>   <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" Font-Size="8px" ControlToValidate="Txt_Discount"
 ErrorMessage="Enter Numeric Value" ValidationExpression="^\d+(\.\d+)?$"></asp:RegularExpressionValidator>
<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
ControlToValidate="Txt_Discount" Display="Dynamic" ErrorMessage="Enter Numeric Value" Font-Size="8px"></asp:RequiredFieldValidator>   
           </span>     </ItemTemplate>
                <FooterStyle HorizontalAlign="Center" />
                <FooterTemplate>
                 <asp:Button ID="ButtonAdd" runat="server" Text="ADD" onclick="ButtonAdd_Click"
                      style="width:50px;height:25px ;background-color:#3498db ;color: #ffffff"  />
                </FooterTemplate>
            </asp:TemplateField>
           
                <asp:TemplateField HeaderText="Total Amount" ItemStyle-Width="80px">
             <ItemTemplate>
                 <asp:Label ID="LblTotal" runat="server" Text="0"></asp:Label>
             </ItemTemplate>
             <FooterStyle HorizontalAlign="Center" />
              <FooterTemplate>
              <asp:Button ID="Submit_Btn1" runat="server" Text="CALCULATE" OnClick="Submit_Btn1_Click"
                        style="width:100px;height:25px ;background-color:#3498db ;color: #ffffff"  />
             
        </FooterTemplate>
            </asp:TemplateField>
           

             <asp:CommandField ShowDeleteButton="True" ButtonType="Button" DeleteText="Remove"  ControlStyle-ForeColor="Maroon" />
            </Columns>
          
        </asp:gridview>
   </tr>
 </table>

  <table width="100%" cellpadding="0" cellspacing="0" class="big" >
<tr>
   <td valign="middle"  colspan="4" style="padding-bottom:0px; text-align:center; background-color:#DDDCDD; height:55px">
   <asp:ImageButton ID="ImageButton5" runat="server" 
           ImageUrl="~/images/submitbutton.png" onclick="ImageButton5_Click"  />&nbsp;&nbsp;
   <asp:ImageButton ID="reset" runat="server" ImageUrl="~/images/reset.png" 
            CausesValidation="False" onclick="reset_Click" />
       <asp:Label ID="lbldate" runat="server" Text="" Visible="false"></asp:Label>
   </td>
    
   </tr>
 </table>
</div>
</center>
  </div>
    
</asp:Content>

