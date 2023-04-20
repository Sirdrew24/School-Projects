import java.util.ArrayList;

abstract class Polygon
{
    protected ArrayList<Integer> sides;
    
    public Polygon(double[] sides)
    {
        this.sides = new ArrayList<Integer>();
        for (double side : sides)
        {
            this.sides.add((int) side);
        }
    }
    public int computePerimeter() 
    {
        int perimeter = 0;
        for (int side : sides)
        {
            perimeter += side;
        }
        return perimeter;            
    }  
    public abstract double computeArea();
}
