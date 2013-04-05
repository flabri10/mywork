<%@ Page Title="Registrer deg" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RegistrerDeg.aspx.cs" Inherits="RegistrerDeg" %>

<asp:Content ID="cphRegistrerDegHead" ContentPlaceHolderID="cphMasterpageHead" Runat="Server">
</asp:Content>
<asp:Content ID="cphRegistrerDeg1" ContentPlaceHolderID="cphMasterpage1" Runat="Server">
    <h2>Registrer deg</h2>
    
    <table>
        <tr>
            <td>Navn</td>
            <td><asp:TextBox ID="txtNavn" runat="server"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="rfvNavn" ErrorMessage="Oppgi navn!" runat="server" 
                    ControlToValidate="txtNavn" ForeColor="red" SetFocusOnError="true">*</asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>Profilbilde</td>
            <td><asp:FileUpload ID="fulProfilbilde" runat="server" /></td>
            <td></td>
        </tr>
        <tr>
            <td>Brukernavn</td>
            <td><asp:Textbox ID="txtBrukernavn" runat="server"></asp:Textbox></td>
            <td><asp:RequiredFieldValidator ID="rfvBrukernavn" ErrorMessage="Oppgi brukernavn!" runat="server" 
                    ControlToValidate="txtBrukernavn" ForeColor="red" SetFocusOnError="true">*</asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>Passord</td>
            <td><asp:TextBox ID="txtPassord" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Gjenta passord</td>
            <td><asp:TextBox ID="txtPassordGjentatt" runat="server" TextMode="Password"></asp:TextBox></td>
            <td><asp:CompareValidator ID="cvPassord" runat="server"
                    ControlToValidate="txtPassordGjentatt" ControlToCompare="txtPassord"
                    ErrorMessage="Passordene er ulike" ForeColor="Red" SetFocusOnError="true">*</asp:CompareValidator></td>
        </tr>
    </table>
    <asp:Button ID="btnRegistrerDeg" Text="Registrer deg" runat="server" 
        onclick="btnRegistrerDeg_Click"/>
</asp:Content>

