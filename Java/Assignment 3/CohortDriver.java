
/**
 * Write a description of class CohDriver here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class CohortDriver
{
    public static void main () {
      Address school = new Address("800 Lancaster Ave.", "Villanova",
                                   "PA", 19085);
      Address jHome = new Address("21 Jump Street", "Lynchburg",
                                  "VA", 24551);
      Student john = new Student("John", "Smith", jHome, school);

      Address mHome = new Address("123 Main Street", "Euclid", "OH",
                                  44132);
      Student marsha = new Student("Marsha", "Jones", mHome, school);
      
      Address taHome = new Address("123 Broadway Ave.", "Louisville", "KY",
                                  40202);
      Student ted = new Student("Ted", "Burman", taHome, school);

      Student anne = new Student("Anne", "Burman", taHome, school);

      Cohort mycohort = new Cohort();
      mycohort.addStudent(john);
      mycohort.addStudent(marsha);
      mycohort.addStudent(ted);
      mycohort.addStudent(anne);
      System.out.println("Printing entire cohort:");
      System.out.println(mycohort);
      System.out.println("Testing getStudent method for student \"Marsha Jones\":");
      System.out.println(mycohort.getStudent("Marsha","Jones"));
      System.out.println("\nTesting getStudentEarliestName method:");
      System.out.println(mycohort.getStudentEarliestName());
    }
}
