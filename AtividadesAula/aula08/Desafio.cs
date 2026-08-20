using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Diagnostics;              

class Ordenacao
{
    //BOLHA
    public static void bolha(List<int> lista)
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

    //INSERÇÃO
    public static void insercao(List<int> lista)
    {
        int n = lista.Count;
        int qtdComparacoes = 0;
        int qtdMovimentos = 0;

        for (int i = 1; i < n; i++)
        {
            int chave = lista[i];
            int j = i - 1;
            while(j >= 0)
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

    //SELEÇÃO
    public static void selecao(List<int> lista)
    {
        int n = lista.Count;
        int tmp;
        int qtdComparacoes = 0;
        int qtdTrocas = 0;

        for(int i = 0; i < n - 1; i++)
        {
            int indiceMinimo = i;
            for(int j = i + 1; j < n; j++)
            {
                qtdComparacoes++;
                if(lista[j] < lista[indiceMinimo])
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

    //AGITAÇÃO
    public static void agitacao(List<int> lista)
    {
        bool houveTroca;
        int tmp;
        int ini = 0;
        int fim = lista.Count;
        int qtdComparacoes = 0;
        int qtdTrocas = 0;

        do
        {
            houveTroca = false;
            for(int i = ini; i < fim - 1; i++)
            {
                qtdComparacoes++;
                if(lista[i] > lista[i + 1])
                {
                    qtdTrocas++;
                    houveTroca = true;
                    tmp = lista[i];
                    lista[i] = lista[i + 1];
                    lista[i + 1] = tmp;
                }
            }
            if(!houveTroca) break;
            fim--;

            houveTroca = false;
            for(int i = fim - 1; i >= ini; i--)
            {
                qtdComparacoes++;
                if(lista[i] > lista[i + 1])
                {
                    qtdTrocas++;
                    houveTroca = true;
                    tmp = lista[i];
                    lista[i] = lista[i + 1];
                    lista[i + 1] = tmp;
                }
            }
            ini++;
        } while (houveTroca);
    }

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

class Util
{
    public static void popular(List<int> lista, int quantidade)
    {
        Random gerador = new Random();
        for (int i = 0; i < quantidade; i++)
        {
            lista.Add(gerador.Next(100000));
        }
    }

    public static void exibir(List<int> lista)
    {
        foreach (var item in lista)
        {
            Console.WriteLine(item.ToString());
        }
    }

    public static void exibirTempo(Stopwatch sw, string frase)
    {
        Console.WriteLine(frase + " (ms): " + sw.ElapsedMilliseconds);
    }
}

public class Principal
{
    public static void Main(string[] args)
    {
        List<int> listaBolha = new List<int>();
        List<int> listaInsercao = new List<int>();
        List<int> listaSelecao = new List<int>();
        List<int> listaAgitacao = new List<int>();      
        List<int> listaPente = new List<int>();
        List<int> listaSort = new List<int>();

        int qtd = 10000;
        Util.popular(listaBolha, qtd);
        Util.popular(listaInsercao, qtd);
        Util.popular(listaSelecao, qtd);
        Util.popular(listaAgitacao, qtd);
        Util.popular(listaPente, qtd);
        Util.popular(listaSort, qtd); /// SORT NATIVO

        Stopwatch sw = new Stopwatch();

        sw.Start();
        Ordenacao.bolha(listaBolha);
        sw.Stop();
        Util.exibirTempo(sw, "Ordenacao por bolha");        
        sw.Reset();

        sw.Start();
        Ordenacao.insercao(listaInsercao);
        sw.Stop();
        Util.exibirTempo(sw, "Ordenacao por insercao");
        sw.Reset();

        sw.Start();
        Ordenacao.selecao(listaSelecao);
        sw.Stop();
        Util.exibirTempo(sw, "Ordenacao por selecao");
        sw.Reset();

        sw.Start();
        Ordenacao.agitacao(listaAgitacao);
        sw.Stop();
        Util.exibirTempo(sw, "Ordenacao por agitacao");        
        sw.Reset();

        sw.Start();
        Ordenacao.pente(listaPente);
        sw.Stop();
        Util.exibirTempo(sw, "Ordenacao por pente");        
        sw.Reset();

        sw.Start();
        listaSort.Sort();
        sw.Stop();
        Util.exibirTempo(sw, "Ordenacao por sort nativo");
        sw.Reset();
    }
}
