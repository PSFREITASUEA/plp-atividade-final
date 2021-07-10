import java.util.ArrayList;
import java.util.List;

public class Teacher extends Person {

    private String registrationId;
    private List<Subject> subjects = new ArrayList<Subject>();

    public Teacher(String name, Integer age, String registrationId) {
        super(name, age);
        this.registrationId = registrationId;
    }


    public void addSubject(Subject subjectToBeAdded) {
        subjects.add(subjectToBeAdded);
    }

    public String getRegistrationId() {
        return registrationId;
    }

    public void setRegistrationId(String registrationId) {
        this.registrationId = registrationId;
    }

    public List<Subject> getSubjects() {
        return subjects;
    }

    public void setSubjects(List<Subject> subjects) {
        this.subjects = subjects;
    }

}
