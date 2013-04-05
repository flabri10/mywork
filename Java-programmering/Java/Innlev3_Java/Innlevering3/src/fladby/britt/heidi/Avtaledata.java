//PG 211 - V�r 2011 - Innlevering 3
//L�st av Britt-Heidi Fladby
/**Applikasjon til bruk for � holde rede p� avtaler, 
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
	
	//konstrukt�r for avtaledata
	public Avtaledata(String beskrivelse, String innhold, String tidspunkt)
	{
		super();
		
		String[] listen = new String[] {beskrivelse, innhold, tidspunkt};

		//l�kke som legger listedata til i array
	    for(int i=0; i < listen.length; i++) 
	    {
	      listedata.add(i, listen[i]);
	    }
	}

	//ikke-parametrisk konstrukt�r
	public nyAvtale()
	{
		
	}
	
	//parametrisk konstrukt�r
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
