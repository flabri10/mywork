//PG111-innleveringsoppgave høst 2010
//Program som tar i mot navn på fotballag, lagets resultater
//og som regner ut poengsummen av dette.

//importerer tilleggspakke for Scanner
import java.util.Scanner;
import javax.swing.JOptionPane;

public class fotballResultater
{
    public static void main(String[] args)
    {
        //oppretter nytt Scannerobjekt
        Scanner tastatur = new Scanner(System.in);
   
        //oppgi fotballagets navn
        System.out.print("Oppgi fotballagets navn:");
        String navn = tastatur.nextLine();
        
        //oppgi vunnede kamper
        System.out.print("Oppgi antall kamper vunnet:");
        int vunnet = tastatur.nextInt();
        tastatur.nextLine();
        
        //oppgi kamper spilt uavgjort
        System.out.print("Oppgi antall kamper spilt uavgjort:");
        int uavgjort = tastatur.nextInt();
        tastatur.nextLine();
        
        //oppgi tapte kamper
        System.out.print("Oppgi antall kamper tapt:");
        int tapt = tastatur.nextInt();
        tastatur.nextLine();
      
        //samlet antall kamper
        int antallKamper = vunnet + uavgjort + tapt; 
        
        //poengutregning vunnede kamper(seier gir 3 poeng)
        int poengVunnet = vunnet * 3;
        
        //poengutregning uavgjorte kamper(uavgjort gir 1 poeng)
        int poengUavgjort = uavgjort * 1;
        
        //poengutregning tapte kamper(tap gir 0 poeng)
        int poengTapt = tapt * 0;
        
        //utregning av samlet poengsum
        int samletPoengsum = poengVunnet + poengUavgjort + poengTapt;
        
        //skriver ut resultat
        System.out.printf("\n%-20S%10s%10s%10s%10s%15s","Lag","Kamper","Seier","Uavgjort","Tapt","Poengsum");
        System.out.printf("\n%-20S%10d%10d%10d%10d%15d",navn,antallKamper,vunnet,uavgjort,tapt,samletPoengsum);
  }
  
}