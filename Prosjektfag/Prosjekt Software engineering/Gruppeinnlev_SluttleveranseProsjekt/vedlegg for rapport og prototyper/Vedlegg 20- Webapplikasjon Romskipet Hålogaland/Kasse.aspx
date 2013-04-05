<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Kasse.aspx.cs" Inherits="Kasse" %>


<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" Runat="Server">
    <h2>Kasse</h2>
    <asp:Literal ID="litIngenVarer" runat="server"></asp:Literal>
    <asp:Panel ID="pnlKasse" runat="server">
    <h3>Ordreoppsummering</h3>
        <asp:Literal ID="litOrdreOppsummering" runat="server"></asp:Literal>
        <asp:Label ID="lblSum" runat="server"></asp:Label>
    <h3>Leveringsinformasjon</h3>
    <table class="tblTabellSkjema">
        <tr>
            <td>Adresse</td>
        </tr>
        <tr>
            <td><asp:TextBox ID="txtAdresse" runat="server" CssClass="brukerInput"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="rfvAdresse" runat="server" ControlToValidate="txtAdresse" ErrorMessage="Adresse er påkrevd" ForeColor="Red" ValidationGroup="vgKasseSummary">*</asp:RequiredFieldValidator></td>
        </tr>

        <tr>
            <td>Postnummer</td>
        </tr>
        <tr>
            <td><asp:TextBox ID="txtPostnummer" runat="server" CssClass="brukerInput"></asp:TextBox></td>
        </tr>
    </table>

    <asp:ValidationSummary ID="vsKasseSummary" runat="server" ValidationGroup="vgKasseSummary"/>
    <a href="Handlekurv.aspx" class="btnSkjemaKnapp">Tilbake til handlekurven</a>
    <asp:Button ID="btnKjøp" runat="server" Text="Kjøp" CssClass="btnSkjemaKnapp" OnClick="KjøpVarer"/>
    </asp:Panel>
</asp:Content>

