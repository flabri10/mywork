<%-- Innlevering 3 Webdesign 1 kodet av Britt-Heidi Fladby-Flabri10 --%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Oppg1MasterPage.master" AutoEventWireup="true" CodeFile="Oppg1_side1.aspx.cs" Inherits="Oppg1_side1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="cphMainContent" Runat="Server">
    <div class="tabeller">
    <h2>Artister</h2>
    <asp:SqlDataSource ID="sdsDatakildeArtister" runat="server" 
    ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
    DeleteCommand="DELETE FROM [Artist] WHERE [ArtistID] = @ArtistID" 
    InsertCommand="INSERT INTO [Artist] ([Artistnavn], [Navn], [Telefon], [MelodiID]) VALUES (@Artistnavn, @Navn, @Telefon, @MelodiID)" 
    SelectCommand="SELECT * FROM [Artist]" 
    UpdateCommand="UPDATE [Artist] SET [Artistnavn] = @Artistnavn, [Navn] = @Navn, [Telefon] = @Telefon, [MelodiID] = @MelodiID WHERE [ArtistID] = @ArtistID">
        <DeleteParameters>
            <asp:Parameter Name="ArtistID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Artistnavn" Type="String" />
            <asp:Parameter Name="Navn" Type="String" />
            <asp:Parameter Name="Telefon" Type="String" />
            <asp:Parameter Name="MelodiID" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Artistnavn" Type="String" />
            <asp:Parameter Name="Navn" Type="String" />
            <asp:Parameter Name="Telefon" Type="String" />
            <asp:Parameter Name="MelodiID" Type="Int32" />
            <asp:Parameter Name="ArtistID" Type="Int32" />
        </UpdateParameters>
</asp:SqlDataSource>
    <asp:GridView ID="gvArtister" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="ArtistID" DataSourceID="sdsDatakildeArtister">
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:BoundField DataField="ArtistID" HeaderText="ArtistID" 
                InsertVisible="False" ReadOnly="True" SortExpression="ArtistID" />
            <asp:BoundField DataField="Artistnavn" HeaderText="Artistnavn" 
                SortExpression="Artistnavn" />
            <asp:BoundField DataField="Navn" HeaderText="Navn" SortExpression="Navn" />
            <asp:BoundField DataField="Telefon" HeaderText="Telefon" 
                SortExpression="Telefon" />
            <asp:BoundField DataField="MelodiID" HeaderText="MelodiID" 
                SortExpression="MelodiID" />
        </Columns>
    </asp:GridView>
    
    
    <h2>Melodier</h2>
    <asp:SqlDataSource ID="sdsDatakildeMelodier" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        DeleteCommand="DELETE FROM [Melodi] WHERE [MelodiID] = @MelodiID" 
        InsertCommand="INSERT INTO [Melodi] ([Tittel], [Sjanger], [ArtistID]) VALUES (@Tittel, @Sjanger, @ArtistID)" 
        SelectCommand="SELECT * FROM [Melodi]" 
        UpdateCommand="UPDATE [Melodi] SET [Tittel] = @Tittel, [Sjanger] = @Sjanger, [ArtistID] = @ArtistID WHERE [MelodiID] = @MelodiID">
        <DeleteParameters>
            <asp:Parameter Name="MelodiID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Tittel" Type="String" />
            <asp:Parameter Name="Sjanger" Type="String" />
            <asp:Parameter Name="ArtistID" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Tittel" Type="String" />
            <asp:Parameter Name="Sjanger" Type="String" />
            <asp:Parameter Name="ArtistID" Type="Int32" />
            <asp:Parameter Name="MelodiID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:GridView ID="gvMelodier" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="MelodiID" DataSourceID="sdsDatakildeMelodier">
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:BoundField DataField="MelodiID" HeaderText="MelodiID" 
                InsertVisible="False" ReadOnly="True" SortExpression="MelodiID" />
            <asp:BoundField DataField="Tittel" HeaderText="Tittel" 
                SortExpression="Tittel" />
            <asp:BoundField DataField="Sjanger" HeaderText="Sjanger" 
                SortExpression="Sjanger" />
            <asp:BoundField DataField="ArtistID" HeaderText="ArtistID" 
                SortExpression="ArtistID" />
        </Columns>
    </asp:GridView>
    </div>
    <div id="crud">
    <h2>CRUD-Artist</h2>
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
        DataKeyNames="ArtistID" DataSourceID="sdsDatakildeArtister" Height="50px" 
        Width="125px">
        <Fields>
            <asp:BoundField DataField="ArtistID" HeaderText="ArtistID" 
                InsertVisible="False" ReadOnly="True" SortExpression="ArtistID" />
            <asp:BoundField DataField="Artistnavn" HeaderText="Artistnavn" 
                SortExpression="Artistnavn" />
            <asp:BoundField DataField="Navn" HeaderText="Navn" SortExpression="Navn" />
            <asp:BoundField DataField="Telefon" HeaderText="Telefon" 
                SortExpression="Telefon" />
            <asp:BoundField DataField="MelodiID" HeaderText="MelodiID" 
                SortExpression="MelodiID" />
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                ShowInsertButton="True" />
        </Fields>
    </asp:DetailsView>
    </div>
    </asp:Content>

