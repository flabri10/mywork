<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="NyttProdukt.aspx.cs" Inherits="NyttProdukt" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" Runat="Server">
<h2>Nytt produkt i nettbutikk</h2>
<p>Bruk skjemaet under for å legge til et nytt produkt i nettbutikken.</p>
    <table class="tblTabellSkjema">
        <tr>
            <td>Produktnavn</td>
        </tr>
        <tr>
            <td><asp:TextBox ID="txtProduktNavn" runat="server" CssClass="brukerInput"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="rfvProduktNavn" runat="server"
                        ControlToValidate="txtProduktNavn" ErrorMessage="Produktnavn er påkrevd!"    
                        ForeColor="Red" SetFocusOnError="true">*</asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>Pris</td>
        </tr>
        <tr>
            <td><asp:TextBox ID="txtPris" runat="server" CssClass="brukerInput"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="rfvPris" runat="server"
                        ControlToValidate="txtPris" ErrorMessage="Pris er påkrevd!"    
                        ForeColor="Red" SetFocusOnError="true">*</asp:RequiredFieldValidator>
            <asp:RangeValidator ID="rvPris" runat="server"
                        ControlToValidate="txtPris" ErrorMessage="må være mellom 1 og 3000kr"
                        ForeColor="Red" Type="Integer" MinimumValue="1" MaximumValue="3000">*</asp:RangeValidator></td>
        </tr>

        <tr>
            <td>Beskrivelse</td>
        </tr>
        <tr>
            <td><asp:TextBox ID="txtProduktBeskrivelse" runat="server" TextMode="MultiLine" CssClass="brukerInput"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="rfvBeskrivelse" runat="server"
                        ControlToValidate="txtProduktBeskrivelse" ErrorMessage="Beskrivelse er påkrevd!"    
                        ForeColor="Red" SetFocusOnError="true">*</asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>Bilde</td>
        </tr>
        <tr>
            <td><asp:FileUpload ID="fuBilde" runat="server" /></td>
            <td><asp:RequiredFieldValidator ID="rfvBilde" runat="server"
                        ControlToValidate="fuBilde" ErrorMessage="Bilde er påkrevd!"    
                        ForeColor="Red" SetFocusOnError="true">*</asp:RequiredFieldValidator></td>
        </tr>
    </table>

    <asp:Button ID="btnLagreProdukt" runat="server" Text="Lagre produkt" OnClick="LagreProdukt" CssClass="btnSkjemaKnapp"/>
    <asp:Label ID="lblStatus" runat="server" />
    <asp:ValidationSummary ID="vsNettbutikkStatus" runat="server" />
</asp:Content>

