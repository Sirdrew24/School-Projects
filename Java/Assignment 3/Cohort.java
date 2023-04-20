import java.util.ArrayList;

public class Cohort
{
    private ArrayList<Student> students;
    
    public Cohort()
    {
        students = new ArrayList<Student>();
    }
    
    public void addStudent(Student newStudent){
        students.add(newStudent);
    }
    
    public Student getStudent(String firstname, String lastname){
        for (Student student : students){
            if (student.getFirstName().equals(firstname) && student.getLastName().equals(lastname)){
                return student;
            }
        }
        return null;
    }
    
    public Student getStudentEarliestName(){
        if (students.size() == 0){
            return null;
        }
        Student earliestStudent = students.get(0);
        for (int i = 1; i < students.size(); i++) {
            Student currentStudent = students.get(i);
            if (currentStudent.getLastName().compareTo(earliestStudent.getLastName()) < 0) {
                earliestStudent = currentStudent;
            } else if (currentStudent.getLastName().equals(earliestStudent.getLastName()) && 
                       currentStudent.getFirstName().compareTo(earliestStudent.getFirstName()) < 0) {
                earliestStudent = currentStudent;
            }
        }
        return earliestStudent;
    }
    
    public String toString(){
        StringBuilder result = new StringBuilder();
        for (Student student : students){
            result.append(student.toString()).append("\n\n");
        }
        return result.toString();
    }
}
