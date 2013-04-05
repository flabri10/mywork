<%@ Page Title="Side2" Language="C#" MasterPageFile="~/Oppg2Masterpage.master" AutoEventWireup="true" CodeFile="Oppg2_side2.aspx.cs" Inherits="Oppg2_side2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    
    <h2>Session side2</h2>

    <asp:Label ID="lblStatus2" runat="server" Text="" Font-Size="XX-Large"></asp:Label>
    <br/>
    <br/>
    <br/>
    <asp:HyperLink ID="HyperLink1" runat="server"><a href="Oppg2_side1.aspx">Til side1</a></asp:HyperLink>

</asp:Content>

