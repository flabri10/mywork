package Innlevering2;

//Oppgave 2, innlevering 2 høst 2010
//program som skal simulere et kontantkort på en mobiltelefon

public class Kontantkort
{
    private int ringetid;
    private String selskap;
    private boolean erTomt;
    
    public Kontantkort(int ringetid, String selskap, boolean erTomt)
    {
        setRingetid(ringetid);
        setSelskap(selskap);
    }
    //setter standardverdier for klassen kontantkort
    public Kontantkort()
    {
        ringetid = 250;
        selskap = "telenor";
        erTomt = false;
    }
    //setter ringetid
    public void setRingetid(int ringetid)
    {
        ringetid = ringetid;
        
    }
    //setter ny ringetid etter påfylling
    public void fyllPaaRingetid(int nyRingetid)
    {
        ringetid = ringetid + nyRingetid;
    }
    //setter ny ringetid etter bruk
    public void brukRingetid(int brukRingetid)
    {
        ringetid = ringetid - brukRingetid;
    }
    //returnerer ringetid
    public int getRingetid()
    {
        return ringetid;
    }
    //vurderer om kontantkortet er tomt eller ikke
    public void erTomt(boolean erTomt)
    {
        if (ringetid <= 0)
        {
            erTomt = true;
        }
        else
        {
            erTomt = false;
        }
    }
    //setter selskap
    public void setSelskap(String selskap)
    {
        selskap = selskap;
    }
    //returnerer selskap
    public String getSelskap()
    {
        return selskap;
    }
    //skriver ut informasjon til bruker
    public void skrivDetaljer()
    {
        System.out.println("Info om kontantkort: ");
        System.out.println();
        System.out.println("Ringetid -  " + ringetid + "kr.");
        System.out.println("Selskap -  " + selskap);
        System.out.println("Er tomt -  "+ erTomt);
    }
}