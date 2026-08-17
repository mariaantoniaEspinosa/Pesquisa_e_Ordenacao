using System;
using System.Collections.Generic;

public class OrdenacaoView
{
    public void ExibirTempo(long milissegundos, string frase)
    {
        Console.WriteLine(frase + " (ms): " + milissegundos);
    }

    public void ExibirLista(List<int> lista)
    {
        foreach (var item in lista)
        {
            Console.WriteLine(item.ToString());
        }
    }
}
