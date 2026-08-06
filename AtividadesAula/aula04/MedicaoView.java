// É A CLASSE QUE CONTÉM OS PRINTS, ELA RECEBE OS DADOS PUROS E FORFMATA NA TELA 
import java.util.List;

public class MedicaoView {

    public void exibirTempoRotina(String nomeRotina, double tempoMs) {
        System.out.println("Tempo (ms) " + nomeRotina + ": " + tempoMs);
    }

    public void exibirLista(List<Integer> lista, String frase) {
        System.out.println(frase);
        for (Integer item : lista) {
            System.out.println(item);
        }
        System.out.println("--------------------------");
        System.out.println("Total de registros: " + lista.size());
    }
}
