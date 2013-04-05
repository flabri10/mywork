package fladby.britt.heidi;

import java.awt.BorderLayout;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.DefaultListModel;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JList;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.ListSelectionModel;
import javax.swing.event.ListSelectionListener;

public class Knappepanel extends JFrame implements ActionListener
{
	private static final long serialVersionUID = 1L;
	private JButton btnNy, btnFjern, btnVis, btnEndre, btnAvslutt;
	private JPanel pnlKnapper;
	private static String vindustittel;
	private JList listen;
	private DefaultListModel listedata;

	public Knappepanel()
	{
		super(vindustittel);
		setLayout(new BorderLayout());
		
		listen= new JList(listedata);
		listen.addListSelectionListener((ListSelectionListener) this);
		listen.setVisibleRowCount(10);
		listen.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);
        listen.setSelectedIndex(0);

        add(listen, BorderLayout.CENTER);
		
		pnlKnapper = new JPanel();
		
		//instansierer og legger til knappene i panelet
		JButton[] knapper = new JButton[ 5 ];
		knapper[ 0 ] = new JButton("Ny avtale");
		knapper[ 1 ] = new JButton("Fjern avtale");
		knapper[ 2 ] = new JButton("Vis avtale");
		knapper[ 3 ] = new JButton("Endre avtale");
		knapper[ 4 ] = new JButton("Avslutt");
		
		setLayout(new GridLayout(5,1));
		
		Knappelytter lytter = new Knappelytter();
		
		for ( int i = 0; i < 5; i++ ) 
		{
		add(knapper[ i ]);
		knapper[i].addActionListener(lytter);
		}
		
		add(pnlKnapper, BorderLayout.EAST);
		pnlKnapper.setLayout(new GridLayout(5,1));
		
		setSize(300, 200);
		setVisible(true);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);	
	}
	private class Knappelytter implements ActionListener 
	{
		public void actionPerformed(ActionEvent e) 
		{
			String handling = e.getActionCommand();
			
			if (btnNy.equals(handling)) 
			{
				vindustittel = "Ny avtale";
				String beskrivelse = JOptionPane.showInputDialog("Beskrivelse");
				listedata.addElement(beskrivelse);
				String innhold = JOptionPane.showInputDialog("Innhold");
				listedata.addElement(innhold);
				String tidspunkt = JOptionPane.showInputDialog("Tidspunkt");
				listedata.addElement(tidspunkt);
			} 
			else if (btnFjern.equals(handling))
			{
				
			}
			else if (btnVis.equals(handling))
			{
			
			}
			else if (btnEndre.equals(handling))
			{
			
			}
			else if (btnAvslutt.equals(handling))
			{
			
			}
			else
			{
			
			}
		}
	}
	public static void main(String [] args)
	{
		new Knappepanel();
	}

	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub
		
	}
}
