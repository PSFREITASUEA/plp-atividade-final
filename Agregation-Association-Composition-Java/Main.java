import java.util.ArrayList;
import java.util.Arrays;

public class Main {

    public static void main(String[] args) {

        University university;
        ArrayList<Subject> subjects = new ArrayList<Subject>();
        Teacher teacher = new Teacher(
                "Teacher 1",
                23,
                "123123123"
        );

        for (int i = 0; i <= 6; i++) {
            subjects.add(
                    new Subject(
                            i,
                            "Subject " + i,
                            "Just a subject"

                    )
            );
        }

        for (Subject subject : subjects) {
            teacher.addSubject(subject);
        }

        for (Subject subject : teacher.getSubjects()) {
            System.out.println(subject.getName());
        }


        university = new University(
                "University 1",
                new ArrayList<Department>(
                        Arrays.asList(
                                new Department(
                                        1,
                                        new ArrayList<Teacher>(
                                                Arrays.asList(teacher)
                                        )
                                )
                        )
                )
        );


    }
}
