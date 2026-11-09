package Controller;

import Model.Sessao;

import java.io.BufferedReader;
import java.io.FileReader;
import java.util.HashMap;

public class Arquivo {
    public static void  carregarArquivo(HashMap<String,Sessao> mapa,String arquivo){

        String linha;
        try{
            BufferedReader leitor = new BufferedReader(new FileReader((arquivo)));
            while((linha = leitor.readLine()) != null){
                String[] campos = linha.split(";");
                Sessao s = new Sessao(campos[0], campos[1]);
                mapa.put(s.numeroCelular,s);

            }
        
        }catch(Exception e){
            e.printStackTrace();
        }
        
    }
}
