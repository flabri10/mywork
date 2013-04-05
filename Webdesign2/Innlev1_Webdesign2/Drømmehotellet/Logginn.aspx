<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Logginn.aspx.cs" Inherits="Logginn" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Logg inn- Drømmehotellet</title>
<style type="text/css">
.style1 
{
    width: 35px;
}
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Drømmehotellet- Administrasjon</h1>
        <h2>Logg inn</h2>
        <table>
        <tr>
            <td>
                <label for="lblBrukernavn">Brukernavn:</label>
            </td>
            <td>
                <asp:TextBox ID="txtBrukernavn" runat="server"></asp:TextBox>
            </td>
            <td class="style1"><asp:RequiredFieldValidator ID="rfvBrukernavn" runat="server"
                        ControlToValidate="txtBrukernavn" ErrorMessage="Brukernavn må oppgis!"
                        ForeColor="Red" SetFocusOnError="true">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
            <label for="lblPassord">Passord:</label>
            </td>
            <td>
                <asp:TextBox ID="txtPassord" runat="Server" TextMode="Password"></asp:TextBox>
            </td>
            <td class="style1"><asp:RequiredFieldValidator ID="rfvPassord" runat="server"
                        ControlToValidate="txtPassord" ErrorMessage="Passord må oppgis!"
                        ForeColor="Red" SetFocusOnError="true">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        </table>
        <asp:Button ID="btnLogginn" runat="server" Text="Logg inn" OnClick="Logginn_bruker"/>
        <div id="divStatus">
        <asp:ValidationSummary ID="vsStatus" runat="server" />
        <asp:Literal ID="litLoggInnStatus" runat="server"></asp:Literal>
    </div>
    </div>
    </form>
</body>
</html>
