<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="Media.aspx.cs" Inherits="Media" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" Runat="Server">

    <h2>Media</h2>
    <p>Her kan du se forskjellige bilder/filmer. Trykk på bildet eller filmen for stor visning.</p>
    <h3>Bilder</h3><br />
 
    <div id="divBilder">
      <asp:Literal ID="litUtskrift" runat="server"></asp:Literal>
    </div>
           <div id="bildeFremviser">
            
                <img id="fokusBilde" src="" />
                <div id="divLukk">
                <img src="gfx/lukk.png" align="right" />
                <p>hei</p>
                </div>
            </div>
  
    <h3>Filmer</h3><br />
    <p>Disse filmene fører til YouTube.</p>
    <div id="divFilmer">
        <div id="videocontainer">
            <div id="playKnapp"></div>
            <a class="video"  onmouseover="visPlayKnapp" title="ICI-3 animation" href="http://www.youtube.com/watch?v=FwmMi_TVptM&feature=youtube_gdata;autoplay=1;fs=1;"><img src="img/Media/filmer/IC3.png" alt="" /></a>
            <a class="video"  title="CaNoRoCk 4" href="http://www.youtube.com/watch?v=jM0jQkf016Y&feature=youtube_gdata;autoplay=1"><img src="img/Media/filmer/canorock4.png" alt="" /></a>
            <a class="video"  title="The CHAMPS mission" href="http://www.youtube.com/watch?v=L7wh9PLEaXY&feature=youtube_gdata;autoplay=1"><img src="img/Media/filmer/champs.png" alt="" /></a>
        </div>
    </div>

    <div class="clearfix"></div>

</asp:Content>

