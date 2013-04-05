//PG 211 - Vår 2011 - Innlevering 3
//Løst av Britt-Heidi Fladby
/**Applikasjon til bruk for å holde rede på avtaler, 
med et gitt brukergrensesnitt**/

package fladby.britt.heidi;

import javax.swing.DefaultListModel;
import javax.swing.JList;
import javax.swing.JOptionPane;


public class Avtaledata extends DefaultListModel
{
	private static final long serialVersionUID = 1L;
	private DefaultListModel listedata;
	private Object avtale;
	
	//konstruktør for avtaledata
	public Avtaledata(String beskrivelse, String innhold, String tidspunkt)
	{
		super();
		
		String[] listen = new String[] {beskrivelse, innhold, tidspunkt};

		//løkke som legger listedata til i array
	    for(int i=0; i < listen.length; i++) 
	    {
	      listedata.add(i, listen[i]);
	    }
	}

	//ikke-parametrisk konstruktør
	public nyAvtale()
	{
		
	}
	
	//parametrisk konstruktør
	public nyAvtale()
	{
    	Avtale nyAvtale = new Avtale();   
    }
	
	//metode for fjerning av avtale
	public void fjernAvtale()
	{
		
	}
	
	//setter avtale
	public void setAvtale(Object avtale)
	{
		this.avtale = avtale;
	}
	
	//henter avtale
	public Object getAvtale()
	{
		return avtale;
	}
}
