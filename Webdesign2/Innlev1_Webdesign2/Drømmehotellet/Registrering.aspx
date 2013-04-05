<%@ Page Title="Drømmehotellet- Registrering av kunde" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Registrering.aspx.cs" Inherits="Registrering" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<title></title>
    <style type="text/css">
        .style1 {
            width: 35px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h2>Registrer kunde på rom</h2>
    <table>
        <tr>
            <td>Fornavn</td>
            <td><asp:TextBox ID="txtFornavn" runat="server"></asp:TextBox></td>
            <td class="style1"><asp:RequiredFieldValidator ID="rfvFornavn" runat="server"
                        ControlToValidate="txtFornavn" ErrorMessage="Fornavn må oppgis!"
                        ForeColor="Red" SetFocusOnError="true">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Etternavn</td>
            <td><asp:TextBox ID="txtEtternavn" runat="server"></asp:TextBox></td>
            <td class="style1">
                <asp:RequiredFieldValidator ID="rfvEtternavn" runat="server"
                        ControlToValidate="txtEtternavn" ErrorMessage="Etternavn må oppgis!"
                        ForeColor="Red" SetFocusOnError="true">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Mobil</td>
            <td><asp:TextBox ID="txtMobil" runat="server"></asp:TextBox></td>
            <td class="style1">
                <asp:RegularExpressionValidator ID="revMobil" runat="server"
                    ErrorMessage="Oppgi gyldig mobilnummer!" ForeColor="Red" SetFocusOnError="true"  ControlToValidate="txtMobil"
                    ValidationExpression="[0-9]{8}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>Epost</td>
            <td><asp:TextBox ID="txtEpost" runat="server"></asp:TextBox></td>
            <td class="style1">
                <asp:RegularExpressionValidator ID="revEpost" runat="server"
                    ControlToValidate="txtEpost" ErrorMessage="Gyldig epost må oppgis!" 
                    ForeColor="Red" SetFocusOnError="true"  ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>Rom</td>
            <td>
                <asp:DropDownList ID="ddlRom" runat="server" 
                    onselectedindexchanged="ddlRom_SelectedIndexChanged">
                    <asp:ListItem Text="Velg rom" Value="true"></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="style1">
                    <asp:RequiredFieldValidator ID="rfvRom" runat="server"
                        ControlToValidate="ddlRom" ErrorMessage="Rom må oppgis!"
                        ForeColor="Red" InitialValue="Velg rom" SetFocusOnError="true">*</asp:RequiredFieldValidator>
            </td>
        </tr>
    </table>
    <asp:Button ID="btnRegistrer" runat="server" Text="Registrer" 
        onclick="RegistrerKunde"/>
    
    <div id="divStatus">
        <asp:ValidationSummary ID="vsStatus" runat="server" />
    </div>
    
     <asp:Literal ID="litRegTilbakemelding" runat="server"></asp:Literal>

</asp:Content>

