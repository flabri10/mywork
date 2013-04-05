package Innlevering2;

//Oppgave 1a, innlevering 2 høst 2010
//Program som spør etter og behandler heltall

import java.util.Scanner;

public class Oppgave1a
{
    public static void main(String [] args)
    {
        //oppretter scanner for input fra bruker
        Scanner input = new Scanner(System.in);
       
        int utholdenhet = 0, resultat = 0;
       
        //leser inn et heltall fra bruker
        System.out.print("Skriv inn et heltall: ");
        int heltall = input.nextInt();
        input.nextLine();
       
        //lagrer det opprinnelige tallet i startTall
        int startTall = heltall;
        
        do 
        {
            //tester om tallet kan deles på 2, da skal det halveres
            if ( heltall % 2 == 0)
            {
                utholdenhet++;
                resultat = heltall / 2;
                System.out.println(utholdenhet+": "+heltall+" kan deles med to.");
                heltall = resultat;
                
            }
             //hvis det ikke kan deles på 2 skal der ganges med tre, og
             //legge til en. Programmet fortsetter til resultatet er 1 
            else 
            {
                utholdenhet++;
                resultat =(heltall * 3) + 1;
                System.out.println(utholdenhet+": "+heltall+" kan ikke deles med to.");
                heltall = resultat;
                
            }
        }while (heltall != 1);
        //når resultatet er blitt 1, skal utholdenheten til det gitte tallet skrives ut
        if (heltall == 1)
        {
            System.out.println();
            System.out.println("Tallet "+startTall+" hadde en utholdenhet på "
                                + utholdenhet+".");
        }
       
        
    }
}