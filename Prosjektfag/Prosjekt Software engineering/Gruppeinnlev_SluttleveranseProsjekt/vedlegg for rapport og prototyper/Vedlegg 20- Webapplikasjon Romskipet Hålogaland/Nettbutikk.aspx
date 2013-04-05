<%@ Page Title="Nettbutikk" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Nettbutikk.aspx.cs" Inherits="Nettbutikk" %>

<asp:Content ID="contentNettbutikk2" ContentPlaceHolderID="cphMainContent" Runat="Server">
    <p class="failure"><asp:Literal ID="litKjøpTilbamelding" runat="server"></asp:Literal></p>
    <h2>Nettbutikk</h2>

    <div id="divHandlevogn">
        <p>Antall varer i handlekurven: <asp:Label ID="lblAntallVarer" runat="server"></asp:Label></p>
        <a href="Handlekurv.aspx" class="btnSkjemaKnapp"><img src="gfx/handlevogn.png" class="imgNoStyle" alt="Handlevogn"/>Gå til handlekurven</a>
    </div>

    <div class="clearfix"></div>

    <div id="divProduktContainer">
        <asp:Literal ID="litProduktliste" runat="server"></asp:Literal>
    </div>

    <p><asp:Literal ID="litHandleKurvInnhold" runat="server"></asp:Literal></p>
    <div class="clearfix"></div>
</asp:Content>

