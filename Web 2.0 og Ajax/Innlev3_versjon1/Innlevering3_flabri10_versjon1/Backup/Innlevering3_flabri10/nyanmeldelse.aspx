<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="nyanmeldelse.aspx.cs" Inherits="Innlevering3_flabri10.nyanmeldelse" %>
<!DOCTYPE HTML>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Filmanmeldelser-Legg til ny</title>
    <link href="stilark.css" rel="Stylesheet" type="text/css" />
</head>
<body>
<form id="form1" runat="server">
<div id="divContainer">
    <h1>Filmanmeldelser</h1>
    <a href="filmanmeldelser.aspx">Tilbake til listen</a>
    
    <h2>Legg inn din anmeldelse</h2>
    <table>
        <tr>
            <td>Epost</td>
            <td><asp:TextBox ID="txtEpost" runat="server"></asp:TextBox></td>
            <td><asp:RegularExpressionValidator ID="revEpost" runat="server"
                ControlToValidate="txtEpost" ErrorMessage="Endre til epostformat"
                ForeColor="#333333" SetFocusOnError="true"
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>Tittel</td>
            <td><asp:TextBox ID="txtTittel" runat="server"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="rfvTittel" runat="server"
                ControlToValidate="txtTittel" ErrorMessage="Tittel er påkrevd!"    
                ForeColor="#333333" SetFocusOnError="true">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Anmeldelse</td>
            <td><asp:Textbox ID="txtAnmeldelse" textmode="multiline" Rows="10" Columns="30" runat="server"></asp:Textbox></td>
            <td><asp:RequiredFieldValidator ID="rfvAnmeldelse" runat="server"
                ControlToValidate="txtAnmeldelse" ErrorMessage="Anmeldelse er påkrevd!"    
                ForeColor="#333333" SetFocusOnError="true">*</asp:RequiredFieldValidator>
            </td>
        </tr>  
        <tr>
            <td>Vurdering</td>
            <td>
                <asp:RadioButtonList ID="rblVurdering" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Text="1"></asp:ListItem>
                    <asp:ListItem Text="2"></asp:ListItem>
                    <asp:ListItem Text="3"></asp:ListItem>
                    <asp:ListItem Text="4"></asp:ListItem>
                    <asp:ListItem Text="5"></asp:ListItem>
                    <asp:ListItem Text="6"></asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td><asp:RequiredFieldValidator ID="rfvRadio" runat="server"
                ControlToValidate="rblVurdering" ErrorMessage="Vurdering er påkrevd!"    
                ForeColor="#333333" SetFocusOnError="true">*</asp:RequiredFieldValidator>
            </td>
        </tr>
    </table>
    <asp:Button ID="btnLeggTil" runat="server" Text="Legg til anmeldelse" OnClick="leggTilAnmeldelse" />
    <asp:Label ID="lblStatus" runat="server"></asp:Label>

    <div id="divStatus">
        <asp:ValidationSummary ID="vsStatus" runat="server" ForeColor="#333333" />
    </div>
    
    <asp:Literal ID="litListe" runat="server"></asp:Literal>
</div>
</form>
</body>
</html>
