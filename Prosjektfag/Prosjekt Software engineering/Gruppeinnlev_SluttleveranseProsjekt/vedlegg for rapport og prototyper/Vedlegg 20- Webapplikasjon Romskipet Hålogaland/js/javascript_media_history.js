//javaScript/jQuery for Norsk Romfartshistorie, KursProfil og Media

var deltakerListe;

window.onload = init;

function init() {
    deltakerListe = document.getElementById("deltakerListe");
}

$(document).ready(function () {
    
    //Setter opacity til 100% når man hovrer bildet, og til 80% når musen forlater bildet.
    $('.imgBildeliste').mouseover(function () {
        $(this).animate({
            "opacity": 1,
        }, 200);
    });

    $('.imgBildeliste').mouseout(function () {
        $(this).animate({
            "opacity": 0.8
        }, 200);
    });

    //Klikk på et bilde, utfør funksjoner
    $('.imgBildeliste').click(function () {

        //fader inn bildefremviseren
        $('#bildeFremviser').fadeIn(400);

        //overfører attributter fra bildet som ble trykket på til bildefremviseren.
        var bildepath = $(this).attr("src");
        var bildenavn = $(this).attr("alt");

        $('#fokusBilde').attr("src", bildepath);
        $('#fokusBilde').attr("alt", bildenavn);

        //Finner størrelsen på bildet slik bildet popper opp i midten, 
        //og at lukkeknapp og bildetekst kan vises på samme sted uansett størrelse på bilde.
        $('#fokusBilde').load(function () {
            var X = $('#fokusBilde').width();
            var Y = $('#fokusBilde').height();

            $('#divLukk').width(X);
            $('#divLukk').height(Y);
        });

        $('#divLukk p').html(bildenavn);

    });
    //Lukker bildefremviseren.
    $('#bildeFremviser').click(function () {
        $('#bildeFremviser').fadeOut(400);
    });

});

//Js for deltakere og lister
function visDeltakerListe() {
    deltakerListe.style.display = "block";
}

function lukkDeltakerListe() {
    deltakerListe.style.display = "none";
}

function LeggTilForeleser() {
    var foreleser = document.getElementById("cphMainContent_ddlForelesere").value;
    document.getElementById("pForeleserListe").innerHTML += foreleser + ", ";
}
  

//HISTORIE

function finnHistorie(grader) {

    if (grader >= 1960 && grader < 1970) {
        h3Overskrift.innerHTML = "Perioden 1960-1969";
        pHistorie.innerHTML = "18. august 1962 ble den aller første forskningsraketten skutt ut fra Andøya Rakettskytefelt, og markerte med det starten på en helt ny industri i Norge. En industri som i dag omsetter for flere milliarder kroner årlig. Norske rombedrifter nyter stor anseelse i utlandet for sin spisskompetanse og gode produkter.";
        imgHistorie.src = "img/historie/1960.jpg";
    } else if (grader >= 1970 && grader < 1980) {
        h3Overskrift.innerHTML = "Perioden 1970-1979";
        pHistorie.innerHTML = "Få dager før Apollo 13 ble skutt opp 11. april 1970, ble primærbesetningen for ferden, James Lovell (kommandør), Fred Haise (pilot for månelandingsfartøyet) og Thomas Mattingly (pilot for kommandoseksjonen) utsatt for smitte av røde hunder. Undersøkelser gjorde det klart at Mattingly ikke var immun mot sykdommen. Siden en syk astronaut i rommet kunne være en fare for både seg selv og romferden, fikk Mattingly «startforbud». Kommandopiloten i reservebesetningen, John Leonard Swigert jr., gikk inn i primærbesetningen istedenfor Mattingly.";
        imgHistorie.src = "img/historie/1970.jpg";
    } else if (grader >= 1980 && grader < 1990) {
        h3Overskrift.innerHTML = "Perioden 1980-1989";
        pHistorie.innerHTML = "80-tallet var en viktig tid for Norsk Romfart. Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
        imgHistorie.src = "img/historie/1980.jpg";
    } else if (grader >= 1990 && grader < 2000) {
        h3Overskrift.innerHTML = "Perioden 1990-1999";
        pHistorie.innerHTML = "90-tallet er tiden for raketter. Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
        imgHistorie.src = "img/historie/1990.jpg";
    } else if (grader >= 2000 && grader < 2010) {
        h3Overskrift.innerHTML = "Perioden 2000-2009";
        pHistorie.innerHTML = "Norge har aldri skutt opp fler rakketter enn i denne perioden. Med god økonomi og gode rakkettforskere lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
        imgHistorie.src = "img/historie/2000.jpg";
    } else {
        h3Overskrift.innerHTML = "Perioden 2010 til nåtid";
        pHistorie.innerHTML = "I 2012 er det 50 år siden den første forskningsrakketter ble skutt opp fra Andøya rakettskytefelt. Dette ble feiret med lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
        imgHistorie.src = "img/historie/2010.jpg";
    }

}

$(function () {

    $(".lesMerOnclick").click(function (event) {
        event.preventDefault();
        $(this).next().slideToggle();
    })
})

$(function () {

    $(".lesMerOnclickSkole").click(function (event) {
        event.preventDefault();
        $(this).next().slideToggle();
    })
})

$(function () {

    $(".lesMerOnclickProsjekt").click(function (event) {
        event.preventDefault();
        $(this).next().slideToggle();
    })
})
