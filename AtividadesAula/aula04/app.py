from medicao_model import MedicaoModel
from medicao_view import MedicaoView
from medicao_controller import MedicaoController  # Alterado aqui!

def principal():
    meu_modelo = MedicaoModel()
    minha_visao = MedicaoView()
    
    controlador = MedicaoController(meu_modelo, minha_visao)
    controlador.iniciar()

if __name__ == "__main__":
    principal()
