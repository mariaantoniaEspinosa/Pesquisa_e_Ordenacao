# Roteiro de estudo:
1) O universo da ordenação
   - algoritmos
   - conceitos
2) O universo de pesquisa
   - conceitos
   - algoritmos
     - sequencial
     - binário
     - digital
3)  HASH
   - função de espalhamento, ou seja, um dado é armazenado ou pesquisado na estrutura via um código de endereçamento
   - conceitos
     - tabela hash: estrutura de dados que armazena dados
       - estrutura de dados mais eficiente
         - complexidade baixa [O(1)]
           - menor esforço:
             - na ordenação → esforço é calculado pela quantidade de comparações + quantidade de trocas
             - na pesquisa → esforço é calculado pela quantidade de comparações
               - tipos de PESQUISA:
                 - sequencial → O(n)
                 - binária → O (log n)
                 - digital → ?
                 - hash → O(1)
     - função hash: cálculo de endereçamento para armazenar e buscar elementos na estrutura
     - tipos de tratamento de colisões
       - listas encadeadas
       - open addressing ou closed hashing
      - DADO: composto por chaves (nome, id, cpf, email...)
        - para quando uma chave tiver duplicidade, exemplo, nome Maria, usamos a FUNÇÃO HASH
        - [funcaoHash(chave)]
  - Hash não é ideal para estruturas pequenas
  - tabela hash é ESPALHAMENTO
  - existe um cálculo de endereçamento que coloca no mesmo lugar e busca no mesmo lugar
  - **pesquisar a diferença de Hash MAP pra Hash SET, com exemplos**
  - tabela hash NÃO TEM ÍNDICE 
