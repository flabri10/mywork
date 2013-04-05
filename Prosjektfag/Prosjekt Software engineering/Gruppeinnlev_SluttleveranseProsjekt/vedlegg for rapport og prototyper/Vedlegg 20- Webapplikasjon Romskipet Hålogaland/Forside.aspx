<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="Forside.aspx.cs" Inherits="Forside" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphExtendedHeader" runat="server">

<script type='text/javascript'>

    $(window).load(function () {
        var sliderBilde = $('#sliderWrapper #slider ul li img');
        var bildeBredde = sliderBilde.width()
        //wrapper til en moderdiv
        $('#sliderWrapper #slider ul').wrap('<div id="mother" />');
        //Gir bredde og høyde og overflow hidden til moderdiven.
        $('#mother').css({
            width: function () {
                return bildeBredde;
            },
            height: function () {
                return sliderBilde.height();
            },
            position: 'relative',
            overflow: 'hidden'
        });
        //Finner den totale bredden bildene gir sammenlagt og setter samme bredde til ul
        var totalBredde = sliderBilde.length * bildeBredde;
        $('#sliderWrapper #slider ul').css({
            width: function () {
                return totalBredde;
            }
        });

        //Forhindrer at siden hopper opp ved trykk på a med href="#".
        $("a[href='#']").click(function (e) {
            e.preventDefault();
        });


        $("#slider ul li img").each(
        function (intIndex) {
            $(this).parent().siblings('.neste,.forrige,.restart')
	        .bind("click", function () {

	            if ($(this).is('a.neste')) {

	                $(this).parent('li').parent('ul').animate({

	                    "margin-left": (-(intIndex + 1) * bildeBredde)

	                }, 500)
	            } else if ($(this).is(".forrige")) {
	                $(this).parent('li').parent('ul').animate({
	                    "margin-left": (-(intIndex - 1) * bildeBredde)
	                }, 500)
	            } else if ($(this).is(".restart")) {
	                $(this).parent('li').parent('ul').animate({
	                    "margin-left": (0)
	                }, 500)

	                return false;
	            }
	        }); //lukk .bind()									 
        }); //lukk .each()

    });       //doc ready

 
</script>



    <div id="headerExtended">
        <div id="headerExtendedWrapper">
            
           <div id="headerText"> <h1>Romskipet Hålogaland</h1>
                <p>Velkommen til nettstedet for NAROM og Romskipet Hålogaland! Her finner du alt av nyttig informasjon angående norsk romfart og diverse tilbud som finnes for dette på Andøya. </p>
                <p>Romskipet Hålogaland er et opplevelsessenter hvor man kan få en god følelse av hvordan det er å jobbe ved et rakettskytefelt.</p>

<div class="linkButton">
    <a href="Romskipet.aspx">Les mer</a>
</div>
           </div>

           <div id="headerIllustrasjon"> </div>

        </div>
    </div>
 </asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="cphMainContent" Runat="Server">

<div id="sliderWrapper">
    <div id="slider">
        <ul>
            <li>
                 <a href="Nettbutikk.aspx"><img src="img/slider/nettbutikktilbud1.gif" alt="nettbutikk tilbud" /></a><a class="neste" href="#">Neste</a>
            </li>
            <li>
                 <a href="Nettbutikk.aspx"><img src="img/slider/billetter2for1.gif" alt="2for1 billetter" /></a><a class="neste" href="#">Neste</a><a class="forrige" href="#">Forrige</a>
            </li>
            <li>
                 <a href="Aktuelt.aspx"><img src="img/slider/1.png" alt="hei" /></a><a class="neste" href="#">Neste</a><a class="forrige" href="#">Forrige</a>
            </li>
            <li>
                <a href="Aktuelt.aspx"><img src="img/slider/2.png" alt="hei" /></a><a class="neste" href="#">Neste</a><a class="forrige" href="#">Forrige</a> 
           </li>
            <li>
                <a href="Aktuelt.aspx"><img src="img/slider/3.png" alt="hei" /></a><a class="forrige" href="#">Forrige</a><a class="restart" href="#">Restart</a>
           </li> 
        </ul>
        </div> 
    </div>

     <div class="infoBoksIndex"> 
        <h3><asp:Literal ID="litNyhetsTittel_1" runat="server"></asp:Literal></h3>
        <p><asp:Literal ID="litNyhetsIngress_1" runat="server"></asp:Literal></p>
        <asp:Literal ID="litLinkNyhet1" runat="server"></asp:Literal>
     </div>

     <div class="infoBoksIndex"> 
        <h3><asp:Literal ID="litNyhetsTittel_2" runat="server"></asp:Literal></h3>
        <p><asp:Literal ID="litNyhetsIngress_2" runat="server"></asp:Literal></p>
        <asp:Literal ID="litLinkNyhet2" runat="server"></asp:Literal>
    </div>
        
    <div class="clearfix"></div>
</asp:Content>

