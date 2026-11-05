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
    - rodar/girar para direita -> quando +2

  - Métodos
    - rodar direita: raiz vira filho do filho da direita
    - rodar esquerda: raiz vira filho do filho da esquerda

  - Tipos de rotação
    - simples:
      - fbPai == - && fbFilho == -
      - fbPai == + && fbFilho == +
    - dupla:
      - fbPai == - && fbFilho == +
      - fbPai == + && fbFilho == -    

- O AVL é ativado no inserir 
