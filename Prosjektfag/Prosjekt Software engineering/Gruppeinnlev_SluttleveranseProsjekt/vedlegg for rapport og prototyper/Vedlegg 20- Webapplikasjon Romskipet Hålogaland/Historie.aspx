<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Historie.aspx.cs" Inherits="Historie" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphExtendedHeader" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" Runat="Server">

   <h2>Norsk Romfartshistorie</h2>

   <br />

   <div class="clearfix"></div>
   
    <div class="historieContainer"> 
        <input id="historieRange" type="range" min="1960" max="2010" value="1960" onChange="finnHistorie(this.value)"/>
       
        <div id="tidslinje"></div>

        <h3 id="h3Overskrift">Perioden 1960-1969</h3>
        <p id="pHistorie">18. august 1962 ble den aller første forskningsraketten skutt ut fra Andøya Rakettskytefelt,
        og markerte med det starten på en helt ny industri i Norge. En industri som i dag omsetter for flere milliarder kroner årlig.
        Norske rombedrifter nyter stor anseelse i utlandet for sin spisskompetanse og gode produkter.</p>
    </div>

    <img id="imgHistorie" src="img/historie/1960.jpg" alt="bilde mangler" />

   <div class="clearfix"></div>
   
</asp:Content>




