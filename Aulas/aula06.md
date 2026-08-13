## Continuação dos Algoritmos
- **Agitação: Shake Sort/Cocktail**
  - É baseado no bolha, ou seja, é uma tentativa de melhorar o Bolha
  - Estável = mantém a ordenação - "não bagunça"
  - Memória Interna - RAM
  - A estrutura possui 3 partes/porções - pirâmide invertida
    - 1ª ordenada pelos menores
    - 2ª desordenada
    - 3ª ordenada pelos maiores
  - É a aplicação do bolha da esquerda pra direita e depois da direita pra esquerda
  - Há os índices/ponteiros "início" e "fim" que marcam o início e o fim da estrutura
```c#

void agitacao(List<> lista) {
    bool houveTroca;
    int tmp;
    int ini = 0;
    int fim = lista.Count;
    int qtdComparacoes = 0, qtdTrocas = 0;  //avalia a complexidade ou o esforço

    do {
        houveTroca = False;
        for (int i = ini; i < fim-1; i++){
            qtdComparacoes++;
            if (lista[i] > lista[i+1]) {
                qtdTrocas++;
                houveTroca = True;
                tmp = lista[i];
                lista[i] = lista[i+1];
                lista[i+1] = tmp;
            }
        }

        if (!houveTroca) {
            break;
        }
        fim--;

        houveTroca = False;
        for (int i = fim; i > ini+1; i--){
            qtdComparacoes++;
            if (lista[i] < lista[i-1]) {
                qtdTrocas++;
                houveTroca = True;
                tmp = lista[i];
                lista[i] = lista[i-1];
                lista[i-1] = tmp;
            }
        }
        ini++;

    } while (houveTroca);
}
````

