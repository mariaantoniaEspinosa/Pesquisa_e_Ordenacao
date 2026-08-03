- Códigos a partir da aula de hoje devem seguir o padrão arquitetural
# Conceitos e fundamentos
 - Categorias de ordenação para os algoritmos:
   - memória interna ou memória externa
   - estabilidade do algoritmo
     - estável: o processo de ordenação garante a ordenação temporária da estrutura
     - instável: o processo de ordenação não garante a ordenação temporária da estrutura
  - Complexidade computacional é o esforço de um algoritmo
    - na ordenação a complexidade dos algoritmos é medida pela quantidade de **comparações** e **trocas**
    - categorias:
      - complexidade fatorial      - O(n!)           - menos eficiente
      - complexidade polinomial    - O(n^k)
      - complexidade exponencial   - O(n^2)
      - complexidade linear        - O(n)
      - complexidade logarítmica   - O(log n)        - mais eficiente
## Pesquisar sobre os métodos de ordenação e categoriza-los em:
- algoritmo de memória interna ou externa
- estabilidade (estável ou instável)
- complexidade
- porções de ordenação
### Métodos:

- **Bolha** (bubble sort)
  - memória interna
  - estável
  - O(n^2)
  - porção ordenada: final
    
- **seleção** (selection sort)
   - memória interna
   - instável
   - O(nˆ2)
   - porção ordenada: início
     
- **inserção** (inserction sort)
  - memória interna
  - estável
  - O(nˆ2)
  - porção ordenada: início

- **pente** (combsort)
  - memória interna
  - instável
  - O(n^2) ou O(n log n)
  - porção ordenada: todo o vetor
    
- **agitação** (shakesort ou cocktailsort)
  - memória interna
  - estável
  - O(n^2)
  - porção ordenada: início e final simultaneamente 

- **shellsort**
  - memória interna
  - instável
  - O(n^2) ou O(n log^2 n)
  - porção ordenada: todo o vetor

 - **bucketsort**
   - memória externa
   - estável
   - O(n + k) ou O(n^2)
   - porção ordenada: distribuída em baldes

- **radix**
  - memória externa
  - estável
  - O(n * k) (k é o número de bytes)
  - porção ordenada: do dígito menos significativo para o mais significativo 

- **heapsort**
  - memória interna
  - instável
  - O(n log n)
  - porção ordenada: final do vetor

- **mergesort**
  - memória externa
  - estável
  - O( n log n)
  - porção ordenada: subvetores progressivamente maiores

- **quicksort**
  - memória interna
  - instável
  - O(n log n) ou O(n^2)
  - porção ordenada: em torno do pivô

### Comentários
- eficiente versus eficaz: ambos atingem objetivos
- qual o melhor algoritmo de ordenação?
  - depende do **tamanho** e do **quanto já está ordenado**
- cenários de um processo de ordenação
  - pior caso
    - bolha: lista ordenada decrescente e se desejar ordenar crescente
    - seleção: lista ordenada
    - inserção: lista ordenada e se desejar ordenar crescente 
   
