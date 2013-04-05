//Innlevering1 PG211 skrevet av Britt-Heidi Fladby
import java.util.*;
//klassen er en utvidelse av Tjeneste og implementerer interfacet Arkiver
public class Utrykning extends Tjeneste implements Arkiver
{
    private int gebyr;

    //ikke-parametrisk konstruktør setter datafelt blanke eller til null 
    public Utrykning(int gebyr)
    {
        this("ukjent", "ukjent", 0, 0);
    }
    
    //parametrisk konstruktør som tar imot data fra attributter
    public Utrykning(String registreringsnr, String kontaktperson, int pris, int gebyr)
    {
        super(registreringsnr, kontaktperson, pris);
        setGebyr(gebyr);
    }

    //metode som setter gebyr
    public void setGebyr(int gebyr)
    {
        this.gebyr = gebyr;
    }
    
    //metode som henter gebyr
    public int getGebyr()
    {
        return gebyr;
    }
    
    //klassen sin versjon av interfacet Arkiver
    public void arkiver()
    {
        System.out.println("Utrykningen legges i mappen for utrykninger..");
    }
    
    //metode som returnerer utrykningsinformasjon
    public String toString()
    {
        return super.toString() + ", gebyr : " + this.getGebyr();
    }
}
