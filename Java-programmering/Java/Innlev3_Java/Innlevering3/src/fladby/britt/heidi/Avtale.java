//PG 211 - Vår 2011 - Innlevering 3
//Løst av Britt-Heidi Fladby
/**Applikasjon til bruk for å holde rede på avtaler, 
med et gitt brukergrensesnitt**/

package fladby.britt.heidi;

public class Avtale implements Comparable<Avtale>
{
	private String beskrivelse;
	private String innhold;
	private String tidspunkt;
	
	//ikke-parametrisk konstruktør
	public Avtale()
	{
		this(null, null, null);
	}
	
	//parametrisk konstruktør
	public Avtale(String beskrivelse, String innhold, String tidspunkt)
	{
		setBeskrivelse(beskrivelse);
		setInnhold(innhold);
		setTidspunkt(tidspunkt);
	}
	
	//setter beskrivelse
	public void setBeskrivelse(String beskrivelse)
	{
		this.beskrivelse = beskrivelse;
	}
	
	//henter beskrivelse
	public String getBeskrivelse()
	{
		return beskrivelse;
	}
	
	//setter innhold
	public void setInnhold(String innhold)
	{
		this.innhold = innhold;
	}
	
	//henter innhold
	public String getInnhold()
	{
		return innhold;
	}
	
	//setter tidspunkt
	public void setTidspunkt(String tidspunkt)
	{
		this.tidspunkt = tidspunkt;
	}
	
	//henter tidspunkt
	public String getTidspunkt()
	{
		return tidspunkt;
	}
	
	//returnerer beskrivelse 
	public String toString()
	{
		return getBeskrivelse();
	}
	
	//sjekker likhet i objekter
	public boolean equals(Object objekt) 
	{	  
		if (!(objekt instanceof Avtale)) return false;
		if (objekt == this) return true;
		return false;
		
	}
	
	//sammenlikner objekter
	public int compareTo(Avtale objekt)
	{
		return getBeskrivelse().compareTo(objekt.getBeskrivelse());
	}
}
