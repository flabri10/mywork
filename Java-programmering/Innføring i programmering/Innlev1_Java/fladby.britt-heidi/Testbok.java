//innlevering PG111 høst 2010
//oppretter prigrammet testbok
public class Testbok
{
   public static void main( String [] args )

   {
       //oppretter bok-objektet testbok 
       Bok testbok1 = new Bok("Erlend Loe", "Dopler", 300);
         
       //skriver ut informasjon om boka
       testbok1.setReferanseNummer("45646556");
       testbok1.skrivDetaljer();
       
   }
}