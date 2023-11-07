function openPopup() {
    document.getElementById("batalha").style.display = "block";

}

// Função para fechar o pop-up
function closePopup() {
    document.getElementById("batalha").style.display = "none";
    location.reload(); // Isso recarregará a página atual
}

document.addEventListener("DOMContentLoaded", function () {
    // Event listener para o botão de abrir pop-up
    document.getElementById("abrirbatalha").addEventListener("click", openPopup);
});

// Função para realizar um ataque
function realizarAtaque() {
    // Simulação: Reduzir HP e MP ao realizar um ataque
    var hpAtual = parseInt(document.getElementById("hpValue").textContent);
    var mpAtual = parseInt(document.getElementById("mpValue").textContent);

    // Reduz 10 de HP e 5 de MP (valores arbitrários)
    hpAtual -= 10;
    mpAtual -= 5;

    // Atualiza os valores exibidos
    document.getElementById("hpValue").textContent = Math.max(0, hpAtual);
    document.getElementById("mpValue").textContent = Math.max(0, mpAtual);

    // Exibe mensagem no console (substitua isso pela lógica real do seu jogo)
    console.log("Ataque realizado! HP e MP reduzidos.");
}