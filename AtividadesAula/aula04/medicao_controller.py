from medicao_model import MedicaoModel
from medicao_view import MedicaoView

class MedicaoController:
    def __init__(self, model: MedicaoModel, view: MedicaoView):
        self.model = model
        self.view = view

    def iniciar(self):
        # Executa e exibe a Rotina 1 (Aleatória)
        rotina1 = self.model.executar_rotina(100000, 100, 100000, True)
        self.view.exibir_tempo_rotina("rotina 1 (Aleatória)", rotina1.tempo_ms)

        # Executa e exibe a Rotina 2 (Sequencial)
        rotina2 = self.model.executar_rotina(100000, 0, 100000, False)
        self.view.exibir_tempo_rotina("rotina 2 (Sequencial)", rotina2.tempo_ms)
