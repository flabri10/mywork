<%@ Page Title="Romskipet Hålogaland - Info" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Mal.aspx.cs" Inherits="sider_Mal" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" Runat="Server">

   <h2>Praktisk info</h2>  
   <div id="tekstContainer">
       <h3>Beliggenhet og ankomst</h3>
        <p>Andøya Rakettskytefelt AS, base for oppskytning av forskningsraketter og for geofysiske observasjoner, ligger ved Oksebåsen like sør for Andenes, Andøy kommune, Nordland (69° 17’ N, 16°01’ Ø). Skytefeltet ligger i den sørlige ytterkant av sonen for maksimal nordlysaktivitet, og har dermed en spesielt gunstig beliggenhet for å studere nordlys og den polare atmosfæren.</p><p>Kommer du fra andre deler av lander er det fly som er enkleste ankomstmåte. For øyeblikket er det kun Widerøe som flyr denne strekningen, men Norwegian skal også begynne med sommerflygninger fra 2012. </p>

        <h3>Bomuligheter</h3>
        <p>På Andøya finnes det et stort utvalg bomuligheter. Blant annet hoteller, hytter, pensjonater og vandrehjem alt etter hvilken prisklasse du er ute etter. For mer informasjon, trykk her: <a href="http://www.andoyturist.no/overnatting.html" class="lesMer">Andøya turist</a> </p>

        <h3>Billetter</h3>
        <p>For å få tilgang til vårt opplevelsessenter Romskipet Hålogaland, må man kjøpe billett. Denne kan kjøpes her på nettsiden eller i inngangen på senteret. </p>
          <ul>
            <li>Barn: 70kr</li>
            <li>Student:80kr</li>
            <li>Voksen: 100kr</li>
            <li>Honnør: 70kr</li>
          </ul>

          <a href="Nettbutikk.aspx" class="btnSkjemaKnapp">Gå til nettbutikk</a>
    
        <h3>Åpningstider</h3>
        <p>Egne åpningstider gjelder på helligdager.</p>
        <ul>
            <li>Mandag - Fredag: 08.00-16.00</li>
            <li>Lørdag - Søndag: 10.00-15.00</li>
        </ul>
    
    </div>
    <div id="kartContainer">
        <iframe width="425" height="380" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" 
        src="http://maps.google.com/maps?f=q&amp;source=s_q&amp;hl=en&amp;geocode=&amp;q=narom&amp;aq=&amp;sll=59.913869,10.752245&amp;sspn=0.190352,0.676346&amp;vpsrc=6&amp;g=oslo&amp;ie=UTF8&amp;hq=narom&amp;hnear=&amp;radius=15000&amp;t=h&amp;cid=13043456070241866627&amp;ll=69.334562,16.12381&amp;spn=0.050888,0.146255&amp;z=12&amp;iwloc=A&amp;output=embed">
        </iframe>
        <br />
    </div>

    <div class="clearfix"></div>
</asp:Content>
