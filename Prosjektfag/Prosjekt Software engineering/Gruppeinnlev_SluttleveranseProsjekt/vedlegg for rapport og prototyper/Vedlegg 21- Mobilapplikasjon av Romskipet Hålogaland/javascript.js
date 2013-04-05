//tabeller
var bildenavn = ["media/1.jpg",
                "media/2.jpg",
                "media/3.jpg",
                "Media/4.jpg",
                "Media/5.jpg",
                "Media/6.jpg",
                "Media/7.jpg",
                "Media/8.jpg",
                "Media/9.jpg",
                "Media/10.jpg",
                "Media/11.jpg",
                "Media/12.jpg",
                "Media/13.jpg",
                "Media/14.jpg",
                "Media/15.jpg"
                ];
var divBilder;

window.onload = function initialLoad(){
	divBilder = document.getElementById("divBilder");
	genererBilder();
}

function genererBilder() {
	for (var i = 0; i < bildenavn.length; i++) {
		var nyttBilde = "<img class='imgBildeliste' src='" + bildenavn[i] + "'alt='informasjon' />";
		divBilder.innerHTML += nyttBilde;
	}
}



$(document).ready(function () {
	
    $('.imgBildeliste').live("click", function () {
	
        //fader inn bildefremviseren
        $('#bildeFremviser').fadeIn(200);

        //overfører attributter fra bildet som ble trykket på til bildefremviseren.
        var bildepath = $(this).attr("src");
        var bildenavn = $(this).attr("alt");
		
		//Splitter bildepathen slik at bilde med høyere oppløsning vil bli vist i bildefremviser.
		var splittetBildepath = bildepath.split('/', 2);
		var nyBildepath = "Media/big_" + splittetBildepath[1];
		
        $('#fokusBilde').attr("src", nyBildepath);
        $('#fokusBilde').attr("alt", bildenavn);
				
		//Lukker bildefremviseren.
		$('#bildeFremviser').click(function () {
			$('#bildeFremviser').fadeOut(200);
		});
	});
});
