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

// Fun��o para realizar um ataque
function realizarAtaque() {
    // Simula��o: Reduzir HP e MP ao realizar um ataque
    var hpAtual = parseInt(document.getElementById("hpValue").textContent);
    var mpAtual = parseInt(document.getElementById("mpValue").textContent);

    // Reduz 10 de HP e 5 de MP (valores arbitr�rios)
    hpAtual -= 10;
    mpAtual -= 5;

    // Atualiza os valores exibidos
    document.getElementById("hpValue").textContent = Math.max(0, hpAtual);
    document.getElementById("mpValue").textContent = Math.max(0, mpAtual);

    // Exibe mensagem no console (substitua isso pela l�gica real do seu jogo)
    console.log("Ataque realizado! HP e MP reduzidos.");
}