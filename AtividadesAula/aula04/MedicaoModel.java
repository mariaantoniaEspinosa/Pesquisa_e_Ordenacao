// É A CLASSE QUE CALCULA O TEMPO E PREENCHE A LISTA DE FORMA SEQUENCIAL OU COM RANDOM
import java.util.List;
import java.util.ArrayList;
import java.util.Random;

public class MedicaoModel {

    // Estrutura para envelopar o resultado (Lista + Tempo de execução)
    public static class ResultadoMedicao {
        public List<Integer> lista;
        public double tempoMs;

        public ResultadoMedicao(List<Integer> lista, double tempoMs) {
            this.lista = lista;
            this.tempoMs = tempoMs;
        }
    }

    public ResultadoMedicao executarRotina(long quantidade, int inicio, int fim, boolean aleatorio) {
        List<Integer> lista = new ArrayList<>();
        Random gerador = new Random();
        
        long tempoInicio = System.nanoTime();
        
        if (aleatorio) {
            for (long i = 0; i < quantidade; i++) {
                lista.add(gerador.nextInt(inicio, fim + 1));
            }
        } else {
            for (int i = 0; i < quantidade; i++) {
                lista.add(inicio + i);
            }
        }
        
        long tempoFim = System.nanoTime();
        double tempoMs = (tempoFim - tempoInicio) / 1000000.0;
        
        return new ResultadoMedicao(lista, tempoMs);
    }
}
