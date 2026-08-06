class MedicaoView:
    def exibir_tempo_rotina(self, nome_rotina: str, tempo_ms: float):
        print(f"Tempo (ms) {nome_rotina}: {tempo_ms:.4f}")

    def exibir_lista(self, lista: list, frase: str):
        print(frase)
        for item in lista:
            print(item)
        print("--------------------------")
        print(f"Total de registros: {len(lista)}")
