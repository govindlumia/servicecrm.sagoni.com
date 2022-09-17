<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="View_Jobwork.aspx.cs" Inherits="Jobwork_View_Jobwork" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%--   <link rel="stylesheet" type="text/css"  href="../themes/softed/style.css">--%>

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
   
  <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
  <script type="text/javascript" src="../Jscript/mtmv.js"></script>
  <link href ="../css/doplus_style.css" rel="stylesheet" type="text/css"/>

<div class="detailedViewHeader">
  <p class="lvtHeaderText jobwork">JobWork List Details</p>
  </div>

    <center>
<div class="dvtContentSpace" style="padding:10px 10px 10px 0px;width:99%;">

 <div class ="gridSearch" >
   <table style="height:0px; padding-left:30px"> 
   <tr>
     <td >
      <h2 >JobWork List </h2>
     </td> 
     <td></td>
      <td align="left" style="padding-top:5px; padding-bottom:5px; padding-left: 100%;" > 
         <%-- <asp:Button ID="Update_Jobwork" runat="server" Font-Bold="true" 
              ForeColor="Black" Height="28px"
              Font-Size="10pt" Text="Update Jobwork Status" 
            Width="185px" onclick="Update_Jobwork_Click"    />--%></td> 
      </tr>
    </table>

   <asp:Panel ID="pnlsearch" runat="server" DefaultButton=cmdSearch>

   <table cellpadding="0" cellspacing="0" width="100%" style ="color:Black; padding-left:0px; padding-bottom:0px;margin-top: 6px; ">
     
		        <tr>
                <div class="jobwork_view1">
			        <td class="job_td1">
                      Jobwork Status&nbsp;&nbsp; 
      <asp:DropDownList id="ddlStatus" runat ="server"  Width="150px"  
                            >  
      </asp:DropDownList></td>
                    
                     </div>

    <div class="jobwork_view1">
      <td class="job_td2">&nbsp;Chip Level Engineer&nbsp;:&nbsp; 
          <asp:DropDownList ID="ddlchiplevel" runat="server" Width="150px" Height="22px" 
             >
                    </asp:DropDownList> &nbsp;</td>
        
        </div>       
               
    <div  class="jobwork_view2">              
 <td class="job_td3">Repair Status&nbsp;:<asp:DropDownList ID="ddlRepairstatus" 
         runat="server"  Width="150px" Height="22px" >  
  </asp:DropDownList>&nbsp;
 </td>
     </div>               <%-- <td align="left" style="padding-top:10px; padding-bottom:10px" > 
                      <asp:Button ID="callreminder" runat="server" Font-Bold="true" Height="28px"
                           ForeColor="Black" Font-Size="10pt" Text="Call Back Reminder" 
             Width="185px" onclick="callreminder_Click"     />&nbsp;</td> --%>
    
                           
  </tr> 
<tr>
   <td class="padding_left_job" style="width:10%;" align="right" >
       Office &nbsp;:&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;
        <asp:DropDownList id="ddlOffice" runat ="server" class="small" Width="150px" 
           >  
        </asp:DropDownList>&nbsp;
      


                        </td>
                    
                    
  <td  align="left" style=" padding-top:10px;width:15%">&nbsp;
                                         Search(Request ID)&nbsp;
                                         <asp:TextBox ID="txtSearch" runat="server"  width="147px" 
                             CausesValidation="True" 
                                             ></asp:TextBox>&nbsp;</td>
                                         
  <td align= "left" style=" padding-top:10px; padding-left:0px">
 <asp:Button  id="cmdSearch" runat ="server"  Text ="View" 
                             OnClientClick ="return displayLoadingImage();" Font-Bold="True" 
                                                 Width="100px" Height="28px" onclick="cmdSearch_Click"  /> 
                           <asp:Image ImageUrl="~/images/rotation.gif"  runat="server"  
                                                id="imgLoading" style="Z-INDEX: 101; LEFT: 424px; VISIBILITY:hidden   ;  

POSITION: absolute; TOP: 240px; width: 40px;"/>
	               
	                </td> 
                    
                    
                    
                    </tr>
	        </table>
	        </asp:Panel> 

   </div> 
    <div class="mGrid"    id="gridCustomers" style="width:100%;border-collapse:collapse; padding-top:0px"">
                         <asp:GridView ID="grdLead" runat ="server" AutoGenerateColumns ="False"   GridLines ="None"  
                         AllowPaging ="True"

                                EmptyDataText ="No lead found for the criteria you selected." 
                             onrowcommand="grdLead_RowCommand" onrowdatabound="grdLead_RowDataBound" 
                             onrowediting="grdLead_RowEditing" AllowSorting="True" onpageindexchanging="grdLead_PageIndexChanging" 
                             CssClass="mGrid"
            PagerStyle-CssClass="pgr"
                           > 
                                
                         <Columns >
                         <asp:TemplateField  HeaderText ="Edit">
                                                <ItemTemplate>
               <asp:ImageButton ID="imgEdit" ImageUrl ="~/images/edit_icon.png" runat="server" CommandName ="edit" ToolTip ="Click to edit" CausesValidation ="false"   /> 
                                                     
                                                   
                                                </ItemTemplate>
                          </asp:TemplateField>
                          
                      
                           <asp:TemplateField HeaderText="serialno" Visible= "false">
                                    <ItemTemplate>
                                     <asp:Label ID="lblserialno" runat="server" Text ='<%#Eval("serialNo") %>' />
                                      
                                    </ItemTemplate>
                                </asp:TemplateField>
                          <asp:TemplateField HeaderText="Lead">
                                    <ItemTemplate>
                                     <asp:Label ID="lblticketid" runat="server" Text ='<%#Eval("requestId") %>' />
                                      
                                    </ItemTemplate>
                                </asp:TemplateField>
                         <asp:TemplateField HeaderText ="Customer ID"  Visible= "false">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblLeadNo" runat="server" Text ='<%#Eval("customerid") %>' />
                                                </ItemTemplate>
                          </asp:TemplateField>
                          <asp:BoundField DataField ="customerId" HeaderText ="Customer ID"/>
                          
                                 <asp:TemplateField HeaderText ="Customer"  Visible="true">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblname" runat="server" Text ='<%#Eval("customername") %>' />
                                                </ItemTemplate>
                          </asp:TemplateField>
                          <asp:BoundField DataField ="mobile_no" HeaderText ="Mobile"/>
                              <asp:BoundField DataField ="address" HeaderText ="Address"/>
                              <asp:BoundField DataField ="Gadgettype_name" HeaderText ="Gadget Type"/>
                                <asp:BoundField DataField ="equipmentStatus_name" HeaderText ="Status"/>
                                 <asp:BoundField DataField ="Entry_status" HeaderText ="Entry_Status"/>
                          <asp:BoundField DataField ="Issue" HeaderText ="Issue"/>
                                  <asp:BoundField DataField ="RepairStatus" HeaderText ="Status"/> 
                                 <%--   <asp:BoundField DataField ="Repairreason" HeaderText ="Repairreason"/>    --%>                            
                        <%--  <asp:BoundField DataField ="Pickuptime" HeaderText ="Pickup Date"/>    --%>                    
                          <%-- <asp:BoundField DataField ="inTime" HeaderText ="InTime Date"/>
                           <asp:BoundField DataField ="outTime" HeaderText ="OutTime Date" />--%>
                           <asp:BoundField DataField ="StoreRemarks" HeaderText ="StoreRemarks" />                       
                           <asp:BoundField DataField="Brand" HeaderText="Brand" />
                           
                                    <asp:BoundField DataField ="Model" HeaderText ="Model"/>
                             <%-- <asp:BoundField DataField ="IMIE_NO" HeaderText ="IMIE_NO"/>--%>
                             <%-- <asp:BoundField DataField ="Screen" HeaderText ="Screen"/>
                                <asp:BoundField DataField ="Battery_Serial_No" HeaderText ="Battery_Serial_No"/>--%>
                       <%--   <asp:BoundField DataField ="Back_cover" HeaderText ="Back_cover"/>--%>
                                 <%-- <asp:BoundField DataField ="Pickup_Engineer" HeaderText ="Pickup Engineer"/>--%>
                               <%-- <asp:BoundField DataField ="chipEngineer" HeaderText ="chipEngineer"/>
                                 <asp:BoundField DataField ="software_engg" HeaderText ="Software_Engineer"/>
                                 <asp:BoundField DataField ="QualitycheckEngineer" HeaderText ="QualitycheckEngineer"/>
                          <asp:BoundField DataField ="DeliveryEngineer" HeaderText ="DeliveryEngineer"/> --%>                       
                          
                           
                           <asp:BoundField DataField ="created_by" HeaderText ="Created By" />   
                           <asp:BoundField DataField ="created_on" HeaderText ="Date" />                    
                          
                            
                           <%-- <asp:BoundField DataField="phone_rent_status" HeaderText="Phone In Rent" />--%>
                         </Columns>
                            


                         </asp:GridView>
        		           
			           </div>
    

   </div>
   </center>  
   
   
 
</asp:Content>
