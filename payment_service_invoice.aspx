<%@ Page Language="C#" AutoEventWireup="true" CodeFile="payment_service_invoice.aspx.cs" Inherits="payment_service_invoice" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
 <title>SERVICE INVOICE DETAILS</title>
   <link rel="Shortcut Icon" href="images/icon.png" />
    <style type="text/css">
#wrapper{
		width:800px;
		margin:0px auto;
		font:11px tahoma, Arial, Helvetica, sans-serif;
		}

        .style1
        {
            height: 63px;
        }

    </style>
</head>
<body style="margin:5px 0px 0px 0px">
    <form id="form1" runat="server">
    <center>
    <div id="wrapper">
    <table width="100%" cellpadding="2" cellspacing="0" style=" border: 1px solid #8C8C8C;padding:2px 2px 2px 2px ">
    <tr>
    <td valign="top" style="text-align:center">
    <table>
    <tr>
    <td valign="middle" style="width:400px; text-align:left; padding-left:5px">
     <img alt="" src="images/gadget_logo.png" width="294px" height="90px"/>
    </td>
    <td valign="middle" style="width:400px; text-align:right; padding-right:10px">
<%--    <img alt="" src="images/doplus_invoice.png" width="172px" height="50px"/>
--%>    </td>
    </tr>
    </table>
   
    </td>
    </tr>

    <tr>
    <td>
    <%-- INVOICE DETAILS--%>
    
    <table width="100%" cellpadding="0" cellspacing="0" style="border:1px solid #8C8C8C">
    <tr>
    <td colspan="2" style="padding-bottom:2px; text-align:left; font-size:12px; padding-left:2px; text-align:left; padding-top:3px; background-color:#CECECE; border-bottom:1px solid #8C8C8C"><b>Billing Details</b>
    <b style="padding-left:225px">SERVICE&nbsp; INVOICE</b>
    </td>
    </tr>

    <tr>
    <td valign="middle" style="width:480px; padding-left:5px; padding-top:10px; padding-bottom:10px; text-align:left">
    <table cellspacing="0" cellpadding="4" style="float:left; width:325px; line-height:16px" border="1" bordercolor="#8C8C8C" >
	<tr>
    <td width="110" valign="top" bgcolor="#CECECE">Customer Name : </td>
	<td width="225" valign="top"><asp:Label ID="lblCompName1" runat="server" ></asp:Label></td>
	</tr>

    <tr>
    <td width="110" valign="top" bgcolor="#CECECE">Contact No. :</td>
    <td width="225" valign="top"><asp:Label ID="lblMobile1" runat="server" ></asp:Label></td>
	</tr>
    <tr>
    <td width="110" valign="top" bgcolor="#CECECE">Address :</td>
    <td width="225" valign="top"><asp:Label ID="lblemail1" runat="server" ></asp:Label></td>
	</tr>
   
   </table>
    </td>
    <td valign="top" style="width:400px; padding-right:5px; padding-top:10px; padding-bottom:10px; text-align:left">
    <table cellspacing="0" cellpadding="4" style="float:right; width:325px; line-height:16px" border="1" bordercolor="#8C8C8C" >
	
     <tr>
    <td width="110" valign="top" bgcolor="#CECECE">Invoice Date :</td>
    <td valign="top"><asp:Label ID="lblDate1" runat="server" ></asp:Label></td>
	</tr>
    
    <tr>
    <td width="110" valign="top" bgcolor="#CECECE">Invoice No. :</td>
    <td valign="top"><asp:Label ID="lblInvoiceNo1" runat="server" ></asp:Label></td>
	</tr>
   
    <tr>
    <td width="110" valign="top" bgcolor="#CECECE">Service Tax No. :</td>
    <td valign="top"><asp:Label ID="lbltinno1" runat="server" ></asp:Label></td>
    </tr>

    </table>
    </td>
    </tr>

    </table>

    <%--INVOICE DETAILS ENDS--%>
    </td>
    </tr>

    <tr>
    <td valign="middle">
    
    <%--SERVICE DETAILS--%>

    <table width="100%" cellpadding="2" cellspacing="0" style="border:1px solid #8C8C8C">
    <tr>
    <td colspan="3" style="padding-bottom:5px; text-align:left; font-size:12px; padding-left:5px; text-align:left; padding-top:5px; background-color:#CECECE; border-bottom:1px solid #8C8C8C"><b>Services  Details</b></td>
    </tr>
    <tr style="height:23px">
    <td style="border:1px solid #8C8C8C; text-align:center; width:200px"><b>No Of Device</b></td>
    <td style="border:1px solid #8C8C8C; text-align:center; width:200px"><b>Service Type</b></td> 
    <td style="border:1px solid #8C8C8C; text-align:center; width:400px"><b>Service Description</b></td> 
    
    </tr>

    <tr style="height:25px">
    <td style="border:1px solid #8C8C8C; text-align:center; width:200px"> <asp:Label ID="lblservicetype1" runat="server" ></asp:Label> </td> 
    <td style="border:1px solid #8C8C8C; text-align:center; width:200px"><asp:Label ID="lblremarks1" runat="server"></asp:Label></td>
    <td style="border:1px solid #8C8C8C; text-align:center; width:400px"><asp:Label ID="lblDescription1" runat="server" ></asp:Label></td> 
    
    </tr>
    
    <tr>
    <td valign="top" colspan="3" style="text-align:left;">
    <table width="100%" cellpadding="0" cellspacing="0" style="margin-top:-2px">
	<tr>
	<td valign="top" style="padding:5px; width:388px;border-top:1px solid #8C8C8C;">
    <table width="100%">
    <tr>
    <td valign="middle" style="height:20px; color:#d40000"><b>FOR CREDIT TO</b> </td>
    </tr>
    <tr>
    <td valign="top">
    <b>Company Name &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :</b> &nbsp;GADGETGOLD <br />
    <b>Name Of the Bank &nbsp;:</b> &nbsp; xxxxxxxxx <br />
    <b>Branch &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :</b>  &nbsp; xxxxxxxxx  <br />
    <b>Account Number&nbsp;&nbsp;&nbsp;&nbsp;:</b> &nbsp; xxxxxxxxx <br />
    <b>RTGS/NEFT IFSC&nbsp;&nbsp;&nbsp;&nbsp; :</b> &nbsp; xxxxxxxxx
    </td>
    </tr>
    </table>  

    </td>
	<td valign="top" style="border-top:1px solid #8C8C8C; text-align:right; padding-left:140px;">
    <table cellpadding="0"  cellspacing="0" style="width:250px; line-height:20px; margin-right:-3px; margin-bottom:-3px">
	<tr>
    <td width="60%" align="left" bgcolor="#E1E1E1" style="border-left:2px solid #8C8C8C;border-bottom:2px solid #8C8C8C; padding-left:5px"> Sub-Total :</td>
    <td width="40%"  style="border-right:2px solid #8C8C8C;border-bottom:2px solid #8C8C8C; border-left:2px solid #8C8C8C" align="center"><asp:Label ID="lblquotamt1" runat="server" ></asp:Label></td>
    </tr>
    <tr>
    <asp:Panel runat="server" ID="pnldiscount" Visible="false">
    <td width="60%" bgcolor="#E1E1E1" align="left" style="border-left:2px solid #8C8C8C;border-bottom:2px solid #8C8C8C; padding-left:5px" ><asp:Label ID="lbldiscount1" runat="server" ></asp:Label></td>
    <td width="40%"  style="border-right:2px solid #8C8C8C;border-bottom:2px solid #8C8C8C; border-left:2px solid #8C8C8C" align="center"><asp:Label ID="lbldisamount1" runat="server" ></asp:Label></td>
    
    </asp:Panel>
    </tr>

    <%--<tr>
    <td width="60%" bgcolor="#E1E1E1" align="left" style="border-left:2px solid #8C8C8C;border-bottom:2px solid #8C8C8C; padding-left:5px" >Sub Total :</td>
    <td width="40%"  style="border-right:2px solid #8C8C8C;border-bottom:2px solid #8C8C8C; border-left:2px solid #8C8C8C" align="center"><asp:Label ID="lblSubTotal1" runat="server" ></asp:Label></td>
    </tr>--%>
    
    <tr>
    <td width="60%" bgcolor="#E1E1E1" align="left" style="border-left:2px solid #8C8C8C;border-bottom:2px solid #8C8C8C; padding-left:5px" >Service Tax @ 14.00%</td>
    <td  style="border-right:2px solid #8C8C8C;border-bottom:2px solid #8C8C8C;border-left:2px solid #8C8C8C" align="center"><asp:Label ID="lblservicetax1" runat="server" ></asp:Label></td>
    </tr>

    <tr>
    <td bgcolor="#E1E1E1" width="60%" align="left" style=" border-left:2px solid #8C8C8C;border-bottom:2px solid #8C8C8C; padding-left:5px">GRAND TOTAL :</td>
    <td  style=" border-right:2px solid #8C8C8C; border-bottom:2px solid #8C8C8C;border-left:2px solid #8C8C8C" align="center"><asp:Label ID="lblGrandTotal1" runat=server ></asp:Label></td>
    </tr>
   <%-- <tr>
    <td bgcolor="#E1E1E1" width="46%" align="left" style=" border-left:2px solid #8C8C8C;border-bottom:2px solid #8C8C8C; padding-left:5px">Received Amount : </td>
    <td  style=" border-right:2px solid #8C8C8C; border-bottom:2px solid #8C8C8C;border-left:2px solid #8C8C8C" align="center"><asp:Label ID="lblReceivedamount1" runat="server" ></asp:Label></td>
    </tr>--%>
	</table>
		
		
		
		</td>
	</tr></table>
    </td>
    </tr>

    </table>

    </td>
    </tr>

    <tr style="height:30px">
   
    <td valign="middle" style="height:10px; color:#000; padding-left:5px" >
    <b>Service Tax No. : </b> xxxxxxxx &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    <b>PAN No. : </b> xxxxxxxxxx
    </td>
    
    </tr>

    <tr>
    <td valign="top">
    <table width="100%" cellpadding="0" cellspacing="0" style=" border:1px solid #8C8C8C ; background-color:#E1E1E1">
	<tr>
	<td valign="middle" width="55%" class="style1">
    
    <p align="left" style="margin-left:5px; margin-top:-5px"> <br />
	<strong>SPJ GADGET</strong>
    </p>
	<p align="left" style="font-size:10px; margin-top:-10px; margin-left:5px">
 Corporate office:Villa no. 4 , Basement , block no. 5 | Opposite Charmwood Plaza <br />Eros Garden,
                                                       Faridabad | Haryana (India)
    <br />+91 - 9136- 537527 |0129 - 4023102
    <br />  info@gadgetgold.in | www.gadgetgold.in

  
    
    </p>

    </td>
	<td width="45%" style="text-align:right; padding-right:10%" class="style1">
    <b>This is Computer Generated Invoice . No Need Of Any Kind Of Signature.</b>
    </td>
	</tr>
    </table>
    </td>
    </tr>

    </table>
    


    </div>
    </center>
    </form>
</body>
</html>
