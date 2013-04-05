<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RedigerProdukt.aspx.cs" Inherits="RedigerProdukt" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" Runat="Server">
    <h2>Rediger produkt</h2>
    <asp:Literal ID="litProduktFeilmelding" runat="server"></asp:Literal>
    <table class="tblTabellSkjema">
        <tr>
            <td>Produktnavn</td>
        </tr>
        <tr>
            <td><asp:TextBox ID="txtProduktNavn" runat="server" CssClass="brukerInput"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="rfvProduktNavn" runat="server"
                        ControlToValidate="txtProduktNavn" ErrorMessage="Produktnavn er påkrevd!"    
                        ForeColor="Red" SetFocusOnError="true" ValidationGroup="vgRedigerStatus">*</asp:RequiredFieldValidator></td>
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
            <td><asp:FileUpload ID="fuBilde" runat="server"/></td>
        </tr>
        <tr>
            <td><asp:Button ID="btnLagreEndringer" runat="server" Text="Lagre endringer" CssClass="btnSkjemaKnapp" OnClick="LagreEndringer"/><asp:Button ID="btnSlettProdukt" runat="server" Text="Slett produkt" CssClass="btnSkjemaKnapp" OnClick="SlettProdukt" />  </td>
        </tr>
    </table>

    <asp:ValidationSummary ID="vsRedigerStatus" runat="server" />
</asp:Content>

