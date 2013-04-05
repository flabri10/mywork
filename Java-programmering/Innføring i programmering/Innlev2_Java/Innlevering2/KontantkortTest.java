package Innlevering2;
//testprogram til klassen Kontantkort
public class KontantkortTest
{
    public static void main (String [] args)
    {
        //oppretter nytt kontantkort-objekt
        Kontantkort kontantkort = new Kontantkort();
        
        //setter bruksverdier
        kontantkort.brukRingetid(150);
        kontantkort.fyllPaaRingetid(100);
        
        //skriver ut informasjon om kontantkortets status til bruker
        kontantkort.skrivDetaljer();
    }
}
    