<%@ Page Language="C#" AutoEventWireup="true" CodeFile="print_Sales_Product.aspx.cs" Inherits="print_Sales_Product" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<title> INVOICE DETAILS </title>
  <link rel="Shortcut Icon" href="images/icon.png" />
  <link rel="stylesheet" href="css/crm_style.css" />
<style type="text/css">
#wrapper{
		width:970px;
		margin:0px auto;
		font:11px tahoma, Arial, Helvetica, sans-serif;
		}
#header_left{
		float:left;
		width:322px;
	
		}
#header_left p{
		margin:0px 0px 0px 0px;
		font:10px Arial, Helvetica, sans-serif;
		}
#header_left h5{
		font:bold 12px Arial, Helvetica, sans-serif;
		margin:5px 0px;
		}
#header_right{
		float:right;
		}
.clear{
		clear:both;
		}
		
    </style>
</head>
<body>
<form id="form1" runat ="server" >
<div id="wrapper">
<table width="100%" cellpadding="2" cellspacing="0" style="margin-top:0px; font-size:15px; font-family:Arial helvetica Sans-Serif"  border="1" bordercolor="#C3C3C3">
<tr>
<td>

<!--endheader-->
<table>
    <tr>
    <td>
         <asp:Image ID="q" ImageUrl="images/gadget_logo.png" runat="server" Width="350px" Height="100px"/>
        </td>
     <td style="width:55%;"></td>
     <td style="width:55%;">
    <table style="font-size:18px; margin-left: 0px;">
    <tr><td width="500px">Website : www.gadgetgold.in</td> </tr>
    <%--<tr><td width="500px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: </td> </tr>--%>
    <tr><td width="500px">Email&nbsp;&nbsp;&nbsp; : info@gadgetgold.in</td> </tr>
<%--  <tr><td width="500px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: support@spjgadget.com</td> </tr>--%>
    <%--  <tr><td width="500px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: accounts@nikhilglass.com</td> </tr>--%>
   
   <tr> <td width="500px">Mobile&nbsp;&nbsp;:  0129 - 4023102  </td> </tr>
   <tr> <td width="500px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: +91 - 9136- 537527 </td> </tr>
<%--   <tr> <td width="500px">Phone(Off): 011-29835079 </td> </tr>--%>
<%--   <tr> <td width="500px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: 011-41716139</td> </tr>
--%>    <tr><td><asp:Label ID="lbladdresss" runat="server" ></asp:Label></td></tr>
   
    </table>
    
    </td>
    </tr>
    </table>

<div ><table width="100%" cellpadding="2" cellspacing="0" style="margin-top:5px " border="1" bordercolor="#8C8C8C" >
<tr><td>
<table cellspacing="0" cellpadding="4" style="float:left; margin:0px 0px 0px; width:350px;" border="1" bordercolor="#8C8C8C" >
	<tr> <td width="300" valign="top" >Customer Name </td>
	<td width="250" valign="top" style="height:18px" ><asp:Label ID="lblname" runat="server" ></asp:Label>
    &nbsp;&nbsp;<asp:Label ID="lbl_lastname" runat="server" ></asp:Label> </td>
	</tr>
	<tr><td valign="top" style="height:18px" >Contact No. </td><td valign="top"><asp:Label ID="lblMobile" runat=server ></asp:Label></td>
	</tr>
    
     <tr><td valign="center" style="height:25px">Email ID</td>
    <td valign="center"><asp:Label ID="lblemail" runat="server" ></asp:Label></td>
	</tr>

   <%--  <tr><td valign="middle" style="height:25px">TIN No.</td>
    <td valign="middle" style="padding-left:5px"><asp:Label ID="lbltin" runat="server" ></asp:Label></td>
	</tr>--%>
</table>
<table cellspacing="0" cellpadding="4" style="float:right; margin:0px 0px; width:400px;"border="1" bordercolor="#8C8C8C" >
	<tr><td width="102" valign="top">Serial No.</td>
	<td width="176" style="height:20px" valign="top"><asp:Label ID="lblsno" runat="server" ></asp:Label></td>
	</tr>
    
	<tr><td valign="center" style="height:21px">Invoice No.</td><td valign="center"><asp:Label ID="lblInvoiceNo" runat="server" ></asp:Label></td>
	</tr>
   
    	<tr><td valign="top">Invoice Date</td><td valign="top"><asp:Label ID="lblDate" runat="server" ></asp:Label></td>
	</tr>
  <%--    <tr>
   <td valign="top" style="width:40%">CST No.</td>
   <td valign="top"><asp:Label ID="lblcstno" runat="server" ></asp:Label></td>
	</tr>--%>
</table>
</td></tr></table>
</div>

<table width="100%" cellpadding="0" cellspacing="0" border="0" bordercolor="#8C8C8C">


<tr>
   <td colspan="4" style="padding-top:0px">
  <table width="100%" cellpadding="0" cellspacing="0" class="big" style="margin-left:0px" >
   
   <tr>
 <td valign="middle" class="dvtCellLabeltop">
 <div class="mGrid2" id="Div1" style="width:100%;border-collapse:collapse; padding-top:0px"">


                        <asp:GridView ID="GridView1" runat ="server" AutoGenerateColumns ="False"  GridLines ="None"  font-size="20px"
                         AllowPaging ="false" Width="100%"
                            ShowFooter= "true"   
                                EmptyDataText ="No lead found for the criteria you selected." 
                            
                           
                             
            PagerStyle-CssClass="pgr" onrowdatabound="GridView1_RowDataBound"
                           > 
                             <FooterStyle BackColor="#CCCC99" HorizontalAlign="left" Font-Bold ="true" />        
                         <Columns>

                      
                         
                      
                           <asp:TemplateField HeaderText="sno" Visible= "false">
                                    <ItemTemplate>
                                     <asp:Label ID="lblserialno" runat="server" Text ='<%#Eval("s_id") %>' />
                                      
                                    </ItemTemplate>
                                </asp:TemplateField>
                    
                                 <asp:TemplateField HeaderText="Sno." HeaderStyle-ForeColor="black">
                                        <ItemTemplate>
                                    <%#Container.DataItemIndex+1 %>
                                     </ItemTemplate>
                                      </asp:TemplateField>   
                                 <asp:BoundField DataField ="Product_Code" HeaderText ="Product Code" HeaderStyle-ForeColor="black"/>
                                 <asp:BoundField DataField ="Product_Name" HeaderText ="Product Particular" HeaderStyle-ForeColor="black"/>
                                <%--  <asp:BoundField DataField ="UM" HeaderText ="UM" HeaderStyle-ForeColor="black"/>  --%>
                                 <asp:BoundField DataField ="Quantity" HeaderText ="Quantity" HeaderStyle-ForeColor="black"/>
                                    <asp:BoundField DataField ="Selling_Price" HeaderText ="Amount" HeaderStyle-ForeColor="black"/>
                                  
                                <asp:BoundField DataField ="Discount" HeaderText ="Discount(%)" HeaderStyle-ForeColor="black"/>
                                  <asp:BoundField DataField ="Total_SP" HeaderText ="Total Amount" HeaderStyle-ForeColor="black"/>
                                
                                   
                                  
                                    
                         </Columns>
                            


                         </asp:GridView>
        		           
			           </div>

 </td>
  
 </tr>

  </table>
   </td>
   </tr>
	
	
<tr><td>
	<%--<table width="100%" cellpadding="0" cellspacing="0" height="50">
	<tr>
	<td valign="middle" style="padding:5px">Amount in words:&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblAmtWords" runat="server" ></asp:Label> Rupees Only</td>
	<td width="30%" valign="top">
		<table cellpadding="0"  cellspacing="0" style="width:100px; float:right; border-left:2px solid #8C8C8C;">
		<tr><td style="border-bottom:2px solid #8C8C8C;" align="center">&nbsp;</td></tr>
		<tr><td style="border-bottom:2px solid #8C8C8C;" align="center"><asp:Label ID="lblSubTotal" runat="server" ></asp:Label></td></tr>
		<tr><td style="border-bottom:2px solid #8C8C8C; height:15px" align="center"><asp:Label ID="lblservicetax" runat="server" ></asp:Label></td></tr>
		<tr><td align="center"><asp:Label ID="lblGrandTotal" runat=server ></asp:Label></td></tr>
		</table>
		<table cellpadding="0"  cellspacing="0" style="width:150px; float:right; text-align:right">
		<tr>
		  <td style="border-bottom:2px solid #fff;">&nbsp;</td>
		</tr>
		<tr><td style="border-bottom:2px solid #fff;">SUBTOTAL</td></tr>
		<tr><td style="border-bottom:2px solid #fff;">Service TAX</td></tr>
		<tr><td>TOTAL</td></tr>
		</table>
		</td>
	</tr></table>--%>
    <table width="100%" cellpadding="0" cellspacing="0" height="70" style="line-height:155%">
	<tr>
	<td valign="middle" style="padding:5px"> 
        For Credit to Bank Name : xxxxxxxxxxxx
<br />In favor of : "GADGETGOLD "<br />Bank Account Number: xxxxxxxxxxxxx
    <br />RTGS/NEFT IFSC: xxxxxxxxx</td>
	<td width="30%" valign="top">
		<table cellpadding="0"  cellspacing="0" style="width:250px; float:right; height:80px">
		<%--<tr><td style="border-bottom:2px solid #8C8C8C;" align="center">&nbsp;</td></tr>--%>
		<tr><td width="60%" align="center" style="border-left:2px solid #8C8C8C;border-bottom:2px solid #8C8C8C" >SUBTOTAL</td><td width="63.5%" style="border-right:1px solid #8C8C8C;border-bottom:2px solid #8C8C8C; border-left:2px solid #8C8C8C" align="center"><img src="images/rupee-symbol.png" style="position:absolute;margin-top:6px;margin-left:-9px;width:10px;height:10px"/><asp:Label ID="lblSubTotal" runat=server ></asp:Label></td></tr>
		<tr><td width="60%" align="center" style="border-left:2px solid #8C8C8C;border-bottom:2px solid #8C8C8C" ><asp:Label ID="LBLEXTRA" runat="server" ></asp:Label></td><td width="63.5%" style="border-right:1px solid #8C8C8C;border-bottom:2px solid #8C8C8C; border-left:2px solid #8C8C8C" align="center"><img src="images/rupee-symbol.png" style="position:absolute;margin-top:6px;margin-left:-9px;width:10px;height:10px"/><asp:Label ID="lblextrachargeAMOUNT" runat=server ></asp:Label></td></tr>
	
    <tr><td width="60%"align="center" style="border-left:2px solid #8C8C8C;border-bottom:2px solid #8C8C8C" >VAT @<asp:Label ID="LblVatpt" runat="server" Text=""></asp:Label>%</td><td style="border-right:1px solid #8C8C8C;border-bottom:2px solid #8C8C8C;border-left:2px solid #8C8C8C" align="center"><img src="images/rupee-symbol.png" style="position:absolute;margin-top:6px;margin-left:-9px;width:10px;height:10px"/><asp:Label ID="lblvat" runat="server" ></asp:Label> <asp:Label ID="l1" runat="server"  Visible="false"></asp:Label></td></tr>
        <tr><td width="60%"align="center" style="border-left:2px solid #8C8C8C;border-bottom:2px solid #8C8C8C" >CST @<asp:Label ID="Lblcstpt" runat="server" Text=""></asp:Label>%</td><td style="border-right:1px solid #8C8C8C;border-bottom:2px solid #8C8C8C;border-left:2px solid #8C8C8C" align="center"><img src="images/rupee-symbol.png" style="position:absolute;margin-top:6px;margin-left:-9px;width:10px;height:10px"/><asp:Label ID="lblcst" runat="server" ></asp:Label><asp:Label ID="l2" runat="server"  Visible="false"></asp:Label></td></tr>
<%--        <tr><td width="60%"align="center" style="border-left:2px solid #8C8C8C;border-bottom:2px solid #8C8C8C" >TAX @<asp:Label ID="Lbltaxpt" runat="server" Text=""></asp:Label>%</td><td style="border-right:1px solid #8C8C8C;border-bottom:2px solid #8C8C8C;border-left:2px solid #8C8C8C" align="center"><img src="images/rupee-symbol.png" style="position:absolute;margin-top:6px;margin-left:-9px;width:10px;height:10px"/><asp:Label ID="lbltax" runat="server" ></asp:Label><asp:Label ID="l3" runat="server"  Visible="false"></asp:Label></td></tr>
--%><%--		<tr><td width="60%"align="center" style="border-left:2px solid #8C8C8C;border-bottom:2px solid #8C8C8C" >Insurance @<asp:Label ID="lblinsupt" runat="server" Text=""></asp:Label>%</td><td style="border-right:1px solid #8C8C8C;border-bottom:2px solid #8C8C8C;border-left:2px solid #8C8C8C" align="center"><img src="images/rupee-symbol.png" style="position:absolute;margin-top:6px;margin-left:-9px;width:10px;height:10px"/><asp:Label ID="lblinsu" runat="server" ></asp:Label><asp:Label ID="l4" runat="server"  Visible="false"></asp:Label></td></tr>
--%>        <%--<tr><td width="70%"align="center" style="border-left:2px solid #8C8C8C;border-bottom:2px solid #8C8C8C" >VAT @ 4 %</td><td width="53.5%" style="border-right:1px solid #8C8C8C;border-bottom:2px solid #8C8C8C;border-left:2px solid #8C8C8C" align="center"><asp:Label ID="lblservicetax" runat=server ></asp:Label></td></tr>--%>
		<tr><td width="60%" align="center" style=" border-left:2px solid #8C8C8C;border-bottom:2px solid #8C8C8C">TOTAL</td><td width="53.5%" style=" border-right:1px solid #8C8C8C; border-bottom:2px solid #8C8C8C;border-left:2px solid #8C8C8C" align="center"><img src="images/rupee-symbol.png" style="position:absolute;margin-top:6px;margin-left:-9px;width:10px;height:10px"/><asp:Label ID="lblGrandTotal" runat=server ></asp:Label></td></tr>
		</table>
		<%--<table cellpadding="0"  cellspacing="0" style="width:185px; float:right; text-align:right">
		<tr>
		  <td style="border-bottom:2px solid #fff;">&nbsp;</td>
		</tr>
		<tr><td style="border-bottom:2px solid #fff;">SUBTOTAL</td></tr>
		<tr><td style="border-bottom:2px solid #fff;">VAT @ 5%</td></tr>
		<tr><td>TOTAL</td></tr>
		</table>--%>
		</td>
	</tr></table>
	</td></tr>	
</table>

	

    <%--<table width="100%" cellpadding="2" cellspacing="0" border="1" bordercolor="#8C8C8C">
	<tr><td width="16%" height="30" >For Credit to Bank Name : HDFC BANK LTD. Shop no. 2,3,4,5, Charmwood Bazar,

FARIDABAD-121009,HARYANA<br />In favor of : " NIKHIL GLASS "<br />Bank Account Number: 50200004946490
    <br />RTGS/NEFT IFSC: HDFC0000396</td>
	</tr>
	</table>--%>



	<table width="100%" cellpadding="2" cellspacing="0" style="margin-top:0px" border="1" bordercolor="#c3c3c3">
	<tr>
	<td valign="middle">
    <p style="margin-top:0px;font-size:18px " border="0.7">
	
       
        Service Tax No: xxxxxxxxxxx
       
        <br />
      TIN NO: XXXXXXXXXX <br />
      I E Code No:- XXXXXXXXX <br />
      CERTIFIED ISO 9001 : 2008
      
       
        </p></td>
	<td width="52%" align="center"><p  style="margin-top:-10px;"> <br />
	  <strong style="font-size:18px;">GADGETGOLD</strong></p>
      
	  <p  style="font-size:16px; margin-top:-15px;">
      Villa no. 4 , Basement , block no. 5 | Opposite Charmwood Plaza , Eros Garden
      , | Faridabad | Haryana (India)
    <br />
    www.gadgetgold.in
       </p></td>
	</tr></table>
      <br />
    <table width="100%" cellpadding="2" cellspacing="0" border="1" bordercolor="#c3c3c3" style="padding-top:0px; margin-top:-20px; line-height:155%">
	<tr><td width="16%" height="30" ><b>Terms & Conditions </b><br />
    1. <asp:Label ID="lblAdv" runat="server" ></asp:Label>% Advance with purchase order. <br />
    2. Goods sold are not returnable or refundable.<br />
    3.  Our Responsibility Ceases on the Delivery of goods to you.<br />
   <%-- 4. Toughened glass order require at least up to 7 
        or 8 Working days, After Technical &
       Commercial Clearance. <br />
    5. Goods sold are not returnable or refundable. <br />
    6. Scaffolding/Power supply/Any type of civil work/ template/ Road Form / proper
      storage space etc. if required are to be provided by the party.<br />
        7. Standard measurements and wastage etc. shall be charged.<br />
         8. Our Responsibility Ceases on the Delivery of goods to you.<br />--%>
    </td>
	</tr>
	</table>
    </td></tr></table>
</div>
</form>
</body>
</html>
