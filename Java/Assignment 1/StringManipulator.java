import java.util.Scanner;
public class StringManipulator
{
    static void main (String[] args){
        String input;
        Scanner scan = new Scanner(System.in);
        
        System.out.println("Please input a string: ");
        input = scan.nextLine();
        
        System.out.println(input.length()); //1
        System.out.println(input.toUpperCase()); //2
        System.out.println(input.substring(0,5));
    }
    
    public StringManipulator()
    {
        
    }
}
