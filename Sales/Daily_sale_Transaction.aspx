<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Daily_sale_Transaction.aspx.cs" Inherits="Sales_Daily_sale_Transaction" Culture="en-GB" UICulture="en-GB"%>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register TagPrefix="Ajaxified" Assembly="Ajaxified" Namespace="Ajaxified" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="wrap">
    <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
  <script type="text/javascript" src="../Jscript/mtmv.js"></script>
  <link href ="../css/doplus_style.css" rel="stylesheet" type="text/css"/>
  
    <div class ="gridSearch" style="height:60px">
 <table style="width:100%">
 <tr>

<td  style="width:100%; padding-bottom:0px;  padding-top:0px">
<label style=" font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:22px;padding-left:15px">Total Trasactions </label>
  
</td>
</tr>
 <tr>
 <td  style=" padding-bottom:0px; padding-left:380px; width:1118px; color:Black"><b> Daily Trasactions&nbsp; </b>

                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                     
                        <asp:TextBox ID="txtfromdate" runat="server" 
                           ></asp:TextBox>
                        <asp:Image runat="Server" ID="Image1" ImageUrl="~/images/cal.gif"  />

     <asp:RequiredFieldValidator ID="rfv_fromdate" runat="server" ErrorMessage="Please Enter a valid Date" SetFocusOnError="true"  ControlToValidate="txtfromdate" Display="Dynamic"></asp:RequiredFieldValidator>
     
   
                        <ajaxtoolkit:CalendarExtender ID="calendarextender1" runat="server" TargetControlID="txtfromdate"
                            Format="dd/MM/yyyy" PopupButtonID="image1" />

                           <label style="padding-left:20px"><asp:Button ID="View_show" runat="server" Text="View" 
         onclick="VIEW_CLICK" Width="111px" /></label>  
                       </td>

  
 
 
 </tr>
 </table>
 </div> 
  <div class ="grid" >
 <table width="100%" style=" padding-bottom:0px">
<tr>
<td align="left"  style="font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:16px;padding-left:2px ">
<b> Sale Summary</b>
</td>
<td align="left" style="font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:16px;padding-left:2px "  >
<b> Count</b>
</td>


<td align="left" style="font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:16px;padding-left:2px ">
<b> Amount</b></td>
<td align="left"style="font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:16px;padding-left:2px ">
<b>Conversion</b></td>
</tr>
<tr>
<td align="left"style=" border-style:solid; width: 593px;" >
 Total Leads
</td>
<td  align="left"  >
    <asp:Label ID="lbltlead" runat="server"></asp:Label>
</td>
<td></td>
<td></td>
</tr>
<tr>
<td   align="left" style=" border-style:solid; width: 593px;" >
 Assign-Tech
</td>
<td   align="left"   >
    <asp:Label ID="lblassign" runat="server" ></asp:Label>
</td>

<td   align="left"  >
    <asp:Label ID="lblassignamount" runat="server" ></asp:Label>
</td>
<td   align="left"  style=" border-style:solid" >
    <asp:Label ID="lblassignconversion" runat="server" ></asp:Label>
</td>
</tr>
<tr>
<td align="left" style=" border-style:solid; width: 593px;"  >
Prospect [ Money to be collected ]
</td>
<td   align="left"  >
 <asp:Label ID="lblproscount" runat="server"></asp:Label>
    </td>
    
    <td   align="left" style=" border-style:solid"  >
     <asp:Label ID="lblprosamount" runat="server"></asp:Label>
    </td>
     <td   align="left" style=" border-style:solid"  >
     <asp:Label ID="lblprosconversion" runat="server"></asp:Label>
    </td>
    </tr>
    <tr>
<td   align="left" style=" width: 593px" >
 Qualified
    [ Money Collected ]
</td>
<td   align="left"   >
 <asp:Label ID="lblqulicount" runat="server"></asp:Label>
</td>

<td   align="left"  >
 <asp:Label ID="lblquliamount" runat="server"></asp:Label>
</td>
<td   align="left"  >
 <asp:Label ID="lblquliconversion" runat="server"></asp:Label>
</td>
</tr>



</table>
</div>
<div>
<table  width="100%" style=" background-color:#DDDDDD;  height:60px "  >
   
        <tr>
            <td  rowspan= "2" style="width: 70%" >
            <label style=" font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:15pt;padding-left:20px" >Assign Tech</label>
        
            </td>
             <td class="total_trasactions">
                 Assign Tech&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                 :&nbsp;&nbsp;
                 <asp:Label ID="lblassign1" runat="server" ></asp:Label>
            </td>
        </tr>
        <tr>
          
            <td class="total_trasactions" align ="left" style="height: 23px">
               Total Amount&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;
                 <asp:Label ID="lblassignamount1" runat="server" ></asp:Label>
            </td>
        </tr>
        </table>

<asp:Panel ID="Pnlassign" runat="server">

<div class="grid" cellspacing="0" rules="cols"  id="Div3" style="border-collapse:collapse; padding-left:0px; padding-top:0px">
                         <asp:GridView ID="grdvassigntech" runat ="server" 
                             AutoGenerateColumns ="False"   GridLines ="None"  
                             Width ="100%"

                                EmptyDataText ="No lead found for the criteria you selected." 
                              BorderColor="#CCCCCC" 
                             BorderStyle="None" onrowdatabound="grdvassigntech_RowDataBound1" > 
                                
                         <Columns >
                            <asp:TemplateField HeaderText="Lead No.">
                                    <ItemTemplate>
                                       <asp:LinkButton ID="lblLeadNo" Text ='<%#Eval("lead_no") %>' runat="server" 
                                            CommandName ="lblLeadNo_Click" ToolTip ="Click to see Lead Detail" ForeColor ="Black" 
                                            onclick="lblLeadNo_Click"/>
                                    </ItemTemplate>
                                </asp:TemplateField>
                       
                          <%--  <asp:TemplateField HeaderText ="Lead No." Visible="false" >
                                                <ItemTemplate>
                                                    <asp:Label ID="lblLeadNo" runat="server" Text ='<%#Eval("lead_no") %>' />
                                                </ItemTemplate>
                          </asp:TemplateField>
                          --%>
                                 <asp:TemplateField HeaderText ="Customer Name"  Visible="true">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblname" runat="server" Text ='<%#Eval("customername") %>' />
                                                </ItemTemplate>
                          </asp:TemplateField>
                           
                          
                          <asp:BoundField DataField ="mobile" HeaderText ="Mobile"/>
                           <asp:BoundField DataField ="amount" HeaderText ="Amount"/>
                           <asp:BoundField DataField ="ExpectedDate" HeaderText ="Expected Time"/>
                           <asp:BoundField DataField ="created_by" HeaderText ="Created By"/>
                            
                            <asp:TemplateField HeaderText ="Status_id"  Visible="false">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblStatus_id" runat="server" Text ='<%#Eval("lead_status") %>' />
                                                </ItemTemplate>
                          </asp:TemplateField>
                         </Columns>
                         </asp:GridView>
        		           
			           
 </div>
  </asp:Panel>

<table width="100%" style=" background-color:#DDDDDD; margin-top:0px; height:60px"  >
   
        <tr>
            <td  rowspan= "2" style="width: 72%"  >
                  <label style=" font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:15pt;padding-left:20px">Prospect</label>
            </td>
             <td class="total_trasactions" style="padding-left:0px" align ="left"> 
                 Lead Prospect&nbsp;&nbsp; :&nbsp;&nbsp; 
                 <asp:Label ID="lblPrsCnt" runat="server" ></asp:Label>
            </td>
        </tr>
        <tr>
          
            <td class="total_trasactions" align ="left" style="padding-left:0px">
              Total Amount&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;                  
                <asp:Label ID="lblPrsamt" runat="server" ></asp:Label>
            </td>
        </tr></table>

    <asp:Panel ID="Pnlpros" runat="server">
   
         
         <div class="grid" cellspacing="0" rules="cols"  id="Div1" style="border-collapse:collapse;padding-left:0px; padding-top:0px">
                         <asp:GridView ID="gredpros" runat ="server" AutoGenerateColumns ="False"   GridLines ="None"  
                             Width ="100%"

                                EmptyDataText ="No lead found for the criteria you selected." 
                             onrowdatabound="gredpros_RowDataBound" 
                           > 
                                
                         <Columns >
                          
                        <asp:TemplateField HeaderText="Lead No.">
                                    <ItemTemplate>
                                       <asp:LinkButton ID="lblLeadNo" Text ='<%#Eval("lead_no") %>' runat="server" 
                                            CommandName ="viewlead" ToolTip ="Click to see Lead Detail" 
                                            ForeColor ="Black" onclick="lblLeadNo_Click1"   />
                                    </ItemTemplate>
                                </asp:TemplateField>
                         
                                 <asp:TemplateField HeaderText ="Customer Name"  Visible="true">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblname" runat="server" Text ='<%#Eval("customername") %>' />
                                                </ItemTemplate>
                          </asp:TemplateField>
                          <asp:BoundField DataField ="mobile" HeaderText ="Mobile"/>
                           <asp:BoundField DataField ="amount" HeaderText ="Amount"/>
                          
                           <asp:BoundField DataField ="pickup" HeaderText ="Pickup Executive"/>
                             <asp:BoundField DataField ="created_by" HeaderText ="Created By"/>
                             
                            <asp:TemplateField HeaderText ="Status_id"  Visible="false">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblStatus_id" runat="server" Text ='<%#Eval("lead_status") %>' />
                                                </ItemTemplate>
                          </asp:TemplateField>
                          
                         </Columns>
                         </asp:GridView>
             
			           </div>
 </asp:Panel>


    <table  width="100%"style=" background-color:#DDDDDD; margin-top:0px; height:60px" >
   
        <tr>
            <td  rowspan= "2" style="width: 72%" >
              <label style=" font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:15pt;padding-left:20px">Qualified</label>
            </td>
             <td class="total_trasactions" align ="left">
                 Lead Qualified&nbsp;&nbsp; :&nbsp;&nbsp; 
                 <asp:Label ID="lblQualcnt" runat="server" ></asp:Label>
            </td>
        </tr>
        <tr>
          
            <td class="total_trasactions" align ="left">
              Total Amount&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp; &nbsp;<asp:Label ID="lblQualamt" runat="server" ></asp:Label>
            </td>
        </tr>
      </table>

    <asp:Panel ID="pnlquli" runat="server">
   
      
         <div class="grid" cellspacing="0" rules="cols"  id="gridCustomers" style="border-collapse:collapse;padding-left:0px; margin-bottom: 6px; padding-top:0px">
                         <asp:GridView ID="grdqulify" runat ="server" AutoGenerateColumns ="False"   GridLines ="None"  
                             Width ="100%"

                                EmptyDataText ="No lead found for the criteria you selected." 
                             PageSize="20" onrowdatabound="grdqulify_RowDataBound" 
                           > 
                                
                         <Columns >
                          
                       
                            <asp:TemplateField HeaderText ="Lead No." >
                                                <ItemTemplate>
                                                    <asp:Label ID="lblLeadNo" runat="server" Text ='<%#Eval("lead_no") %>' />
                                                </ItemTemplate>
                          </asp:TemplateField>
                          
                                 <asp:TemplateField HeaderText ="Customer Name"  Visible="true">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblname" runat="server" Text ='<%#Eval("customername") %>' />
                                                </ItemTemplate>
                          </asp:TemplateField>
                          <asp:BoundField DataField ="mobile" HeaderText ="Mobile"/>
                           <asp:BoundField DataField ="amount" HeaderText ="Total Amt"/>
                           <asp:BoundField DataField ="amount_paid" HeaderText ="Paid Amt"/>
                           <asp:BoundField DataField ="rest_amount" HeaderText ="Rest Amt"/>
                           <asp:BoundField DataField ="created_by" HeaderText ="Created By"/>
                           
                         </Columns>
                         </asp:GridView>
        		           
			      

</div>

 </asp:Panel>





     </div>

</div>
</asp:Content>

