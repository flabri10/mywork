<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MeldPåAktivitet.aspx.cs" Inherits="MeldPåAktivitet" %>


<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" Runat="Server">
<h2><asp:Literal ID="litAktivitetNavn" runat="server"></asp:Literal></h2>

<asp:Literal ID="litFeilmelding" runat="server"></asp:Literal>

<asp:Panel ID="pnlMeldPåAktivitet" runat="server">
    <p><asp:Literal ID="litBrukerInfo" runat="server"></asp:Literal></p>
    <asp:Button ID="btnMeldPåAktivitet" runat="server" Text="Meld meg på denne aktiviteten" OnClick="_MeldPåAktivitet" CssClass="btnSkjemaKnapp" />
</asp:Panel>
</asp:Content>

