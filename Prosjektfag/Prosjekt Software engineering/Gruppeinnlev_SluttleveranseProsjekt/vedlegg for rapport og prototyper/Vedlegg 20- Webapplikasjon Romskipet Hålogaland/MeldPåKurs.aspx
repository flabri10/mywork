<%@ Page Title="Romskipet Hålogaland - Kurspåmelding" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MeldPåKurs.aspx.cs" Inherits="MeldPåKurs" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" Runat="Server">
<h2><asp:Literal ID="litKursNavn" runat="server"></asp:Literal></h2>

<p class="failure"><asp:Literal ID="litFeilmelding" runat="server"></asp:Literal></p>

<asp:Panel ID="pnlMeldPåKurs" runat="server">
    <p><asp:Literal ID="litBrukerInfo" runat="server"></asp:Literal></p>
    <asp:Button ID="btnMeldPåKurs" runat="server" Text="Meld meg på dette kurset" OnClick="_MeldPåKurs" CssClass="btnSkjemaKnapp" />
</asp:Panel>

</asp:Content>



