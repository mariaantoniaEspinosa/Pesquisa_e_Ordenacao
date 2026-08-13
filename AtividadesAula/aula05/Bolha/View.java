import java.util.List;

public class ListaView {
    public void exibirLista(String mensagem, List<Integer> lista) {
        System.out.println(mensagem + ": " + lista);
    }

    public void exibirMensagemErro(String erro) {
        System.err.println("Erro: " + erro);
    }
}
