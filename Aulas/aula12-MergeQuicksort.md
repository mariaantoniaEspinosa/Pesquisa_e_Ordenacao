# Ordenação ≅ Organização → Otimização da pesquisa
## Revisando...
- Chave de ordenação ≅ índice
  - Pode ser + de 1 → A classe precisa implementar **comparable**
  - Complexidade ≅ esforço ≅ número de comparações ≅ número de trocas
  - Como contar o esforço? Benchmark
    - número de comparações
    - número de trocas
    - tempo
- **Métodos Simples com Alta complexidade**
    - Bolha - Agitação - Pente - Seleção - Inserção (O(n²))
## Aula 12 
- **Métodos de Baixa complexidade, porém "difíceis" de implementar**
### MERGE
- Intercalar: empilhamento
- Recursivo
- Composto por 2 métodos:
  - merge → recursivo
  - divide homogeneamente 
  - intercalar → ordenar no retorno do "empilhamento" → no processo de intercalação
- Ordenação se dá na volta da recursão
- Pra baixo vai dividindo por 2, pra cima vai intercalando
- Complexidade: O(n. log n)
- OBS: O processo é baseado em divisões da estrutura recursivamente, sempre no meio
### QUICKSORT
- pivo: quem é ordenado
- recursivo
- Composto por 2 métodos:
  - quick → recursivo
  - posicionar → ordenar o pivo
- Complexidade: O(n. log n)
- OBS: O processo é baseado em divisões da estrutura recursivamente, porém obedecendo a posição do pivo
### AlgoRythmics: vídeos tutoriais sobre os algoritmos 
