//Innlevering PG111 høst 2010
//program for å tegne opp en NITH-logo med skillpadde

//importerer tilleggspakker fra java
import util.*;
import java.awt.*;

public class Nith
{    
   private int xPosition;
   private int yPosition;
   
   public void pen()
    {
        xPosition = 180;
        yPosition = 160;
    }
    
    public static void main(String[] args)
    {
        //lager nytt tegneredskap
        TurtleGraphicsWindow pen = new TurtleGraphicsWindow();
        
        //tegner N
        pen.pendown();
        pen.forward(80);
        pen.right(151);
        pen.forward(90);
        pen.left(151);
        pen.forward(80);
        vent(1000);
        
        pen.penup();
        pen.right(90);
        pen.forward(10);
        pen.right(90);
        vent(1000);
        
        //tegner I
        pen.pendown();
        pen.forward(80);
        vent(1000);
        
        pen.penup();
        pen.left(90);
        pen.forward(35);
        vent(1000);
        
        //tegner T
        pen.pendown();
        pen.left(90);
        pen.forward(80);
        vent(1000);
        
        pen.penup();
        pen.left(90);
        pen.forward(25);
        pen.right(180);
        vent(1000);
        
        pen.pendown();
        pen.forward(50);
        vent(1000);
        
        pen.penup();
        pen.forward(10);
        pen.right(90);
        vent(1000);
        
        //tegner H
        pen.pendown();
        pen.forward(80);
        vent(1000);
        
        pen.penup();
        pen.right(180);
        pen.forward(40);
        pen.right(90);
        vent(1000);
        
        pen.pendown();
        pen.forward(50);
        pen.penup();
        pen.right(90);
        pen.forward(40);
        pen.right(180);
        vent(1000);
        
        pen.pendown();
        pen.forward(80);
        pen.penup();
        vent(1000);
        
        pen.forward(20);
        pen.left(90);
        pen.forward(205);
        pen.left(90);
        vent(1000);
        
        //tegner rammen
        pen.pendown();
        pen.forward(120);
        vent(1000);
        
        pen.left(90);
        pen.forward(240);
        vent(1000);
        
        pen.left(90);
        pen.forward(120);
        vent(1000);
        
        pen.left(90);
        pen.forward(240);
        vent(1000);
        pen.hideturtle();
    }
     
   //setter verdier for pauser i tegningen 
    public static void vent(int tid)
    {
        try
            {
                Thread.sleep(tid);
            }
            catch (Exception e)
        {}
    }
}