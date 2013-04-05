<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RedigerNyhet.aspx.cs" Inherits="RedigerNyhet" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" Runat="Server">
<h2>Rediger nyhet</h2>

<table class="tblTabellSkjema">
        <tr>
            <td>Tittel</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtNyhetsTittel" runat="server" CssClass="brukerInput"></asp:TextBox>
            </td>
        </tr>


        <tr>
            <td>Ingress</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtNyhetsIngress" runat="server" CssClass="brukerInput" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Brødtekst</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtNyhetsBrødtekst" runat="server" CssClass="brukerInput" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Bilde (last opp)</td>
        </tr>
        <tr>
            <td>
                <asp:FileUpload ID="fuNyhetsBilde" runat="server" />
            </td>
        </tr>

    </table>

    

    <asp:Button ID="btnLeggTilNyhet" runat="server" Text="Lagre endringer" onclick="LagreEndringer" class="btnSkjemaKnapp"/>
    <asp:Button ID="btnSlettNyhet" runat="server" Text="Slett nyheten" onclick="SlettNyhet" class="btnSkjemaKnapp"/>

    <p><asp:Literal ID="litNyhetFeilmelding" runat="server"></asp:Literal></p>

</asp:Content>

