using System;
using System.Collections.Generic;

public class OrdenacaoModel
{
    public List<int>ListaBolha{get;set;} = new List<int>();
    public List<int>ListaInsercao{get;set;} = new List<int>();
    public List<int>ListaSelecao{get;set;} = new List<int>();
    public List<int>ListaAgitacao{get;set;} = new List<int>();
    public List<int>ListaSort{get;set;} = new List<int>();

    public void PopularListas(int quantidade)
    {
        Random gerador = new Random();
        for (int i = 0; i < quantidade; i++)
        {
            int numero = gerador.Next(100000);
            ListaBolha.Add(numero);
            ListaInsercao.Add(numero);
            ListaSelecao.Add(numero);
            ListaAgitacao.Add(numero);
            ListaSort.Add(numero);
        }
    }

    public static void Bolha(List<int> lista)
    {
        int n = lista.Count;
        int tmp;
        int qtdComparacoes = 0;
        int qtdTrocas = 0;
        
        for(int i = 0; i < n - 1; i++)
        {
            bool houveTroca = false;
            for(int j = 0; j < n - i - 1; j++)
            {
                qtdComparacoes++;
                if(lista[j] > lista[j + 1]) 
                {
                    qtdTrocas++;
                    houveTroca = true;
                    tmp = lista[j];
                    lista[j] = lista[j + 1];
                    lista[j + 1] = tmp;
                }
            }
            if(!houveTroca) break;
        }
    }

    public static void Insercao(List<int> lista)
    {
        int n = lista.Count;
        int qtdComparacoes = 0;
        int qtdMovimentos = 0;

        for (int i = 1; i < n; i++)
        {
            int chave = lista[i];
            int j = i - 1;
            while(j>= 0)
            {
                qtdComparacoes++;
                if(lista[j] > chave)
                {
                    qtdMovimentos++;
                    lista[j + 1] = lista[j];
                    j--;
                }
                else
                {
                    break;
                }
            }
            lista[j + 1] = chave;
        }
    }

    public static void Selecao(List<int> lista)
    {
        int n = lista.Count;
        int tmp;
        int qtdComparacoes = 0;
        int qtdTrocas = 0;

        for (int i = 0; i < n-1; i++)
        {
            int indiceMinimo = i;
            for (int j = i + 1; j < n; j++)
            {
                qtdComparacoes++;
                if (lista[j] < lista[indiceMinimo])
                {
                    indiceMinimo = j;
                }
            }
            if(indiceMinimo != i)
            {
                qtdTrocas++;
                tmp = lista[i];
                lista[i] = lista[indiceMinimo];
                lista[indiceMinimo] = tmp;
            }
        }
    }

    public static void Agitacao(List<int> lista)
    {
        bool houveTroca;
        int tmp;
        int ini = 0;
        int fim = lista.Count;
        int qtdComparacoes = 0, qtdTrocas = 0;

        do
        {
            houveTroca = false;
            for (int i = ini; i < fim - 1; i++)
            {
                qtdComparacoes++;
                if (lista[i] > lista[i + 1])
                {
                    qtdTrocas++;
                    houveTroca = true;
                    tmp = lista[i];
                    lista[i] = lista[i + 1];
                    lista[i + 1] = tmp;
                }
            }

            if (!houveTroca) break;
            fim--;

            houveTroca = false;
            for (int i = fim; i >= ini + 1; i--)
            {
                qtdComparacoes++;
                if (lista[i] < lista[i - 1])
                {
                    qtdTrocas++;
                    houveTroca = true;
                    tmp = lista[i];
                    lista[i] = lista[i - 1];
                    lista[i - 1] = tmp;
                }
            }
            ini++;

        } while (houveTroca);
    }
}
