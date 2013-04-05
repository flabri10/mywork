package Innlevering3;
//Innlevering 3 PG111-10
//Løst av Britt-Heidi Fladby

/*Programmet skal være et enkelt skattejakt?spill, hvor
spilleren skal gjette hvor på brettet skatten er gjemt*/
import java.util.Scanner;
public class Oppgave
{
    public static void main(String [] args)
    {
        boolean restart = true;
        printMessage("Velkommen til Skattejakten!", true);
        int rad = 0;
        int kol = 0;
        //while-løkke som betemmer om programmet skal fortsette å kjøre eller ikke
        do
        {
            //oppretter scanner for dialog med bruker
            Scanner input = new Scanner(System.in); 
        
            int teller = 0;
            int radTips, kolTips = 0;
      
            printMessage("Skriv inn antall rader: ", false);
            rad = input.nextInt();
            input.nextLine();
             
            printMessage("Skriv inn antall kolonner: ", false);
            kol = input.nextInt();
            input.nextLine();
            
            //oppretter arrayen kart
            char[][] kart = new char [rad] [kol];
            
           
            
            //Plasserer skatten
            int rKey = (int)(Math.random()*rad); 
            int kKey = (int)(Math.random()*kol);
            char tegn = 'O';
            fillArea(kart, tegn);
            printArea(kart);
             
            //do-whileløkke som kjøres til bruker har gjettet riktig
            do 
            {
                 printMessage("Hvor tror du skatten er? ", true);
                 printMessage("Oppgi rad og kolonne (adskilt av mellomrom): ", false);
                 radTips = input.nextInt()-1;
                 kolTips = input.nextInt()-1;
                 input.nextLine();
                 teller++;
                 
                 //if-løkke som sjekker om bruker har funnet skatten
                 if(radTips == rKey && kolTips == kKey)  
                 {
                     //lagrer $ på stedet i arrayen
                     kart [radTips] [kolTips] = '$';
                     printArea(kart);
                     printMessage("Gratulerer du fant skatten!", true);
                     printMessage("Det tok "+ teller +" forsøk.", true);
                     
                     printMessage("Vil du prøve igjen? (Ja/Nei) ",false);
                     char svar = input.next().toUpperCase().charAt(0);
                     char start = svar;
                     //if-løkke som sjekker svaret og bestemmer om du skal restarte programmet
                     if (start == 'J')
                     {
                         restart = true;
                     }
                     else if (start == 'N')
                     {
                         restart = false;
                     }
                     else
                     {
                         printMessage("Ugyldig svar. Programmet avsluttes!",false);
                         restart = false;
                     }
                 }
                 else 
                 {
                     //Lagrer en X på stedet i arrayen
                     kart [radTips] [kolTips] = 'X';
                     printArea(kart);
                     printMessage("Feil sted!", false);
                     
                     //if-løkke som gir bruker tilbakemelding på tipset
                     if (radTips < rKey && kolTips < kKey)
                     {
                        printMessage("Tipsene for rad og kolonne var for lave.", true);   
                     }
                     else if(radTips > rKey && kolTips > kKey)
                     {
                        printMessage("Tipsene for rad og kolonne var for høye.",true);
                     }
                     else if (radTips < rKey && kolTips > kKey)
                     {
                        printMessage("Tipset for kolonne var for lavt, og rad for høyt.",true);
                     }
                     else if (radTips > rKey && kolTips < kKey)
                     {
                        printMessage("Tipset for kolonne var for høyt, og rad for lavt.",true);      
                     }
                   
                     printMessage("Vil du prøve igjen? (Ja/Nei) ",false);
                     char svar = input.next().toUpperCase().charAt(0);
                     char start = svar;
                     //if-løkke som sjekker svaret og bestemmer om du skal prøve igjen
                     if (start == 'J')
                     {
                         restart = true;
                     }
                     else if (start == 'N')
                     {
                         restart = false;
                     }
                     else
                     {
                         printMessage("Ugyldig svar. Programmet avsluttes!",false);
                         restart = false;
                     }
                 }
            } while (radTips != rKey && kolTips != kKey);
            
            //nullstiller teller
            teller = 0;
        } while (restart == true);
    } 
    
    public static char [] [] fillArea(char [][] kart, char tegn)
    {
        //Fyller ut array med bokstaven 'O'
        for (int rad = 0; rad < kart.length; rad++)
        {
              for (int kol = 0; kol < kart[rad].length; kol++) 
              {
                  kart[rad] [kol] = 'O';
              }                                           
        }
        return kart;
    } 
   
    public static void printArea(char [] [] kart)
    {
        //skriver ut tallene på siden
        System.out.printf("%4s", "");
        for (int i = 1; i <= kart[0].length; i++)
        {
            System.out.printf("%4d", i);
        }
        printMessage("\n", true);
        printMessage("\n", true);
        
        //skriver ut brettet
        for (int rad = 0; rad < kart.length; rad++)
        {
             System.out.printf("%-4d", rad + 1);
             for (int kol = 0; kol < kart[rad].length; kol++) 
             {
                  System.out.printf("%4s", kart [rad] [kol]);
             } 
             printMessage("\n", true);
        }
    }
    
    public static void printMessage (String tekst, boolean linjeskift)
    {
        //if-løkke som styrer linjeskift i dialog
        if (linjeskift == true)
        {
            System.out.println(tekst);
        }
        else
        {
            System.out.print(tekst);   
        }
    }
}