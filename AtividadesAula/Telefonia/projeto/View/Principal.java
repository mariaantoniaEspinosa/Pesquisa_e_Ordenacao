package View;

import Model.Sessao;
import Controller.Arquivo;

import java.util.HashMap;

import javax.swing.JOptionPane;



public class Principal {
    public static void main(String[] args) {
        HashMap<String,Sessao> mapa = new HashMap<>();
        Arquivo.carregarArquivo(mapa,"telephony_sessions.txt");

        for(Sessao item : mapa.values()){
            System.out.println(item);
        }

        String dadosPesquisa = JOptionPane.showInputDialog(null, "Informe o número do telefone para pesquisar:");

  
        if (dadosPesquisa!= null) {
           
            Sessao sessaoEncontrada = mapa.get(dadosPesquisa.trim());

            if (sessaoEncontrada != null) {
                JOptionPane.showMessageDialog(null, "Dados da Sessão:\n" + sessaoEncontrada);
            } else {
                JOptionPane.showMessageDialog(null, "Telefone não encontrado!");
            }
        }
    }
}
