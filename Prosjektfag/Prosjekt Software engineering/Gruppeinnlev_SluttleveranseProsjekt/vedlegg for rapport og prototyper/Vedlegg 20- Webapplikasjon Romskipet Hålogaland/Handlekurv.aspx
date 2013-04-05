<%@ Page Title="Handlekurv" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Handlekurv.aspx.cs" Inherits="Handlekurv" %>

<asp:Content ID="contentHandlekurv2" ContentPlaceHolderID="cphMainContent" Runat="Server">
    <h2>Handlekurv</h2>
    <p>Du har <asp:Label ID="lbAntallVarer" runat="server"></asp:Label> varer i handlekurven din.</p>
    <div id="handleKurvNav">
        <a href="Nettbutikk.aspx" runat="server" class="btnSkjemaKnapp">Fortsett å handle</a>
        <a href="Kasse.aspx" runat="server" class="btnSkjemaKnapp">Gå til kassen</a>
    </div>

    <asp:Panel ID="pnlHandlekurv" runat="server">
        <asp:Literal ID="litProduktListe" runat="server"></asp:Literal>
        <div id="produktSumHandlekurv"><p class="success">Sum: <asp:Literal ID="litProduktSum" runat="server"></asp:Literal></p></div>
    </asp:Panel>

    <div class="clearfix"></div>
</asp:Content>

