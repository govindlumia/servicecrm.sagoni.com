<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Refund_Repair_Invoice.aspx.cs" Inherits="Refund_Refund_Repair_Invoice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script type ="text/javascript" >
        function displayLoadingImage() {
            var imgLoading = document.getElementById("<%=imgLoading.ClientID%>");

            imgLoading.style.visibility = "visible";

        }
 </script>
   <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
  <script type="text/javascript" src="../Jscript/mtmv.js"></script>
  <link href ="../css/doplus_style.css" rel="stylesheet" type="text/css"/>
    <asp:UpdatePanel ID="up1" runat ="server" >
      <ContentTemplate >
     
   <table class="create_service_invoice" border=0 cellspacing=0 cellpadding=0  align=center>
<tr>
<td>
<table border=0 cellspacing=0 cellpadding=3 width=100% class="small">
<tr>
<td class="dvtTabCache create" style="width:65%" nowrap><span class="lvtHeaderText"> Create Repair Refund Invoice</span></td>
</table>
</td>
 </tr>
<tr>
			<td valign=top align=left >

			    <!-- Basic Information Tab Opened -->
			    <div id="basicTab">

				<table border=0 cellspacing=0 cellpadding=3 width=100% class="dvtContentSpace">
				   <tr>
					<td align=left>

					<!-- content cache -->
					
						<table border=0 cellspacing=0 cellpadding=0 style="height: 329px; width: 100%">
						  
						   <tr>
							<td style="padding: 0px 10px 10px;">
							<!-- General details -->
								<table border=0 cellspacing=0 cellpadding=0 width="100%" class="small">

								   <tr>
									<td  colspan=4 style="padding: 2px 5px 5px;">
									   <div align="center">
											<asp:Button ID="btnSave" runat ="server" Text ="Save" 
                OnClientClick ="return displayLoadingImage();" onclick="btnSave_Click" /> 
											&nbsp;
											
											
             <asp:Button ID="btnClose" runat =server Text ="Cancel"  CausesValidation=false onclick="btnClose_Click" />
             
             
             
            
                                              <%--  &nbsp;<asp:CheckBox ID="chkRenewal" runat="server"  
                                                 Text="Renewal" />--%>
             
            
                                                <br />
                                                <asp:Label ID="lblMsg" runat =server Visible =false ForeColor =Red ></asp:Label>
                                                <asp:Image ImageUrl="~/images/rotation.gif"  runat="server"  
                                                id="imgLoading" style="Z-INDEX: 101; LEFT: 524px; VISIBILITY:hidden ;  

POSITION: absolute; TOP: 240px; width: 60px;"/>
																																									
									   </div>
									</td>
								   </tr>

								   								    <tr>
															         		<td colspan=4 class="detailedViewHeader">
                                                	        		            <b>Customer Information</b>
																 		</td>
		                                        	   </tr>
		                                        	   </tr>

								   <!-- Here we should include the uitype handlings-->
								   

<!-- Added this file to display the fields in Create Entity page based on ui types  -->

             <tr style="height:25px">
             
             <td class="dvtCellLabel" align=right>

	<font color="red">*</font> Lead No. </td>
			<td align=left class="dvtCellInfo" style="width: 20%; height: 27px;" >
							   		 
			   	 <asp:TextBox ID="txtRequestid" CssClass="textbox " runat="server" 
                     AutoPostBack="True" ontextchanged="txtRequestid_TextChanged"    
                      ></asp:TextBox>														
				
				</td>
                  <td class="dvtCellLabel" align=right>

	<font color="red">*</font>Customer Name</td>
			<td align="left" class="dvtCellInfo" >
							   		 
			   	 <asp:Label ID="lblclient_name" runat="server" Font-Bold="true" ></asp:Label>
			 						
			
			 						
			</td>
			
			 
            </tr>
							
						
				<tr style="height:25px">
				  <td class="dvtCellLabel" align=right>

	            Mobile_no   </td>
			<td align=left class="dvtCellInfo" style="width: 20%" >
							   		 
		 <asp:Label ID="lblmobileno" runat="server" ></asp:Label>
                   
			 						
			</td>
            <td class="dvtCellLabel" align=right style="width: 6%">

				Address 			</td>
			<td align=left class="dvtCellInfo" >
							   		 <asp:Label ID="lblAddress" runat="server" ></asp:Label>
			   															
												
			</td>
          


				
</tr>

							
				   <tr style="height: 25px">
                                                            <td class="dvtCellLabel" align="right" style="width: 6%">
                                                              Total Unit
                                                            </td>
                                                            <td align="left" class="dvtCellInfo" style="width: 20%">
                                                               
                                                            <%--<asp:DropDownList ID="ddlPayment" runat="server" class="small"  >			         		 
                                                            </asp:DropDownList>--%>
                                        <asp:TextBox ID="txtunit" CssClass="textbox " runat="server"  Height="22px"
                                                                   Width="128px"></asp:TextBox>
                                                           
                                                            </td>
                                                            <td class="dvtCellLabel" align="right" style="width: 6%">Total Amount
                                                              </td>
                                                            <td width="30%" align="left" class="dvtCellInfo" >
                                                               
                                             <asp:TextBox ID="txtamount" CssClass="textbox" runat="server" ></asp:TextBox>                                                 
                                                 </td> 
                                                                  
                                                        </tr>
                          <tr>
						
			
			 <td  class="dvtCellLabel" align="right" >Payment Mode 
                </td>
							<td align=left class="dvtCellInfo">				
							<asp:RadioButton ID="rbCheque" runat =server Text ="Cheque" GroupName ="PMode" AutoPostBack =true
                            Checked =true   /> 
						<asp:RadioButton ID="rbCash" runat =server Text ="Cash" GroupName ="PMode" 
                             AutoPostBack =true  /> 
                            <asp:RadioButton ID="rbonline" runat =server Text ="Online" GroupName ="PMode" 
                              AutoPostBack =true   /> 
                            <asp:RadioButton ID="PRadioTeller" runat ="server" Text ="NEFT" GroupName ="PMode" 
                            AutoPostBack =true   />
							</td>
			<td class="dvtCellLabel" align=right style="width: 6%">

				Cheque No / Transaction No. 			</td>
			<td align=left class="dvtCellInfo" style="width: 21%">
							   	
                            <asp:TextBox ID="txtChequeNo" CssClass="textbox" runat =server MaxLength=20 Width="106px" ></asp:TextBox>								
												
			</td>
					

							</tr>                              
                           <tr style="height: 25px" >

                           <td class="dvtCellLabel" align="right" style="width: 6%">
                                                                VAT</td>
                                                          
                                                                        <td class="tax_border">
                                                                            <asp:TextBox ID="txttaxAmount" class="tax_margin_left textbox" Text="14.00" runat="server" />
                                                                        </td>
                                                           
                                                 		
							

                          
    <td valign="middle" class="dvtCellLabel">Warranty :</td>
    <td valign="middle" class="cellInfo1">
     <asp:DropDownList ID="ddServicetype" class="dropdown" runat="server"></asp:DropDownList><br />
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Select Service Type"
 ControlToValidate="ddServicetype" InitialValue="0"></asp:RequiredFieldValidator>
        </td>
  
                                                 </tr>   
                                              
		    <tr style="height: 25px" >
                                                            <td class="dvtCellLabel" align="right" style="width: 6%">
                                                              Product  Description  </td>
                                                            <td width="30%" align="left" class="dvtCellInfo" >
                                                                <%--<asp:DropDownList ID="ddlCustomer" runat="server" AutoPostBack=true class="small"
                  Width="167px" onselectedindexchanged="ddlCustomer_SelectedIndexChanged" >
                  </asp:DropDownList>--%>
                                                                <asp:TextBox ID="txtitems" CssClass="textbox" runat="server"  Height="50px"
                                                                   Width="200px" TextMode="MultiLine"></asp:TextBox>                              
                                                 </td>
                                                 		<TD  class="dvtCellLabel" align=right >Remarks</TD>
							<TD align=left class="dvtCellInfo">				
							 
                  
							    <asp:TextBox ID="txtremarks" CssClass="textbox" runat="server"  Height="50px"  Width="200px" 
                                    TextMode="MultiLine"></asp:TextBox>
							 
                  
							</TD>
                                                 </tr>
                                                            		  
							    
							 
        
			

							<tr>

									<td  colspan=4 style="padding: 13px 5px 0px;">
									   <div align="center">
									   <asp:Button ID="btnSave1" runat="server" 
                                        Text="Save" style="height: 26px" OnClientClick ="return displayLoadingImage();" onclick="btnSave1_Click"  
                                               /> 
											&nbsp; 
											<asp:Button ID="btnCancel1" runat =server Text ="Cancel" 
                                               CausesValidation="false" onclick="btnCancel1_Click" />
																				    </div>
									</td>
								   </tr>
								   
								</table>
							</td>

						   </tr>
						</table>
					</td>
				   </tr>
				</table>
					
			    </div>
			    <!-- Basic Information Tab Closed -->

			    <!-- More Information Tab Opened -->

			    <div id="moreTab">
			
			    </div>

			</td>
		   </tr>
		   
		</table>
		
								     
								 
</ContentTemplate> 


</asp:UpdatePanel> 


</asp:Content>

