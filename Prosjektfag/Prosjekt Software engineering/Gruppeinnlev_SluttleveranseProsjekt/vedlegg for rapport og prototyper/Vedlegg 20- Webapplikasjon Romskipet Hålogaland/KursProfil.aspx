<%@ Page Title="Romskipet Hålogaland - Kursprofil" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="KursProfil.aspx.cs" Inherits="KursProfil" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" Runat="Server">
    <p class="success"><asp:Literal ID="litPåmeldingTilbakemelding" runat="server"></asp:Literal></p>
    <asp:Literal ID="litFeilmelding" runat="server"></asp:Literal>

    <h2><asp:Literal ID="litKursNavn" runat="server"></asp:Literal></h2>

    <asp:Panel ID="pnlAdminInfo" runat="server">
        <div id="deltakerListe">
            <div id="btnClose"><img src="gfx/close.png" alt="Lukk vindu" onclick="lukkDeltakerListe()" class="imgNoStyle"/></div>
            <div id="divPointer"><img src="gfx/pointer.png" alt="Pil" class="imgNoStyle"/></div>
            <h3>Deltakere</h3>
            <asp:Literal ID="litDeltakerListe" runat="server"></asp:Literal>
        </div>

            <div id="divAdminInfo">
                <h3><img src="gfx/user.png" alt="Bruker" />Antall påmeldte</h3>
                <p onclick="visDeltakerListe()" id="btnVisDeltakerListe"><asp:Literal ID="litAntallPåmeldte" runat="server"></asp:Literal></p>

                <h3><img src="gfx/cog_small.png" alt="Bruker" />Rediger kurs</h3>
                <asp:LinkButton ID="ltbnSendTilProfil" runat="server" Text="Rediger kurset" OnClick="SendTilRedigering"></asp:LinkButton>
            </div>

     </asp:Panel>

    <div id="kursInfo">
        <asp:Literal ID="litKursInfo" runat="server"></asp:Literal>
    </div>



    <div id="kursBeskrivelseLeft">
        <h3>Beskrivelse</h3>
        <asp:Literal ID="litKursBeskrivelse" runat="server"> </asp:Literal>
    </div>
    
    <div class="clearfix"></div>
</asp:Content>

