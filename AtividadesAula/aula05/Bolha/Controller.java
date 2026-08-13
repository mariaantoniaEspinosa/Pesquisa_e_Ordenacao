public class ListaController {
    private ListaModel model;
    private ListaView view;

    public ListaController(ListaModel model, ListaView view) {
        this.model = model;
        this.view = view;
    }

    // Método que coordena a ação de ordenação
    public void executarOrdenacao() {
        view.exibirLista("Lista antes da ordenação", model.getLista());
        
        // Executa a lógica do Model
        model.ordenarPorBolha(); 
        
        view.exibirLista("Lista após a ordenação (Bubble Sort)", model.getLista());
    }
}
