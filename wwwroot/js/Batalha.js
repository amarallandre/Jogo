function openPopup() {
    document.getElementById("batalha").style.display = "block";

}

// Fun��o para fechar o pop-up
function closePopup() {
    document.getElementById("batalha").style.display = "none";
    location.reload(); // Isso recarregar� a p�gina atual
}

document.addEventListener("DOMContentLoaded", function () {
    // Event listener para o bot�o de abrir pop-up
    document.getElementById("abrirbatalha").addEventListener("click", openPopup);
});

function realizarAtaque() {
    // Obter o DanoBase do HTML
    var danoBase = parseInt(document.getElementById("danoBaseValue").textContent);

    // Obter o HP do inimigo do HTML
    var hpInimigo = parseInt(document.getElementById("hpInimigo").textContent);

    // Calcular o dano aleat�rio
    var dano = calcularDano(danoBase);

    // Reduzir o HP do inimigo
    hpInimigo -= dano;

    // Garantir que o HP n�o seja negativo
    hpInimigo = Math.max(0, hpInimigo);

    // Atualizar o HP do inimigo no HTML
    document.getElementById("hpInimigo").textContent = hpInimigo;

    // Verificar se o inimigo foi derrotado
    if (hpInimigo === 0) {
        exibirResultadoDoAtaque(dano);
    } else {
        alert("Ataque bem-sucedido! Dano causado: " + dano);
    }
}

function calcularDano(danoBase) {
    // Gerar um n�mero aleat�rio entre 1 e o danoBase
    var danoAleatorio = Math.floor(Math.random() * danoBase) + 1;

    return danoAleatorio;
}

function exibirResultadoDoAtaque(dano) {
    // Exibir ou processar o resultado do ataque
    var confirmacao = confirm("Inimigo Derrotado! Dano causado: " + dano + "\nDeseja fechar a batalha?");
    if (confirmacao) {
        closePopup();
    }
}

// Fun��o para fechar o pop-up
function closePopup() {
    document.getElementById("batalha").style.display = "none";
    location.reload(); // Isso recarregar� a p�gina atual
    // N�o h� necessidade de recarregar a p�gina aqui, remova a linha abaixo se n�o for necess�rio
    // location.reload(); 
}