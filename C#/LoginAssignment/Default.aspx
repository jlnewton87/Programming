<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Agent Login</title>
    <link href="content/style/site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <img src="content/images/FBI_Seal_300.png" title="FBI" alt="FBI" class="center"/>
        <div id="login-section">
            
            <asp:Login ID="Login1" runat="server" BorderPadding="5" 
                UserNameLabelText="Agent Id:" 
                UserNameRequiredErrorMessage="Agent Id is required." Width="252px" 
                BorderWidth="5px" VisibleWhenLoggedIn="False" 
                DestinationPageUrl="~/MissionList.aspx">
            </asp:Login>
            <p style="text-align:center;">
                DISCLAIMER: This is not ACTUALLY a federal site.  The Agent Id is 'agent007', and the password is 'password!' (both without the ' ')
            </p>
            
        </div>
        <div id="footer">
            <p id="footer-content">This is a SECURED and MONITORED government system. Unauthorized access is strictly prohibited. All
             activity is fully monitored. Individuals who attempt to gain unauthorized access or attempt any modification of information on 
             this systemis subject to criminal prosecution. All persons who are hereby notified that use of this system constitutes consent 
             to monitoring and auditing.</p>
        </div>
    </div>
    </form>
</body>
</html>
