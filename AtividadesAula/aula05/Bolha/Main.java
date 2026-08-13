import java.util.ArrayList;
import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        // Criando a lista inicial de dados
        ListaModel model = new ListaModel(new ArrayList<>(Arrays.asList(5, 3, 8, 1, 2)));
        ListaView view = new ListaView();
        
        // Instanciando o controlador com o modelo e a visão
        ListaController controller = new ListaController(model, view);
        
        // Executando o fluxo
        controller.executarOrdenacao();
    }
}
