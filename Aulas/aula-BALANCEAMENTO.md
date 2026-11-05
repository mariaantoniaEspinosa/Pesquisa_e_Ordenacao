# BALANCEAMENTO DE ÁRVORES
- Motivo: acelerar as buscas = diminuir o número de comparações
- Técnicas:
  - AVL: faz o balanceamento ao inserir, garantindo que a árvore esteja menos profunda e o mais balanceada possível
  - DSW: faz o balanceamento em uma árvore totalmente desbalanceada
 
  
- Na estrutura de uma árvore AVL ou DSW há um novo atributo:
    - fb ou fe (fator de balanceamento ou fator de equilíbrio)
    - fb = altura(subArvore->esq) - altura(subArvore->dir)

- Situação de desbalanceamento/desequilíbrio
    - fb == -2 ou fb == 2

- Há somente dois métodos de rotação/giro
    - rodar/girar para esquerda -> quando -2
    - rodar/girar para direitoa -> quando +2
