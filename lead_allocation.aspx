<%@ Page Language="C#" AutoEventWireup="true" CodeFile="lead_allocation.aspx.cs" Inherits="lead_allocation" Culture ="en-GB" UICulture ="en-GB"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1"  runat="server">
  
    <link href ="../css/crm_style.css" rel="stylesheet" type="text/css"/>
   
   <%-- <script type="text/javascript" src="Jscript/Menu.js"></script>--%>

    <%--<link href="http://fonts.googleapis.com/css?family=Armata" rel='stylesheet' type='text/css'>--%>
    
    <title>::GadgetGold - HelpDesk :: </title>  

   <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
   <script type="text/javascript" src="../Jscript/mtmv.js"></script>
   <link href ="../css/doplus_style.css" rel="stylesheet" type="text/css"/>

   <script language="javascript" type="text/javascript">
       function Add() {
           var ab, cd, ef, gh;
           ab = parseFloat(document.getElementById("txt_amt").value);
           if (isNaN(ab) == true) {
               ab = 0;
           }
           cd = parseFloat(document.getElementById("txtgivenamt").value);
           if (isNaN(cd) == true) {
               cd = 0;
           }
           var mNm = (parseFloat(ab)) - (parseFloat(cd));
           var xxd = mNm.toFixed(2);
           document.getElementById("txtdues").value = xxd;


       }
      </script>
   <script type="text/javascript" language="javascript">
       window.onload = blinkOn;

       function blinkOn() {
           document.getElementById("blink").style.color = "Black"
           setTimeout("blinkOff()", 300)
       }

       function blinkOff() {
           document.getElementById("blink").style.color = "Red"
           setTimeout("blinkOn()", 300)
       }



</script>
   <style type="text/css">
   /* Begin Navigation Bar Styling */
   #nav {
      width: 95%;
      float: left;
      margin: 0 0 3em 0;
      padding: 0;
      list-style: none;
      background-color: #f2f2f2;
      border-bottom: 1px solid #ccc; 
      border-top: 1px solid #ccc;
      height:30px;
     
      }
   #nav li {
      float: left;
       height:30px;
       }
   #nav li a {
      display: block;
      padding: 5px 15px;
      text-decoration: none;
      font-weight: bold;
      color: #069;
      border-right: 1px solid #ccc;
      height:15px;
        }
        
   #nav li a:hover {
      color: #c00;
      background-color: #fff;
       height:15px; 
       }
   /* End navigation bar styling. */
   
   /* This is just styling for this specific page. */
 
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:ScriptManager ID="emp2" EnableScriptGlobalization="true" EnableScriptLocalization="true" EnablePartialRendering="true" 
  ScriptMode="Release" runat="server">
</asp:ScriptManager>
        <div class="detailedViewHeader">
<p class="lvtHeaderText"> Lead Allocation </p>
</div>
    
    
    <div class="mGrid"    id="Div1" style="width:100%;border-collapse:collapse; padding-top:0px"">
        <asp:GridView ID="grdLead" runat="server" AutoGenerateColumns="False" GridLines="None"
             Style="font-size: 13px;width:100%" 
            EmptyDataText="No lead found for the criteria you selected." 
            onrowcommand="grdLead_RowCommand" onrowediting="grdLead_RowEditing"  
           >
            <FooterStyle BackColor="#CCCC99" HorizontalAlign="Right" Font-Bold ="true" />
            <Columns>
                <asp:TemplateField HeaderText="Create lead">
                    <ItemTemplate>
                        <%-- <asp:LinkButton ID="imgLnk" runat=server CommandName ="edit" ToolTip ="Click to edit" Text ="Edit" ForeColor =Blue   />--%>
                        <asp:ImageButton ID="imgincentive" ImageUrl="~/images/quotation-icon.jpg" runat="server"
                            CommandName="edit" ToolTip="Click to Create Lead" CausesValidation="false" />
                    </ItemTemplate>
                </asp:TemplateField>
              
                <asp:TemplateField HeaderText="Lead No." Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="lblLeadNo" runat="server" Text='<%#Eval("Lead_no") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="sno" HeaderText="Sno" />
                <asp:BoundField DataField="customername" HeaderText="Customer Name" />
                <%-- <asp:BoundField DataField ="company" HeaderText ="Company"/>--%>
                <asp:BoundField DataField="mobile_no" HeaderText="Mobile" />
                <%--<asp:BoundField DataField ="phone" HeaderText ="Phone"  />--%>
                <asp:BoundField DataField="Email" HeaderText="Email" />
                 <asp:BoundField DataField="issue" HeaderText="Description" />
                <asp:BoundField DataField="leadsource_name" HeaderText="Lead Source" />
                <asp:BoundField DataField="lead_status" HeaderText="Lead Status" />
                <asp:BoundField DataField="allocate_to" HeaderText="Allocate_to" />
                <asp:BoundField DataField="created_on1" HeaderText="Date" />
               <%-- <asp:BoundField DataField="office_name" HeaderText="city" />--%>
                <asp:TemplateField HeaderText="mobile_no" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="lblmobile" runat="server" Text='<%#Eval("mobile_no") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="officeid" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="office_id" runat="server" Text='<%#Eval("office_id") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="lead_status" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="lead_status" runat="server" Text='<%#Eval("lead_status") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Email" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="lblemail" runat="server" Text='<%#Eval("Email") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="allocate_to" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="allocate_to" runat="server" Text='<%#Eval("allocated_to") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="customername" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="customername" runat="server" Text='<%#Eval("customername") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="lead_name" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="lead_name" runat="server" Text='<%#Eval("lead_source") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>        
    </div>
    
    </div>
    </form>
</body>
</html>