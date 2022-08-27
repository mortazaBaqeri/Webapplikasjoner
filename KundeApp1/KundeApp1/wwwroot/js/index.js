$(function () {
    hentAlleKunder();
});

function hentAlleKunder() {
    $.get("Kunde/HentAlle", function (kunder) {
        formaterKunder(kunder);
    });
};

function formaterKunder(kunder) {
    let ut = "<table class='table table-striped'>";
    ut += "<tr>";
    ut += "<th>Navn</th><th>Adresse</th>";
    ut += "</tr>";

    for (let kunde of kunder) {
        ut += "<tr>" +
            "<td>" + kunde.navn + "</td>" +
            "<td>" + kunde.adresse + "</td>" +
            "</tr>"
    }
    ut += "</table>";
    $("#kundene").html(ut);
};
