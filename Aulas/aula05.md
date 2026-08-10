# Algoritmos Simples - Altos em complexidade
- Bolha -> O(n^2) -> estável -> memória RAM -> parte ordenada está no final da lista/vetor
  - A ideia da Bolha é porque o maior valor em cada passada (aplica o for) do vetor é levado até o final da estrutura como uma bolha.
  - 2 repetições -> 1° While, 2° For
  - Variável "houve troca"
```cs
void bolha (List<int> lista){
    int aux;
    boolean houveTroca;
    int i;
    do{
        houveTroca = false;
        for(i=0; i< lista.size() = -1; i++){
            if(lista[i] > lista[i+1]){
                houveTroca = true;
                aux = lista[i];
                lista[i] = lista [i +1];
                lista[i +1] = aux;
            }
        }
    }while(houveTroca);
}
````
- Seleção -> O(n^2) -> instável -> memória RAM -> parte ordenada está no início da estrutura
  - A ideia da Seleção é porque a cada célula do vetor, ao avançar, se seleciona (ou laça) o menor valor para aquela posição.
  - 2 repetições -> 1° For, 2° For
  - Variável "posição menor"
```cs
void selecao(List<int> lista)
{
    int posMenor, aux;
    int i, j;
    for(i = 0; i < lista.size()-1; i++)
    {
        posMenor = i;
        for(j = i+1; j < lista.size(); i++)
        {
            if(lista[j] < lista[posMenor])
            {
                posMenor = j;
            }
        }
        if(i != posMenor)
        {
            aux = lista[i];
            lista[i] = lista[posMenor];
            lista[posMenor] = aux;
        }
    }
}
```
- Inserção -> O(n^2) -> instável -> memória RAM -> parte ordenada está no início da estrutura
  - A ideia da Inserção é porque cada vetor da porção da direita da estrutura é inserido na sua posição correta na porção da esquerda.
  - 2 repetições -> 1° For(1), 2° For(--)
```cs
void insercao(List<int> lista)
{
    int aux, i, j;
    for(i = 1; i < lista.size(); i++)
    {
        aux = lista[i];
        for(j = i-1; j > 0; j--)
        {
            if (aux < lista[j])
            {
                lista[j + 1] = lista[j];
            } 
            else
            {
                break;
            }
        lista [j + 1] = aux;
        }
    }
}
```
- obs: algoritmos instáveis costumam ser melhores que os algoritmos estáveis

### Qual melhor algoritmo de ordenação?
- Depende
  - Tamanho
  - Grau de Ordenação
## MVC
- <<package>> Model
  - utilidades
  - popular.Lista(...)
- <<package>>  View
  - ListaView
  - exibirLista(...)
  - exibirTempo(...)
- <<package>> Controller
  - ListaController
  - listaBolha
  - listaSelecao
  - listaInsercao
  - popularListaBolha
  - popularListaSelecao
  - popularListaInsercao
  - ?.bolha(listaBolha)
  - ?.selecao(listaSelecao)
  - ?.insercao(listaInsercao)
- Classe Ordenada (ficará onde??)
  - bolha(...)
  - selecao(...)
  - insercao(...)
