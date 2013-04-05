//Innlevering1 PG211 skrevet av Britt-Heidi Fladby
/*Program som skal registrere og holde orden på tjenestene til et
konsulentfirma. Her skal denne klassen Tjeneste være superklasse
og utgangspunkt for programet*/
import java.util.*;

public abstract class Tjeneste implements Comparable <Tjeneste>
{
    private String registreringsnr;
    private String kontaktperson;
    private int pris;
   
    //ikke-parametrisk konstruktør setter datafelt blanke eller til null 
    public Tjeneste()
    {
        this("00000", "Vet ikke", 0);
    }
    
    //parametrisk konstruktør som tar imot data fra attributter
    public Tjeneste(String registreringsnr, String kontaktperson, int pris)
    {
        setRegistreringsnr(registreringsnr);
        setKontaktperson(kontaktperson);
        setPris(pris);
    }
    
    //metode som setter registreringsnummer
    public void setRegistreringsnr(String registreringsnr)
    {
        this.registreringsnr = registreringsnr;
    }
    
    //metode som finner registreringsnummer
    public String getRegistreringsnr()
    {
        return registreringsnr;
    }
    
    //metode som setter kontaktperson
    public void setKontaktperson(String kontaktperson)
    {
        this.kontaktperson = kontaktperson;
    }
    
    //metode som henter kontaktperson
    public String getKontaktperson()
    {
        return kontaktperson;
    }
    
    //metode som setter pris
    public void setPris(int pris)
    {
        this.pris = pris;
    }
    
    //metode som henter pris
    public int getPris()
    {
        return pris;
    }
    
    //metode for arkivering av tjenester
    public void arkiver()
    {
        System.out.println("*Arkiverer*");
    }
    
    //metode som sjekker om objektet e er likt o
    public boolean equals(Object o) 
    {
        if (!(o instanceof Tjeneste)) 
        {
            return false;
        }
        if (o == this) 
        {
            return true;
        }
        Tjeneste e = (Tjeneste) o;
        
        if (getRegistreringsnr().equals(e.getRegistreringsnr())) 
        {
            return true;
        }
        return false;
    }
    
    //sammenligner registreringsnummerene
    public int compareTo(String registreringsnr) 
    {
        int resultat = e.getRegistreringsnr().compareTo(k.getRegistreringsnr());

        //Skrive ut resultat
        if (resultat != 0)
        {
            return System.out.println("\"" + e + "\"" +
                " er ikke lik  " +
                "\"" + k + "\"");
        }
        else if (result == 0)
        {
            return System.out.println("\"" + e + "\"" +
                " er lik " +
                "\"" + e + "\"");
        }
    }
    
    //metode som returnerer tjenesteinformasjonen
    public String toString()
    {
        return "Registreringsnummer: "+registreringsnr
                    +", kontaktperson: "+kontaktperson
                    +", pris: "+pris;
    }   
}