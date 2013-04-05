<%-- Innlevering 3 Webdesign 1 kodet av Britt-Heidi Fladby-Flabri10 --%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Oppg1MasterPage.master" AutoEventWireup="true" CodeFile="Oppg1_side2.aspx.cs" Inherits="Oppg1_side2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="cphMainContent" Runat="Server">
    <div class="tabeller">
        <h2>Artist/Melodi</h2>
        <asp:SqlDataSource ID="sdsArtisterMelodier" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            SelectCommand="SELECT Melodi.MelodiID, Melodi.Tittel, Melodi.Sjanger, Artist.Artistnavn FROM Artist INNER JOIN Melodi ON Artist.ArtistID = Melodi.ArtistID">
        </asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="sdsArtisterMelodier">
        </asp:GridView>
    </div>
</asp:Content>

