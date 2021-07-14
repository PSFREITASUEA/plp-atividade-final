# Classe
class Person:
    # Contrutor
    def __init__(self, name, age, cpf):
        self.name = name
        self.age = age
        self.cpf = cpf

    def get_name(self):
        return self.name

    def get_age(self):
        return self.age

    def get_cpf(self):
        return self.cpf


# Herança
class Student(Person):
    def __init__(self, name, age, cpf, enrollment_number):
        super().__init__(name, age, cpf)
        self.enrollment_number = enrollment_number

    def get_enrollment_number(self):
        return self.enrollment_number


class Class:
    students = []

    def __init__(self, name):
        self.name = name

    def add_student(self, student_name):
        self.students.append(student_name)

    def empty_class(self):
        self.students = []


class Course:
    students = []

    def __init__(self, name, code):
        self.name = name
        self.code = code

    def add_student(self, student):
        self.students.append(student)


class University:
    courses = []

    def __init__(self, name):
        self.name = name

    def add_course(self, course_name, course_code):
        self.courses.append(Course(course_name, course_code))


# Objeto
lucas = Student("Lucas", 23, "123.456.789-00", "123456789")

# Associação
plp = Class("Paradigmas de Linguagens de Programação")
plp.add_student(lucas)

# Composição
Uea = University("UEA")
Uea.add_course("Sistemas de informação", "12345")

# Agregação
Uea.courses[0].add_student(lucas)

print("Hey")
print(Uea.courses[0].students[0].get_enrollment_number())
