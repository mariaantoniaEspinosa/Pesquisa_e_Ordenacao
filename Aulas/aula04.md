# Premissas da Disciplina
- Padrão de desenvolvimento
  - Ideia de MVC
  - Documentação
- BenchMark
  - Medições
    - Complexidade do algoritmo
      - quantidade de comparações
      - quantidade de trocas
    - Tempo
# Medir Tempo de Ordenação
## Java
```java

    long tempoInicio, tempoFim;  
    
    tempoInicio = System.nanoTime();
    // rotina1
    tempoFim = System.nanoTime();
    System.out.println("Tempo (ms) rotina 1: " + (tempoFim - tempoInicio)/1000000);

    tempoInicio = System.nanoTime();
    // rotina2
    tempoFim = System.nanoTime();
    System.out.println("Tempo (ms) rotina 2: " + (tempoFim - tempoInicio)/1000000);

```
### C#
````C#

    Stopwatch sw = new Stopwatch();

    sw.Start();
    // rotina 1
    sw.Stop();
    Console.WriteLine("Fim da rotina 1 (ms): " + sw.ElapsedMilliseconds);
    sw.Reset();

    sw.Start();
    // rotina 1
    sw.Stop();
    Console.WriteLine("Fim da rotina 1 (ms): " + sw.ElapsedMilliseconds);
    sw.Reset();
````

### Python
````python

    tempoInicio = time.time()
    # rotina 1
    tempoFim = time.time()
    print("Tempo da rotina 1: ", (tempoFim - tempoInicio) , "s")        
````

### C++
````c++

    clock_t tempoInicio, tempoFim;
    tempoInicio = clock();
    // rotina 1
    tempoFim = clock();
    cout << "Tempo para rotina 1: "<< (float)(tempoFim - tempoInicio)/CLOCKS_PER_SEC << endl;
````
# Atividade 
## MedicaoModel.java
- É a classe que calcula o tempo e preenche a lista com *Random* ou de forma sequencial;
## MedicaoView.java
- É a classe que contém os System.out.println, ela recebe os dados puros e formata na tela com textos como "Tempo (ms) rotina1: ";
## MedicaoController.java
- União da Visão ao Modelo, chama model.executarRotina(...) para obter os tempos de execução e, logo em seguida, passa esse resultado para view.exibirTempoRotina(...);
