//PG111-innleveringsoppgave høst 2010
//program som inneholder informasjon om en gitt bok som skal kunne være en del av et større biblioteksystem

public class Bok 
{ 
    // attributter 
    private String forfatter; 
    private String tittel;
    private int sider;
    private String referanseNummer;
   
    //setter standardverdier for klassen bok
    public Bok(String forfatter, String tittel, int sider)
    {
        //kaller på setmetoder
        setForfatter (forfatter); 
        setTittel (tittel); 
        setSider (sider);
        referanseNummer = "";
    }
    
    //metoder
    //set-metode hvor bruker fyller inn verdi
    //setter forfatternavn
    public void setForfatter(String forfatterNavn)
    {
        forfatter = forfatterNavn;
    }
    
    //get-metode returnerer verdier til set-attributtet
    //henter forfatternavn
    public String getForfatter()
    {
        return forfatter;
    }
    
    //setter boktittel
    public void setTittel(String tittelNavn)
    {
        tittel = tittelNavn;
    }
    
    //henter boktittel
    public String getTittel()
    {
        return tittel;
    }
   
    //setter sideantall
    public void setSider(int sider1)
    {
        sider = sider1;
    }
    
    //henter sideantall
    public int getSider()
    {
        return sider;
    }
   
    //setter referansenummer
    public void setReferanseNummer(String refnr)
    {
        referanseNummer = refnr;
    }
    
    //henter referansenummer
    public String getReferanseNummer()
    {
        return referanseNummer;
    }
    
    //skriver ut detaljene om boka
    public void skrivDetaljer()
    {
        System.out.println("Forfatteren :" +forfatter);
        System.out.println("Boktittel :" +tittel);
        System.out.println("Antall sider :" +sider);
        System.out.println("Referansenummer :" +referanseNummer);
    }
   
    }

