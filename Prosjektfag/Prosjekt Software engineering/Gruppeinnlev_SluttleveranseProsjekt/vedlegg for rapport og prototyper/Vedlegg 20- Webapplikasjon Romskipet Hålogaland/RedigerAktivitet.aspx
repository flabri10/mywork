<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RedigerAktivitet.aspx.cs" Inherits="RedigerAktivitet" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" Runat="Server">
<h2>Rediger aktivitet</h2>
<asp:Literal ID="litAktivitetFeilmelding" runat="server"></asp:Literal>

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
        <td>
            <asp:Button ID="btnLeggTilAktivitet" runat="server" CssClass="btnSkjemaKnapp" Text="Lagre endringer" OnClick="LagreEndringer" />
            <asp:Button ID="btnSlettAktivitet" runat="server" CssClass="btnSkjemaKnapp" Text="Slett aktivitet" OnClick="SlettAktivitet" />
        </td>
    </tr>


</table>
</asp:Content>

