import java.util.ArrayList;

public class Rectangle extends Polygon
{
    int sideA, sideB, sideC, sideD;
    
    public Rectangle(ArrayList<Integer> sides) throws Exception
    {
        super(sides.stream().mapToDouble(Integer::doubleValue).toArray());
        if (sides.size() != 4)
        {
            throw new Exception("A rectangle must have excatly four sides.");
        }
        
        sideA = sides.get(0);
        sideB = sides.get(1);
        sideC = sides.get(2);
        sideD = sides.get(3);
        
        if (sideA != sideC || sideB != sideD)
        {
            throw new Exception("The sides do not from a rectangle.");
        }
    }
    
    public double computeArea()
    {
        return sideA * sideB;
    }
}
