import java.util.HashMap;
import java.util.Map;

public class Exchange {

    // instance fields
    HashMap<Integer, Integer> exchange;
    int[] valors = new int[] {500,200,100,50,20,5,2,1};



    public Exchange(int sum){
        this.exchange = new HashMap<Integer, Integer>();
        for(int valor : this.valors)
            this.exchange.put(valor, 0);
        calculate(sum);
    }



    public void calculate(int sum){ // TODO gör valor till enum
        int units = 0;
            for (int valor : valors) {
                if(valor == 0 || sum < valor) continue;
                units = sum / valor;
                this.exchange.put(valor, units);
                sum = sum % (units*valor);
            }
    }

    @Override
    public String toString(){
        String s = "";
        for (Map.Entry<Integer,Integer> e : this.exchange.entrySet()) {
            s += "Valor: " + e.getKey() + ", number of units: " + e.getValue() + "\n";
        }
        return s;
    }

    public static void main(String[] args){
        int sum = 3178;
        Exchange e = new Exchange(sum);
        System.out.println(e.toString());
    }
}