<%@ Page Title="Romskipet Hålogaland - Administrator" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AdminPanel.aspx.cs" Inherits="AdminPanel" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" Runat="Server">
    <h2>Administrator</h2>
    <p>På denne siden kan en administrator oppdatere kurslister, aktiviteter, legge til nyhetssaker, samt endre innholdet i galleriet og nettbutikk.</p>

    <h3>Kurs 2012</h3>
<div id="divKursNavigasjon">
    <div class="navigasjonsFane">
        <asp:LinkButton ID="lbtnAlleMålgrupper" runat="server" Text="Alle målgrupper" OnClick="VisAlleKurs"></asp:LinkButton>
    </div>

    <div class="navigasjonsFane">
        <asp:LinkButton ID="lbtnStudentKurs" runat="server" Text="Studenter" OnClick="VisStudentKurs"></asp:LinkButton>
    </div>

    <div class="navigasjonsFane">
        <asp:LinkButton ID="lbtnLærerKurs" runat="server" Text="Lærere" OnClick="VisLærerKurs"></asp:LinkButton>
    </div>

    <div class="navigasjonsFane">
        <asp:LinkButton ID="lbtnEleverKurs" runat="server" Text="Elever" OnClick="VisEleverKurs"></asp:LinkButton>
    </div>

    <div id="divNyttKurs">
         <a href="NyttKurs.aspx"><img src="gfx/newFile.png" alt="Nytt kurs" class="imgNoStyle"/>Lag et nytt kurs</a>
     </div>
</div>

    <asp:Literal ID="litKursHeader" runat="server"></asp:Literal>
    <asp:Literal ID="litKursliste" runat="server"></asp:Literal>

    <div class="dividerAdmin"></div>

    <h3>Aktiviteter</h3>
    <div class="new"><a href="NyAktivitet.aspx"><img src="gfx/newFile.png" alt="Nytt kurs" class="imgNoStyle"/>Legg til en aktivitet</a></div>
    <asp:Literal ID="litAktivitetsHeader" runat="server"></asp:Literal>
    <asp:Literal ID="litAktivitetsListe" runat="server"></asp:Literal>

    <div class="dividerAdmin"></div>

    <h3 class="floatLeft">Nyhetssaker</h3>
    <div id="divNyNyhet"><a href="NyNyhet.aspx"> <img src="gfx/newFile.png" alt="Ny nyhet" class="imgNoStyle"/> Lag en ny nyhetssak</a> </div>
    <div class="clearfix"></div>
    <asp:Literal ID="litNyhetsHeader" runat="server"></asp:Literal>
    <asp:Literal ID="litNyhetsListe" runat="server"></asp:Literal>

    <div class="dividerAdmin"></div>

<h3>Nettbutikk</h3>
    <div class="new"><a href="NyttProdukt.aspx"><img src="gfx/newFile.png" alt="Nytt kurs" class="imgNoStyle"/>Legg til et produkt</a></div>
    <asp:Literal ID="litProduktHeader" runat="server"></asp:Literal>
    <asp:Literal ID="litProduktliste" runat="server" />

    <div class="dividerAdmin"></div>

    <h3>Mediahåndtering</h3>
    <p>Bruk skjemaet under for å laste opp nye bilder til Media-siden. Du kan også slette eksisterende bilder ved å trykke på krysset i hjørnet på et bilde nedenfor.</p>
    <table class="tblTabellSkjema">
        <tr>
            <td>Bildetittel</td>
        </tr>
          <tr>
            <td><asp:TextBox ID="txtBildeTittel" runat="server" CssClass="brukerInput"></asp:TextBox></td>
        </tr>

        <tr>
            <td>Fil</td>
        </tr>
        <tr>
            <td><asp:FileUpload ID="fuMediaOpplasting" runat="server" /></td>
        </tr>
    </table>

    <asp:Button ID="btnLastOppBilde" runat="server" Text="Last opp bilde" CssClass="btnSkjemaKnapp" OnClick="LastOppBilde"/>

    <div id="adminBildeGalleri">
        <asp:Literal ID="litAdminBildeGalleri" runat="server"></asp:Literal>
    </div>
</asp:Content>
