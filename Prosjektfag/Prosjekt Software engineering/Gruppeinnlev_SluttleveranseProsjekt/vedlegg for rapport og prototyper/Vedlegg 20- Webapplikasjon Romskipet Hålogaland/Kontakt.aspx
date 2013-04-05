<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Kontakt.aspx.cs" Inherits="Kontakt" %>


<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" Runat="Server">

<div id="KontaktSkjemaContainer">
     <h2>Kontakt</h2>
     <p>Vennligst benytt kontaktskjemaet under eller kontaktinformasjonen til høyre for å komme i kontakt med oss!</p>

     <table class="tblTabellSkjema">
         <tr>
            <td>Fornavn</td>
         </tr>
         <tr>
            <td><asp:TextBox ID="txtFornavn" runat="server" CssClass="brukerInput"></asp:TextBox></td>
         </tr>

         <tr>
            <td>Etternavn</td>
         </tr>
         <tr>
            <td><asp:TextBox ID="TextBox1" runat="server" CssClass="brukerInput"></asp:TextBox></td>
         </tr>

         <tr>
            <td>Epost</td>
         </tr>
         <tr>
            <td><asp:TextBox ID="TextBox2" runat="server" CssClass="brukerInput"></asp:TextBox></td>
         </tr>

         <tr>
            <td>Telefonnummer</td>
         </tr>
         <tr>
            <td><asp:TextBox ID="TextBox3" runat="server" CssClass="brukerInput"></asp:TextBox></td>
         </tr>
     
         <tr>
            <td>Emne</td>
         </tr>
         <tr>
            <td>
                <asp:DropDownList ID="ddlEmne" runat="server">
                    <asp:ListItem>Romskipet</asp:ListItem>
                    <asp:ListItem>NAROM</asp:ListItem>
                    <asp:ListItem>Jobb</asp:ListItem>
                    <asp:ListItem>Utdanning</asp:ListItem>
                    <asp:ListItem>Annet</asp:ListItem>
                </asp:DropDownList>
            </td>
         </tr>

         <tr>
            <td>Din melding</td>
         </tr>
         <tr>
            <td><asp:TextBox ID="txtMelding" runat="server" CssClass="brukerInput" TextMode="MultiLine"></asp:TextBox></td>
         </tr>

         <tr>
            <td><asp:Button ID="btnSendMelding" runat="server" Text="Send melding" CssClass="btnSkjemaKnapp" OnClick="SendMelding"/></td>
         </tr>
     </table>
     <asp:Literal ID="litSendTilbakemelding" runat="server"></asp:Literal>

     
</div>

<div id="kontaktInfo">
    <h3>Romskipet Hålogaland</h3>
    <p> PO Box 54 N-8483 Norway</p>

    <div class="kontaktContainer">
        <img src="img/telefon.jpg" alt="Telefon"/>
        <p>Tlf: +47 76 14 44 00</p>
    </div>

    <div class="kontaktContainer">
        <img src="img/mail.jpg" alt="Mail" />
        <p>Romskipet@andoya.no</p>
    </div>

    <iframe width="425" height="380" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" 
    src="http://maps.google.com/maps?f=q&amp;source=s_q&amp;hl=en&amp;geocode=&amp;q=narom&amp;aq=&amp;sll=59.913869,10.752245&amp;sspn=0.190352,0.676346&amp;vpsrc=6&amp;g=oslo&amp;ie=UTF8&amp;hq=narom&amp;hnear=&amp;radius=15000&amp;t=h&amp;cid=13043456070241866627&amp;ll=69.334562,16.12381&amp;spn=0.050888,0.146255&amp;z=12&amp;iwloc=A&amp;output=embed">
    </iframe>
</div>


<div class="clearfix"></div>


</asp:Content>

