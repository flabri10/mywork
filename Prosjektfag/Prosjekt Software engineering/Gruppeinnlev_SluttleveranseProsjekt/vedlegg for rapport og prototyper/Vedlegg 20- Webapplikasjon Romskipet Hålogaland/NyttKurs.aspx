<%@ Page Title="Romskipet Hålogaland - Nytt kurs" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="NyttKurs.aspx.cs" Inherits="NyttKurs" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" Runat="Server">
    <h2>Opprett et nytt kurs</h2>
    <p>Vennligst benytt skjemaet under for å opprette et nytt kurs.</p>

    <table class="tblTabellSkjema">
        <tr>
            <td>Kursnavn</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtKursnavn" runat="server" CssClass="brukerInput"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvKursnavn" ControlToValidate="txtKursnavn" runat="server" ErrorMessage="Kursnavn er påkrevd" ForeColor="Red">Kursnavn er påkrevd</asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td>Kursbeskrivelse</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtKursBeskrivelse" runat="server" CssClass="brukerInput" TextMode="MultiLine"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvKursbeskrivelse" ControlToValidate="txtKursBeskrivelse" runat="server" ErrorMessage="Beskrivelse er påkrevd" ForeColor="Red">Kursbeskrivelse er påkrevd</asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td>Påmeldingsfrist (dd.mm.yyyy)</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtPåmeldingsfrist" runat="server" CssClass="brukerInput"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvPåmeldingsfrist" ControlToValidate="txtPåmeldingsfrist" runat="server" ErrorMessage="Påmeldingsfrist er påkrevd" ForeColor="Red">Påmeldingsfrist er påkrevd</asp:RequiredFieldValidator><asp:RegularExpressionValidator ID="revPåmeldingsfrist" runat="server" ControlToValidate="txtPåmeldingsfrist" ErrorMessage="Påmeldingsfrist er på feil format" ForeColor="Red" ValidationExpression="^(0[1-9]|[12][0-9]|3[01])[.](0[1-9]|1[012])[.](19|20)\d\d$">Påmeldingsfrist er på feil format</asp:RegularExpressionValidator>
            </td>
        </tr>

        <tr>
            <td>Startdato (dd.mm.yyyy)</td>
        </tr>

        <tr>
            <td><asp:TextBox ID="txtStartdato" runat="server" CssClass="brukerInput"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rvtStartdato" ControlToValidate="txtStartdato" runat="server" ErrorMessage="Startdato er påkrevd" ForeColor="Red">Startdato er påkrevd</asp:RequiredFieldValidator> <asp:RegularExpressionValidator ID="revStartdato" runat="server" ControlToValidate="txtStartdato" ErrorMessage="Startdato er på feil format" ForeColor="Red" ValidationExpression="^(0[1-9]|[12][0-9]|3[01])[.](0[1-9]|1[012])[.](19|20)\d\d$">Startdato er på feil format</asp:RegularExpressionValidator>
            </td>
        </tr>

        <tr>
            <td>Sluttdato (dd.mm.yyyy)</td>
        </tr>

        <tr>
            <td><asp:TextBox ID="txtSluttdato" runat="server" CssClass="brukerInput"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvSluttdato" ControlToValidate="txtSluttdato" runat="server" ErrorMessage="Sluttdato er påkrevd" ForeColor="Red">Sluttdato er påkrevd</asp:RequiredFieldValidator> <asp:RegularExpressionValidator ID="revSluttdato" runat="server" ControlToValidate="txtSluttdato" ErrorMessage="Sluttdato er på feil format" ForeColor="Red" ValidationExpression="^(0[1-9]|[12][0-9]|3[01])[.](0[1-9]|1[012])[.](19|20)\d\d$">Sluttdato er på feil format</asp:RegularExpressionValidator></td>
        </tr>

        <tr>
            <td>Målgruppe</td>
        </tr>
        <tr>
            <td><asp:DropDownList ID="ddlMålgruppe" runat="server">
                <asp:ListItem>Elever</asp:ListItem>
                <asp:ListItem>Studenter</asp:ListItem>
                <asp:ListItem>Lærere</asp:ListItem>
            </asp:DropDownList></td>
        </tr>

        <tr>
            <td>Ankomst/Avreise</td>
        </tr>
        <tr>
            <td><asp:TextBox ID="txtTilleggsInformasjon" runat="server" CssClass="brukerInput" TextMode="MultiLine"></asp:TextBox></td>
        </tr>

        <tr>
            <td>Maks antall deltakere</td>
        </tr>
        <tr>
            <td><asp:TextBox ID="txtMaxAntallDeltakere" runat="server" CssClass="brukerInput"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvMaxAntallDeltakere" ControlToValidate="txtMaxAntallDeltakere" runat="server" ErrorMessage="Maks antall deltakere må være angitt" ForeColor="Red">Maks antall deltakere er påkrevd</asp:RequiredFieldValidator> <asp:RegularExpressionValidator ID="revMaxAntallDeltakere" runat="server" ControlToValidate="txtMaxAntallDeltakere" ErrorMessage="Maks antall deltakere er på feil format" ForeColor="Red" ValidationExpression="[1-9][0-9]*">Maks antall deltakere er på feil format</asp:RegularExpressionValidator></td>
        </tr>

        <tr>
            <td>Kursansvarlig</td>
        </tr>
        <tr>
            <td><asp:TextBox ID="txtKursansvarlig" runat="server" CssClass="brukerInput"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvKursAnsvarlig" ControlToValidate="txtKursansvarlig" runat="server" ErrorMessage="Kursansvarlig er påkrevd" ForeColor="Red">Kursansvarlig må være satt</asp:RequiredFieldValidator></td>
        </tr>

        <tr>
            <td>Samarbeidspartnere</td>
        </tr>
        <tr>
            <td><asp:TextBox ID="txtSamarbeidspartnere" runat="server" CssClass="brukerInput" TextMode="MultiLine"></asp:TextBox></td>
        </tr>

       <tr>
            <td>Forelesere</td>
        </tr>
        <tr>
            <td><asp:DropDownList ID="ddlForelesere" runat="server"></asp:DropDownList><asp:LinkButton ID="lbtnLeggTilForeleser" runat="server" OnClick="LeggTilForeleser">Legg til foreleser</asp:LinkButton></td>
        </tr>

        <tr>
            <td><asp:TextBox ID="txtValgteForelesere" runat="server" CssClass="brukerInput" TextMode="MultiLine"></asp:TextBox></td>
        </tr>

    </table>

    <asp:Button ID="btnLeggTilKurs" runat="server" Text="Legg til kurs" onclick="LeggTilKurs" class="btnSkjemaKnapp"/>

    <asp:Literal ID="litKursFeilmelding" runat="server"></asp:Literal>
</asp:Content>

