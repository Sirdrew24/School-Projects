import java.util.ArrayList;

public class RightTriangle extends Polygon
{
    int sideA, sideB, sideC;
    
    public RightTriangle(ArrayList<Integer> sides) throws Exception
    {
        super(sides.stream().mapToDouble(Integer::doubleValue).toArray());
        if (sides.size() != 3)
        {
            throw new Exception ("A right triangle must have exactly three sides.");
        }
        
        sideA = sides.get(0);
        sideB = sides.get(1);
        sideC = sides.get(2);
        
        if (sideA*sideA + sideB*sideB != sideC*sideC)
        {
            throw new Exception ("The sides do not satisfy the Pythagorean theorom.");
        }
    }
    
    public double computeArea()
    {
        return sideA * sideB * 0.5;
    }
}
