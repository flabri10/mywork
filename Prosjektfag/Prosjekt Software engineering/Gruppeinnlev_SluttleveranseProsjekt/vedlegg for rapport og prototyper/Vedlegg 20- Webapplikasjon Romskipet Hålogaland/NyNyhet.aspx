<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="NyNyhet.aspx.cs" Inherits="NyNyhet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphExtendedHeader" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" Runat="Server">
<h2>Ny nyhetssak</h2>
<p>Bruk skjemaet under for å lage en ny nyhetssak. Datoen nyheten blir publisert blir lagt til automatisk.</p>

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

    

    <asp:Button ID="btnLeggTilKurs" runat="server" Text="Legg til nyhet" onclick="LeggTilNyhet" class="btnSkjemaKnapp"/>

    <asp:Literal ID="litNyhetFeilmelding" runat="server"></asp:Literal>
</asp:Content>

