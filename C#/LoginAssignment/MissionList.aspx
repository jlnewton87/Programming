<%@ Page Language="VB" AutoEventWireup="false" CodeFile="MissionList.aspx.vb" Inherits="MissionList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Your Missions</title>
    <link href="content/style/site.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            width: 245px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <img src="content/images/FBI_Seal_300.png" title="FBI" alt="FBI" class="center"/>
        <div id="mission_list">
            <h1>
                <asp:LoginName ID="LoginName1" runat="server" FormatString="Thank you for logging in, {0}." /> <span id="login_status">
                    <asp:LoginStatus ID="LoginStatus1" runat="server" LogoutAction="Redirect" 
                    LogoutPageUrl="~/Default.aspx" />
                </span>
            </h1>
            <p>
                Your missions, should you choose to accept:
            </p>
            <table>
                <thead>
                    <tr>
                        <td class="style1">From</td>
                        <td>Description</td>
                    </tr>
                </thead>
                <tr>
                    <td class="style1">FBI</td>
                    <td>Save NY from terrorists</td>
                </tr>
                <tr>
                    <td class="style1">MI6</td>
                    <td>Chase criminals in fancy sports car</td>
                </tr>
                <tr>
                    <td class="style1">M</td>
                    <td>Pick up dry cleanin</td>
                </tr>
            </table>
        </div>
        <div id="footer">
            <p id="footer-content">This is a SECURED and MONITORED government system. Unauthorized access is strictly prohibited. All
                activity is fully monitored. Individuals who attempt to gain unauthorized access or attempt any modification of information on 
                this systemis subject to criminal prosecution. All persons who are hereby notified that use of this system constitutes consent 
                to monitoring and auditing.
            </p>
        </div>
    </div>
    </form>
</body>
</html>
