public class ForLoopTest
{
   public static void main(){
       String mystr = "My_apple_is_red.";
       String eostr = "";
       //int curindex = -2; 
       //while (curindex < mystr.length()-2) {
        //   curindex += 2;
       //    eostr = eostr + mystr.charAt(curindex);
       // }
       //System.out.println(eostr);
       
       for (int i = 0; i < mystr.length(); i +=2){
           eostr = eostr + mystr.charAt(i);
       }
       System.out.println(eostr);
   }
}
