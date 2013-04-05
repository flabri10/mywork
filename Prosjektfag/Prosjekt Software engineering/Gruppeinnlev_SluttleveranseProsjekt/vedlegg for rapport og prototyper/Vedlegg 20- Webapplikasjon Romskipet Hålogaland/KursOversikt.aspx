<%@ Page Title="Romskipet Hålogaland - Kurs og aktiviteter" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="KursOversikt.aspx.cs" Inherits="KursOversikt" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" Runat="Server">
<h2>Kurs og aktiviteter</h2>

<p>NAROM gjennomfører en rekke undervisningsaktiviteter innen romteknologi, romfysikk, atmosfære og miljø. I samarbeid med Andøya Rakettskytefelt tilbyr NAROM spennende romrelaterte laboratorieøvelser, og er derfor blitt en viktig feltstasjon for mange utdanningsinstitusjoner. </p>

<p>I løpet av 2012 gjennomføres en rekke spennende kurs og aktiviteter. Noe av tilbudet er feltsamlinger som er en del av studietilbudet til utdanningsinstitusjoner og er ikke åpne for påmelding. NAROM arrangerer i samarbeid med sine samarbeidspartnere også kurs som er åpne. For de kursene hvor påmelding skjer direkte til NAROM, kan deltakerne melde seg på via NAROMs nettsted. Kursene/aktivitetene er sortert iht. målgruppe og beskrives med en omtale, og evt. påmeldingsskjema.</p>

<h3>Kurs 2012</h3>
<div id="divKursNavigasjon">
    <div class="navigasjonsFane">
        <asp:LinkButton ID="lbtnAlleMålgrupper" runat="server" Text="Alle målgrupper" OnClick="VisAlleKurs"></asp:LinkButton>
    </div>

    <div class="navigasjonsFane">
        <asp:LinkButton ID="lbtnStudentKurs" runat="server" Text="Studenter" OnClick="VisStudentKurs"></asp:LinkButton>
    </div>

    <div class="navigasjonsFane">
        <asp:LinkButton ID="lbtnLærerKurs" runat="server" Text="Lærere" OnClick="VisLærerKurs"></asp:LinkButton>
    </div>

    <div class="navigasjonsFane">
        <asp:LinkButton ID="lbtnEleverKurs" runat="server" Text="Elever" OnClick="VisEleverKurs"></asp:LinkButton>
    </div>
</div>

<asp:Literal ID="litKursHeader" runat="server"></asp:Literal>
<asp:Literal ID="litKursliste" runat="server"></asp:Literal>


<h3>Aktiviteter 2012</h3>
<asp:Literal ID="litAktivitetsHeader" runat="server"></asp:Literal>
<asp:Literal ID="litAktivitetsliste" runat="server"></asp:Literal>
</asp:Content>

