<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="search_value.aspx.cs" Inherits="search_value" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
     <script type="text/javascript" src="../Jscript/mtmv.js"></script>
     <link href ="../css/doplus_style.css" rel="stylesheet" type="text/css"/>
     <div class="detailedViewHeader">
  <p class="lvtHeaderText">Search Result</p>
  </div>

<div class="dvtContentSpace" style="padding:5px 5px 5px 5px">
<table border="0" cellspacing="0" cellpadding="0" width="100%" class="big">
 
 
 <tr style="background-color:#E7E6E6">
 <td  valign="top"  style="width: 100%; padding-bottom:10px; padding-top:10px; text-align:left; border-left:1px solid #8C8C8C;; border-top:1px solid #8C8C8C;; border-right:1px solid #8C8C8C; "  >
   <label style=" font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:17px;padding-left:20px">Lead</label>
        </td>
             
 </tr>

 <tr>
 <td colspan="4">
 <table width="100%" cellpadding="0" cellspacing="0" class="big" >
   
 <tr>
 <td valign="middle" class="dvtCell" >
 
 <div class="mGrid"  cellspacing="0" rules="cols" border="1" id="Div4" style="width:100%;border-collapse:collapse; text-align:center">
 <asp:GridView ID="grdlead" runat ="server" AutoGenerateColumns ="False"   GridLines ="None"  
 AllowPaging ="false" Width="100%"  EmptyDataText ="No Data found for the criteria you selected." CssClass="mGrid1" 
         PagerStyle-CssClass="pgr"> 
                                
            <Columns >
                          
        

                            <asp:TemplateField HeaderText="Lead">
                                    <ItemTemplate>
                                       <asp:LinkButton ID="lblLeadNo" Text ='<%#Eval("lead_no") %>' runat="server" 
                                            CommandName ="lblLeadNo_Click" ToolTip ="Click to see Lead Detail" 
                                            ForeColor ="Black" onclick="lblLeadNo_Click"  
                                            />
                                    </ItemTemplate>
                                </asp:TemplateField>
                          
                                 <asp:TemplateField HeaderText ="Customer"  Visible="true">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblname" runat="server" Text ='<%#Eval("customername") %>' />
                                                </ItemTemplate>
                          </asp:TemplateField>

                          

                           <asp:BoundField DataField ="mobile" HeaderText ="Mobile"/>
                           <asp:BoundField DataField ="street" HeaderText ="Address"/>
                          <asp:BoundField DataField ="leadstatus_name" HeaderText ="Lead Status"/>
                          <asp:BoundField DataField ="ExpectedRevenue" HeaderText ="Expected Revenue"/>
                           <asp:BoundField DataField ="created_by" HeaderText ="Created By"/>
                           <asp:BoundField DataField ="created_on" HeaderText ="Created_on"/>
                            <asp:TemplateField HeaderText ="Status_id"  Visible="false">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblStatus_id" runat="server" Text ='<%#Eval("lead_status") %>' />
                                                </ItemTemplate>
                          </asp:TemplateField>
                           
                         </Columns>
                 <PagerStyle CssClass="pgr" />
               
                 </asp:GridView>
        		           
			      </div>

 </td>
  
 </tr>

 </table>
 </td>
 </tr>

 </table>


   </div>

<div class="dvtContentSpace" style="padding:10px 10px 10px 10px">
<table border="0" cellspacing="0" cellpadding="0" width="100%" class="big">
 
 
 <tr style="background-color:#E7E6E6">
 <td  valign="top"  style="width: 100%; padding-bottom:10px; padding-top:10px; text-align:left; border-left:1px solid #8C8C8C;; border-top:1px solid #8C8C8C;; border-right:1px solid #8C8C8C; "  >
   <label style=" font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:17px;padding-left:20px">Service Invoice </label>
        </td>
             
 </tr>

 <tr>
 <td colspan="4">
 <table width="100%" cellpadding="0" cellspacing="0" class="big" >
   
 <tr>
 <td valign="middle" class="dvtCell" >
 
 <div class="mGrid"  cellspacing="0" rules="cols" border="1" id="Div2" style="width:100%;border-collapse:collapse; text-align:center">
 <asp:GridView ID="grdcustomer" runat ="server" AutoGenerateColumns ="False"   GridLines ="None"  
 AllowPaging ="false" Width="100%"  EmptyDataText ="No Data found for the criteria you selected." CssClass="mGrid1" 
         PagerStyle-CssClass="pgr"> 
                                
                 <Columns >
                         
                         <%-- <asp:BoundField DataField ="Model" HeaderText ="Model"/>--%>
                         <asp:BoundField DataField ="customerId" HeaderText ="Customer Id"/>
                         <asp:BoundField DataField ="customerName" HeaderText ="Customer"/>
                          <asp:BoundField DataField ="mobile_no" HeaderText ="mobile"/>
                        <asp:BoundField DataField ="address" HeaderText ="Address"/>
                         <asp:BoundField DataField ="invoice_no" HeaderText ="invoice"/>
                       
                           <asp:BoundField DataField ="Description" HeaderText ="Description"/>
                      <%--  <asp:BoundField DataField ="Issue" HeaderText ="Issue"/>--%>
                        <asp:BoundField DataField ="created_on" HeaderText ="created_on"/>
                         
                         <%--  <asp:BoundField DataField ="amount" HeaderText ="Amount"/>--%>
                          <asp:BoundField DataField ="created_by" HeaderText ="Created By"/>
                           
                         </Columns>
                 <PagerStyle CssClass="pgr" />
               
                 </asp:GridView>
        		           
			      </div>

 </td>
  
 </tr>

 </table>
 </td>
 </tr>

 </table>


   </div>
   <div class="dvtContentSpace" style="padding:10px 10px 10px 10px">
<table border="0" cellspacing="0" cellpadding="0" width="100%" class="big">
 
 
 <tr style="background-color:#E7E6E6">
 <td  valign="top"  style="width: 100%; padding-bottom:10px; padding-top:10px; text-align:left; border-left:1px solid #8C8C8C;; border-top:1px solid #8C8C8C;; border-right:1px solid #8C8C8C; "  >
   <label style=" font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:17px;padding-left:20px">JobWork List</label>
        </td>
             
 </tr>

 <tr>
 <td colspan="4">
 <table width="100%" cellpadding="0" cellspacing="0" class="big" >
   
 <tr>
 <td valign="middle" class="dvtCell" >
 
 <div class="mGrid"  cellspacing="0" rules="cols" border="1" id="Div3" style="width:100%;border-collapse:collapse; text-align:center">
 <asp:GridView ID="grdrequestid" runat ="server" AutoGenerateColumns ="False"   GridLines ="None"  
 AllowPaging ="false" Width="100%"  EmptyDataText ="No Data found for the criteria you selected." CssClass="mGrid1" 
         PagerStyle-CssClass="pgr"> 
                                
                 <Columns >
                        <asp:TemplateField HeaderText="serialno" Visible= "false">
                                    <ItemTemplate>
                                     <asp:Label ID="lblserialno" runat="server" Text ='<%#Eval("serialNo") %>' />
                                      
                                    </ItemTemplate>
                                </asp:TemplateField>
                        <asp:TemplateField HeaderText="Request Id">
                                    <ItemTemplate>
                                       <asp:LinkButton ID="lblrequestid" Text ='<%#Eval("requestId") %>' runat="server" 
                                            ToolTip ="Click to see Jobwork Detail" 
                                            ForeColor ="Black"  
                                            />
                                    </ItemTemplate>
                                </asp:TemplateField>   
                     
                    

                      <asp:BoundField DataField ="customerName" HeaderText ="Customer"/>
                         <asp:BoundField DataField ="mobile_no" HeaderText ="Mobile"/>
                          <asp:BoundField DataField ="equipmentStatus_name" HeaderText ="Status"/>
                          
                             <asp:BoundField DataField ="Issue" HeaderText ="Issue"/>
                           
                            <asp:BoundField DataField ="created_by" HeaderText ="Created By"/>
                          <asp:BoundField DataField ="created_on" HeaderText ="Created_on"/>
                          
                        
                           
                         </Columns>
                 <PagerStyle CssClass="pgr" />
               
                 </asp:GridView>
        		           
			      </div>

 </td>
  
 </tr>

 </table>
 </td>
 </tr>

 </table>


   </div>
    <div class="dvtContentSpace" style="padding:10px 10px 10px 10px">
<table border="0" cellspacing="0" cellpadding="0" width="100%" class="big">
 
 
 <tr style="background-color:#E7E6E6">
 <td  valign="top"  style="width: 100%; padding-bottom:10px; padding-top:10px; text-align:left; border-left:1px solid #8C8C8C;; border-top:1px solid #8C8C8C;; border-right:1px solid #8C8C8C; "  >
   <label style=" font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:17px;padding-left:20px">Repair Invoice</label>
        </td>
             
 </tr>

 <tr>
 <td colspan="4">
 <table width="100%" cellpadding="0" cellspacing="0" class="big" >
   
 <tr>
 <td valign="middle" class="dvtCell" >
 
 <div class="mGrid"  cellspacing="0" rules="cols" border="1" id="Div5" style="width:100%;border-collapse:collapse; text-align:center">
 <asp:GridView ID="grdrepair" runat ="server" AutoGenerateColumns ="False"   GridLines ="None"  
 AllowPaging ="false" Width="100%"  EmptyDataText ="No Data found for the criteria you selected." CssClass="mGrid1" 
         PagerStyle-CssClass="pgr"> 
                                
                 <Columns >
                                  

                          <asp:BoundField DataField ="lead_no" HeaderText ="Lead"/>
                         <asp:BoundField DataField ="customerName" HeaderText ="Customer"/>
                           <asp:BoundField DataField ="description" HeaderText ="description"/>
                          <asp:BoundField DataField ="mobile" HeaderText ="mobile"/>
                        <asp:BoundField DataField ="street" HeaderText ="Address"/>
                         <asp:BoundField DataField ="invoice_no" HeaderText ="invoice"/>
                          <asp:BoundField DataField ="amount" HeaderText ="amount"/>
                        <asp:BoundField DataField ="warrantytype_name" HeaderText ="Warranty"/>
                        <asp:BoundField DataField ="created_on" HeaderText ="Created_on"/>
                        <asp:BoundField DataField ="created_by" HeaderText ="Created By"/>
                           
                         </Columns>
                 <PagerStyle CssClass="pgr" />
               
                 </asp:GridView>
        		           
			      </div>

 </td>
  
 </tr>

 </table>
 </td>
 </tr>

 </table>


   </div>
</asp:Content>

