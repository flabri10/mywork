<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="NyAktivitet.aspx.cs" Inherits="NyAktivitet" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" Runat="Server">
<h2>Ny aktivitet</h2>

<table class="tblTabellSkjema">
    <tr>
        <td>Aktivitetnavn</td>
    </tr>
    <tr>
        <td><asp:TextBox ID="txtAktivitetNavn" runat="server" CssClass="brukerInput"></asp:TextBox></td>
    </tr>

    <tr>
        <td>Beskrivelse</td>
    </tr>
    <tr>
        <td><asp:TextBox ID="txtAktivitetBeskrivelse" runat="server" TextMode="MultiLine" CssClass="brukerInput"></asp:TextBox></td>
    </tr>

    <tr>
        <td>Startdato (dd.mm.yyyy)</td>
    </tr>
    <tr>
        <td><asp:TextBox ID="txtStartdato" runat="server" CssClass="brukerInput"></asp:TextBox></td>
    </tr>

    <tr>
        <td>Sluttdato (dd.mm.yyyy)</td>
    </tr>
    <tr>
        <td><asp:TextBox ID="txtSluttdato" runat="server" CssClass="brukerInput"></asp:TextBox></td>
    </tr>

    <tr>
        <td>Starttidspunkt (tt.mm)</td>
    </tr>
    <tr>
        <td><asp:TextBox ID="txtStartTidspunkt" runat="server" CssClass="brukerInput"></asp:TextBox></td>
    </tr>

    <tr>
        <td>Sluttidspunkt (tt.mm)</td>
    </tr>
    <tr>
        <td><asp:TextBox ID="txtSluttTidspunkt" runat="server" CssClass="brukerInput"></asp:TextBox></td>
    </tr>

    <tr>
        <td><asp:Button ID="btnLeggTilAktivitet" runat="server" CssClass="btnSkjemaKnapp" Text="Legg til aktivitet" OnClick="LeggTilAktivitet"/></td>
    </tr>


</table>
</asp:Content>

