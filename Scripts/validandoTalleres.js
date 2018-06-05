
$("#cbxTaller1").change(function () {
    var taller1 = $('#cbxTaller1').val();
    var taller2 = $('#cbxTaller2').val();
    var taller3 = $('#cbxTaller3').val();
    var taller4 = $('#cbxTaller4').val();
    var taller5 = $('#cbxTaller5').val();
    var taller6 = $('#cbxTaller6').val();
    var taller7 = $('#cbxTaller7').val();
    if (taller1 == taller2 || taller1 == taller3 || taller1 == taller4 || taller1 == taller5 || taller1 == taller6 || taller1 == taller7) {
        alert("Seleccione un taller que no haya seleccionado antes");
        $('#cbxTaller1').val(0);
        $('#decripcionTaller1').text("");
    } else {

        $('#decripcionTaller1').text(textoValidar($('#cbxTaller1').val()));
      

    }

});
$("#cbxTaller2").change(function () {
    var taller1 = $('#cbxTaller1').val();
    var taller2 = $('#cbxTaller2').val();
    var taller3 = $('#cbxTaller3').val();
    var taller4 = $('#cbxTaller4').val();
    var taller5 = $('#cbxTaller5').val();
    var taller6 = $('#cbxTaller6').val();
    var taller7 = $('#cbxTaller7').val();
    if (taller2 == taller1 || taller2 == taller3 || taller2 == taller4 || taller2 == taller5 || taller2 == taller6 || taller2 == taller7) {
        alert("Seleccione un taller que no haya seleccionado antes");
        $('#cbxTaller2').val(0);
        $('#decripcionTaller2').text("");
    } else {

        $('#decripcionTaller2').text(textoValidar($('#cbxTaller2').val()));
        
    }

});

$("#cbxTaller3").change(function () {
    var taller1 = $('#cbxTaller1').val();
    var taller2 = $('#cbxTaller2').val();
    var taller3 = $('#cbxTaller3').val();
    var taller4 = $('#cbxTaller4').val();
    var taller5 = $('#cbxTaller5').val();
    var taller6 = $('#cbxTaller6').val();
    var taller7 = $('#cbxTaller7').val();
    if (taller3 == taller1 || taller3 == taller2 || taller3 == taller4 || taller3 == taller5 || taller3 == taller6 || taller3 == taller7) {
        alert("Seleccione un taller que no haya seleccionado antes");
        $('#cbxTaller3').val(0);
        $('#decripcionTaller3').text("");
    } else {

        $('#decripcionTaller3').text(textoValidar($('#cbxTaller3').val()));
    }

});

$("#cbxTaller4").change(function () {
    var taller1 = $('#cbxTaller1').val();
    var taller2 = $('#cbxTaller2').val();
    var taller3 = $('#cbxTaller3').val();
    var taller4 = $('#cbxTaller4').val();
    var taller5 = $('#cbxTaller5').val();
    var taller6 = $('#cbxTaller6').val();
    var taller7 = $('#cbxTaller7').val();
    if (taller4 == taller1 || taller4 == taller2 || taller4 == taller3 || taller4 == taller5 || taller4 == taller6 || taller4 == taller7) {
        alert("Seleccione un taller que no haya seleccionado antes");
        $('#cbxTaller4').val(0);
        $('#decripcionTaller4').text("");
    } else {

        $('#decripcionTaller4').text(textoValidar($('#cbxTaller4').val()));
    }

});
$("#cbxTaller5").change(function () {
    var taller1 = $('#cbxTaller1').val();
    var taller2 = $('#cbxTaller2').val();
    var taller3 = $('#cbxTaller3').val();
    var taller4 = $('#cbxTaller4').val();
    var taller5 = $('#cbxTaller5').val();
    var taller6 = $('#cbxTaller6').val();
    var taller7 = $('#cbxTaller7').val();
    if (taller5 == taller1 || taller5 == taller2 || taller5 == taller3 || taller5 == taller4 || taller5 == taller6 || taller5 == taller7) {
        alert("Seleccione un taller que no haya seleccionado antes");
        $('#cbxTaller5').val(0);
        $('#decripcionTaller5').text("");
    } else {
        $('#decripcionTaller5').text(textoValidar($('#cbxTaller4').val()));
    }

});
$("#cbxTaller6").change(function () {
    var taller1 = $('#cbxTaller1').val();
    var taller2 = $('#cbxTaller2').val();
    var taller3 = $('#cbxTaller3').val();
    var taller4 = $('#cbxTaller4').val();
    var taller5 = $('#cbxTaller5').val();
    var taller6 = $('#cbxTaller6').val();
    var taller7 = $('#cbxTaller7').val();
    if (taller6 == taller1 || taller6 == taller2 || taller6 == taller3 || taller6 == taller4 || taller6 == taller5 || taller6 == taller7) {
        alert("Seleccione un taller que no haya seleccionado antes");
        $('#cbxTaller6').val(0);
        $('#decripcionTaller6').text("");
    } else {
        $('#decripcionTaller6').text(textoValidar($('#cbxTaller6').val()));
    }

});
$("#cbxTaller7").change(function () {
    var taller1 = $('#cbxTaller1').val();
    var taller2 = $('#cbxTaller2').val();
    var taller3 = $('#cbxTaller3').val();
    var taller4 = $('#cbxTaller4').val();
    var taller5 = $('#cbxTaller5').val();
    var taller6 = $('#cbxTaller6').val();
    var taller7 = $('#cbxTaller7').val();
    if (taller7 == taller1 || taller7 == taller2 || taller7 == taller3 || taller7 == taller4 || taller7 == taller5 || taller7 == taller6) {
        alert("Seleccione un taller que no haya seleccionado antes");
        $('#cbxTaller7').val(0);
        $('#decripcionTaller4').text("");
    } else {
        $('#decripcionTaller7').text(textoValidar($('#cbxTaller7').val()));
    }

});

function limpiarCampos() {

    $('#cbxTituloRol').val(0);
    $('#cbxTaller1').val(0);
    $('#cbxTaller2').val(0);
    $('#cbxTaller3').val(0);
    $('#cbxTaller4').val(0);
    $('#cbxTaller5').val(0);
    $('#cbxTaller6').val(0);
    $('#cbxTaller7').val(0);

}
function textoValidar(valorCombobox) {


    // alert("Taller #: " + $('#cbxTaller1').val());
    switch (valorCombobox) {

        case "1":
            return "Es una herramienta que permite actualizarnos y facilitar la enseñanza";
            break;
        case "2":
            return "Aprenderemos sobre el propósito de las matemáticas y su perspectiva bíblica.";
            break;
        case "3":
            return "Su implementación en el currículo regular tiene un gran aporte cognitivo en el desarrollo de las habilidades de los estudiantes.";
            break;
        case "4":
            return "¿Cómo mejorar el nivel de atención de nuestros estudiantes de manera eficiente?";
            break;
        case "5":
            return "La supervisión y evaluación tienen resultados diferentes que se complementan uno a otro. Supervisar es desarrollar la capacidad del maestro.";
            break;
        case "6":
            return "¿Cómo sé si necesito ayuda adicional para identificar los problemas a los que mi alumno puede estarse enfrentando?";
            break;
        case "7":
            return "¿Cómo los educadores cristianos deben responder al argumento de que el cristianismo está en contra de la ciencia?";
            break;
        case "8":
            return "La postura de un educador cristiano frente a la ideología de género.";
    }


}