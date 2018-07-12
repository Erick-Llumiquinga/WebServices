var puntajes = {};
function Guardar() {
    puntajes.puntos = puntosJugador;

    var puntajeJson = JSON.stringify(puntajes);
    $.ajax({
        url: 'http://localhost:50355/api/values',
        type: 'POST',
        dataType: 'JSON',
        contentType: 'application/json',
        data: puntajeJson,
        success: function (result) { console.log("Realizado"); return result;}
});
}
Guardar();
 console.log(pong.players[1].score.value)