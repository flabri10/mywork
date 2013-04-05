<%@ Page Title="Bilde med kommentar" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BildeMedKommentar.aspx.cs" Inherits="BildeMedKommentar" %>

<asp:Content ID="cphBildeMedKommentarHead" ContentPlaceHolderID="cphMasterpageHead" Runat="Server">
</asp:Content>
<asp:Content ID="cphBildeMedKommentar1" ContentPlaceHolderID="cphMasterpage1" Runat="Server">
    <asp:Literal ID="litBilde" runat="server"></asp:Literal>

    <h2>Kommenter</h2>
    <table>
        <tr>
            <td>Tittel</td>       
            <td><asp:TextBox ID="txtTittel" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Kommentar</td>
            <td><asp:TextBox ID="txtKommentar" runat="server" Columns="50" Rows="10"></asp:TextBox></td>
        </tr>
    </table>
    <asp:Button ID="btnKommenter" runat="server" Text="Kommenter" onclick="btnKommenter_Click"/>
    <asp:Literal ID="litPostKommentar" runat="server"></asp:Literal> 
    

    <div id="kommentarListe">
        <h2>Kommentarer</h2>
        <asp:Literal ID="litKommentarliste" runat="server"></asp:Literal>
    </div>
    

</asp:Content>

