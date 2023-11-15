function openPopup() {
    document.getElementById("batalha").style.display = "block";

}

function closePopup() {
    document.getElementById("batalha").style.display = "none";
    location.reload();
}

document.addEventListener("DOMContentLoaded", function () {
    document.getElementById("abrirbatalha").addEventListener("click", openPopup);
    AtaqueInimigo();
});

function realizarAtaque() {
    var danoBase = parseInt(document.getElementById("danoBaseValue").textContent);
    var hpInimigo = parseInt(document.getElementById("hpInimigo").textContent);
    var dano = calcularDano(danoBase);

    hpInimigo -= dano;
    hpInimigo = Math.max(0, hpInimigo);

    document.getElementById("hpInimigo").textContent = hpInimigo;

    if (hpInimigo === 0) {
        exibirResultadoDoAtaque(dano, true);
    } else {
        exibirResultadoDoAtaque(dano, false);
    }
}

function exibirResultadoDoAtaque(dano, vitoria) {
    var chatBox = document.getElementById("chat-box");

    var infoDano = document.createElement("div");

    infoDano.textContent = "Ataque bem-sucedido! Dano causado: " + dano;

    chatBox.appendChild(infoDano);

    if (vitoria) {
        alert("Inimigo Derrotado!");
        location.reload();
    }
}

function AtaqueInimigo() {
    function loopAtaqueInimigo() {
        // Verifique se o HP do personagem é maior que 0 antes de realizar o ataque
        if (parseInt(document.getElementById("hpPersonagem").textContent) > 0) {
            setTimeout(function () {
                realizarAtaqueInimigo();
                // Chame recursivamente a função loopAtaqueInimigo após um tempo de espera
                loopAtaqueInimigo();
            }, 1000); // Aguarde 1 segundo entre os ataques inimigos
        }
    }

    // Inicie o loop de ataques inimigos
    loopAtaqueInimigo();
}


function realizarAtaqueInimigo() {
    var danoInimigo = parseInt(document.getElementById("danoInimigoValue").textContent);
    var hpPersonagem = parseInt(document.getElementById("hpPersonagem").textContent);
    var inimigoDano = calcularDanoInimigo(danoInimigo);

    hpPersonagem -= inimigoDano;
    hpPersonagem = Math.max(0, hpPersonagem);

    document.getElementById("hpPersonagem").textContent = hpPersonagem;

    if (hpPersonagem === 0) {
        exibirResultadoDoAtaqueInimigo(inimigoDano, true); // Passando true para indicar que é uma vitória
    } else {
        exibirResultadoDoAtaqueInimigo(inimigoDano, false); // Passando false para indicar que não é uma vitória
    }
}

function exibirResultadoDoAtaqueInimigo(inimigoDano, vitoria) {
    var chatBox = document.getElementById("chat-box");

    // Crie um novo elemento para a informação do dano do inimigo
    var infoDanoInimigo = document.createElement("div");

    // Adicione a informação do dano do inimigo à div chat-box
    infoDanoInimigo.textContent = "Ataque do inimigo! Dano causado: " + inimigoDano;

    // Adicione o novo elemento à div chat-box
    chatBox.appendChild(infoDanoInimigo);

    // Se for uma vitória, exiba um alerta
    if (vitoria) {
        alert("Você foi derrotado!");
        location.reload();
    }
}

function calcularDano(danoBase) {
    var danoAleatorio = Math.floor(Math.random() * danoBase) + 1;

    return danoAleatorio;
}
function calcularDanoInimigo(danoInimigo) {
    var danoAleatorio = Math.floor(Math.random() * danoInimigo) + 1;

    return danoAleatorio;
}



function closePopup() {
    document.getElementById("batalha").style.display = "none";
    location.reload();
}

