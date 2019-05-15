package hwdingetje;

import java.util.Scanner;

/**
 *
 * @author adeliae
 */
public class HwDingetje {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        //opgave1();
        opgave2();
    }
    
    public static void opgave1(){
        //met maar één printline huh?
        System.out.println("*\n**\n***\n****\n*****");
    }
    
    public static void opgave2(){
        //TO INFINITY AND BEYOOOOOOOOOOOOOOOOOOOOND ﾟ+.(ﾉ｡'▽')ﾉ*.ｵｵｫｫ☆ﾟ･:*☆
        //i'll keep this joke running.
        
        double kelvin = 273.15; //celsius + < wat daar staat.
        int wiegebruiktditbehalveamerika = 0; //celsius * 1.8 + 32
        
        Scanner mcScanFace = new Scanner(System.in); //scanner aanroepen omdat we user input nodig hebben
        //nee fuck updates, stop windhoos
        //uh ja het zou helpen als je ook iets in de console laat zien zodat de gebruiker ook weet wat ie moet doen.
        System.out.println("> enter zooi");
        System.out.print("* ");
        
        double input = mcScanFace.nextDouble(); //inputmismatchexception? really?? waar is de mismatch???
        System.out.println(input); //je moet een komma gebruiken??? wat.
    }
}
