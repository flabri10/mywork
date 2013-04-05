//Innlevering1 PG211 skrevet av Britt-Heidi Fladby
import java.util.*;
//klassen er en utvidelse av Tjeneste og implementerer interfacet Arkiver
public class Engasjement extends Tjeneste implements Arkiver
{
    private int varighet;
        
    //ikke-parametrisk konstruktør setter datafelt blanke eller til null 
    public Engasjement(int varighet)
    {
        this("ukjent", "ukjent", 0, 0);
    }
    
    //parametrisk konstruktør som tar imot data fra attributter
    public Engasjement(String registreringsnr, String kontaktperson, int pris, int varighet)
    {
        super(registreringsnr, kontaktperson, pris);
        setVarighet(varighet);
    }

    //metode som setter varighet
    public void setVarighet(int varighet)
    {
        this.varighet = varighet;
    }
    
    //metode som henter varighet
    public int getVarighet()
    {
        return varighet;
    }
    
    //klassen sin versjon av interfacet Arkiver
    public void arkiver()
    {
        System.out.println("Engasjementet legges i mappen for engasjementer..");
    }
    
    //metode som returnerer engasjementsinformasjonen
    public String toString()
    {
        return super.toString() + ", varighet : " + this.getVarighet();
    }
}
