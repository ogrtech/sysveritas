
//Validando cuando los talleres a seleccionar según la asistencia
function valAsistencia() {
    var div1 = document.getElementById('divTaller1');
    var div2 = document.getElementById('divTaller2');
    var div3 = document.getElementById('divTaller3');
    var div4 = document.getElementById('divTaller4');
    var div5 = document.getElementById('divTaller5');
    var div6 = document.getElementById('divTaller6');
    var div7 = document.getElementById('divTaller7');

    var radioDia10=document.getElementsByName("optradio");
     
    if (radioDia10[0].checked)
    {
        div1.style.display = 'block';
        div2.style.display = 'block';
        div3.style.display = 'block';
        div4.style.display = 'block';
        div5.style.display = 'none';
        div6.style.display = 'none';
        div7.style.display = 'none';
    } else if (radioDia10[1].checked) {
        div1.style.display = 'none';
        div2.style.display = 'none';
        div3.style.display = 'none';
        div4.style.display = 'none';
        div5.style.display = 'block';
        div6.style.display = 'block';
        div7.style.display = 'block';
    } else if (radioDia10[2].checked) {
        div1.style.display = 'block';
        div2.style.display = 'block';
        div3.style.display = 'block';
        div4.style.display = 'block';
        div5.style.display = 'block';
        div6.style.display = 'block';
        div7.style.display = 'block';
    }
    
}