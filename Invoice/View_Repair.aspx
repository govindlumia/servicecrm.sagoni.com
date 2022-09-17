<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="View_Repair.aspx.cs" Inherits="View_Repair"Culture="en-GB" UICulture="en-GB"  %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register TagPrefix="Ajaxified" Assembly="Ajaxified" Namespace="Ajaxified" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%--<link rel="stylesheet" type="text/css"  href="../themes/softed/style.css">--%>
    <%--  <asp:ListItem Text="Free trial 30 days" Value="5"></asp:ListItem>--%>
 <script type ="text/javascript" >
     function displayLoadingImage() {
         var imgLoading = document.getElementById("<%=imgLoading.ClientID%>");

         imgLoading.style.visibility = "visible";

     }
 </script>
   <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
  <script type="text/javascript" src="../Jscript/mtmv.js"></script>
  <link href ="../css/doplus_style.css" rel="stylesheet" type="text/css"/>
<script type ="text/ecmascript" >
    var _Page = '0';
    var _StartsWith = 'All';

    var _SearchText = '';

    function NavigateToLetter(ltr) {

        _Page = 0;
        _StartsWith = ltr;

        DoNavigate();

        //        alert(url);
        //        return;
    }
    function DoNavigate() {
        var url = 'leadReport.aspx'

        url = url + '?firstname=' + _StartsWith;

        location.href = url;
    }


    

</script>
    
  
   
   <div class ="gridSearch" >
   <table width =100%>
      
   <tr>
     <td style="padding-left:30px" >
      <h2>Repair Invoice List&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </h2>
     </td> 
      <td align =right >
        <%--  <asp:Button ID="btnLead_create" runat="server" Text="Create Lead" 
              onclick="btnLead_create_Click" />--%>
       </td> 
    
   </tr> 
    </table>
   <%--<asp:Panel ID="pnlsearch" runat=server DefaultButton=cmdSearch>--%>
   <table cellpadding="0" cellspacing="0" width="100%" style ="color:Black ">
     <tr>
                    <td align="right">
                        From&nbsp;
                        <asp:TextBox ID="txtfromdate" runat="server" 
                            ></asp:TextBox>
                        <asp:Image runat="Server" ID="Image1" ImageUrl="~/images/cal.gif" />
                        <asp:RequiredFieldValidator ID="rfv_fromdate" runat="server" SetFocusOnError="true"
                            ControlToValidate="txtfromdate" Display="Dynamic" ErrorMessage="Enter From Date"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="cmv_fromdate" ControlToValidate="txtfromdate" Operator="DataTypeCheck"
                            Type="Date" ErrorMessage="Enter Valid Date" Display="Dynamic" runat="server"
                            SetFocusOnError="true"></asp:CompareValidator>
                        <ajaxtoolkit:calendarextender ID="calendarextender1" runat="server" TargetControlID="txtfromdate"
                            Format="dd/MM/yyyy" PopupButtonID="image1" />
                       </td><td> To &nbsp;
                        <asp:TextBox ID="txttodate" runat="server" 
                          style="height: 22px"
                            ></asp:TextBox>
                        <asp:Image runat="Server" ID="Image2" ImageUrl="~/images/cal.gif" />
                        <asp:RequiredFieldValidator ID="rfv_todate" runat="server" ControlToValidate="txttodate"
                            Display="Dynamic" ErrorMessage="Enter To Date" SetFocusOnError="true"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="cmv_todate" ControlToValidate="txttodate" Operator="DataTypeCheck"
                            Type="Date" ErrorMessage="Enter Valid Date" Display="Dynamic" runat="server"
                            SetFocusOnError="true"></asp:CompareValidator>
                        <asp:CompareValidator ID="cmv_todate2" ControlToValidate="txttodate" ControlToCompare="txtfromdate"
                            Type="Date" Operator="GreaterThanEqual" Display="Dynamic" ErrorMessage="This Date cannot be less than from date"
                            runat="server" SetFocusOnError="true"></asp:CompareValidator>
                        <ajaxtoolkit:calendarextender ID="calendarextender2" runat="server" TargetControlID="txttodate"
                            Format="dd/MM/yyyy" PopupButtonID="image2" />
                    </td>
                </tr>
		         
  <tr> <td style="width:40%;" align="right" >
                                         Search(Request ID)&nbsp;
                                         <asp:TextBox ID="txtSearch" runat="server"  width="147px" 
                                         CausesValidation="True"></asp:TextBox>&nbsp;</td>
                                                <td align="" colspan="2"  style="padding-left:30px">
                                                    <asp:Button ID="cmdSearch" runat="server" 
                                                        OnClientClick="return displayLoadingImage();" Text="View" Width="110px" onclick="cmdSearch_Click"  
                                                        />
                                                    <asp:Image ID="imgLoading" runat="server" ImageUrl="~/images/rotation.gif" style="Z-INDEX: 101; LEFT: 391px; VISIBILITY:hidden;  

POSITION: absolute; TOP: 241px; height: 60px;" /> <asp:Label ID="lblmsg" runat="server" Visible="false"  Text="" foreColor="Red"></asp:Label>
                                                </td>
                                            </tr>
       </caption>
       </tr>
	        </table>
	       <%-- </asp:Panel>--%> 

   </div>

     <div class="mGrid" cellspacing="0" rules="cols" border="1" id="gridCustomers" style="width:100%;border-collapse:collapse;">
                         <asp:GridView ID="grdLead" runat =server AutoGenerateColumns =False   GridLines =None  
                             Width =100%

                                EmptyDataText ="No lead found for the criteria you selected." 
 
                          ShowFooter= "true" onrowcommand="grdLead_RowCommand" 
                             onpageindexchanging="grdLead_PageIndexChanging" 
                             onrowdatabound="grdLead_RowDataBound" onrowediting="grdLead_RowEditing" > 
                               <FooterStyle BackColor="#CCCC99" HorizontalAlign="Right" Font-Bold =true />
                         <Columns >
                         <asp:TemplateField  HeaderText ="Edit">
                                                <ItemTemplate>
               <asp:ImageButton ID="imgEdit" ImageUrl ="~/images/edit_icon.png" runat="server" CommandName ="edit" ToolTip ="Click to edit" CausesValidation ="false"   /> 
                                                     
                                                   
                                                </ItemTemplate>

                          </asp:TemplateField>
                           <asp:TemplateField  HeaderText ="Print" >
                                                <ItemTemplate>
            <asp:ImageButton ID="imgInvoice" ImageUrl ="~/images/pdf.png" runat="server" CommandName ="print"  CausesValidation ="false"   /> 
                                                     
                                                </ItemTemplate>

<ItemStyle Width="10px"></ItemStyle>
                          </asp:TemplateField>
                          
                       <asp:TemplateField HeaderText="serial_no" Visible="false">
                                    <ItemTemplate>
                                     <asp:Label ID="lblserialno" runat="server" Text ='<%#Eval("serial_no") %>' />
                                      
                                    </ItemTemplate>
                                </asp:TemplateField>
                           <asp:TemplateField HeaderText="Lead">
                                    <ItemTemplate>
                                     <asp:Label ID="lblticketid" runat="server" Text ='<%#Eval("lead_no") %>' />
                                      
                                    </ItemTemplate>
                                </asp:TemplateField>
                   <asp:BoundField DataField ="invoice_no" HeaderText ="Invoice"/>  
                                 <asp:TemplateField HeaderText ="Customer"  Visible="true">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblname" runat="server" Text ='<%#Eval("customerName ") %>' />
                                                </ItemTemplate>
                          </asp:TemplateField>

                      
                         <asp:BoundField DataField ="mobile_no" HeaderText ="Mobile"/>
                     <%-- <asp:BoundField DataField ="address" HeaderText ="Address"/> --%>
                        
                            <asp:BoundField DataField ="NoOfNode" HeaderText ="Unit"/>            
                           <asp:BoundField DataField ="amount" HeaderText ="Amount"/>
                             <asp:BoundField DataField ="item" HeaderText ="Product Details"/>
                           
                                 <%-- <asp:TemplateField HeaderText ="Payment Status"  Visible="true">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblpaymentstatus" runat="server" Text ='<%#Eval("paymentstatus") %>' />
                                                </ItemTemplate>
                          </asp:TemplateField>--%>

                                  <asp:BoundField DataField ="invoice_date" HeaderText ="Date"/>  


                                   

                                 <%-- <asp:BoundField DataField ="paymentstatus" HeaderText ="Payment Status"/>  --%>
                                <%--  <asp:BoundField DataField ="created_by" 
                                 HeaderText ="Created_by"/>  --%>
                                   
                        <%-- <asp:TemplateField HeaderText ="month"  Visible="false">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblcreatedmonth" runat="server" Text ='<%#Eval("created_month") %>' />
                                                </ItemTemplate>
                          </asp:TemplateField>--%>
                           <%--<asp:TemplateField HeaderText ="year"  Visible="false">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblcreatedyear" runat="server" Text ='<%#Eval("created_year") %>' />
                                                </ItemTemplate>
                          </asp:TemplateField>--%>
                           
                         </Columns>
                         </asp:GridView>
        		           
			           </div>
 
</asp:Content>

