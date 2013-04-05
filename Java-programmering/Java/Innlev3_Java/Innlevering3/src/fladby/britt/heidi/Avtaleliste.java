//PG 211 - Vår 2011 - Innlevering 3
//Løst av Britt-Heidi Fladby
/**Applikasjon til bruk for å holde rede på avtaler, 
med et gitt brukergrensesnitt**/

package fladby.britt.heidi;

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.event.*;


public class Avtaleliste extends JFrame implements ListSelectionListener
{
	private static final long serialVersionUID = 1L;
	private JList listen;
	private DefaultListModel listedata;
	private JButton [] pnlKnapper;

	public Avtaleliste(String vindustittel)
	{
		super(vindustittel);
		
		listedata = new DefaultListModel();
		listen = new JList(listedata);
		
		listen.setVisibleRowCount(10);
		listen.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);
        listen.setSelectedIndex(0);

        add(listen, BorderLayout.CENTER);
        KnappePanel knappepanel = new KnappePanel();
		add(knappepanel, BorderLayout.EAST);  
		
		setSize(450, 200);
		setVisible(true);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);	
	}
	
	//Egen privat klasse for oppretting av knappepanel
	private class KnappePanel extends JPanel implements ActionListener
	{
		private static final long serialVersionUID = 1L;
		private final String [] tekst = {"Ny avtale", "Fjern avtale", 
							"Vis avtale", "Endre avtale", "Avslutt"};
		
		public KnappePanel()
		{
			super();
			
			setLayout(new GridLayout(5,1));
			pnlKnapper = new JButton[5];
			
			for ( int i = 0; i < pnlKnapper.length; i++ ) 
			{
				pnlKnapper[i] = new JButton(tekst[i]);
				pnlKnapper[i].addActionListener(this);
				add(pnlKnapper[ i ]);
			}
		}
		
		public void actionPerformed(ActionEvent e) 
		{
			String handling = e.getActionCommand();
			int index = listen.getSelectedIndex(); 
			int valg = 0;
			
			//Ny avtale trykkes
			if (tekst[0].equals(handling)) 
			{
				String beskrivelse = JOptionPane.showInputDialog(Avtaleliste.this, 
						"Beskrivelse", "Ny avtale", JOptionPane.QUESTION_MESSAGE);
				if(valg == JOptionPane.CANCEL_OPTION)
				{
					JOptionPane.showMessageDialog(null, "Handlingen ble avbrutt!");
					return;
				}
				
				String innhold = JOptionPane.showInputDialog(Avtaleliste.this, 
						"Innhold", "Ny avtale", JOptionPane.QUESTION_MESSAGE);
				if(valg == JOptionPane.CANCEL_OPTION)
				{
					JOptionPane.showMessageDialog(null, "Handlingen ble avbrutt!");
					return;
				}
				
				String tidspunkt = JOptionPane.showInputDialog(Avtaleliste.this, 
						"Tidspunkt", "Ny avtale", JOptionPane.QUESTION_MESSAGE);
				if(valg == JOptionPane.CANCEL_OPTION)
				{
					JOptionPane.showMessageDialog(null, "Handlingen ble avbrutt!");
					return;
				}
				
				Avtale nyAvtale = new Avtale(beskrivelse, innhold, tidspunkt);
				listedata.addElement(nyAvtale);
				
			} 
			//Fjern avtale trykkes
			else if (tekst[1].equals(handling))
			{
				listedata.removeElementAt(index);
			}
			//Vis avtale trykkes
			else if (tekst[2].equals(handling))
			{	
				//avgjør om en avtale er valgt
				if (index >= 0)
				{
					Avtale avtale = (Avtale) listedata.getElementAt(index);
					JOptionPane.showMessageDialog(null, avtale.getBeskrivelse()+" - "
									+ avtale.getInnhold()+" - "+ avtale.getTidspunkt());
				}
				else
				{
					JOptionPane.showInputDialog(null, "Ingen avtale funnet!");
				}
			}
			//Endre avtale trykkes
			else if (tekst[3].equals(handling))
			{
				//avgjør om avtale er valgt
				if (index >= 0)
				{
					String beskrivelse = JOptionPane.showInputDialog(Avtaleliste.this, 
					"Oppgi ny beskrivelse", "Endre avtale", JOptionPane.QUESTION_MESSAGE);
					
					//avtale legges ikke til om den allerede eksisterer
					if (this.equals(beskrivelse))
					{
						JOptionPane.showMessageDialog(null, "Avtalen ble ikke lagt til!");
					}
					
					String innhold = JOptionPane.showInputDialog(Avtaleliste.this, 
					"Oppgi nytt innhold", "Endre avtale", JOptionPane.QUESTION_MESSAGE);
					String tidspunkt = JOptionPane.showInputDialog(Avtaleliste.this, 
					"Oppgi nytt tidspunkt", "Endre avtale", JOptionPane.QUESTION_MESSAGE);
			
					Avtale nyAvtale = new Avtale(beskrivelse, innhold, tidspunkt);

					listedata.removeElementAt(index);
					listedata.addElement(nyAvtale);		
				
					//cancel trykkes
					if(valg == JOptionPane.CANCEL_OPTION)
					{
						JOptionPane.showMessageDialog(null, "Handlingen ble avbrutt!");
						return;
					}	
				}
			}
			//Avslutt trykkes
			else if (tekst[4].equals(handling))
			{
				System.exit(0);
			}
			//Avslutter
			else
			{
				System.exit(0);
			}
		}
	}
	//metode som registrer valg på listen
	public void valueChanged(ListSelectionEvent e) 
	{
		ListSelectionModel lsm = (ListSelectionModel)e.getSource();
		
		if (lsm.isSelectionEmpty()) 
		{
			
        } 
		else 
		{
            
		}
	}
	
	public static void main(String [] args)
	{
		//kjører applikasjon
		new Avtaleliste("Mine avtaler: ");
	}

}

	