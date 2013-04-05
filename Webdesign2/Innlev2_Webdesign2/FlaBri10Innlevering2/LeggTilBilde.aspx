<%@ Page Title="Legg til bilde" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LeggTilBilde.aspx.cs" Inherits="LeggTilBilde" %>

<asp:Content ID="cphLeggTilBildeHead" ContentPlaceHolderID="cphMasterpageHead" Runat="Server">
</asp:Content>
<asp:Content ID="cphLeggTilBilde1" ContentPlaceHolderID="cphMasterpage1" Runat="Server">
    <h2>Legg til bilde</h2>
    <table>
        <tr>
            <td>
                <label for="angiFil">Angi fil
                    <asp:FileUpload ID="fuFil" runat="server" />
                </label>
            </td>
            <td>
                <label>Angi ønsket bildenavn
                    <asp:TextBox ID="txtBildenavn" runat="server"></asp:TextBox>
                </label>
            </td>
            <td>
                <label for="bildeTittel">Angi bildetittel
                    <asp:TextBox ID="txtTittel" runat="server" />
                </label>
            </td>
            <td>
                <asp:Button ID="btnLastOppFil" runat="server" Text="Last opp fil" OnClick="LastOppFil" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnVisFilinfo" runat="server" Text="Vis filinfo" OnClick="VisFilinfo" />
                
            </td>
        </tr>
    </table>

    <asp:Label ID="lblFilStatus" runat="server"></asp:Label>
    <asp:Literal ID="litFilinfo" runat="server"></asp:Literal>
</asp:Content>

