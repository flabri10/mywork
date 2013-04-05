<%@ Page Title="Romskipet Hålogaland - Rediger kurs" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RedigerKurs.aspx.cs" Inherits="RedigerKurs" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" Runat="Server">
<h2>Rediger Kurs</h2>
<asp:Literal ID="litFeilmelding" runat="server"></asp:Literal>
    <table class="tblTabellSkjema">
        <tr>
            <td>Kursnavn</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtKursnavn" runat="server" CssClass="brukerInput"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Kursbeskrivelse</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtKursBeskrivelse" runat="server" CssClass="brukerInput" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Påmeldingsfrist (dd.mm.yyyy)</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtPåmeldingsfrist" runat="server" CssClass="brukerInput"></asp:TextBox>
            </td>
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
            <td>Målgruppe</td>
        </tr>
        <tr>
            <td><asp:DropDownList ID="ddlMålgruppe" runat="server">
                <asp:ListItem>Elever</asp:ListItem>
                <asp:ListItem>Studenter</asp:ListItem>
                <asp:ListItem>Lærere</asp:ListItem>
            </asp:DropDownList></td>
        </tr>

        <tr>
            <td>Maks antall deltakere</td>
        </tr>
        <tr>
            <td><asp:TextBox ID="txtMaksAntallDeltakere" runat="server" CssClass="brukerInput"></asp:TextBox></td>
        </tr>

        <tr>
            <td>Ankomst/Avreise</td>
        </tr>
        <tr>
            <td><asp:TextBox ID="txtTilleggsInformasjon" runat="server" CssClass="brukerInput" TextMode="MultiLine"></asp:TextBox></td>
        </tr>

        <tr>
            <td>Kursansvarlig</td>
        </tr>
        <tr>
            <td><asp:TextBox ID="txtKursansvarlig" runat="server" CssClass="brukerInput"></asp:TextBox></td>
        </tr>

        <tr>
            <td>Samarbeidspartnere</td>
        </tr>
        <tr>
            <td><asp:TextBox ID="txtSamarbeidspartnere" runat="server" CssClass="brukerInput" TextMode="MultiLine"></asp:TextBox></td>
        </tr>
    </table>

    <asp:Button ID="btnLagreEndringer" runat="server" Text="Lagre endringer" CssClass="btnSkjemaKnapp" OnClick="LagreEndringer"/>
    <asp:Button ID="btnSlettKurs" runat="server" Text="Slett dette kurset" onclick="SlettKurs" CssClass="btnSkjemaKnapp"/>

</asp:Content>

