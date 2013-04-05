<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Logginn.aspx.cs" Inherits="Logginn" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Logg inn- MinKunst.no</title>
</head>
<body>
<form id="form1" runat="server">
<div id="loggInn">
    <h1>Logg inn</h1>
    <table>
        <tr>
            <td>Brukernavn:</td>
            <td><asp:TextBox ID="txtBrukernavn" runat="server"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="rfvBrukernavn" runat="server"
                        ControlToValidate="txtBrukernavn" ErrorMessage="Brukernavn må oppgis!"
                        ForeColor="Red" SetFocusOnError="true">*</asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>Passord</td>
            <td><asp:TextBox ID="txtPassord" runat="server" TextMode="Password"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="rfvPassord" runat="server"
                        ControlToValidate="txtPassord" ErrorMessage="Gyldig passord må oppgis!"
                        ForeColor="Red" SetFocusOnError="true">*</asp:RequiredFieldValidator></td>
        </tr>
    </table>
    <asp:Button ID="btnLoggInn" Text="Logg inn" runat="server" OnClick="LoggInn" />
    <asp:ValidationSummary ID="vsSammendrag" runat="server" />
    <asp:Literal ID="litLoggInnStatus" runat="server"></asp:Literal>
</div>
</form>
</body>
</html>
