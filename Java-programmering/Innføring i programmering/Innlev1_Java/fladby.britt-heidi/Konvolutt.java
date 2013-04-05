import util.*;
import java.awt.*;

public class Konvolutt
{    
    public static void main(String[] args)
    {
        TurtleGraphicsWindow pen = new TurtleGraphicsWindow();
        pen.left(90);
        pen.penup();
        vent(1000);
        
        pen.forward(100);
        pen.right(90);
        pen.pendown();
        vent(1000);
        
        pen.forward(50);
        pen.right(90);
        vent(1000);
        
        pen.forward(100);
        pen.right(90);
        vent(1000);
        
        pen.forward(50);
        pen.right(90);
        vent(1000);
        
        pen.forward(100);
        pen.right(90);
        pen.penup();
        vent(1000);
        
        pen.forward(50);
        pen.pendown();
        pen.right(60);
        vent(1000);
        
        pen.forward(58);
        pen.right(60);
        vent(1000);
        
        pen.forward(58);
        vent(1000);
        pen.hideturtle();
    }
    
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
