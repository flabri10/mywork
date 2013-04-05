/**Kodet av Britt-Heidi Fladby**/
function GetFilmanmeldelseliste() {

    $('#anmeldelseTabell').empty();

    $('#anmeldelseTabell').append('<tr><td>Laster...</td></tr>');

    $.getJSON('api/Anmeldelse', function (data) {
        $('#anmeldelseTabell').empty();

        $.each(data, function (key, value) {
            $('#anmeldelseTabell').append(
                '<tr onclick="GetFilmanmeldelse(' + value["Id"] + ')"><td>'
                + value["Id"] +
                '</td><td>' + value['Epost'] +
                '</td><td>' + value['Tittel'] +
                '</td><td>' + value['Vurdering'] +
                '</td><td>' + value['Anmeldelsetekst'] +
                '</td></tr>');  
        });
    });
}

function GetFilmanmeldelse() {
    $.getJSON('api/Anmeldelse/' + id, function (data) {

        $('#txtId').val(data['Id']);
        $('#txtEpost').val(data['Epost']);
        $('#txtTittel').val(data['Tittel']);
        $('#rblVurder').val(data['Vurder']);
        $('#txtAnmeldelse').val(data['Anmeldelsetekst']);
    });
}

function OppdaterListe() {
    
    var anmeldelse = {
        Id: $('#txtId').val(),
        Epost: $('#txtEpost').val(),
        Tittel: $('#txtTittel').val(),
        Vurder: $('#rblVurder').val(),
        Anmeldelsetekst: $('#txtAnmeldelse').val()
    };

    $.ajax({
        url: 'api/Anmeldelse/' + anmeldelse.Id,
        type: 'PUT',
        data: JSON.stringify(anmeldelse),
        contentType: 'application/JSON',
        success: function () {
            GetFilmanmeldelseliste();
        }
    });
}

function SoekEtterAnmeldelse() {
    $.getJSON('api/Anmeldelse/' + epost, function (data) {
        $('#txtSoekEpost').val(data['SoekEpost']);
    });
}