<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="filmanmeldelser.aspx.cs" Inherits="Innlevering3_flabri10.filmanmeldelser" %>
<!DOCTYPE HTML>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Filmanmeldelser</title>
<link href="stilark.css" rel="Stylesheet" type="text/css" />
<script type="text/javascript" src="jquery-1.8.2.js"></script>
<script type="text/javascript">
<!--
$(function () {    
    $('article.modul h3').click(function () {

    if ($(this).next('p').is(':hidden')) {

        $(this).next('p').slideDown(500);

        $(this)
		.parent()
		.siblings()
		.children('p')
        .slideUp(500);
    } else {
        $(this).next('p').slideUp(500);
    }
    });
});
-->
</script>
</head>
<body>
<form id="form1" runat="server">
<div id="divContainer">
    <div id="divHeader">
        <h1>Filmanmeldelser</h1>
    </div>
        <p>Legg inn din anmeldelse<a href="nyAnmeldelse.aspx">her</a></p>
    <hr />

    <div id="divSoek">
        <table>    
            <tr>
                <td>Epost</td>
                <td><asp:TextBox ID="txtSoekEpost" runat="server"></asp:TextBox></td>
                <td><asp:RegularExpressionValidator ID="revSoekEpost" runat="server"
                    ControlToValidate="txtSoekEpost" ErrorMessage="Endre til epostformat"
                    ForeColor="#333333" SetFocusOnError="true"
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                </td>
                <td>
                    <asp:Button ID="btnSoekEpost" runat="server" onClick="HentAnmeldelse" Text="Søk" />
                </td>
            </tr>
        </table>
    </div>
    
    <h2>Filmliste</h2>
    <asp:Label ID="lblResultatEpost" runat="server"></asp:Label>
    <asp:Literal ID="litListe" runat="server"></asp:Literal>
</div>
</form>
</body>
</html>
