//Innlevering1 PG211 skrevet av Britt-Heidi Fladby
import java.util.*;
public class Klientprogram
{
    public static void main(String[] args)
    {
        //oppretter objekter for de ulike tjenesteklassene
        Engasjement e = new Engasjement("22222", "Jan Johansen", 2000, 10);
        Utrykning u = new Utrykning("00001", "Kari Knutsen", 1500, 5);
        Kontrakt k = new Kontrakt("33333", "Ola Nordman", 5000, "Mandag");
        
        //skriver ut tjenesteinformasjonen
        System.out.println(e.toString());
        System.out.println(u.toString());
        System.out.println(k.toString());
        System.out.println();
        
        //bruker polymorfi og "arkiverer" tjenestene
        e.arkiver();
        u.arkiver();
        k.arkiver();
        System.out.println();
        
        //oppretter en array for sortering
        Tjeneste[] tjenesteArray = new Tjeneste[3];
        tjenesteArray[0] = new Engasjement("22222", "Jan Johansen", 2000, 10);
        tjenesteArray[1] = new Utrykning("00001", "Kari Knutsen", 1500, 5);
        tjenesteArray[2] = new Kontrakt("33333", "Ola Nordman", 5000, "Mandag");
        
        //sorterer arrayen
        Arrays.sort(tjenesteArray);
        System.out.println("Sortert rekkefølge: ");
        //skriver ut arrayen i ny rekkefølge
        for (int i = 0; i < tjenesteArray.length; i++)
        {
            System.out.println(tjenesteArray[i]);
        }
    }
}