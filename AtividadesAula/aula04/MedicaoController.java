// CHAMA model.executarRotina() PARA OBTER OS TEMPOS DE EXECUÇÃI E SEM SEGUIDA PARA ESSE RESULTADO PARA view.exibirTempoRotina
public class MedicaoController {
    private MedicaoModel model;
    private MedicaoView view;

    public MedicaoController(MedicaoModel model, MedicaoView view) {
        this.model = model;
        this.view = view;
    }

    public void iniciar() {
        // Executa e exibe a Rotina 1 (Aleatória)
        MedicaoModel.ResultadoMedicao rotina1 = model.executarRotina(100000, 100, 100000, true);
        view.exibirTempoRotina("rotina 1 (Aleatória)", rotina1.tempoMs);

        // Executa e exibe a Rotina 2 (Sequencial)
        MedicaoModel.ResultadoMedicao rotina2 = model.executarRotina(100000, 0, 100000, false);
        view.exibirTempoRotina("rotina 2 (Sequencial)", rotina2.tempoMs);
        
    }
}
