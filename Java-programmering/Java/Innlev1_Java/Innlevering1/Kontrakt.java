//Innlevering1 PG211 skrevet av Britt-Heidi Fladby
import java.util.*;
//klassen er en utvidelse av Tjeneste og implementerer interfacet Arkiver
public class Kontrakt extends Tjeneste implements Arkiver
{
    private String dag;
        
    //ikke-parametrisk konstruktør setter datafelt blanke eller til null 
    public Kontrakt (String dag)
    {
        this("ukjent", "ukjent", 0, "ukjent");
    }
    
    //parametrisk konstruktør som tar imot data fra attributter
    public Kontrakt (String registreringsnr, String kontaktperson, int pris, String dag)
    {
        super(registreringsnr, kontaktperson, pris);
        setDag(dag);
    }

    //metode som setter dag
    public void setDag(String dag)
    {
        this.dag = dag;
    }
    
    //metode som henter dag
    public String getDag()
    {
        return dag;
    }
    
    //klassen sin versjon av interfacet Arkiver
    public void arkiver()
    {
        System.out.println("Kontrakten legges i mappen for kontrakter..");
    }
    
    //metode som returnerer kontraktinformasjon
    public String toString()
    {
       return super.toString() + ", dag : " + this.getDag();
    }
}

