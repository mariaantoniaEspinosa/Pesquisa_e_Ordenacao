import random
import time

class ResultadoMedicao:
    """Estrutura simples para envelopar os resultados."""
    def __init__(self, lista, tempo_ms):
        self.lista = lista
        self.tempo_ms = tempo_ms

class MedicaoModel:
    def executar_rotina(self, quantidade: int, inicio: int, fim: int, aleatorio: bool) -> ResultadoMedicao:
        lista = []
        
        # Marca o tempo inicial em nanossegundos
        tempo_inicio = time.perf_counter_ns()
        
        if aleatorio:
            for _ in range(quantidade):
                # random.randint já inclui o valor do parâmetro 'fim'
                lista.append(random.randint(inicio, fim))
        else:
            for i in range(quantidade):
                lista.append(inicio + i)
                
        # Marca o tempo final
        tempo_fim = time.perf_counter_ns()
        
        # Converte a diferença para milissegundos
        tempo_ms = (tempo_fim - tempo_inicio) / 1_000_000.0
        
        return ResultadoMedicao(lista, tempo_ms)
