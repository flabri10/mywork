<%@ Page Title="Romskipet Hålogaland - Logg inn" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LoggInn.aspx.cs" Inherits="LoggInn" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" Runat="Server">

<div id="divLoggInnContainer">
<h3>Logg inn</h3>
    <table class="tblTabellSkjema">
        <tr>
            <td>Brukernavn</td>
        </tr>
        <tr>
            <td><asp:TextBox ID="txtBrukernavnLoggInn" runat="server" CssClass="brukerInput"></asp:TextBox></td>
            <td>
                        <asp:RequiredFieldValidator ID="rfvBrukernavnLoggInn" runat="server"
                        ControlToValidate="txtBrukernavnLoggInn" ErrorMessage="Brukernavn er påkrevd"    
                        ForeColor="Red" SetFocusOnError="true" ValidationGroup="vsLoggInnStatus">*</asp:RequiredFieldValidator>

                       <asp:RegularExpressionValidator ID="rfvBruknernavnLoggInn" runat="server"
                        ControlToValidate="txtBrukernavnLoggInn" ErrorMessage="Brukernavn er på ugyldig format."
                        ForeColor="Red" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="vsLoggInnStatus">Feil format</asp:RegularExpressionValidator>
            </td>
        </tr>

        <tr>
            <td>Passord</td>
        </tr>
        <tr>
            <td><asp:TextBox ID="txtPassordLoggInn" runat="server" CssClass="brukerInput" TextMode="Password"></asp:TextBox></td>
        </tr>
    </table>

    <asp:Button ID="btnLoggInn" runat="server" CssClass="btnSkjemaKnapp" Text="Logg Inn" OnClick="_LoggInn" ValidationGroup="vsLoggInnStatus"/>
   <p> <asp:Literal ID="litLoggInnTilbakemelding" runat="server"></asp:Literal></p>

</div>

    <div id="divRegistrerContainer">
    <h3>Registrer ny bruker</h3>
        <table class="tblTabellSkjema">
            <tr>
                <td>Brukernavn</td>
            </tr>
            <tr>
                <td><asp:TextBox ID="txtBrukernavn" runat="server" CssClass="brukerInput"></asp:TextBox></td>
                <td>
                        <asp:RequiredFieldValidator ID="rfvBrukernavn" runat="server"
                        ControlToValidate="txtBrukernavn" ErrorMessage="Brukernavn er påkrevd"    
                        ForeColor="Red" SetFocusOnError="true" ValidationGroup="vgRegistrerStatus">*</asp:RequiredFieldValidator>

                       <asp:RegularExpressionValidator ID="revEpost" runat="server"
                        ControlToValidate="txtBrukernavn" ErrorMessage="Brukernavn må være i e-post format."
                        ForeColor="Red" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="vgRegistrerStatus">*</asp:RegularExpressionValidator>
                </td>
            </tr>

            <tr>
                <td>Passord</td>
            </tr>
            <tr>
                <td><asp:TextBox ID="txtPassord" runat="server" CssClass="brukerInput" TextMode="Password"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvPassord" runat="server"
                        ControlToValidate="txtPassord" ErrorMessage="Passord er påkrevd!"    
                        ForeColor="Red" SetFocusOnError="true" ValidationGroup="vgRegistrerStatus">*</asp:RequiredFieldValidator>
                </td>
            </tr>

            <tr>
                <td>Gjenta Passord</td>
            </tr>
            <tr>
                <td><asp:TextBox ID="txtPassordSjekk" runat="server" class="brukerInput" TextMode="Password"></asp:TextBox></td>
                <td>
                    <asp:CompareValidator ID="cvPassord" runat="server"
                        ControlToValidate="txtPassordSjekk" ControlToCompare="txtPassord" 
                        ErrorMessage="Passordene er ulike" ForeColor="Red" SetFocusOnError="true" ValidationGroup="vgRegistrerStatus">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>Fornavn</td>
            </tr>
            <tr>
                <td><asp:TextBox ID="txtFornavn" runat="server" CssClass="brukerInput"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvFornavn" runat="server"
                        ControlToValidate="txtFornavn" ErrorMessage="Fornavn er påkrevd!"    
                        ForeColor="Red" SetFocusOnError="true" ValidationGroup="vgRegistrerStatus">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Etternavn</td>
            </tr>
            <tr>
                <td><asp:TextBox ID="txtEtternavn" runat="server" CssClass="brukerInput"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvEtternavn" runat="server"
                        ControlToValidate="txtEtternavn" ErrorMessage="Etternavn er påkrevd!"    
                        ForeColor="Red" SetFocusOnError="true" ValidationGroup="vgRegistrerStatus">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Mobil</td>
            </tr>
            <tr>
                <td><asp:TextBox ID="txtMobil" runat="server" CssClass="brukerInput"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvMobil" runat="server"
                        ControlToValidate="txtMobil" ErrorMessage="Mobil er påkrevd!"    
                        ForeColor="Red" SetFocusOnError="true" ValidationGroup="vgRegistrerStatus">*</asp:RequiredFieldValidator>
                </td>
                <td><asp:RegularExpressionValidator ID="revMobil" runat="server"
                    ErrorMessage="Ikke riktig format på mobilnummer" ForeColor="Red" ControlToValidate="txtMobil"
                    ValidationExpression="[0-9]{8}" ValidationGroup="vgRegistrerStatus">*</asp:RegularExpressionValidator>
                </td>
            </tr>
        </table>


         <div id="divStatus">
            <asp:ValidationSummary ID="vgRegistrerStatus" runat="server" ValidationGroup="vgRegistrerStatus"/>
        </div>

        <asp:ValidationSummary ID="vgLoggInnStatus" runat="server" ValidationGroup="vgLoggInnStatus" />

        <asp:Button ID="btnRegistrerBruker" runat="server" Text="Registrer" OnClick="RegistrerBruker" CssClass="btnSkjemaKnapp" ValidationGroup="vgRegistrerStatus"/>

        <asp:Literal ID="litRegistrerTilbakemelding" runat="server"></asp:Literal>

    </div>

    <div class="clearfix"></div>

</asp:Content>

