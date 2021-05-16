$(document).ready(function () {
    $("#valor").mask('000000,00', { reverse: true });
    $("#valor").val("");
   
});

$(document).submit(function () {
    $("#valor").val().replace(',', '.');
});
