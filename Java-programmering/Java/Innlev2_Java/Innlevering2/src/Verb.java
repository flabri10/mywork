//Innlevering 2 PG211
//Skrevet av Britt-Heidi Fladby

import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.Scanner;
import javax.swing.JOptionPane;

public class Verb 
{
	private String [] former;
	private String navn;
	private String bokstav;
	private String verbliste;
	private String tekst;
	private String returverdi;
	private int prosent;
	private int fjernet;
	
	
	Scanner input = new Scanner(System.in);
	
	
	//Parametrisk konstruktør
	public Verb(String [] former, String verbliste)
	{
		setFormer(former);
		setVerbliste(verbliste);
	}
	
	//Uparametrisk konstruktør
	public Verb()
	{
		this("", "");
	}

	//Metode som setter former
	public void setFormer(String [] former)
	{
		this.former = former;
	}
	
	//Metode som returnerer former
	public String [] getFormer(int fjernet, String returverdi)
	{
		String returVerdi = "";
		
		//Løkke som fjerner en av formene og returnerer formatert
		for (int i = 0; i < former.length; i++)
		{
			if (i != fjernet)
			{
				returVerdi += String.format("%15s", former[i]);
			}
			else 
			{
				returVerdi += String.format("%15s", "-");
			}
			
		}
		return former;
	}
		
	//Metode som setter verbliste
	public void setVerbliste(String verbliste) 
	{
		this.verbliste = verbliste;
		
		ArrayList<String> verbliste = new ArrayList<String>();
		
		//legger til verb i liste
		for(int i = 0; i == 2; i++)
		verbliste.add(new String(i));
	}
	
	//Metode som returnerer verbliste
	public String getVerbliste() 
	{
		return verbliste;
	}
	
	//Metode for splitting av verbfilen
	public void splitt()
	{
		try
		{
			//oppretter scanner for lesing av fil
			Scanner input = new Scanner(new File("verb.txt"));
			
			//Løkke for som splitter linje og finner tilfeldig verb
			while (input.hasNext())
			{
				tekst = input.nextLine();
				
				String[] former = tekst.split("-");
				
				fjernet = (int)(Math.random()*3);
				
				verbliste.remove(fjernet);
			}
			
		}
		catch (FileNotFoundException ex)
		{
			JOptionPane.showMessageDialog(null,"Teknisk feil!");
		}
		//lukker input for sparing av kapasitet
		input.close();
	}
	
	//Metode som returnerer sluttresultat
	public String toString()
	{
		return	 navn  
				 +"\nScore: " + prosent +"%"
				 +"\nKarakter: " + bokstav;
	}
}
