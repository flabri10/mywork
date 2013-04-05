//Innlevering 2 PG211
//Skrevet av Britt-Heidi Fladby

/*Programmet skal være et verb spill, hvor man gjetter 
 * verbformen som ikke vises.
 */
import java.io.FileNotFoundException;
import java.util.Formatter;
import java.util.Scanner;
import javax.swing.JOptionPane;

//Klientprogram for klassen Verb
public class VerbKlient
{
	private String vfilnavn;
	private String rfilnavn;
	private String gjett;
	private String bokstav;
	private String svar;
	private String navn;
	private int teller;
	private int riktig;
	private int prosent;
	private int fjernet;
	
	public static void main(String [] args, String navn)
	{
		Verb verb = new Verb();
		Scanner input = new Scanner(System.in);

		String bokstav;
		String svar;
		int teller;
		int riktig;
		int prosent;
		int fjernet;
		
		//Løkke som kaster unntak om spillet ikke fungerer
		try 
		{
		Verb verb = new Verb();
		String vfilnavn = JOptionPane.showInputDialog("Oppgi navn på verbfilen: ");
			
		String rfilnavn = JOptionPane.showInputDialog("Oppgi navn på resultatfilen: ");
		
		JOptionPane.showInputDialog("Skriv inn antall verb:");
		int antall = input.nextInt();
		
		//løkke som kjører til brukerens antall verb er testet
		do 
		{
			getVerbliste();
				
			String gjett = JOptionPane.showInputDialog("Skriv inn formen som mangler: ");
			
			//Løkke som avgjør om oppgitt svar er riktig, og viser resultat	
			if(fjernet == gjett)
				{
					riktig++;
					JOptionPane.showMessageDialog(null,"Antall riktige: " + riktig + " av " + antall);
				}
				else if (fjernet != gjett)
				{
					JOptionPane.showMessageDialog(null,"Feil! Riktig svar er " + svar);
				}
			
			}while (antall>=teller);
			
			String navn = JOptionPane.showInputDialog("Oppgi navn: ");
			
			//Regner ut prosent riktige
			prosent = riktig * 100 / antall;
			
			//Løkke som avgjør hvilke karakter prosenten tilsvarer
			if( 0 <= prosent && prosent <= 30)
			{
				bokstav = "F";
			}
			else if (prosent >= 31 && prosent <=45)
			{	
				bokstav = "E";
			}	
			else if (prosent >= 46 && prosent <=60)
			{	
				bokstav = "D";
			}
			else if (prosent >= 61 && prosent <=75)
			{	
				bokstav = "C";
			}
			else if (prosent >= 76 && prosent <=90)
			{	
				bokstav = "B";
			}
			else if (prosent >= 91 && prosent <=100)
			{	
				bokstav = "A";
			}
			else
			{
				bokstav = "??";
			}
			
			//Sluttresultat skrives ut
			JOptionPane.showMessageDialog(null,toString);
		
		} 
		catch(FileNotFoundException e) 
		{
			JOptionPane.showMessageDialog(null,"Teknisk feil!");	
		}	
			//Skriver resultatet til oppgitt resultatfil
			Formatter output = new Formatter(rfilnavn);
			output.format(navn + " - " + prosent + " - " + bokstav);
			
			//lukker output for sparing av kapasitet
			output.close();
	}
}


	