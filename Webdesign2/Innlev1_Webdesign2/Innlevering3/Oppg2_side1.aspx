<%@ Page Title="Side1" Language="C#" MasterPageFile="~/Oppg2Masterpage.master" AutoEventWireup="true" CodeFile="Oppg2_side1.aspx.cs" Inherits="Oppg2_side1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    
    <h2>Session side1</h2>
    <label for="txtNavn">
        Navn:
        <asp:TextBox ID="txtNavn" runat="server"></asp:TextBox>
    </label>

    <h3>Velg farge:</h3>
    
    <asp:RadioButtonList ID="rblListe" runat="server" Width="91px" AutoPostBack="True" onselectedindexchanged="ColorSelector_IndexChanged">
    </asp:RadioButtonList>
    
    <asp:Button ID="btnLagreSession" runat="server" Text="Lagre session" CssClass="knapper"/>
    <asp:Button ID="btnTilSide2" runat="server" Text="Til side2" CssClass="knapper"/>
    <asp:Button ID="btnSlettSession" runat="server" Text="Slett session" CssClass="knapper"/>

</asp:Content>

