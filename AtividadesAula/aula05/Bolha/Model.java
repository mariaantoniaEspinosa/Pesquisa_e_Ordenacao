import java.util.List;

public class ListaModel {
    private List<Integer> lista;

    public ListaModel(List<Integer> lista Inicial) {
        this.lista = listaInicial;
    }

    public List<Integer> getLista() {
        return lista;
    }

    public void setLista(List<Integer> lista) {
        this.lista = lista;
    }

    // O seu código adaptado fica aqui na camada de negócio
    public void ordenarPorBolha() {
        int aux;
        boolean houveTroca;
        int i;
        do {
            houveTroca = false;
            for (i = 0; i < lista.size() - 1; i++) {
                if (lista.get(i) > lista.get(i + 1)) {
                    houveTroca = true;
                    aux = lista.get(i);
                    lista.set(i, lista.get(i + 1));
                    lista.set(i + 1, aux);
                }
            }
        } while (houveTroca);
    }
}
