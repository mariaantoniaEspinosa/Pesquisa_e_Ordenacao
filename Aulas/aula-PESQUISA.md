# Ordenação
  - algoritmos
  - definições
# Pesquisa
  - dependente de ordenação
  - quando a estrutura está desordenada, há somente a pesquisa SEQUENCIAL
```python
  def esta_contido(valor_pesquisa, lista):
      for item in lista:
          if item == valor_pesquisa:
              True
      return False
  
  
  lista = [6, 1, 3, 7, 4, 2, 9, 7]
  
  numero_pesquisa = 7
  
  #ideaia do contains
  print(numero_pesquisa in lista)
  print(esta_contido(numero_pesquisa, lista))
```
  - técnicas de pesquisa
    - sequencial: a estrutura não precisa estar ordenada
    - binária:
      - baseada na teoria de árvore, porém a estrutura precisa estar ordenada
      - retorna somente um elemento, caso ele esteja repetido na estrutura
