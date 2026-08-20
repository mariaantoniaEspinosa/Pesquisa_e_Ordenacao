# Revisando 
- Bolha → Agitação → Estáveis
  - → Pente (Comb Sort)
    - Uso da distância
      - Variável de comparação de valores
      - Comparações a distância
        - Pré-organização
          - Diminui as trocas 
- Seleção → Instável
- Inserção → Estável 
## Pente 
- → Instável
- Memória Principal
- O(n^2)
- dist = dist/1.3;
  - n = 10;
  - dist = n;
- Parar quando o *Pente* virar *Bolha* e não houver mais trocas
- Exemplo:
  - 10/1.3= 7
  - 7/1.3= 5
  - 5/1.3= 3
  - 3/1.3= 2
  - 2/1.3= 1
  - 1/1.3= 1 (divisão quando der Zero seguirá valendo Um para seguir no método Bolha)
- **Decorar o Pente**
```c#
//PENTE (Comb Sort)
    public static void pente(List<int> lista)
    {
        int tmp, dist = lista.Count;
        bool houveTroca;

        do
        {
            dist = (int)(dist / 1.3);
            if(dist < 1)
            {
                dist = 1;
            }
            houveTroca = false;
            for(int i = 0; i + dist < lista.Count; i++)
            {
                if(lista[i] > lista[i + dist])
                {
                    houveTroca = true;
                    tmp = lista[i];
                    lista[i] = lista[i + dist];
                    lista[i + dist] = tmp;
                }
            }
        } while (dist > 1 || houveTroca);
    }
}

```
### Atividade
1) Como ordernar uma lista por alguma chave do objeto
2) Como ordenar, por exemplo, por data e id na 2ª chave