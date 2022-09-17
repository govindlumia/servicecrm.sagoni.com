<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Lead_select.aspx.cs" Inherits="Sales_Lead_select" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
  <script type="text/javascript" src="../Jscript/mtmv.js"></script>
  <link href ="../css/doplus_style.css" rel="stylesheet" type="text/css"/>

<div class ="gridSearch" >
    <table   width ="100%">
      
   <tr>
     <td style="padding-left:0px">
      <h2>Lead List&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </h2>
     </td> 
      <td align =right >
          <asp:Button ID="btnLead_create" runat="server" Text="Create Lead" 
               />
       </td> 
    
   </tr> 
    </table>
   <asp:Panel ID="pnlsearch" runat="server" DefaultButton="cmdSearch">
   <table cellpadding="0" cellspacing="0" width="100%" style ="color:Black ; padding-bottom:0px">
		        <tr>
			        <td style="width:40%;" align =center >
                        Search for:&nbsp;<asp:TextBox  id="txtSearch" runat =server size="15" 
                            Width="162px"  class=detailedViewTextBox Height="17px" />&nbsp;&nbsp; In
                        <asp:DropDownList id="cboViewList" runat =server class="small" >  
                           
                         

    <asp:ListItem value="All" selected="selected">All</asp:ListItem> 
	<asp:ListItem value="leadno">Lead No</asp:ListItem> 
	<asp:ListItem value="firstname">First Name</asp:ListItem>
	<asp:ListItem value="lastname">Last Name</asp:ListItem>
	<asp:ListItem value="company">Company Name</asp:ListItem>
	<asp:ListItem value="phone">Phone</asp:ListItem>
	<%--<asp:ListItem value="website">Web Site</asp:ListItem>--%>
	<asp:ListItem value="email">Email</asp:ListItem>
	<%--<asp:ListItem value="assignto">Assign To</asp:ListItem>--%>
</asp:DropDownList>
                        &nbsp;&nbsp; &nbsp;Type:<asp:DropDownList id="ddlType" runat =server class="small" 
                              >  
                           
  
	<asp:ListItem value="A" selected="selected">All</asp:ListItem> 
	<asp:ListItem value="S">Assign to me</asp:ListItem>
	<asp:ListItem value="M">My Lead</asp:ListItem>

</asp:DropDownList>
                        &nbsp;&nbsp;&nbsp; Office:<asp:DropDownList id="ddlOffice" runat =server class="small"  >                           
 
</asp:DropDownList>

                        &nbsp;&nbsp; Lead Source:
<asp:DropDownList id="ddlLeadSource" class="small" runat =server 
                                        AutoPostBack =true 
                                         ></asp:DropDownList>
                                         &nbsp;&nbsp;&nbsp; Lead Status:<asp:DropDownList id="ddlLeadStatus" 
                            class="small" runat =server  AutoPostBack =true 
                                        ></asp:DropDownList>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
 <asp:Button  id="cmdSearch" runat =server  Text ="View" 
                             OnClientClick ="return displayLoadingImage();" 
                            Width="111px" onclick="cmdSearch_Click"   /> 
                           <asp:Image ImageUrl="~/images/rotation.gif"  runat="server"  
                                                id="imgLoading" style="Z-INDEX: 101; LEFT: 424px; VISIBILITY:hidden   ;  

POSITION: absolute; TOP: 240px; width: 60px;"/>
	               
	                </td>
	            </tr>
	        </table>
	        </asp:Panel> 

   </div>
   <div class="mGrid1" cellspacing="0" rules="cols" border="1" id="gridCustomers" style="width:100%;border-collapse:collapse;">
                         <asp:GridView ID="grdLead" runat ="server" AutoGenerateColumns ="False"   GridLines ="None"  
                             Width ="100%" AllowPaging ="True"

                                EmptyDataText ="No lead found for the criteria you selected." 
                             onrowcommand="grdLead_RowCommand" AllowSorting="True" 
                             onpageindexchanging="grdLead_PageIndexChanging" 
                             onrowdatabound="grdLead_RowDataBound" onrowediting="grdLead_RowEditing" 
                              CssClass="mGrid"
            PagerStyle-CssClass="pgr"
                           > 
                                
                         <Columns >
                         <asp:TemplateField  HeaderText ="Edit">
                                                <ItemTemplate>
               <asp:ImageButton ID="imgEdit" ImageUrl ="~/images/edit_icon.png" runat="server" CommandName ="edit" ToolTip ="Click to edit" CausesValidation ="false"   /> 
                                                     
                                                   
                                                </ItemTemplate>
                          </asp:TemplateField>
                          
                         <asp:TemplateField HeaderText ="Lead">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblLeadNo" runat="server" Text ='<%#Eval("lead_no") %>' />
                                                </ItemTemplate>
                          </asp:TemplateField>

                           <asp:BoundField DataField ="first_name" HeaderText ="Customer"/>
                          <asp:BoundField DataField ="company" HeaderText ="Company"/>
                         <asp:TemplateField Visible="true" HeaderText ="Mobile">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblMobile" runat="server" Text ='<%#Eval("mobile") %>' />
                                                </ItemTemplate>
                          </asp:TemplateField>
                            <asp:TemplateField Visible="true" HeaderText ="Status">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblStatus" runat="server" Text ='<%#Eval("leadstatus_name") %>' />
                                                </ItemTemplate>
                          </asp:TemplateField>
                           <asp:TemplateField Visible="false" HeaderText ="lStatus">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblStatus_id" runat="server" Text ='<%#Eval("leadstatus_id") %>' />
                                                </ItemTemplate>
                          </asp:TemplateField>
                         
                          
                        <asp:BoundField DataField="ExpectedRevenue" HeaderText="ExpRevenue" />
                         <asp:BoundField DataField ="created_by" HeaderText ="Created By" />
                       <asp:BoundField DataField="expecteddate" HeaderText="Date" />                            
                         
                         </Columns>
                            
                         </asp:GridView>
        		           
			           </div>
</asp:Content>

