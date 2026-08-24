# Tenho listas de Objetos, como eu ordeno? 
- Classe Pessoa
```java

import java.util.Objects;


public class Pessoa implements Comparable<Pessoa>{
    String nome;
    int idade;

    public Pessoa(String nome, int idade) {
        this.nome = nome;
        this.idade = idade;
    }
    
    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public int getIdade() {
        return idade;
    }

    public void setIdade(int idade) {
        this.idade = idade;
    }

    @Override
    public String toString() {
        return "Pessoa{" + "nome=" + nome + ", idade=" + idade + '}';
    }

    @Override
    public int hashCode() {
        int hash = 7;
        hash = 97 * hash + Objects.hashCode(this.nome);
        hash = 97 * hash + this.idade;
        return hash;
    }

    @Override
    public boolean equals(Object obj) {
        if (this == obj) {
            return true;
        }
        if (obj == null) {
            return false;
        }
        if (getClass() != obj.getClass()) {
            return false;
        }
        final Pessoa other = (Pessoa) obj;
        if (this.idade != other.idade) {
            return false;
        }
        return Objects.equals(this.nome, other.nome);
    }

    @Override
    public int compareTo(Pessoa o) {
       int resultado = this.getNome().compareTo(o.getNome());
       if(resultado != 0){
           return resultado;
       }
       return Integer.compare(this.idade, o.getIdade());
    }
    
    
    
}
```
- Classe Principal
```java

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;


public class Principal {
    public static void main(String[] args) {
        List<Pessoa> lista = new ArrayList<>();
        
        lista.add(new Pessoa("Gabriel", 19));
        lista.add(new Pessoa("Alex", 52));
        lista.add(new Pessoa("Gabriel", 20));
        lista.add(new Pessoa("Alex", 51));
        
        Collections.sort(lista);       
        System.out.println(lista);
        
        lista.sort((p1, p2) -> Integer.compare(p2.getIdade(), p1.getIdade()));
        System.out.println(lista);
    }
}

```
