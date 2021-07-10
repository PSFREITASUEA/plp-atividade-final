import java.util.ArrayList;

public class Department {

    private Integer id;
    private ArrayList<Teacher> teachers;

    public Department(Integer id, ArrayList<Teacher> teachers) {
        this.id = id;
        this.teachers = teachers;
    }

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public ArrayList<Teacher> getTeachers() {
        return teachers;
    }

    public void setTeachers(ArrayList<Teacher> teachers) {
        this.teachers = teachers;
    }


}
