const iniciar = async () => {
    const tabela = document.getElementById('tabelaBurguers');
    // Fetch em /Burguers
    const response = await fetch('/Burguers');
    const fetchResult = await response.json();
    // Fetch em /BurguerIngrediente
    const responseBgIngrediente = await fetch('/BurguerIngrediente');
    const fetchResultBgIngrediente = await responseBgIngrediente.json();
    // Fetch em /Ingrediente
    const responseIngrediente = await fetch('/Ingrediente');
    const fetchResultIngrediente = await responseIngrediente.json();

    fetchResult.forEach(bg => {
        tabela.insertAdjacentHTML('beforeend', `<tr><td>${bg.nome}</td><td>${bg.preco.toFixed(2)}</td></tr>`);
    });
};

document.addEventListener('DOMContentLoaded', iniciar);