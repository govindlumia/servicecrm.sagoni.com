<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="insert_jobwork.aspx.cs" Inherits="Jobwork_insert_jobwork" Culture ="en-GB" UICulture ="en-GB" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register TagPrefix="Ajaxified" Assembly="Ajaxified" Namespace="Ajaxified" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script src="../js/jquery-1.6.3.min.js" type="text/javascript"></script>

    <script src="https://maps.googleapis.com/maps/api/js?v=3.exp&sensor=false"></script>

    <script src="../js/functions.js" type="text/javascript"></script>
     <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
   <script type="text/javascript" src="../Jscript/mtmv.js"></script>
   <link href ="../css/doplus_style.css" rel="stylesheet" type="text/css"/>
    <link rel="stylesheet" type="text/css" href="../css/style.css">
    <link href="../css/TimePicker.css" rel="stylesheet" type="text/css" />
    <asp:UpdatePanel ID="up1" runat="server">
        <ContentTemplate>
            <table border=0 cellspacing=0 cellpadding=0 width=95% align=center>
		   <tr><td>
				<table border=0 cellspacing=0 cellpadding=3 width=100% class="small">
				   <tr>	<td class="dvtTabCache" style="width:65%" nowrap><span class="lvtHeaderText">
                                    Create New JobWork  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</span>
                                    <asp:HyperLink ID="Calllog" runat =server NavigateUrl="~/sales/Calllog.aspx" Text="Call Log "  Visible=false ToolTip ="Click to Add call Log"  Font-Size=Large/>                                    
                                    </td>			</tr>	   </table>
			</td>
		   </tr>
		   <tr>
			<td valign=top align=left >

			    <!-- Basic Information Tab Opened -->
			    <div id="basicTab">

				
					<!-- content cache -->
					
						<table border=0 cellspacing=0 cellpadding=0 width=100%>
						  
						   <tr>
							<td style="padding:10px">
							<!-- General details -->
							<table border=0 cellspacing=0 cellpadding=0 width="100%" class="small">

								   <tr>
									<td  colspan=4 style="padding:5px">
									   <div align="center">
										<table>
                                        <tr>
                                        <td>	<asp:Button ID="btnSave" runat ="server" Text ="Save" 
               onclick="btnSave_Click" OnClientClick ="return displayLoadingImage();"/> 
											&nbsp;
											
											<asp:Button ID="btncancel" runat ="server" Text ="Cancel" 
             CausesValidation ="false" onclick="btncancel_Click"  />
           <%--  <asp:Button ID="btnreturnticket" runat ="server" Text ="Create Return Ticket" 
             CausesValidation ="false"  Font-Bold="True" ForeColor="#993300" />--%>
           
             
            
             </td>
             <td style=" padding-left:10px">
            
                                              
 <asp:CheckBox ID="chkReturn" runat ="server" Text ="Return "  valign="top" align="left" 
                                                AutoPostBack="true" Enabled="true" Visible= "true" 
                                                    />   
                                                
                                            &nbsp;&nbsp;&nbsp;&nbsp;
                                                       
                                                <br />




                                              
										</td></tr>

                             <tr><td colspan=4 style="padding:5px">  <asp:Label ID="lblMsg" runat ="server" Visible ="false" ForeColor="Red" ></asp:Label>
                                                <asp:Image ImageUrl="~/images/rotation.gif"  runat="server"  
                                                id="imgLoading" style="Z-INDEX: 101; LEFT: 524px; VISIBILITY:hidden ;  

POSITION: absolute; TOP: 240px; width: 60px;"/></td></tr>           
                                        
                                        
                                        </table>																															
									   </div>
									</td>
								   </tr>

								   								   <tr>
															         		<td colspan=4 class="detailedViewHeader">
                                                	        		            <b>Customer Detail</b>
																 		</td>
		                                        	   </tr>

								   <!-- Here we should include the uitype handlings-->
								   

<!-- Added this file to display the fields in Create Entity page based on ui types  -->

<tr style="height:25px">
<td  class="dvtCellLabel" align=right style="width: 16%">
				              Enter Lead No. </td>
			<td align=left class="dvtCellInfo" style="width: 14%" >
			<asp:TextBox ID="txtLeadno" runat="server" AutoPostBack="True" Height="18px" 
                    Width="150px" ontextchanged="txtLeadno_TextChanged"> </asp:TextBox> </td>
                    <td  class="dvtCellLabel" align=right style="width: 4%">
										Customer Name</td>
			
			<td width="30%" align=left class="dvtCellInfo" >
						
				
               
                <asp:Label ID="lblcustomername" runat="server"></asp:Label>
        
			           	</td>
                    
			
</tr>
			
			           		<tr style="height:25px">	
			           		<td align="right" class="dvtCellLabel" style="width: 16%">
                                Contact Number :
                            </td>
                            <td align="left" class="dvtCellInfo" style="width: 14%">
                                <asp:Label ID="lblContactnumber" runat="server"></asp:Label>
                            </td>				
							
							<td align="right" class="dvtCellLabel" style="width: 4%">
                                Customer Address :
                            </td>
                            <td align="left" class="dvtCellInfo" width="30%">
                                <asp:Label ID="lblcustadd" runat="server"></asp:Label>
                            </td>                   
                            
                            </tr>
                            <tr style="height:25px">	
                            
                             <td align="right" class="dvtCellLabel" style="width: 16%">
                                Service Revenue :
                            </td>
                            <td align="left" class="dvtCellInfo" style="width: 14% ">
                                <asp:Label ID="lblServ_revn" runat="server" Font-Bold="True"></asp:Label>
                            </td>
                            
                            
                            
                            <td align="right" class="dvtCellLabel" style="width: 4%">
                         <font color="red">*</font>Office</td>
                     <td align="left" class="dvtCellInfo" colspan="3" width="30%">
                         <asp:DropDownList ID="ddlOffice" runat="server" class="small">
                         </asp:DropDownList>
                         <asp:RequiredFieldValidator ID="rfvAssign" runat="server" 
                             ControlToValidate="ddlOffice" Display="Dynamic" ErrorMessage="Select office" 
                             InitialValue="0"></asp:RequiredFieldValidator>
                     </td>   
                             
                            </tr>
                            <tr style="height:25px">	
                            
                             <td align="right" class="dvtCellLabel" style="width: 16%">
                                Service Type :
                            </td>
                            <td align="left" class="dvtCellInfo" style="width: 14% ">
                                <asp:Label ID="lblservicetype" runat="server" Font-Bold="True"></asp:Label>
                            </td>
                            
                            
                            
                            <td align="right" class="dvtCellLabel" style="width: 4%">
                        </td>
                     <td align="left" class="dvtCellInfo" colspan="3" width="30%">
                        
                        
                     </td>   
                            
                            </tr>
                  <tr>    		<td colspan=4 class="detailedViewHeader">
                                                	        		            <b>Job Work Detail</b>																 		</td>
		                                        	   </tr>             
                    <tr>
                    <td colspan= "2">
                    <table>      
                 <tr style="height:50px">
                     <td align="right" class="dvtCellLabel" style="width: 4%">
                         <font color="red">*</font>Problem
                     </td>
                     <td align="left" class="dvtCellInfo"  width="30%"  colspan="3">
                         <asp:TextBox ID="txtDesc" runat="server" Columns="100" Height="40px" 
                             MaxLength="1000" TextMode="MultiLine" Width="241px"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvDescription" runat="server" 
                             ControlToValidate="txtDesc" Display="Dynamic" ErrorMessage="Enter Description"></asp:RequiredFieldValidator>
                     </td></tr>
                     
                      <tr style="height:50px">
                     <td align="right" class="dvtCellLabel" style="width: 4%">
                         Solution
                     </td>
                     <td align="left" class="dvtCellInfo"  width="30%"  colspan="3">
                         <asp:TextBox ID="txtSolution" runat="server" Columns="100" Height="40px" 
                             MaxLength="1000" TextMode="MultiLine" Width="241px"></asp:TextBox>
                         
                 <tr style="height:25px">
                     <!-- uitype 111 added for noneditable existing picklist values - ahmed -->
                     <td align="right" class="dvtCellLabel" style="width: 4%">
                         <font color="red">*</font>Job work Status</td>
                     <td align="left" class="dvtCellInfo" width="30%"  colspan="3">
                         <asp:DropDownList ID="ddlJobwork" runat="server" 
                             class="small" 
                             Width="167px">                   
                         </asp:DropDownList>
                         <asp:RequiredFieldValidator ID="rfvProduct" runat="server" 
                             ControlToValidate="ddlJobwork" Display="Dynamic" ErrorMessage="Select Product" 
                             InitialValue="0"></asp:RequiredFieldValidator>
                     </td></tr>


<tr>  <td align="right" class="dvtCellLabel" style="width: 4%">
                         <font></font>Entry Status</td>
 <td align="left" class="dvtCellInfo" width="30%"  colspan="3"><asp:DropDownList ID="ddlReturn" 
                     runat="server" class="small"  Width="167px" 
                                                    Visible ="true" 
                                                    ForeColor="Black" 
         AutoPostBack="True" >
             
      
            
            </asp:DropDownList></td></tr>


                       <tr style="height:25px">
                     <!-- uitype 111 added for noneditable existing picklist values - ahmed -->
                     <td align="right" class="dvtCellLabel" style="width: 4%">
                         <asp:Label ID="lblRepairstatus" runat="server" Text="Repair Status"></asp:Label>
                         &nbsp;<td align="left" class="dvtCellInfo" width="30%"  colspan="3">
                         <asp:DropDownList ID="ddlRepairstatus" runat="server"  class="small"  Width="167px"> 
                         </asp:DropDownList>
                        
                       <asp:DropDownList ID="ddlRepairreason" runat="server"   class="small"  Width="167px">                 
                         </asp:DropDownList>
                     </td></tr>
                           <tr>    		<td colspan=4 class="detailedViewHeader">
                                                	        		            <b>Executive Detail</b>																 		</td>
		                                        	   </tr>     
                          <tr style="height:25px">
                     <!-- uitype 111 added for noneditable existing picklist values - ahmed -->
                     <td align="right" class="dvtCellLabel" style="width: 4%">
                         <font color="red">*</font>Pick Executive</td>
                     <td align="left" class="dvtCellInfo" width="30%"  colspan="3">
                         <asp:DropDownList ID="ddlpickupex" runat="server" 
                             class="small" 
                             Width="167px">
                         </asp:DropDownList>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                             ControlToValidate="ddlpickupex" Display="Dynamic" ErrorMessage="Select Product" 
                             InitialValue="0"></asp:RequiredFieldValidator>
                     </td></tr>
                     
                        <tr style="height:25px">
                    
                     <td align="right" class="dvtCellLabel" style="width: 4%">
                         <font color="red">*</font>ChipLevel Engineer</td>
                     <td align="left" class="dvtCellInfo" width="30%"  colspan="3">
                         <asp:DropDownList ID="ddlChipLevel" runat="server" 
                             class="small" 
                             Width="167px">
                         </asp:DropDownList>                         
                     </td></tr>
                     
                      <tr style="height:25px">
                    
                     <td align="right" class="dvtCellLabel" style="width: 4%">
                         <font color="red">*</font>Quality Engineer</td>
                     <td align="left" class="dvtCellInfo" width="30%"  colspan="3">
                         <asp:DropDownList ID="ddlQuality" runat="server"
                             class="small" 
                             Width="167px">
                         </asp:DropDownList>                        
                     </td></tr>
                     <tr style="height:25px">
                    
                     <td align="right" class="dvtCellLabel" style="width: 4%">
                         <font color="red">*</font>Software Engineer</td>
                     <td align="left" class="dvtCellInfo" width="30%"  colspan="3">
                         <asp:DropDownList ID="ddl_software" runat="server"
                             class="small" 
                             Width="167px">
                         </asp:DropDownList>                        
                     </td></tr>
                     
                       <tr style="height:25px">
                    
                     <td align="right" class="dvtCellLabel" style="width: 4%">
                         <font color="red">*</font>Delivery Executive</td>
                     <td align="left" class="dvtCellInfo" width="30%"  colspan="3">
                         <asp:DropDownList ID="ddlDeliveryex" runat="server"   class="small" 
                             Width="167px">
                         </asp:DropDownList>                        
                     </td></tr>
                     
                           <tr>    		<td colspan=4 class="detailedViewHeader">
                                                	        		            <b>Inward - Outword Detail </b>																 		</td>
		                                        	   </tr>     
                     <tr style="height:25px">
                     <td align="right" class="dvtCellLabel" style="width: 4% ">
                         <font color="red">*</font>Pickup_date</td>
                     <td align="left" class="dvtCellInfo"width="30%"  colspan="3">
                      <asp:TextBox ID="txtPick" runat="server"></asp:TextBox>
                                         <asp:Image ID="Image1" runat="Server" ImageUrl="~/images/cal.gif" />                             
                                         <ajaxToolkit:CalendarExtender ID="calendarextender1" runat="server" 
                                             Format="dd/MM/yyyy" PopupButtonID="Image1" TargetControlID="txtPick" />                                 
                                        
                                      
                     </td>      </tr>  
                     
                     
                     <tr style="height:25px">
                     <td align="right" class="dvtCellLabel" style="width: 4%">
                         <font color="red">*</font>InTime Date</td>
                     <td align="left" class="dvtCellInfo"width="30%"  colspan="3">
                      <asp:TextBox ID="txtIntime" runat="server"></asp:TextBox>
                                         <asp:Image ID="Image2" runat="Server" ImageUrl="~/images/cal.gif" />
                             
                                         <ajaxToolkit:CalendarExtender ID="calendarextender2" runat="server" 
                                             Format="dd/MM/yyyy" PopupButtonID="Image2" TargetControlID="txtIntime" />
                                                                                                               
                     </td>      </tr>   
                     <tr style="height:25px">
                     <td align="right" class="dvtCellLabel" style="width: 4%">
                         <font color="red">*</font>Expected Delivery Date</td>
                     <td align="left" class="dvtCellInfo"width="30%"  colspan="3">
                      <asp:TextBox ID="txtexpdate" runat="server"></asp:TextBox>
                                         <asp:Image ID="Image3" runat="Server" ImageUrl="~/images/cal.gif" />
                             
                                         <ajaxToolkit:CalendarExtender ID="calendarextender3" runat="server" 
                                             Format="dd/MM/yyyy" PopupButtonID="Image3" TargetControlID="txtexpdate" />
                                                                                                               
                     </td>      </tr>
                        <tr style="height:25px">
                     <td align="right" class="dvtCellLabel" style="width: 4%">
                         <font color="red">*</font>OutTime Date</td>
                     <td align="left" class="dvtCellInfo"width="30%"  colspan="3">
                      <asp:TextBox ID="txtOut" runat="server"></asp:TextBox>
                                         <asp:Image ID="Image4" runat="Server" ImageUrl="~/images/cal.gif" />
                             
                                         <ajaxToolkit:CalendarExtender ID="calendarextender4" runat="server" 
                                             Format="dd/MM/yyyy" PopupButtonID="Image4" TargetControlID="txtOut" />
                                                                                                               
                     </td>      </tr>  
                        <tr style="height:25px">
                     <td align="right" class="dvtCellLabel" style="width: 4%">
                         <font color="red">*</font>Return Date</td>
                     <td align="left" class="dvtCellInfo"width="30%"  colspan="3">
                      <asp:TextBox ID="txtReturn" runat="server"></asp:TextBox>
                                         <asp:Image ID="Image5" runat="Server" ImageUrl="~/images/cal.gif" />
                             
                                         <ajaxToolkit:CalendarExtender ID="calendarextender5" runat="server" 
                                             Format="dd/MM/yyyy" PopupButtonID="Image5" TargetControlID="txtReturn" />
                                                                                                               
                     </td>      </tr>              
                    <tr>    		<td colspan=2 class="detailedViewHeader">
                                                	        		            <b>Gadget Detail</b>																 		</td>
		                                        	   </tr>        
		                                        	   
		            <tr style="height:25px">
																								 
	 	
							
										
				 <!-- uitype 111 added for noneditable existing picklist values - ahmed -->
			<td width="20%" class="dvtCellLabel" align=right>
				<font color="red">*</font>Gadget Type</td>
			<td width="30%" align=left class="dvtCellInfo">
       <asp:DropDownList ID="ddlType" runat="server" class=small Width="167px"  >      
             </asp:DropDownList> 
             <asp:RequiredFieldValidator ID="rfvddlType" runat="server" 
                             ControlToValidate="ddlType" Display="Dynamic" ErrorMessage="Select Gadget type" 
                             InitialValue="0"></asp:RequiredFieldValidator>
            </td>
					
			   </tr>
			  
			   
			    <tr style="height:25px">
																								 
	 	
							
										
				 <!-- uitype 111 added for noneditable existing picklist values - ahmed -->
			<td width=20% class="dvtCellLabel" align=right>Brand</td>

							<td width=30% align=left class="dvtCellInfo">
							<asp:TextBox ID="txtBrand" runat =server class=small MaxLength ="50" ></asp:TextBox>
							</td>
				
			   </tr>
		  <tr style="height:25px">
			
			  <td width="20%" class="dvtCellLabel" align=right>
										Model</td>
			
			<td width="30%" align=left class="dvtCellInfo">
						
						<asp:TextBox ID="txtModel" runat =server class=small MaxLength ="50" ></asp:TextBox>
			            
			</td>
																									 
	 						
							
			   </tr>	 
			    <tr style="height:25px">				
				 <!-- uitype 111 added for noneditable existing picklist values - anmol -->
			<td width=20% class="dvtCellLabel" align=right>Gadget IMIE NO</td>

							<td width=30% align=left class="dvtCellInfo">
							<asp:TextBox ID="txtImieno" runat =server class=small MaxLength ="50" ></asp:TextBox>
							</td>
				
			   </tr>
			    <tr style="height:25px">
			
			  <td width="20%" class="dvtCellLabel" align=right>
										Screen</td>
			
			<td width="30%" align=left class="dvtCellInfo">
						
						<asp:TextBox ID="txtScreen" runat =server class=small MaxLength ="50" ></asp:TextBox>
			            
			</td>		
			   </tr>  
			   <tr style="height:25px">
			
			  <td width="20%" class="dvtCellLabel" align=right>
										Battery Serial No</td>
			
			<td width="30%" align=left class="dvtCellInfo">
						
						<asp:TextBox ID="txtBatterySerailNo" runat =server class=small MaxLength ="50" ></asp:TextBox>
			            
			</td>
		
										
						</tr>
			   
			   <tr style="height:25px">
																								 
	 	
							
										
				 <!-- uitype 111 added for noneditable existing picklist values - anmol -->
			<td width=20% class="dvtCellLabel" align=right>
			    Camera</td>

							<td width=30% align=left class="dvtCellInfo">
							<asp:TextBox ID="txtCamera" runat =server class=small MaxLength ="50" ></asp:TextBox>
							</td>
				
			   </tr>
			   
			  
							<tr style="height:25px">
			
			  <td width="20%" class="dvtCellLabel" align=right>
										Keypad</td>
			
			<td width="30%" align=left class="dvtCellInfo">
						
						<asp:TextBox ID="txtKeypad" runat =server class=small MaxLength ="50" ></asp:TextBox>
			            
			</td>

								
							</tr>	
							 <tr style="height:25px">
			
							
							<td width=20% class="dvtCellLabel" align=right>Adopter/Charger</td>

							<td width=30% align=left class="dvtCellInfo">
							<asp:TextBox ID="txtCharger" runat =server class=small MaxLength ="50" ></asp:TextBox>
							</td>
										</tr>  
										
								<tr style="height:25px">
			
			 <td width=20% class="dvtCellLabel" align=right>Front/Back Body</td>

							<td width=30% align=left class="dvtCellInfo">
							<asp:TextBox ID="txtbody" runat =server class=small MaxLength ="50" ></asp:TextBox>
							</td>

						
										
						</tr>			   
			   
			   	<tr style="height:25px">
			
			  <td width="20%" class="dvtCellLabel" align=right>
										Back Cover</td>
			
			<td width="30%" align=left class="dvtCellInfo">
						
						<asp:TextBox ID="txtBackcover" runat =server class=small MaxLength ="50" ></asp:TextBox>
			            
			</td>

				
							</tr>	
								
								
						<tr style="height:25px">
			
			  <td width="20%" class="dvtCellLabel" align=right>
										Data Card</td>
			
			<td width="30%" align=left class="dvtCellInfo">
						
						<asp:TextBox ID="txtDatacard" runat =server class=small MaxLength ="50" ></asp:TextBox>
			            
			</td>

							
										
						</tr>	
						
						<tr style="height:25px">
			
			<td width=20% class="dvtCellLabel" align=right>Data Cable</td>

							<td width=30% align=left class="dvtCellInfo">
							<asp:TextBox ID="txtDatcable" runat =server class=small MaxLength ="50" ></asp:TextBox>
							</td>
							
		
						</tr>
                      
                     </tr>	
					<tr style="height:25px">
			
			<td width=20% class="dvtCellLabel" align=right>Pattern Lock</td>

							<td width=30% align=left class="dvtCellInfo">
							<asp:TextBox ID="txtpattarn_lock" runat =server class=small MaxLength ="50" ></asp:TextBox>
							</td>
							
		
						</tr>
						<tr style="height:25px">
			
			<td width=20% class="dvtCellLabel" align="right"><font color="red">*</font>Phone Condition</td>

							<td width="30%" align="left" class="dvtCellInfo" >
                                <asp:DropDownList ID="ddlrentphone" runat="server" class="small" 
                                    MaxLength ="80" Width="130px" 
                                    >
                                </asp:DropDownList>
                                 <asp:RequiredFieldValidator ID="Rfvphoneinrent" runat="server" 
                             ControlToValidate="ddlrentphone" Display="Dynamic" ErrorMessage="Select Phone ON/OFF Condition" 
                             InitialValue="0"></asp:RequiredFieldValidator>

							
							</td>
							
		
						</tr>
							
								<tr style="height:25px">
			
			<td width=20% class="dvtCellLabel" align=right>Other Accessories</td>

							<td width=30% align=left class="dvtCellInfo">
							<asp:TextBox ID="txtOther" runat =server class=small MaxLength ="50" ></asp:TextBox>
							</td>
							
		
						</tr>
						
						<tr style="height:25px">
			
			 				
							<td width=20% class="dvtCellLabel" align=right>Store Remarks</td>

							<td width=30% align=left class="dvtCellInfo">
							<asp:TextBox ID="txtStoreRemarks" runat =server class=small MaxLength ="2000" 
                                    TextMode =MultiLine Columns =100 Rows =50 Height="48px" ></asp:TextBox>
							
							</td>
				
							</tr>
							                            	        
                
                 </table>
                    </td>
                     <td>
                     <asp:Panel ID="pnlCalllog" runat="server"  
               style=" z-index: 20; border-width:2px; border-style:groove; width: 400px; height:700px; padding-bottom:0px"  
              BackColor="LightGray"  >
              <table >
      
       <tr >
			  <td  class="detailedViewHeader" colspan ="2">
              <table>
              <tr>
              <td> <font size= "2"  ><b>Call Log Details</b></font></td></tr>
            <tr>  <td style="padding-left:0px"> <font><b>Expected Delivery Date&nbsp; :</b></font> 
                <asp:Label ID="lblexpdeldate"  style="padding-left:0px" runat ="server" 
                    ForeColor="Maroon" Font-Bold="True" ></asp:Label></td>
              </tr>
              </table>
			  </td>
           
			</tr>
      <tr >       
      <td >
          <asp:Label ID="lblError" runat="server" ForeColor="Red" Visible="false"></asp:Label>
          </td>
      <td align ="right" >
      <asp:ImageButton  ID="imgcalllog_close" runat =server ImageAlign =AbsMiddle 
                ImageUrl ="~/images/close.gif"  CausesValidation =false 
               Visible= "false" >
          </asp:ImageButton>
        </td>
      </tr>
      <tr >
      <td align ="left" colspan= "2" >        
       
          <asp:TextBox ID="txtCallLog" runat="server" Height="157px" TextMode="MultiLine" 
              Width="392px"></asp:TextBox>
      </td>
      </tr>
                  <tr>
                      <td align="left" colspan="2">
                          <asp:Button ID="btnlogSave" runat="server" onclick="btnlogSave_Click" 
                              Text="Save" Width="42px" />
                          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                          <asp:Button ID="btnCancle" runat="server" onclick="btnCancle_Click" 
                              Text="Reset" />
                      </td>
                  </tr>
                  <tr>
                      <td align="left" colspan="2">
                          <div ID="Div1" cellspacing="0" class="grid" rules="cols" 
                            >
                              <asp:GridView ID="grdCalllog" runat="server" AutoGenerateColumns="False" 
                                  EmptyDataText="No record found." >
                                  <Columns>
                                      <asp:BoundField DataField="requestId" HeaderText="Request ID" />
                                      <asp:BoundField DataField="description" HeaderText="Description" />
                                   <asp:BoundField DataField="equipmentStatus_name" HeaderText="Status" />
                                      <asp:BoundField DataField="created_date" HeaderText="Created_on" />
                                      <asp:BoundField DataField="created_by" HeaderText="Created_by" />
                                      
                                  </Columns>
                              </asp:GridView>
                          </div>
                      </td>
                  </tr>
      </table>
   
		</asp:Panel>
        <table style="height:648px; padding-top:00px; padding-bottom:00px">
   <tr><td></td></tr>
   
   </table>
                     </td>
                    </tr>  
             
                 <tr>
                     <td colspan="4" style="padding:5px">
                         <div align="center">
                             <asp:Button ID="btnSave1" runat="server" onclick="btnSave1_Click" 
                                 OnClientClick="return displayLoadingImage();" style="height: 26px" 
                                 Text="Save" />
                             &nbsp;
                             <asp:Button ID="Button2" runat="server" CausesValidation="false" onclick="Button2_Click" Text="Cancel" />
                            
                         </div>
                     </td>
                 </tr>
								   
								</table>
							</td>

				   </tr>
				</table>
					
			    </div>
			    <!-- Basic Information Tab Closed -->

			    <!-- More Information Tab Opened -->

			   
			<div>
  
  </div>
			   

			</td>
		   </tr>
		</table>
                                                        </ContentTemplate>
                                                        </asp:UpdatePanel>
                                                        
                                                        
                                                        
</asp:Content>

