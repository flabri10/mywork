package Innlevering2;

//Oppgave 1b, innlevering 2 h�st 2010
//Program som sp�r etter nedre og �vre grense, og deretter finner det mest utholdende tallet

import java.util.Scanner;

public class Oppgave1b
{
    private int utholdenhet, uthold, mestUtholdentTall;
   
    public void setUthold(int uthold)
    {
        uthold = uthold;
    }
    public int getUthold()
    {
        return uthold;
    }
    public void setUtholdenhet(int utholdenhet)
    {
        utholdenhet = uthold;
    }
    public int getUtholdenhet()
    {
        return utholdenhet;
    }
    public void setMestUtholdentTall(int mestUtholdentTall)
    {
        mestUtholdentTall = mestUtholdentTall;
    }
    public int getMestUtholdentTall()
    {
        return mestUtholdentTall;
    }
    
    public static void main(String [] args)
    {
        //oppretter scanner for � kunne f� input fra bruker
        Scanner input = new Scanner(System.in);
   
        //leser inn �vre grense fra bruker
        System.out.print("Oppgi nedre grense: ");
        int nedre = input.nextInt();
        input.nextLine();
        
        //leser inn nedre grense fra bruker
        System.out.print("Oppgi �vre grense: ");
        int ovre = input.nextInt();
        input.nextLine();
        
        int utholdenhet = 0, mestUtholdentTall = 0, uthold = 0, resultat = 0, etTall = nedre;

        //forl�kke som fortsetter til etTall er lik �vre grense
        do
        {
            //do-whilel�kke som fortesetter med tallbehandling til resultat er lik 1
            while (resultat > 1 || resultat < 1)
            {
                //tester om tallet kan deles p� 2, da skal det halveres
                if( etTall % 2 == 0 )
                {
                    resultat = etTall / 2;
                    etTall = resultat;
                    uthold++;
                }
            
                //hvis det ikke kan deles p� 2 skal der ganges med tre, og
                //legge til en. Programmet fortsetter til resultatet er 1 
                else
                {
                    resultat = (etTall * 3) + 1;
                    etTall = resultat;
                    uthold++;
                }
            }
            //hvis tallet har utholdenhet st�rre enn tidligere tall, settes uthold
            //til ny utholdenhet og etTall til nytt mestUtholdentTall
            if (uthold > utholdenhet)
            {
                utholdenhet = uthold;
                mestUtholdentTall = etTall;
            }
            else
            {
                utholdenhet = utholdenhet;
                mestUtholdentTall = mestUtholdentTall;
            }
            etTall++;
        }while (etTall <= ovre);
        //skriver ut resultat til bruker
        System.out.println("Tallet " + mestUtholdentTall + " har st�rst utholdenhet: "
                            + utholdenhet);
    }
}