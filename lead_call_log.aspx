<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="lead_call_log.aspx.cs" Inherits="lead_call_log" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div>
<table style="width:100%;background-color:#DDDDDD; border-bottom-color:White; border-bottom-style:solid; border-bottom-width:1px">
 <tr>

<td  style="width:100%; padding-bottom:30px; padding-left:20px; height:0px; padding-top:10px">
<label style=" font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:20px;padding-left:20px">
Call Logs </label>
  
</td>
</tr>
 </table>


</div>
<div style="background-color:#DDDDDD; padding-left:200px; padding-top:5px">
<table   style="background-color:#DDDDDD" >
 <tr> 
 <td    align ="left" style="width:133px"   >Lead No&nbsp; </td>
  <td >
        
    <%-- <asp:TextBox ID="txtlead_no" runat="server"  
          AutoPostBack="True" 
          CausesValidation="True"  ></asp:TextBox>
    --%>
    <asp:Label ID="lbl_lead_no" runat="server" Text=""></asp:Label>
          
                        
     </td>

   <td>
    
                   
</td>

                           
 </tr>
        
        
         
 
        <tr style=" border-color:Black; border-style:solid; border-width:1px;padding-top:5px"">
        <td style="padding-top:10px; width: 133px;" > 
        Description
        
            <br />
        
        </td>
        <td style="padding-top:5px" >
        
         <asp:TextBox  TextMode="MultiLine" ID="txtDescription" Columns="28" Rows="3" 
                runat="server" Height="97px" Width="334px"></asp:TextBox>
          </td> 
       
        
        </tr>
  
     <tr>
         <td  align ="left" style="padding-top:5px"></td>
         <td  style="padding-top:5px"><asp:Label ID="lbllead_status" runat="server" Text="" Visible="false"></asp:Label> &nbsp;  
             
         </td>
       
     </tr>
     <tr><td></td>
      <td align="center" style="padding-top:8px" >
          <asp:Button ID="btncalllogsave" runat ="server" Text ="Save" 
                
              OnClientClick ="return displayLoadingImage();" Width="82px" onclick="btncalllogsave_Click" 
              />&nbsp;&nbsp;
        <asp:Image ImageUrl="~/images/rotation.gif"  runat="server"  
                                                id="Image2" style="Z-INDEX: 101; LEFT: 524px; VISIBILITY:hidden ;  

POSITION: absolute; TOP: 240px; width: 60px;"/>
	
          <asp:Button ID="btncalllogcancel" runat ="server" Text ="Cancel" 
                 Width="97px" onclick="btncalllogcancel_Click" />
           
         </td>
        <td >
            &nbsp;</td>
     </tr>
        
    
     
      </table> 
      
      </div>
      <table style=" height:25px;background-color:#DDDDDD; width: 100%"><tr><td></td></tr>
       </table>
      <table width="100%">
      <tr>
     <td >
      <asp:GridView ID="grdCalllog" runat="server" 
             AllowSorting="True" AutoGenerateColumns="False"  class="grid" 
             EmptyDataText ="No Record found for the criteria you selected." 
                       
             >
          <Columns>
          <asp:TemplateField HeaderText="Serial No.">
 <ItemTemplate>
 <%#Container.DataItemIndex+1 %>
 </ItemTemplate>
 </asp:TemplateField>
           <asp:BoundField DataField="serial_no" Visible="false" HeaderText="Serial_No" />  
              <asp:BoundField DataField="lead_no" HeaderText="Lead_No" /> 
              <asp:BoundField DataField="lead_status" HeaderText="Lead Status" />   
              <asp:BoundField DataField="description" HeaderText="Description" /> 
              <asp:BoundField DataField="created_by" HeaderText="Created_by" />
              <asp:BoundField DataField="created_on" HeaderText="Created_on" />
                
                                    
             
          </Columns>
            </asp:GridView>
            </td>
           </tr></table>

</asp:Content>

