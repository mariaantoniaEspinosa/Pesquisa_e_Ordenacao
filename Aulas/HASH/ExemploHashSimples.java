import java.util.HashSet;

public class ExemploHashSimples{
    public static void main(String[] args) {
        HashSet<String> tableHashString = new HashSet<>();

        tableHashString.add("alexandre");
        tableHashString.add("hermes");
        tableHashString.add("davi");
        tableHashString.add("alan");
        tableHashString.add("Alexandre");
        tableHashString.add("davi");
        
        for (String item : tableHashString){
            System.out.println(item + " -> " + item.hashCode());
        }

        System.out.println(tableHashString.contains("alan") + " -> " + "alan".hashCode());

    }
}