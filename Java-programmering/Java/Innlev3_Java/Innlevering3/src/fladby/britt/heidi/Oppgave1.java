package fladby.britt.heidi;


import java.awt.*;
import java.awt.event.*;   //for oppgave b)
import javax.swing.*;

public class Oppgave1 extends JFrame{
	private Container guiFlate;
	//private JLabel lblEtikett1, lblEtikett2;
	private JTextField txtFelt1,txtFelt2;
	private JTextArea txaOmrade;
	private JButton btnKnapp1,btnKnapp2;
	private JPanel pnlNord,pnlSor;
	
	public Oppgave1(){
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setLayout(new BorderLayout());
		
		//bygg opp nordpanel
		TekstFeltLytter tL = new TekstFeltLytter();	//oppgave c)
		
		JLabel lblEtikett1 = new JLabel("Tekst 1:");
		txtFelt1 = new JTextField("PG210",7);
		txtFelt1.addActionListener(tL);				//oppgave c)
		
		JLabel lblEtikett2 = new JLabel("Tekst 2:");
		txtFelt2 = new JTextField("Eksamen",7);
		pnlNord = new JPanel();
		pnlNord.add(lblEtikett1);
		pnlNord.add(txtFelt1);
		pnlNord.add(lblEtikett2);
		pnlNord.add(txtFelt2);
		
		//innhold i center sone p� guiFlate
		txaOmrade = new JTextArea(10,20);
		JScrollPane rullefelt = new JScrollPane(txaOmrade);
		
		//bygg opp s�rpanel
		KnappeLytter kL = new KnappeLytter();	//oppgave b)
		
		btnKnapp1 = new JButton("Knapp 1");btnKnapp1.setMnemonic('1');
		btnKnapp1.addActionListener(kL);		//oppgave b)
		btnKnapp2 = new JButton("Knapp 2");btnKnapp2.setMnemonic('2');
		btnKnapp2.addActionListener(kL);		//oppgave b)
		pnlSor = new JPanel();
		pnlSor.add(btnKnapp1);
		pnlSor.add(btnKnapp2);

		//legg til guiFlaten
		add(pnlNord,BorderLayout.NORTH);
		add(rullefelt,BorderLayout.CENTER);
		add(pnlSor,BorderLayout.SOUTH);
		pack();
		setVisible(true);
	}


	//lytter til oppgave b)	
	class KnappeLytter implements ActionListener{
		public void actionPerformed(ActionEvent e){
			if (e.getSource()==btnKnapp1){
				txaOmrade.append(txtFelt1.getText() + " " + txtFelt2.getText() +"\n");
			}
			else if (e.getSource()==btnKnapp2){
				txtFelt1.setText("Lykke");
				txtFelt2.setText("til!!!");
			}
		}
	}
	//lytter til oppgave c)
	class TekstFeltLytter implements ActionListener{
		public void actionPerformed(ActionEvent e){
			txaOmrade.append(txtFelt1.getText()+"\n");
		}	
		
	}
	
	public static void main(String[] args) {
		new PCLab9_Oppgave1();
	}
}